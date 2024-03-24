
public class Car : Vehicle
{
    public int Seats { get; private set; }

    // Type of engine, e.g., "V6", "Electric"
    public string EngineType { get; private set; }

    // Type of transmission, e.g., "Automatic", "Manual"
    public string Transmission { get; private set; }

    // Indicates whether the car is convertible (true if it is, false otherwise)
    public bool Convertible { get; private set; }

    // Constructor for the Car class that takes specific parameters for a car
    // and passes common vehicle parameters to the base Vehicle class constructor
    public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string engineType, string transmission, bool convertible)
        : base(model, manufacturer, year, rentalPrice) // Call the base class constructor
    {
        // Initialize car-specific properties with the values provided to the constructor
        Seats = seats; // Set the number of seats
        EngineType = engineType; // Set the engine type
        Transmission = transmission; // Set the transmission type
        Convertible = convertible; // Set whether the car is convertible
    }

    // Override the DisplayDetails method from the Vehicle base class to include car-specific details
    public override void DisplayDetails()
    {
        // Call the DisplayDetails method of the base Vehicle class to display common vehicle details
        base.DisplayDetails();

        // Display car-specific details
        Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {Convertible}");
    }
}
