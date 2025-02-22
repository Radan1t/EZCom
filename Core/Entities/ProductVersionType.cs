using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProductVersionType
    {
        public int id { get; set; }
        public string Version_name { get; set; }
        public decimal Version_price { get; set; }

        public ICollection<Company> Companies { get; set; }
    }
}
