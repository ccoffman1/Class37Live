using System;

namespace Class37Live
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: create different cars and "drive" them

            GasCar explorer = new GasCar("ford", "Explorer", 20, 15); //Calls ElectricCar Constructor
            explorer.Drive(75);
            explorer.Drive(50); //calling the drive function on the explorer.  Drive will log our stuff in this example

            ElectricCar leaf = new ElectricCar("Nissan", "Leaf", 60, 3);
            leaf.Drive(75);
            leaf.Drive(15);

        }
    }
}
