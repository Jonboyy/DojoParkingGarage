namespace ParkingGarage;

public class Ticket
{
    public DateTime ReservedDateTime { get; } = DateTime.Now;
    public string SpotID { get; }
    public string VehicleID { get; }
    public double HourlyRate { get; }

    public Ticket(string spotID, string vehicleID, double hourlyRate)
    {
        
        SpotID = spotID;
        VehicleID = vehicleID;
        HourlyRate = hourlyRate;
    }
    
}