using System;
using System.Collections.Generic;

namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the Car class
            var myCar = new Car();//CAR() is the constructor helps us creat a new
                                  //instance of the CAR() class; VAR is of type CAR
                                  //Set values in the properties for the object ((.) Dot Notation way
            myCar.Make = "Toyota";
            myCar.Model = "Camery";
            myCar.Year = 2017;
            //OR OBJECT INITIALIZER WAY BELOW
            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2015
            };
            //OR
            var chevy = new Car("Chevy", "Impala", 1967);
            //Print the values of each property to the Console
            var carList = new List<Car>() { myCar, mazda, chevy, };
            //List<Car> is a constructor
            foreach (var vehicle in carList)
            {
                Console.WriteLine($" {vehicle.Make}, {vehicle.Make}, {vehicle.Year}");
            }
        }
    
    }
}
