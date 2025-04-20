using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Meet
    {
        public int Id { get; set; }
        public string Meet_name { get; set; }
        public int CompanyID { get; set; }
        public Company Company { get; set; }
        public string Meet_URL { get; set; }
        public DateTime Meet_DateTime { get; set; }
        public ICollection<MeetUser> MeetUsers { get; set; }
    }
}
