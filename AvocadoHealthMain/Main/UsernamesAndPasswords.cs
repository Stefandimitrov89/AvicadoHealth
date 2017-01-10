namespace Main
{
    using System.Collections.Generic;

    public class UsernamesAndPasswords
    {
        private Dictionary<string, string> users;
        private Dictionary<string, string> trainers;

        public UsernamesAndPasswords()
        {
            this.Users = users;
            this.Users = new Dictionary<string, string>();
            this.Trainers = trainers;
            this.Trainers = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Users { get; private set; }
        public Dictionary<string, string> Trainers { get; private set; }

        public Dictionary<string, string> AddCredentialsToUsers()
        {
            this.Users.Add("Iskra", "Lumbeva");
            this.Users.Add("Stefan", "Dimitrov");
            this.Users.Add("Martin", "Kanovsky");
            return this.Users;
        }

        public Dictionary<string, string> AddCredentialsToTrainers()
        {
            this.Trainers.Add("Milena", "Shishkova");
            this.Trainers.Add("Vasilena", "Ilieva");
            this.Trainers.Add("Svetlomir", "Balevski");
            return this.Trainers;
        }
    }
}
