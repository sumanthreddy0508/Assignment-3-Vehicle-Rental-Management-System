using System.Collections.Generic;

public class RentalAgency
{
    private List<Vehicle> fleet = new List<Vehicle>();
    public decimal TotalRevenue { get; private set; }

    // Method to add a vehicle to the fleet
    public void AddVehicle(Vehicle vehicle)
    {
        fleet.Add(vehicle);
    }

    // Method to remove a vehicle from the fleet
    public bool RemoveVehicle(Vehicle vehicle)
    {
        return fleet.Remove(vehicle);
    }

    // Method to rent a vehicle
    public void RentVehicle(Vehicle vehicle, decimal rentalPrice)
    {
        if (fleet.Contains(vehicle))
        {
            TotalRevenue += rentalPrice;
            fleet.Remove(vehicle); // Assuming the vehicle is removed from the fleet when rented
        }
    }

    // Method to display all vehicles in the fleet
    public void DisplayFleet()
    {
        foreach (var vehicle in fleet)
        {
            vehicle.DisplayDetails();
        }
    }

    // Method to get a read-only list of vehicles in the fleet, if needed for external use
    public IEnumerable<Vehicle> GetFleet()
    {
        return fleet.AsReadOnly();
    }
}
