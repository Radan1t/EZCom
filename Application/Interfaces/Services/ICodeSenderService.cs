using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface ICodeSenderService
    {
        Task<(bool success, string message, string code)> SendCodeAsync(string email);
        Task<(bool success, string message)> SendCompanyInviteAsync(string email, string companyName);
        Task SendMeetingInvitationEmails(List<string> attendees, string eventName, DateTime eventDate, string meetLink);
    }
}