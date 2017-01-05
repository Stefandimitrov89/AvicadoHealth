using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;

namespace Main
{
    class User : Person, IPerson
    {
        public User(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Eat(object Food, int Quantity)
        {
            throw new NotImplementedException();
        }
    }
}
