using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

             /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Completed ** Create an abstract class called Vehicle
             * Completed ** The vehicle class shall have three string properties Year, Make, and Model
             * Completed ** Set the defaults to something generic in the Vehicle class
             * Completed ** Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Completed ** Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Completed ** Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Completed ** Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Completed ** Provide the implementations for the abstract methods (I'm providing in this class)
             * 
             * 
             * Completed ** Only in the Motorcycle class will you override the virtual drive method
            */

            // Completed** Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Completed ** Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Completed ** Set the properties with object initializer syntax
             */
            Car car1 = new Car() { Make = "Tesla", Model = "S", Year = 2021, HasTrunk = true };
            Motorcycle cycle1 = new Motorcycle() { Year = 2021, Make = "Kawasake", Model = "Ninja", HasSideCart = false };
            Vehicle auto1 = new Car() { Year = 2018, Make = "BMW", Model = "X", HasTrunk = true };
            Vehicle auto2 = new Car() { HasTrunk = false, Year = 1950, Make = "Pontiac", Model = "Firebird" };

            /*
             * Completed ** Add the 4 vehicles to the list
             * Completed ** Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(auto1);
            vehicles.Add(cycle1);
            vehicles.Add(auto2);

            // Completed ** Call each of the drive methods for one car and one motorcycle

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year {vehicle.Year } Make {vehicle.Make} Model {vehicle.Model}");
                vehicle.DriveAbstract();
                Console.WriteLine();
                Console.WriteLine("***************************************");
                Console.WriteLine();
            }

            #endregion            
            
        }
    }
}
