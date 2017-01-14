using System;
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

            list.Add(new MenuItem() { Number = 1, MenuText = "Set training" });
            list.Add(new MenuItem() { Number = 2, MenuText = "Create training" });
            list.Add(new MenuItem() { Number = 3, MenuText = "Set Food" });
            list.Add(new MenuItem() { Number = 4, MenuText = "User Info" });
            list.Add(new MenuItem() { Number = 5, MenuText = "Show Users" });
            list.Add(new MenuItem() { Number = 6, MenuText = "List Menu" });
            list.Add(new MenuItem() { Number = 7, MenuText = "Return To Login"});
            trainerMenu = new Menu(list);
        }

        public void ExecuteMenuAction(int actionNumber)
        {
            switch (actionNumber)
            {
                case 1:
                    var user = ChooseUser(loggedTrainer);
                    var training = ChooseTraining(loggedTrainer);

                    user.SetTraining(training);

                    break;
                case 2:
                    CreateTraining();
                    break;
                default: break;
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

            var NewTraining = new Training(trainingName, CaloriesSpendPerMin, ProteinsSpendPerMinute,FartsSpendPerMinute,CHsSpendPerMinute);
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
