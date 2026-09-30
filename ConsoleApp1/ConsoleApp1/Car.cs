using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Car
    {
        private string _model;
        private string _brand;

        public string Model { get => _model; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Wanna a kick ?");
                    return;
                }
                else
                {
                    _model = value;
                }
            }
        }
        public string Brand 
        {
            get => _brand;
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    Console.WriteLine("Wanna a kick ?");
                    return;
                }
                else
                {
                    _brand = value;
                }
            }
        }
        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"This car is {model} of {brand}");
        }

        public void TopSpeed()
        {
            Random rand = new Random();
            
            Console.WriteLine($"Top speed of {_model} is {rand.Next(200,250)}/khph.");
        }
    }
}
