using System;
using System.IO;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {

            //make a List that will hold Car objects
            List<Car> carList = new List<Car>()
            //scope of the entire list
            {
                //scope of individual index
                { new NewCar("Toyota","Prius",2012)}, //comma allows us to add another index
                //we can add a New or Used car because they are both derived from Car
                //{ new UsedCar("BMW","M5",1997,222000.22)}
            };

            //make a NewCar object, and call its Definition method
            //NewCar newCar = new NewCar();

            //make a UsedCar object, and call its Definition method
            //UsedCar usedCar = new UsedCar();
            List<NewCar> newCarList = new List<NewCar>()
            {
                { new NewCar("BMW","M5",2012)},
                { new NewCar("Toyota","Prius",2012)}
            };

            //NewCar newCar = new NewCar("BMW","M5",2012);
            //NewCar secondCar = new NewCar("Toyota","Prius",2012);

            //we build a newCar object to call CSV method from
            NewCar newCar = new NewCar();
            newCar.CarToCSV(newCarList);

            //call CSV method off of newCar object to write object data as CSV to text file
            
            newCar.CSVToCar();


            //create new streamwriter object
            StreamWriter sw = new StreamWriter(@"C:\Users\ShaKy\Source\Repos\CarLot\CarLot\CarLotDB.txt");
            //use a foreach loop to iterate through my List of cars
            foreach (Car car in carList)
            {
                //if there is a NewCar it will call NewCar.Definition
                //if there is a UsedCar it will call UsedCar.Definition
                Console.WriteLine(car.Definition());
                sw.WriteLine(car.Definition());
            }
            //closed the connection saving data to the text file
            sw.Close();







            Console.WriteLine("Written");






            StreamReader sr = new StreamReader(@"..\CarLotDB.txt");
            List<string> tempList = new List<string>();

            string line = "";

            while (line != null)
            {
                //some coding
                line = sr.ReadLine();
                if (line != null)
                {
                    tempList.Add(line);
                }
            }

            sr.Close();

            Console.WriteLine("Written");
        }
    }
}