using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            TempController.AddBook("generic", "1", "2", "3", "4");
            Console.WriteLine("done!");
          //  TempController.DeleteBook();
            Console.WriteLine("Removed!");

            foreach (Book b in TempController.GetAllBooks())
            {
                Console.WriteLine(b.id);
            }
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //(new LoginForm()).Show();
            //(new MainForm()).Show();
            //Application.Run();
            Application.Run(new MainForm());
        }
    }
}
