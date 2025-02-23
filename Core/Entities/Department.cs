using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Department_name { get; set; }
        public int Worker_count { get; set; }

        public int CompanyID { get; set; }
        public Company Company { get; set; }

        public ICollection<UserDepartment> UserDepartments { get; set; }
        public ICollection<DepartmentChat> DepartmentChats { get; set; }
    }
}
