using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Date_of_birthday { get; set; }
        public string Phone_number { get; set; }
        public string E_mail { get; set; }

        public int UserTypeID { get; set; }
        public UserType Type { get; set; }

        public int? CompanyID { get; set; }
        public Company Company { get; set; }

        public ICollection<Message> Messages { get; set; }
        public ICollection<UserDepartment> UserDepartments { get; set; }
        public ICollection<MeetUser> MeetUsers { get; set; }
        public ICollection<UserChat> UserChats1 { get; set; }
        public ICollection<UserChat> UserChats2 { get; set; }
    }
}
