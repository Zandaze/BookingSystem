using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookingSystem
{
   static class  TempController
    {

        public static bool AddBook(string title, string author, string category, string year, string isbn)
        {
            Book book = new Book(title, author, category, year, isbn);
            DAL dal = new DAL();

         if(dal.Add(book)) 
            return true;

         else
            return false;

        }


        public static bool DeleteBook(Book book)
        {
            DAL dal = new DAL();

            if (dal.Delete(book))
                return true;
            else
                return false;
        }

        public static bool UpdateBook(Object obj, string[] attributes, string[] data)
        {
            try
            {
                for (int i = 0; i < attributes.Length; i++)
                {
                    //TODO: send parameters to DAL. Dictionary.   
                }
                return true;
            }
            catch (Exception e)
            {
                //Console output is temporary********
                Console.WriteLine("Error Message: " + e.Source);
                return false;
            }
            
        }

        public static List<Book> GetAllBooks()
        {
            DAL dal = new DAL();
            Book b = new Book();
            List<Book> books = new List<Book>(dal.FindAll(new BookingSystem.Book()));
            return books; 
        } 

        public static Book GetBook(string title)
        {
            
        }
    
    }
}
