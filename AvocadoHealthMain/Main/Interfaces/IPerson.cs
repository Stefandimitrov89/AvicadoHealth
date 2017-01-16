﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Interfaces
{
    public interface IPerson
    {
        void Eat(Interfaces.IFood Food, double mass);

        void Train(Training training, double duration);

    }
}
