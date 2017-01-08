using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Interfaces
{
    public interface IPerson
    {
        string Role(); // This should be person's role - trainer or user
        void Eat(Food Food, double mass);

        void Train(Training training, double duration);

    }
}
