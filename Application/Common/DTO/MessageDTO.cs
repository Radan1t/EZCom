using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTO
{
    public class MessageDTO
    {
        public int Id { get; set; }
        public int ChatID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
    }
}
