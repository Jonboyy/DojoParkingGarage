namespace ParkingGarage;

public class LargeSpot : Spot
{
    public LargeSpot(string id) : base(id)
    {
        SpotType = SpotType.Large;
        PricePerHour = 19.99;
    }
}