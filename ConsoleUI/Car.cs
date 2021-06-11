using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    //Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
    public class Car : Vehicle
    {
        public Car()
        {

        }

        public override void DriveAbstract()
        {
            Console.WriteLine("He drives wild");
        }

        //???Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle

        public bool HasTrunk { get; set; } = true;
        

    }
}
