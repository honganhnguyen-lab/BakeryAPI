using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWeb.Models
{
    public class Bakery
    {
        
        public int BakeryID { get; set; }
        public string BakeryName { get; set; }
        public string BakeryPrice { get; set; }
        public string BakeryDay { get; set; }
        public int BakeryExpire { get; set; }
        public int BakeryStatus { get; set; }

    }
}
