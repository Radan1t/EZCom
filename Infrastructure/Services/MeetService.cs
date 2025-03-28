using EZCom.Application.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Common.DTO;
using Infrastructure.Persistence.Repositories;
using Core.Entities;
using Microsoft.Extensions.Configuration; // Add this for accessing configuration

namespace EZCom.Application.Services
{
    public class MeetService : IMeetService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration; // Add this to access configuration

        public MeetService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration; // Inject the configuration
        }

        public async Task<IEnumerable<string>> GetEmployeeEmailsAsync(UserDTO user)
        {
            var employees = await _unitOfWork.Repository<User>().GetAsync();
            return employees.Select(e => e.E_mail).ToList();
        }
        public async Task<IEnumerable<MeetDTO>> GetUserMeetingsAsync(int userId)
        {
            var meetings = await _unitOfWork.Repository<Meet>()
                .GetAsync(m => m.MeetUsers.Any(mu => mu.UserID == userId));

            return meetings.Select(m => new MeetDTO
            {
                Meet_name = m.Meet_name,
                Meet_DateTime = m.Meet_DateTime,
                Meet_URL = m.Meet_URL
            }).ToList();
        }

        public async Task<string> CreateGoogleCalendarEvent(string eventName, DateTime eventDate, List<string> attendees, int companyId)
        {
            try
            {
                // Fetch client_id and client_secret from configuration
                var clientId = _configuration["installed:client_id"];
                var clientSecret = _configuration["installed:client_secret"];

                // Use the credentials from the configuration
                var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = clientId,
                        ClientSecret = clientSecret
                    },
                    new[] { CalendarService.Scope.Calendar }, "user", System.Threading.CancellationToken.None);

                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "EZCom Calendar Access",
                });

                var @event = new Event
                {
                    Summary = eventName,
                    Start = new EventDateTime { DateTime = eventDate, TimeZone = "Europe/Kyiv" },
                    End = new EventDateTime { DateTime = eventDate.AddHours(1), TimeZone = "Europe/Kyiv" },
                    Attendees = attendees.Select(email => new EventAttendee { Email = email }).ToList(),
                    ConferenceData = new ConferenceData
                    {
                        CreateRequest = new CreateConferenceRequest
                        {
                            ConferenceSolutionKey = new ConferenceSolutionKey { Type = "hangoutsMeet" },
                            RequestId = Guid.NewGuid().ToString()
                        }
                    }
                };

                var request = service.Events.Insert(@event, "primary");
                request.ConferenceDataVersion = 1;

                var createdEvent = await request.ExecuteAsync();
                string meetLink = createdEvent.ConferenceData?.EntryPoints?.FirstOrDefault()?.Uri;

                if (!string.IsNullOrEmpty(meetLink))
                {
                    // Створюємо новий запис у таблиці Meet
                    var meet = new Meet
                    {
                        Meet_name = eventName,
                        Meet_DateTime = eventDate,
                        Meet_URL = meetLink,
                        CompanyID = companyId,
                        MeetUsers = new List<MeetUser>()
                    };

                    // Отримуємо користувачів за email
                    var users = await _unitOfWork.Repository<User>()
                        .GetAsync(u => attendees.Contains(u.E_mail));

                    foreach (var user in users)
                    {
                        meet.MeetUsers.Add(new MeetUser { UserID = user.Id });
                    }

                    // Зберігаємо в базі
                    await _unitOfWork.Repository<Meet>().InsertAsync(meet);
                    await _unitOfWork.SaveAsync();
                }

                return meetLink;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
