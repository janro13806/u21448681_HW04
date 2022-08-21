using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    class Bicycle : Vehicle
    {
        private bool hasHelmet;
        Bicycle(string mManufacturer, string mName, string mType, int mYear, int mNumWheels, double mTopSpeed, bool helmet) : base(mManufacturer, mName, mType, mYear, mNumWheels, mTopSpeed)
        {
            hasHelmet = helmet;
        }

        public override double calculateAVG_Speed() => mTopSpeed + mHorsePower;


        public override void driveToSchool()
        {
            double Avgspeed = calculateAVG_Speed();
            Console.WriteLine("The Bicycle :" + this.mName + " is being delivered to New Hope School.");
            Console.WriteLine("The Bicycle was made in the year : " + this.mYear);
            Console.WriteLine("The Bicycle is being delivered at an average speed of : " + Avgspeed);

            if (hasHelmet)
            {
                Console.WriteLine("The Bicycle does have a helmet. SAFETY FIRST!!");
            } else
            {
                Console.WriteLine("The Bicycle does NOT have a helmet to use. Please inform the child to bring one.");
            }
        }
    }
}