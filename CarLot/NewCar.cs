using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CarLot
{
    //NewCar inherits from Car class
    //This means NewCar is derived from Car
    class NewCar : Car
    {
        //make constructor to build more complex objects
        public NewCar(string make, string model, int year)//pass in the necessary values
        {
            Make = make;
            Model = model;
            Year = year;
        }

        //make default constructor to give more flexibility when creating object
        public NewCar() { }

        //we will override our virtual method
        public override string Definition()
        {
            //base refers to class you inherited from
            //we can now change functionality, since we have overridden our virtual method
            return $"{base.Definition()} {Make,-15} {Model,-15} {Year,-4}";
        }

        //create new method to write CSV to text file
        public void CarToCSV(List<NewCar> carList)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\ShaKy\Source\Repos\CarLot\CarLot\CarLotDB.txt");

            //use this keyword to create CSV as a string
            //which we will write to the text file
            //string csv = $"{this.Make},{this.Model},{this.Year}";

            //use foreach loop to iterate through carList
            //build CSV from each index of carList
            foreach (NewCar car in carList)
            {
                //use car in place of this keyword
                //string csv = $"{this.Make},{this.Model},{this.Year}";
                string csv = $"{car.Make},{car.Model},{car.Year}";

                //write our CSV to our text file
                sw.WriteLine(csv);
            }

            //close the connection to the text file
            sw.Close();
        }

        //create a method that reads in a CSV and returns a new object
        public List<NewCar> CSVToCar()
        {
            //make a default object that I can add value to later
            //NewCar tempCar = new NewCar();
            List<NewCar> tempCarList = new List<NewCar>();//changed single object to List of objects
            //make list of strings to hold CSV's
            List<string> csvList = new List<string>();

            //make a StreamReader Object, that will allow us to read a text file
            StreamReader sr = new StreamReader(@"C:\Users\ShaKy\Source\Repos\CarLot\CarLot\CarLotDB.txt");

            //hold each line of text file in a string
            string line = sr.ReadLine();

            //check to make sure the line is not null
            while (line != null)
            {
                //add csv to csvList
                csvList.Add(line);
                line = sr.ReadLine();
            }

            //use string.Split to parse CSV and mapp values to NewCar object
            //first we hold the Split values in a string[]
            //string[] csvArray = line.Split(',');


            //need a while loop to iterate through csvList
            //calling string.Split on each index

            foreach (string csv in csvList)
            {
                string[] csvArray = csv.Split(',');
                //we will now make our NewCar object, from the CSV we read in
                //tempCar.Make = csvArray[0];
                //tempCar.Model = csvArray[1];
                //tempCar.Year = int.Parse(csvArray[2]);

                tempCarList.Add(new NewCar(csvArray[0], csvArray[1], int.Parse(csvArray[2])));
            }



            return tempCarList;
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
                else
                {
                    this.Year = Validate.InputInt(member);
                }
            }

            return this;
        }
    }
}