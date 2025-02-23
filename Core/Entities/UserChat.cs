using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class UserChat
    {
        public int UserID1 { get; set; }
        public User User1 { get; set; }

        public int UserID2 { get; set; }
        public User User2 { get; set; }

        public int ChatID { get; set; }
        public Chat Chat { get; set; }
    }
}
