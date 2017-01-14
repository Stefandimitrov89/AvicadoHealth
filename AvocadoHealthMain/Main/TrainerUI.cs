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
            list.Add(new MenuItem() { Number = 6, MenuText = "List Menu" });
            list.Add(new MenuItem() { Number = 7, MenuText = "Return To Login" });
            trainerMenu = new Menu(list);
        }

        public void ExecuteMenuAction(int actionNumber)
        {
            var Currentuser = ChooseUser(loggedTrainer);
            var training = ChooseTraining(loggedTrainer);

            switch (actionNumber)
            {
                case 1:
                    Currentuser.CreateTraining(training);

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
                    Startup.Login();
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
                if (enteredNumber > 0 && enteredNumber <= loggedTrainer.MyTrainings.Count)
                {
                    currentUser._TrainingsList.Add((dynamic)loggedTrainer.MyTrainings[enteredNumber]);
                    isTrue = true;
                }

            }

        }

        

        private void SetFood(User currentUser)
        {
            Console.WriteLine("Please enter the food to add");
            List<IFoods> listOFFoodTypes = new List<IFoods>() { new BeanRiceAndSimilarStuff(), new BreadAndSimilar(),
            new Drinks(), new Fruits(), new JunkFood(), new Meat(),new NonAlcoBevareges(),new Vegetables(), new Water()};
            for (int i = 0; i < listOFFoodTypes.Count; i++)
            {
                Console.WriteLine($"For {listOFFoodTypes[i].ToString()} enter {i}");
            }
            int enteredNumber = 0;
            bool isTrue = false;
            while(!isTrue)
            try
            {
                    enteredNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                    Console.WriteLine("Please Enter Valid number");
            }
            if (enteredNumber > 0 && enteredNumber <=9)
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

            //TODO Impelementing new training
        }

        private User ChooseUser(Trainer trainer)
        {
            // TODO foreach trainer.Users -> print; get user input

            return new User("as", "as", "gen");
        }

        private Training ChooseTraining(Trainer trainer)
        {
            // TODO foreach trainer.Users -> print; get user input

            return new PowerTraining();
        }

        internal void MainMenu()
        {
            while (true)
            {
                int input = trainerMenu.PrintAndGetInput();

                this.ExecuteMenuAction(input);
            }
        }



    }
}
