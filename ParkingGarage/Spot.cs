namespace ParkingGarage;

public abstract class Spot
{
    public string ID { get; }
    public SpotType SpotType { get; protected set; }
    public double PricePerHour { get; protected set; }

    public bool IsAvailable { get; set; } = true;

    public Spot(string id)
    {
        ID = new Guid().ToString();
    }
}