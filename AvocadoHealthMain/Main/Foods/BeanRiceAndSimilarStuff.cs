﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class BeanRiceAndSimilarStuff : Food
    {
        //Смених начина на скриване на родителското пропърти от override към new
        public new int Calories
        {
            get
            {
                return Calories;
            }

            set
            {
                Calories = value;
            }
        }
    }
}
