﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Human
    {
        public Human(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }
        public int Age  { get; set; }
        public string Id  { get; set; }
    }
}
