using System;
using System.Collections.Generic;
using System.Text;

namespace Class37Live
{
    class ElectricCar : Car
    {
        public int BatteryKwhSize { get; private set; }
        public double BatteryLevel { get; private set; }
        public double MilesPerKwh { get; private set; }

        public ElectricCar(string make, string model, int batteryKwhSize, double milesPerKwh) : base(make, model) //Since ElectricCar extends car, Car needs make and model (see constructor in Car).  this gets it that.
        { //make and model are handled by the base class.  The rest are set in this constructor
            this.BatteryKwhSize = batteryKwhSize;
            this.BatteryLevel = batteryKwhSize;
            this.MilesPerKwh = milesPerKwh;
        }

        //Implement Drive function
        public override void Drive(int miles) //since we are implementing a drive function in Car we need override here
        {
            //TODO: adjust fuel based on mpg
            //TODO: write out distance traveled and fuel remaining

            double maxDistance = this.MilesPerKwh * this.BatteryLevel;
            double distanceTraveled = miles;
            if (miles > maxDistance) //made sure it cant travel too far
            {
                distanceTraveled = maxDistance;
            }

            double KwhUsed = distanceTraveled / this.MilesPerKwh;
            this.BatteryLevel = this.BatteryLevel - KwhUsed;
            var text = String.Format("Traveled {0} Miles, Kwh Used: {1}, Kwh Remaining: {2}", distanceTraveled, KwhUsed, this.BatteryLevel);
            Console.WriteLine(text);
            Console.ReadLine();


        }
    }
}
