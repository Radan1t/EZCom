using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MeetUser
    {
        public int UserID { get; set; }
        public User User { get; set; }

        public int MeetID { get; set; }
        public Meet Meet { get; set; }
    }
}
