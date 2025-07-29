using System;
using System.Collections.Generic;

namespace InterfaceExercise;

public class SUV : ICompany, IVehicle
{
    public int SeatCount { get; set; }
    public string DrivingWheelsCount { get; set; }
    public string NameBrand { get; set; }
    public string OriginCountry { get; set; }
    public string SubModel { get; set; }
    public string EngineType { get; set; }
    public string Model { get; set; }
    public string Title { get; set; }
    
    public void Details()
    {
        Console.WriteLine("--------------SUV Details");
        Console.WriteLine($"Brand: {NameBrand}, \nCountry of Origin is: {OriginCountry}, \nModel: {Model}, \nSubmodel: {SubModel},");
        Console.WriteLine($"Enginetype: {EngineType}, \nTitle is: {Title}, \nCount of seats: {SeatCount}, \nDriving wheels count: {DrivingWheelsCount}");
    }
}