using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class Booking
    {

        private string id { get; set; }
        private string bookedDate { get; set; }
        private string returnDate { get; set; }
        private List<Book> books = new List<Book>();
    }

}
