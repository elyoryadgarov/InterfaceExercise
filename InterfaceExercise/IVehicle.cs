namespace InterfaceExercise;

public interface IVehicle
{
    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */
    public string SubModel { get; set; }
    public string EngineType { get; set; }
    public string Model { get; set; }
    public string Title { get; set; }

    public void Details();
}