using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class UserType
    {
        public int Id { get; set; }
        public string Type_name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
