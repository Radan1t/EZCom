using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.DTO;

namespace EZCom.Application.Interfaces
{
    public interface IMeetService
    {
        Task<IEnumerable<string>> GetEmployeeEmailsAsync(UserDTO user);
        Task<string> CreateGoogleCalendarEvent(string eventName, DateTime eventDate, List<string> attendees, int companyId);
        Task<IEnumerable<MeetDTO>> GetUserMeetingsAsync(int userId);
        Task<Dictionary<string, List<string>>> GetCompanyDepartmentsWithEmailsAsync(int companyId);
    }
}
