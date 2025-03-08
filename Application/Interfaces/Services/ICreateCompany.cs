using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICreateCompany
    {
        Task CreateCompanyAsync(string companyName, string contactManagerName, string contactManagerPhone, string contactManagerEmail, int userCount, int productVersionTypeId, DateTime subscriptionTime);
    }
}
