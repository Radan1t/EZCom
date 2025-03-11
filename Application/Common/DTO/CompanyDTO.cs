using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTO
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string Company_name { get; set; }
        public int User_count { get; set; }
        public string Contact_manager_name { get; set; }
        public string Contact_manager_phone { get; set; }
        public string Contact_manager_email { get; set; }
        public int ProductVersionTypeID { get; set; }
        public string ProductVersionName { get; set; } // Опціонально, якщо потрібно ім'я версії
        public DateTime Subscription_time { get; set; }
    }
}
