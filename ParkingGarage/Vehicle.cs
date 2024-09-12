namespace ParkingGarage;

public abstract class Vehicle
{
    public string ID { get; }
    public Ticket Ticket { get; private set; }
    
    public bool IsParked { get; set; } = false;

    public Vehicle(string id)
    {
        ID = new Guid().ToString();
    }

    public abstract void Park(List<Spot> spots);

    protected Ticket GetTicket(string spotID, string vehicleID, double hourlyRate)
    {
        var ticket = new Ticket(spotID, vehicleID, hourlyRate);
        return Ticket = ticket;
    }

}