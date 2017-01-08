using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Trainer :  Interfaces.IPerson
    {

        public Trainer(string firstName, string lastName)
        {
        }

        public override void Eat(Food Food, double mass)
        {
            throw new NotImplementedException();
        }

        public override void Train(Training training, double duration)
        {
            throw new NotImplementedException();
        }
    }
}
