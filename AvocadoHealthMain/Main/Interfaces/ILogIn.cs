using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Interfaces
{
    interface ILogIn
    {
        string Username { get; }
        string Password { get; }
        Dictionary<string, string> UsersList { get; }
        Dictionary<string, string> TrainersList { get; }
        Type LogIn();
    }
}
