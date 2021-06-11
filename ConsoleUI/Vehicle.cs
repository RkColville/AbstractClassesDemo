using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    //Create an abstract class called Vehicle
    public abstract class Vehicle
    {
        //The vehicle class shall have three string properties Year, Make, and Model
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

       

        //Vehicle shall have an abstract method called DriveAbstract with no implementation
        public abstract void DriveAbstract();

        //Vehicle shall have a virtual method called DriveVirtual with a base implementation.
        public virtual void DriveVirtual()
        {
            Console.WriteLine("I love pretending to drive");
        }


    }
}
