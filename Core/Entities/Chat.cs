using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Chat
    {
        public int Id { get; set; }
        public DateTime Create_DateTime { get; set; }

        public ICollection<UserChat> UserChats { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<DepartmentChat> DepartmentChats { get; set; }
        public ICollection<CompanyChat> CompanyChats { get; set; }
    }
}
