
public class Vehicle
{
    public string Model { get; private set; }
    public string Manufacturer { get; private set; }
    public int Year { get; private set; }


    public decimal RentalPrice { get; private set; }

    // Constructor for the Vehicle class that initializes a new instance with the provided values.
    // model: the model of the vehicle
    // manufacturer: the manufacturer of the vehicle
    // year: the year the vehicle was manufactured
    // rentalPrice: the daily rental price for the vehicle
    public Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
    {
        // Initialize each property with the corresponding parameter passed to the constructor.
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrice = rentalPrice;
    }

    // Virtual method to display details about the vehicle. This method can be overridden in derived classes to include additional information.
    // The method prints the vehicle's model, manufacturer, year, and rental price to the console.
    public virtual void DisplayDetails()
    {
        // Print the details of the vehicle to the console.
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice}");
    }
}
