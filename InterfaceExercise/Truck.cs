using System;
using System.Collections.Generic;

namespace InterfaceExercise;

public class Truck : ICompany, IVehicle
{
    public string TrunkType { get; set; }
    public bool HasTrunk { get; set; }
    public string Title { get; set; }
    public string NameBrand { get; set; }
    public string OriginCountry { get; set; }
    public string SubModel { get; set; } 
    public string EngineType { get; set; }
    public string Model { get; set; }
    
    public void Details()
    {
        Console.WriteLine("-----------------Truck Details");
        Console.WriteLine($"Brand: {NameBrand}, \nCountry of Origin is: {OriginCountry}, \nModel: {Model}, \nSubmodel: {SubModel},");
        Console.WriteLine($"Enginetype: {EngineType}, \nTitle is: {Title}, \nHas a Trunk: {HasTrunk}, \nType of the trunk: {TrunkType}");
    }
}