﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Exercise
{
    public class ModernKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("In MOdern Kitchen: robot clean the dust and throws rubbish");
        }

        public override void CookMeat()
        {
            Console.WriteLine("In Modern Kitchen: pre heated smart oven cooker");
        }

        public void RobotWash()
        {
            Console.WriteLine("In Modern Kitchen only: using a smart dishwasher");
        }
    }
}