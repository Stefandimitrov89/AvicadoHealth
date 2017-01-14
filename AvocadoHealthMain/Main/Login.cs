namespace Main
{
    using Main.Interfaces;
    using System;
    using System.Collections.Generic;


    class Login : ILogIn
    {
        private readonly string username;
        private readonly string password;
        private Dictionary<string, string> usersList;
        private Dictionary<string, string> trainersList;
        UsernamesAndPasswords obj = new UsernamesAndPasswords();

        public Login()
        {
            this.Username = Console.ReadLine();
            this.Password = Console.ReadLine();
            this.UsersList = obj.AddCredentialsToUsers();
            this.TrainersList = obj.AddCredentialsToTrainers();
            //Asks for credentials until they are valid
            while (this.UsersList.ContainsKey(this.Username) == false || this.UsersList[this.Username].Contains(this.Password) == false)
            {
                Console.WriteLine("Invalid input! Please, try again: ");
                this.Username = Console.ReadLine();
                this.Password = Console.ReadLine();
            }
        }

        public string Username { get; }
        public string Password { get; }
        public Dictionary<string, string> UsersList { get; }
        public Dictionary<string, string> TrainersList { get; }

        public Type LogIn()
        {
            if (this.UsersList.ContainsKey(this.Username))
            {
                if (this.UsersList[this.Username].Contains(this.Password))
                {
                    return typeof(Trainer);
                }

                else
                {
                    Console.WriteLine("Wrong password!");
                    return typeof(Person);
                }
            }

            else if (this.TrainersList.ContainsKey(this.Username))
            {
                if (this.TrainersList[this.Username].Contains(this.Password))
                {
                    return typeof(User);
                }

                else
                {
                    Console.WriteLine("Wrong password!");
                    return typeof(Person);
                }
            }
            else
            {
                Console.WriteLine("You are not registered!");
                return typeof(Person);
            }
        }
    }
}
