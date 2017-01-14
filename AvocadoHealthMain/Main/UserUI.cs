using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class UserUI
    {
        private bool ContinueToExecute = true;
        private Menu UserMenu;
        private Trainer loggedTrainer;
        private User loggedUser;

        public UserUI(User loggedUser)
        {
            List<MenuItem> list = new List<MenuItem>();

            list.Add(new MenuItem() { Number = 1, MenuText = "Eat" });
            list.Add(new MenuItem() { Number = 2, MenuText = "Train" });
            //list.Add(new MenuItem() { Number = 3, MenuText = "StrictEat" });
            //list.Add(new MenuItem() { Number = 4, MenuText = "CheatEat" }); Could be implemented if needed
            list.Add(new MenuItem() { Number = 6, MenuText = "List of trainings" });
            list.Add(new MenuItem() { Number = 7, MenuText = "List of Body Information" });
            list.Add(new MenuItem() { Number = 8, MenuText = "Log Out" });
            UserMenu = new Menu(list);
        }

        public void ExecuteMenuAction(int actionNumber)
        {
            switch (actionNumber)
            {
                case 1:
                    UserEating();
                    break;
                case 2:
                    UserTraining();
                    break;
                case 6:
                    loggedUser.printTrainingList();
                    break;
                case 7:
                    loggedUser.printUserInfo();
                    break;
                case 8:
                    ContinueToExecute = false;
                    break;
                default:
                    break;
            }
        }

        private void UserTraining()
        {
            for (int i = 0; i < loggedUser._TrainingsList.Count; i++)
            {
                Console.WriteLine($"For training of {loggedUser._TrainingsList[i]}, enter {i}");
            }
            bool isTrue = false;
            int enteredNumber = 0;
            while (!isTrue)
            {
                try
                {
                    enteredNumber = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter Valid Number");
                }
                if (enteredNumber >= 0 && enteredNumber <= loggedTrainer.MyTrainings.Count)
                {
                    Console.WriteLine("Please enter training time");
                    double trainedTime = 0;
                    if (double.TryParse(Console.ReadLine(), out trainedTime))
                    {
                        loggedUser.Train(loggedUser._TrainingsList[enteredNumber], trainedTime);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Number");
                    }
                    isTrue = true;
                }
            }
        }

        private void UserEating()
        {
            for (int i = 0; i < loggedUser._RecomendedFood.Count; i++)
            {
                Console.WriteLine($"For eating {loggedUser._RecomendedFood[i]} enter {i}");
            }
            bool isTrue = false;
            int enteredNumber = 0;
            while (!isTrue)
            {
                try
                {
                    enteredNumber = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter Valid Number");
                }
                if (enteredNumber >= 0 && enteredNumber <= loggedTrainer.MyTrainings.Count)
                {
                    Console.WriteLine("Please enter Quantity");
                    double eatedQuantity = 0;
                    if (double.TryParse(Console.ReadLine(), out eatedQuantity))
                    {
                        loggedUser.Eat(loggedUser._RecomendedFood[enteredNumber], eatedQuantity);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Number");
                    }
                    isTrue = true;
                }
            }
        }

        internal void MainMenu()
        {
            while (ContinueToExecute)
            {
                int input = UserMenu.PrintAndGetInput();

                this.ExecuteMenuAction(input);
            }
        }
    }
}
