using System;
using System.Collections.Generic;

namespace InterfaceExercise;

public class Car : ICompany, IVehicle
{
    public string DoorCount { get; set; }
    public string FuelType { get; set; }
    public string NameBrand { get; set; }
    public string OriginCountry { get; set; }
    public string SubModel { get; set; }
    public string EngineType { get; set; }
    public string Model { get; set; }
    public string Title { get; set; }
    
    public void Details()
    {
        Console.WriteLine("----------------Car Details");
        Console.WriteLine($"Brand: {NameBrand}, \nCountry of Origin is: {OriginCountry}, \nModel: {Model}, \nSubmodel: {SubModel},");
        Console.WriteLine($"Enginetype: {EngineType}, \nTitle is: {Title}, \nFuel type: {FuelType}, \nDoor count: {DoorCount}");
    }
}