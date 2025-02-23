using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DepartmentChat
    {
        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        public int ChatID { get; set; }
        public Chat Chat { get; set; }
    }
}
