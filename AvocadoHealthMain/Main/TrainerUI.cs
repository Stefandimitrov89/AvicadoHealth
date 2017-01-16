using Main.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class TrainerUI
    {
        private bool ContinueToExecute = true;
        private Menu trainerMenu;
        private Trainer loggedTrainer;

        public TrainerUI(Trainer loggedTrainer)
        {
            List<MenuItem> list = new List<MenuItem>();

            list.Add(new MenuItem() { Number = 1, MenuText = "Create training" });
            list.Add(new MenuItem() { Number = 2, MenuText = "Set training" });
            list.Add(new MenuItem() { Number = 3, MenuText = "Set Food" });
            list.Add(new MenuItem() { Number = 4, MenuText = "User Info" });
            list.Add(new MenuItem() { Number = 5, MenuText = "Show Users" });
            list.Add(new MenuItem() { Number = 7, MenuText = "Return To Login" });
            trainerMenu = new Menu(list);
            this.loggedTrainer = loggedTrainer; // добавих това за да този фиилд се инициализира с истанция на Trainer - Мартин
        }

        public void ExecuteMenuAction(int actionNumber)
        {
            var Currentuser = ChooseUser(loggedTrainer);

            switch (actionNumber)
            {
                case 1:
                    ChooseTraining();
                    break;
                case 2:
                    SetTraining(Currentuser);
                    break;
                case 3:
                    SetFood(Currentuser);
                    break;
                case 4:
                    Currentuser.printUserInfo();
                    break;
                case 5:
                    this.loggedTrainer.PrintMyTrainees();
                    break;
                case 7:
                    ContinueToExecute = false;
                    break;
                default: break;
            }
        }

        private void SetTraining(User currentUser)
        {
            Console.WriteLine("Choose training to set");

            for (int i = 0; i < loggedTrainer.MyTrainings.Count; i++)
            {
                Console.WriteLine($"{i}:{loggedTrainer.MyTrainings[i]}");
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
                    currentUser._TrainingsList.Add((loggedTrainer.MyTrainings[enteredNumber]));
                    isTrue = true;
                }

            }

        }

        private void SetFood(User currentUser)
        {
            Console.WriteLine("Please enter the food to add");

            List<IFood> listOFFoodTypes = new List<IFood>() { new BeanRiceAndSimilarStuff(), new BreadAndSimilar(),
            new Drinks(), new Fruits(), new JunkFood(), new Meat(),new NonAlcoBevareges(),new Vegetables(), new Water()};

            for (int i = 0; i < listOFFoodTypes.Count; i++)
            {
                Console.WriteLine($"For {listOFFoodTypes[i].ToString()} enter {i}");
            }

            int enteredNumber = 0;
            bool isTrue = false;
            while (!isTrue)
                try
                {
                    enteredNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter Valid number");
                }
            if (enteredNumber >= 0 && enteredNumber <= listOFFoodTypes.Count)
            {
                currentUser._RecomendedFood.Add(listOFFoodTypes[enteredNumber]);
                isTrue = true;
            }
            else
            {
                Console.WriteLine("Please Enter Valid number");
            }
        }

        private object CreateTraining()
        {

            //TODO Validation
            Console.WriteLine("Please enter training name");
            string trainingName = Console.ReadLine();
            Console.WriteLine("Please enter calories spend per minute");
            double CaloriesSpendPerMin = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter proteins spend per minute");
            double ProteinsSpendPerMinute = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter fat spend per minute");
            double FartsSpendPerMinute = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter carbonhydrates spend per minute");
            double CHsSpendPerMinute = double.Parse(Console.ReadLine());

            var NewTraining = new Training(trainingName, CaloriesSpendPerMin, ProteinsSpendPerMinute, FartsSpendPerMinute, CHsSpendPerMinute);
            return NewTraining;


        }

        private User ChooseUser(Trainer trainer)
        {
            for (int i = 0; i < loggedTrainer.MyTrainees.Count; i++)
            {
                Console.WriteLine($"For user {loggedTrainer.MyTrainees[i]}, enter {i}");
            }
            int enteredNumber = 0;
            bool isTrue = false;
            while (!isTrue)
            {
                try
                {
                    enteredNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter Valid number");
                }
                if (enteredNumber >= 0 && enteredNumber <= loggedTrainer.MyTrainees.Count)
                {
                    isTrue = true;
                }
            }
            return loggedTrainer.MyTrainees[enteredNumber];
        }

        private void ChooseTraining()
        {
            Console.WriteLine("Enter Training name");
            string name = Console.ReadLine();
            double callPerMin = 0;
            double proteinsPerMin = 0;
            double fartsPerMin = 0;
            double carbPerMin = 0;
            Console.WriteLine("Enter call/min");
            callPerMin = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter proteins/min");
            proteinsPerMin = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fats/min");
            fartsPerMin = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter carb/min");
            carbPerMin = double.Parse(Console.ReadLine());

            loggedTrainer.CreateTraining(name, callPerMin, proteinsPerMin, fartsPerMin, carbPerMin);
        }


        internal void MainMenu()
        {
            while (ContinueToExecute)
            {
                int input = trainerMenu.PrintAndGetInput();

                this.ExecuteMenuAction(input);
            }
        }
    }
}
