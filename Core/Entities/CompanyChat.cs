using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class CompanyChat
    {
        public int CompanyID { get; set; }
        public Company Company { get; set; }

        public int ChatID { get; set; }
        public Chat Chat { get; set; }
    }
}
