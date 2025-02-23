using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Company_name { get; set; }
        public int User_count { get; set; }
        public string Contact_manager_name { get; set; }
        public string Contact_manager_phone { get; set; }
        public string Contact_manager_email { get; set; }
        public int ProductVersionTypeID { get; set; }
        public ProductVersionType ProductVersion { get; set; }
        public DateTime Subscription_time { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<CompanyChat> CompanyChats { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
