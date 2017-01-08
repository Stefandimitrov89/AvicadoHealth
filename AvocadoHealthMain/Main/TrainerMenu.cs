using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public  class TrainerMenu 
    {
        public static void Level1()
        {
            Console.WriteLine("Please Enter Your FirstName");
            string tempFirstName = Console.ReadLine();
            Console.WriteLine("Please Enter Your LastName");
            string tempLastName = Console.ReadLine();
            Console.WriteLine("Please Enter Your LastName");
            Trainer newTrainer = new Trainer(tempFirstName, tempLastName);
        }
        private  void Level2()
        {
            do
            {
                Console.WriteLine("Enter A key:");
                Console.WriteLine("1. For Choosing a user");
                Console.WriteLine("2. For Set Training");
                Console.WriteLine("3. For Create a new training");
                Console.WriteLine("4. For Setting Food recomended for the user");
                Console.WriteLine("E. For User Info");
                Console.WriteLine("Esc For return To login screen");
                ConsoleKeyInfo keyforLevel2 = Console.ReadKey(true);
                switch (keyforLevel2.KeyChar)
                {
                    case '1':
                        ChooseUser(); break;
                    case '2':
                       this.Trainer.SetTraining();break;
                    case '3':
                        Trainer.CreateTraining();break;
                    case '4':
                        Trainer.
                    default: continue;
                }
            } while (true);
            Startup.LogIn();
        }
        public static void ChooseUser()
        {
            //We should choose with which user we are working
        }
    }
}
//ConsoleKeyInfo trainerOrUser = Console.ReadKey(true);
//            switch (trainerOrUser.Key)
//            {
//                case ConsoleKey.T: TrainerMenu.Level1();
//                    break;
//                case ConsoleKey.U:
//                    break;
//                case ConsoleKey.Escape:
//                    return;            
//            }