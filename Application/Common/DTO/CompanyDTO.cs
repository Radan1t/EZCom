using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTO
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int UserCount { get; set; }
        public string ContactManagerName { get; set; }
        public string ContactManagerPhone { get; set; }
        public string ContactManagerEmail { get; set; }
        public int ProductVersionTypeId { get; set; }
        public string ProductVersionName { get; set; } // Опціонально, якщо потрібно ім'я версії
        public DateTime SubscriptionTime { get; set; }
    }
}
