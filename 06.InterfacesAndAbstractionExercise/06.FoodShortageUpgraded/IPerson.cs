﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortageUpgraded
{
    public interface IPerson:IBuyer
    {
        public string Name { get; }
        public int Age { get;}
    }
}
