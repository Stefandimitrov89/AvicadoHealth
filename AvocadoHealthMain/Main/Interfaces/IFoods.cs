using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Interfaces
{
    public interface IFood
    {
        int Calories { get; }
        double Fats { get; }
        double Proteins { get; }
        //Svetlomir Added Properties
    }
}
