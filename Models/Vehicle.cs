using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    abstract class Vehicle
    {
        public string mManufacturer;
        public string mName;
        public string mType;
        public int mYear;
        public int mNumOfWheels;
        public double mAVGSpeed;
        public double mTopSpeed;
        public double mHorsePower;


        public Vehicle(string Manufacturer, string Name, string Type, int Year, int NumWheels, double topSpeed)
        {
            this.mManufacturer = Manufacturer;
            this.mName = Name;
            this.mType = Type;
            this.mYear = Year;
            this.mNumOfWheels = NumWheels;
            this.mTopSpeed = topSpeed;

            switch (this.Type)
            {
                case "Car":
                    mHorsePower = 50;
                    break;
                case "MiniBus":
                    mHorsePower = 35;
                    break;
                case "Bicycle":
                    mHorsePower = 20;
                    break;
                default:
                    break;
            }


        }

        public Vehicle()
        {
            this.mManufacturer = "";
            this.mName = "";
            this.mYear = 0;
            this.mNumOfWheels = 0;
            this.mTopSpeed = 0.0;
            this.mHorsePower = 0.0;
        }

        public int Year { get; set; }
        public string Type { get; set; }


        public abstract double calculateAVG_Speed();

        public virtual void driveToSchool()
        {
            double Avgspeed = 10;
            Console.WriteLine("The Vehicle :" + this.mName + " is being delivered to New Hope School.");
            Console.WriteLine("The Vehicle was made in the year : " + this.mYear);
            Console.WriteLine("The Vehicle is being delivered at an average speed of : " + Avgspeed);
        }
    }
}