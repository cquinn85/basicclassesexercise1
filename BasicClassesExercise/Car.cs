using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClassesExercise
{
    public class Car
    {
        public Car() //constructor special member method has same name as its class
        {

        }

        //Create a Make property of type string that is public
        public string Make { get; set; } // get = read, set = write
                                         //Create a Model property of type string that is public
        public string Model { get; set; }
        //Create a Year property of type int that is public
        public int Year { get; set; }
        //above properties are what DEFINE a car (MAKE MODEL YEAR)

        //scope: contains constructors


        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}