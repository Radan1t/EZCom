using Google.Apis.Auth.OAuth2;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface ICalendarService
    {
        Task<bool> HasCalendarAccessAsync();
        Task<bool> RequestCalendarPermissionAsync();
        Task<UserCredential> GetLoginCredentialAsync();
    }
}
