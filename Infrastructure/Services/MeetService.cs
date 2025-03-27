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

        public async Task<string> CreateGoogleCalendarEvent(string eventName, DateTime eventDate, List<string> attendees)
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

                return createdEvent.ConferenceData?.EntryPoints?.FirstOrDefault()?.Uri;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
