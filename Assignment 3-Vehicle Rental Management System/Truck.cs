
public class Truck : Vehicle
{
    public double Capacity { get; private set; }
    public string TruckType { get; private set; }
    public bool FourWheelDrive { get; private set; }

    // Constructor for the Truck class that takes specific parameters for a truck
    // and passes common vehicle parameters to the base Vehicle class constructor
    public Truck(string model, string manufacturer, int year, decimal rentalPrice, double capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice) // Call the base class constructor
    {
        // Initialize truck-specific properties with the values provided to the constructor
        Capacity = capacity; // Set the load capacity
        TruckType = truckType; // Set the type of truck
        FourWheelDrive = fourWheelDrive; // Set the four-wheel drive capability
    }

    // Override the DisplayDetails method from the Vehicle base class to include truck-specific details
    public override void DisplayDetails()
    {
        // Call the DisplayDetails method of the base Vehicle class to display common vehicle details
        base.DisplayDetails();

        // Display truck-specific details
        Console.WriteLine($"Capacity: {Capacity} tons, Truck Type: {TruckType}, Four-Wheel Drive: {FourWheelDrive}");
    }
}
