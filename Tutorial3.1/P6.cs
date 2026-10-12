using System;

namespace _3._1___Tutorial
{
    internal class P6
    {
        class Vehicle
        {
            public string VehicleNumber { get; set; }
            public string ModelName { get; set; }

            public Vehicle(string vehicleNumber, string modelName)
            {
                VehicleNumber = vehicleNumber;
                ModelName = modelName;
            }
        }

        class Car : Vehicle
        {
            public string CarName { get; set; }
            public double Price { get; set; }

            public Car(string vehicleNumber, string modelName, string carName, double price)
                : base(vehicleNumber, modelName)
            {
                CarName = carName;
                Price = price;
            }

            public void DisplayDetails()
            {
                Console.WriteLine("Vehicle Number: " + VehicleNumber);
                Console.WriteLine("Model Name: " + ModelName);
                Console.WriteLine("Car Name: " + CarName);
                Console.WriteLine("Price: " + Price);
            }
        }

        public static void Program_6()
        {
            Car car = new Car("GJ03AB1234", "2025", "Toyota Fortuner", 3500000);

            car.DisplayDetails();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Sakariya Smit R");
            Console.WriteLine("Enrollment No: 25SOEIT13027");


            Console.ReadLine();
        }
    }
}