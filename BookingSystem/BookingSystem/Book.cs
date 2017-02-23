using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class Book
    {
        public string id { get; private set; }
        public string title { get; private set; }
        public string author { get; private set; }
        public string category { get; private set; }
        public string year { get; private set; }

        

        public Book(string id, string title, string author, string category, string year)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.category = category;
            this.year = year;
        }
    }
}