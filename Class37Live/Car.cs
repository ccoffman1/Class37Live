using System;
using System.Collections.Generic;
using System.Text;

namespace Class37Live
{
    public abstract class Car // abstract prevents new cars from being created outside of Car.  This is now a base class
    {
        public string Make { get; private set; } // Make cannot be updated outside of the Car class
        public string Model { get; private set; }

        public Car(string make, string model) // Constructor
        {
            this.Make = make;
            this.Model = model;
        }

        public abstract void Drive(int miles); // for anything that implements car it will implement this. return nothing and take 1 perameter


    }
}
