﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private int age;
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public int Age
        {
            get { return age; }

            set
            {
                if (age<0)
                {
                    throw new InvalidOperationException("Invalid input!");
                }

                this.age = value;
            }
        }
        public string Gender { get; set; }


        public virtual string ProduceSound()
        {
            return "";
        }
       
    }
}
