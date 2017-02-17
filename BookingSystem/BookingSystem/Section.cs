using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class Section
    {
        private string id { get; set; }
        private string name { get; set; }
        private List<Rack> racks = new List<Rack>();
    }
}
