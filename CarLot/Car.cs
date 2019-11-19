using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
    // We made a standard class, and modified it to be abstract
    abstract class Car
    {
        //make private fields to hold our objects data
        private string make;
        private int year;

        //make a public property that allows us to acces the private field
        //more verbose way to write property
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        //short hand way to write properties
        public string Model { get; set; }

        //made a virtual method that we will later override in a derived class
        public virtual string Definition()
        {
            return "Vehicle: ";
        }

        public abstract Car GetObject();
    }
}
