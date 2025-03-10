using Application.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICompanyService
    {
        Task CreateCompanyAsync(CompanyDTO company, int UserID);
        Task<IEnumerable<ProductVersionDTO>> GetSubscriptionsAsync();
    }
}
