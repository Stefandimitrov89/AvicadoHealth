using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public abstract class Food
    {
        public int Calories { get; set; }
        public double Fats { get; private set; }
        public double Proteins { get; private set; }
    }
}
