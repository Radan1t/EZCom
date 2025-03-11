using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTO
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string Department_name { get; set; }
        public int Worker_count { get; set; }
        public int CompanyID { get; set; }
    }
}
