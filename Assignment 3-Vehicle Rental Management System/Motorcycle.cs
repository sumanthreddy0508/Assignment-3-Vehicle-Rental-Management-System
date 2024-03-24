
public class Motorcycle : Vehicle
{
    public int EngineCapacity { get; private set; }

    // Type of fuel the motorcycle uses (e.g., petrol, diesel, electric)
    public string FuelType { get; private set; }

    // Indicates whether the motorcycle has a fairing (a protective cover)
    public bool HasFairing { get; private set; }

    // Constructor for the Motorcycle class that takes specific parameters for a motorcycle
    public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice) // Call the base class constructor
    {
        // Initialize motorcycle-specific properties with the values provided to the constructor
        EngineCapacity = engineCapacity; // Set the engine capacity
        FuelType = fuelType; // Set the fuel type
        HasFairing = hasFairing; // Set the fairing presence
    }

    // Override the DisplayDetails method from the Vehicle base class to include motorcycle-specific details
    public override void DisplayDetails()
    {
        // Call the DisplayDetails method of the base Vehicle class to display common vehicle details
        base.DisplayDetails();

        // Display motorcycle-specific details
        Console.WriteLine($"Engine Capacity: {EngineCapacity}cc, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");
    }
}
