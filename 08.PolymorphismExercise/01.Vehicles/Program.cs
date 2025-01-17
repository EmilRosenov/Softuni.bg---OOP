﻿using System;
using System.Collections.Generic;

namespace _01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            for (int i = 0; i < 2; i++)
            {
                string[] vehicleInput = Console.ReadLine().Split();
               
                try
                {
                    CreateVehicle(vehicleInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }
                
                vehicleList.Add(CreateVehicle(vehicleInput));
            }
          
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string type = input[1];
                

                if (command=="Drive" && type == nameof(Car))
                {
                    Vehicle car = vehicleList[0];
                    double distance = double.Parse(input[2]);
                    car.Drive(distance);
                }
                else if (command == "Drive" && type == nameof(Truck))
                {
                    Vehicle truck = vehicleList[1];
                    double distance = double.Parse(input[2]);
                    truck.Drive(distance);
                }

                if (command == "Refuel" && type == nameof(Car))
                {
                    Vehicle car = vehicleList[0];
                    double fuel = double.Parse(input[2]);
                    car.Refuel(fuel);
                }
                else if (command == "Refuel" && type == nameof(Truck))
                {
                    Vehicle truck = vehicleList[1];
                    double fuel = double.Parse(input[2]);
                    truck.Refuel(fuel);
                }
            }
            Console.WriteLine($"Car: {vehicleList[0].FuelQuantity:f2}");
            Console.WriteLine($"Truck: {vehicleList[1].FuelQuantity:f2}");


        }

        private static Vehicle CreateVehicle(string[] vehicleInput)
        {
            string type = vehicleInput[0];
            double fuelQuantity = double.Parse(vehicleInput[1]);
            double litersPerKm = double.Parse(vehicleInput[2]);
            Vehicle vehicle = null;

            if (type == nameof(Car))
            {
                
                return vehicle = new Car(fuelQuantity, litersPerKm);
            }
            else if (type == nameof(Truck))
            {
                return vehicle = new Truck(fuelQuantity, litersPerKm);
            }
            else
            {
                throw new ArgumentException("Invalid vehicle");
            }

        }

       
    }
}
