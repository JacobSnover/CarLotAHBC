using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
    //made a UsedCar class, we will inherit our abstract Car class
    //making UsedCar derived from Car
    class UsedCar : Car
    {
        //make a private field to hold our data
        private double mileage;

        //make a public property to access our private field
        public double Mileage
        {
            //get method will return specified field
            get { return mileage; }
            //set method allows us to set our private field outside this class
            set { mileage = value; }
        }

        public UsedCar(string make, string model, int year, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        //override our Definition virtual method
        public override string Definition()
        {
            return $"{base.Definition()} {Make,-15} {Model,-15} {Year,-4} {Mileage,-20}";
        }

        public override Car GetObject()
        {
            List<string> members = new List<string>() { "Make", "Model", "Year" };

            foreach (string member in members)
            {
                if (member == "Make")
                {
                    this.Make = Validate.InputString(member);
                }
                else if (member == "Model")
                {
                    this.Model = Validate.InputString(member);
                }
                else if (member == "Year")
                {
                    this.Year = Validate.InputInt(member);
                }
                else
                {
                    this.Mileage = Validate.InputDouble(member);
                }
            }

            return this;
        }
    }
}