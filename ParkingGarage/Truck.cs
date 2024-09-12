namespace ParkingGarage;

public class Truck : Vehicle
{
    public Truck(string id) : base(id)
    {
        
    }

    public override void Park(List<Spot> spots)
    {
        if (IsParked == false)
        {
            var largeSpot = spots.FirstOrDefault(spot => spot is { SpotType: SpotType.Large, IsAvailable: true });
            if (largeSpot != null)
            {
                largeSpot.IsAvailable = false;
                GetTicket(largeSpot.ID, ID, largeSpot.PricePerHour);
                IsParked = true;
            }
            else
            {
                Console.WriteLine("There is no parking spot.");
            }
        }
        else
        {
            Console.WriteLine("Truck is already parked.");
        }
    }
    
}