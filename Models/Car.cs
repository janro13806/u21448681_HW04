using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    class Car : Vehicle
    {
        private bool hasAC;

        Car(string mManufacturer, string mName, string mType, int mYear, int mNumWheels, double mTopSpeed, bool ac) : base (mManufacturer, mName, mType, mYear, mNumWheels, mTopSpeed)
        {
            hasAC = ac;
        }

        public override double calculateAVG_Speed() => Math.Pow(mTopSpeed, mHorsePower);

        public override void driveToSchool()
        {
            double Avgspeed = calculateAVG_Speed();
            Console.WriteLine("The Car :" + this.mName + " is being delivered to New Hope School.");
            Console.WriteLine("The Car was made in the year : " + this.mYear);
            Console.WriteLine("The Car is being delivered at an average speed of : " + Avgspeed);

            if (hasAC)
            {
                Console.WriteLine("The Car has an Air Conidtioner!! Don't worry about summer!");
            }
            else
            {
                Console.WriteLine("The Car does not have an Air Conidtioner!! Open a Window!!");
            }
        }
    }
}