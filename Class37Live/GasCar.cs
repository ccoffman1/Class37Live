using System;
using System.Collections.Generic;
using System.Text;

namespace Class37Live
{
    public class GasCar : Car // ElectricCar extends Car
    {
        public int GasTankSize { get; private set; }
        public double GasTankLevel { get; private set; }
        public double MilesPerGallon { get; private set; }

        public GasCar(string make, string model, int gasTankSize, double milesPerGallon) : base(make, model) //Since ElectricCar extends car, Car needs make and model (see constructor in Car).  this gets it that.
        { //make and model are handled by the base class.  The rest are set in this constructor
            this.GasTankSize = gasTankSize;
            this.GasTankLevel = gasTankSize;
            this.MilesPerGallon = milesPerGallon;
        }

        //Implement Drive function
        public override void Drive(int miles) //since we are implementing a drive function in Car we need override here
        {
            //TODO: adjust fuel based on mpg
            //TODO: write out distance traveled and fuel remaining

            double maxDistance = this.MilesPerGallon * this.GasTankLevel;
            double distanceTraveled = miles;
            if (miles > maxDistance) //made sure it cant travel too far
            {
                distanceTraveled = maxDistance;
            }

            double gallonsUsed = distanceTraveled / this.MilesPerGallon;
            this.GasTankLevel = this.GasTankLevel - gallonsUsed;
            var text = String.Format("Traveled {0} Miles, Gallons Used: {1}, Gallons Remaining: {2}", distanceTraveled, gallonsUsed, this.GasTankLevel);
            Console.WriteLine(text);
            Console.ReadLine();


        }

    }
}
