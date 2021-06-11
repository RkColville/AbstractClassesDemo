using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    //Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
    public class Motorcycle : Vehicle
    {
        
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is fast!");
        }

        //???Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle

        public bool HasSideCart { get; set; } = false;
        

        public override void DriveVirtual()
        {
            Console.WriteLine("I love pretending to drive");
        }
    }
}
