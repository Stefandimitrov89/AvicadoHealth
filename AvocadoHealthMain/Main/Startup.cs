using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Main.Enums;

namespace Main
{
    class Startup
    {
        private static Menu StartupMenu;

        private static Interfaces.IPerson LoggedUser;

        static void Main()
        {
            Login();

        }

        public static void Login()
        {
            Console.WriteLine("Please, enter your credentials:");
            Login login = new Login();

            var loggedUser = login.LogIn();

            List<MenuItem> MenuItemList = new List<MenuItem>();

            if (loggedUser.Equals(UserType.Trainer ))
            {
                var trainerUi = new TrainerUI(LoggedUser as Trainer);
                trainerUi.MainMenu();
            }
            else
            {
                // TODO Fill List of MenuItems for user
                Console.WriteLine("test");
            }

            StartupMenu = new Menu(MenuItemList);
        }

        public static bool LogIn()
        {
            Console.WriteLine("Enter User Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Your Password");
            string password = Console.ReadLine();

            return true;

        }
    }
}
