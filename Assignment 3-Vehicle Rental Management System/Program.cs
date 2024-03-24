using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the rental agency
        RentalAgency rentalAgency = new RentalAgency();

        // Create some vehicles
        Vehicle car = new Car("Nexon ev", "Tata", 2020, 150m, 5, "Electric", "Automatic", false);
        Vehicle truck = new Truck("Thar", "Mahindra", 2018, 200m, 2.5, "Pickup", true);
        Vehicle motorcycle = new Motorcycle("Xpluse 650", "Pulsar", 2021, 100m, 649, "Petrol", false);

        // Add vehicles to the fleet
        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        // Display all vehicles in the fleet
        Console.WriteLine("Vehicles in the fleet:");
        rentalAgency.DisplayFleet();

        // Simulate renting a vehicle
        Console.WriteLine("\nRenting a vehicle...");
        rentalAgency.RentVehicle(car, car.RentalPrice); // Assuming RentalPrice is a public property of Vehicle

        // Display all vehicles in the fleet after renting out one
        Console.WriteLine("\nVehicles in the fleet after renting out one:");
        rentalAgency.DisplayFleet();

        // Display total revenue
        Console.WriteLine($"\nTotal Revenue: {rentalAgency.TotalRevenue:C}");
    }
}
