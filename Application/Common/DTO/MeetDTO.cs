using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTO
{
    public class MeetDTO
    {
        public int Id { get; set; }
        public string Meet_name { get; set; }
        public int CompanyID { get; set; }
        public string Meet_URL { get; set; }
        public DateTime Meet_DateTime { get; set; }
    }
}
