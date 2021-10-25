using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestCore.Models
{
    public class History
    {
        public int His_ID {get; set;}
        public DateTime His_DateIn { get; set; }
        public DateTime His_DateOut { get; set; }
        public string His_Status { get; set; }

    }

}
