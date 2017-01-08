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
        static void Main()
        {
            LogIn();
            Console.WriteLine("Press T for trainer or U for user, ESC for exit");
            ConsoleKeyInfo trainerOrUser = Console.ReadKey(true);
            switch (trainerOrUser.Key)
            {
                case ConsoleKey.T: TrainerMenu.Level1();
                    break;
                case ConsoleKey.U:
                    break;
                case ConsoleKey.Escape:
                    return;            
            }
        }
        public static void LogIn()
        {
            Console.WriteLine("Enter User Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Your Password");
            string password = Console.ReadLine();

            // Isi is here
            //if (true)
            //{

            //}
        }
    }
}
