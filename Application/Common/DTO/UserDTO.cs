using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string E_mail { get; set; }
        public string Phone_number { get; set; }
        public DateTime Date_of_birthday { get; set; }
        public int UserTypeID { get; set; }
        public int? CompanyID { get; set; }
        public string? Credential {  get; set; }
    }
}
