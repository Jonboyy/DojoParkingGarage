namespace ParkingGarage;

public class Car : Vehicle 
{
    public Car(string id) : base(id)
    {
        
    }

    public override void Park(List<Spot> spots)
    {
        if (IsParked == false)
        {
            var smallSpot = spots.FirstOrDefault(spot => spot is { SpotType: SpotType.Small, IsAvailable: true });
            if (smallSpot != null)
            {
                smallSpot.IsAvailable = false;
                GetTicket(smallSpot.ID, ID, smallSpot.PricePerHour);
                IsParked = true;
            }
            else
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
        }
        else
        {
            Console.WriteLine("Car is already parked.");
        }
    }

    
}