using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineApp.Core.Models
{
    public class Wine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Region { get; set; }
        public string Appelation { get; set; }
        public string Price { get; set; }
    }
}
