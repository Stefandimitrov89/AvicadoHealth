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
        private Trainer loggerTrainer;

        public TrainerUI(Trainer loggedTrainer)
        {
            List<MenuItem> list = new List<MenuItem>();

            list.Add(new MenuItem() { Number = 1, MenuText = "Set training" });
            // todo add other menus

            trainerMenu = new Menu(list);
        }

        public void ExecuteMenuAction(int actionNumber)
        {
            switch (actionNumber)
            {
                case 1:
                    var user = ChooseUser(loggerTrainer);
                    var training = ChooseTraining(loggerTrainer);

                    user.SetTraining(training);

                    break;

                default: break;
            }
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
