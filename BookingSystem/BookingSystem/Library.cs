using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class Library
    {
        private string id { get; set; }
        private string name { get; set; }
        private List<Section> sections = new List<Section>();
    }
}
