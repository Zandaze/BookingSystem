using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    class DAL
    {
        public bool Add<T>(T obj) where T : class
        {
            try
            {
                BookingSystemDBEntities dbEntities = new BookingSystemDBEntities();
                dbEntities.Set<T>().Add(obj);
                dbEntities.SaveChanges();
                dbEntities.Dispose();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return false;
            }
            
        }

        public bool Delete<T>(T obj) where T : class
        {
            try
            {
                BookingSystemDBEntities dbEntities = new BookingSystemDBEntities();
                dbEntities.Set<T>().Remove(obj);
                dbEntities.SaveChanges();
                dbEntities.Dispose();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return false;
            }
        }


        //  Finds all instances of a class that is
        //  identified by receiving one instance of the class.
        //  If it is not possible to retrieve the instances 
        //  an empty list will be returned.
        public List<T> FindAll<T>(T obj) where T : class
        {
            
            try
            {
                BookingSystemDBEntities dbEntities = new BookingSystemDBEntities();
                return dbEntities.Set<T>().ToList();
            }
            catch (Exception e)
            {
                return new List<T>();
            }
        }

    }
}