namespace ParkingGarage;

public class SmallSpot : Spot
{
    public SmallSpot(string id) : base(id)
    {
        SpotType = SpotType.Small;
        PricePerHour = 9.99;
    }
}