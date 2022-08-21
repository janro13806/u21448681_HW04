using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    class MiniBus : Vehicle
    {
        private int numSeats;

        MiniBus(string mManufacturer, string mName, string mType, int mYear, int mNumWheels, double mTopSpeed, int Seats) : base(mManufacturer, mName, mType, mYear, mNumWheels, mTopSpeed)
        {
            numSeats = Seats;
        }

        public override double calculateAVG_Speed() => mTopSpeed * mHorsePower;

        public override void driveToSchool()
        {
            double Avgspeed = calculateAVG_Speed();
            Console.WriteLine("The MiniBus :" + this.mName + " is being delivered to New Hope School.");
            Console.WriteLine("The MiniBus was made in the year : " + this.mYear);
            Console.WriteLine("The MiniBus is being delivered at an average speed of : " + Avgspeed);
            Console.WriteLine("The MiniBus has the following number of seats : " + numSeats);
        }
    }
}