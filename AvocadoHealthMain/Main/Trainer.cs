using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Trainer : Person
    {
        public Trainer(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Eat(object Food, int Quantity)
        {
            throw new NotImplementedException();
        }
    }
}
