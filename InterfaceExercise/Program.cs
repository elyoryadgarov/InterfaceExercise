using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            Truck truck1 = new Truck();
            truck1.EngineType = "Gazoline";
            truck1.Title = "Clean";
            truck1.HasTrunk = true;
            truck1.TrunkType = "Trunked";
            truck1.Model = "F-150";
            truck1.NameBrand = "Ford";
            truck1.OriginCountry = "United States";
            truck1.Details();
            
            Car car1 = new Car();
            car1.EngineType = "Gazoline";
            car1.Title = "Clean";
            car1.DoorCount = "5";
            car1.NameBrand = "Tesla";
            car1.SubModel = "Sb50";
            car1.OriginCountry = "United States";
            car1.FuelType = "Electric";
            car1.Details();
            
            SUV sUV1 = new SUV();
            sUV1.EngineType = "Gazoline";
            sUV1.Title = "Salvage";
            sUV1.Model = "Terrain";
            sUV1.NameBrand = "GMC";
            sUV1.OriginCountry = "United States";
            sUV1.DrivingWheelsCount = "2";
            sUV1.SeatCount = 5;
            sUV1.SubModel = "AMX";
            sUV1.Details();



            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
