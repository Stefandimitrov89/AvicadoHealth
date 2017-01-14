using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;

namespace Main
{
    public abstract class Food : IFood
        //Svetlomir Added inheritence of IFoods

    {
        public int Calories { get; set; }
        public double Fats { get; private set; }
        public double Proteins { get; private set; }
    }
}
