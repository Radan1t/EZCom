using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTO
{
    public class ProductVersionDTO
    {
        public int Id { get; set; }
        public string Version_name { get; set; }
        public decimal Version_price { get; set; }
        public int User_count { get; set; }
    }
}
