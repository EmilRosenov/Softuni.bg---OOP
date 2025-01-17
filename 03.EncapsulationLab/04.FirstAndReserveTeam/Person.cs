﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
       
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
           
            
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");

                }

                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");

                }

                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");

                }
                age = value;

            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }

            private set
            {
                if (value < 555m)
                {
                    throw new ArgumentException("Salary cannot be less than 555 leva!");
                }
                salary = value;

            }
        }
        public string Name { get; set; }
       
       
        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                Salary += (Salary * ((percentage * 0.01m) / 2));
            }
            else
            {
                Salary += (Salary * (percentage * 0.01m));
            }
        }
       
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }
}
