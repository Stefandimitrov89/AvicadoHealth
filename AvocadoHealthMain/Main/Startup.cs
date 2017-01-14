using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Main
{
    class Startup
    {
        private static Menu StartupMenu;

        private static Interfaces.IPerson LoggedUser;

        static void Main()
        {
            /*bool isLogged = false;
            do
            {
                isLogged = LogIn();
            } while (!isLogged);*/
            Console.WriteLine("Please, enter your username:");
            Login login = new Login();
   
            var loggedUser = login.LogIn();

            List<MenuItem> MenuItemList = new List<MenuItem>();

            if (loggedUser == typeof(Trainer))
            {
                var trainerUi = new TrainerUI(LoggedUser as Trainer);
                trainerUi.MainMenu();   
            }
            else
            {
                // TODO Fill List of MenuItems for user
            }

            StartupMenu = new Menu(MenuItemList);
            
        }

        public static bool LogIn()
        {
            Console.WriteLine("Enter User Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Your Password");
            string password = Console.ReadLine();



            // Isi is here
            //if (true)
            //{
            // LoggedUser = ... 
            //}

            return true;

        }
    }
}
