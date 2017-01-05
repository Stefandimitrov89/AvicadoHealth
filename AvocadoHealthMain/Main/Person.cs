using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;

namespace Main
{
    abstract public class Person : IPerson
    {
        public string _FirstName { get; private set; }
        public string _LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            this._FirstName = firstName;
            this._LastName = lastName;
        }

        public abstract void Eat(object Food, int Quantity);
    }
}
