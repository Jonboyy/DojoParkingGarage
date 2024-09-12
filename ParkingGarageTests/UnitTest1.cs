using ParkingGarage;

namespace ParkingGarageTests;

public class Tests
{
  

    [Test]
    public void TestCarParkingToLargeSpot_Test()
    {
        var garage1 = new Garage();
        var vehiclesList = new List<Vehicle>();
       
        var testCar = new Car(new Guid().ToString());
        vehiclesList.Add(new Truck(new Guid().ToString())); 
        
        for (int i = 0; i < 2; i++)
        {
            garage1.Spots.Add(new SmallSpot(new Guid().ToString()));
            garage1.Spots.Add(new LargeSpot(new Guid().ToString()));
            vehiclesList.Add(new Car(new Guid().ToString()));
            
        }
        vehiclesList.ForEach(vehicle=> vehicle.Park(garage1.Spots));
        testCar.Park(garage1.Spots);
        
        Assert.That(testCar.IsParked, Is.True);
        Assert.That(testCar.Ticket.HourlyRate, Is.EqualTo(19.99));
    }
    
    [Test]
    public void FifthCarTryingToParkNoSpots_Test()
    {
        var garage1 = new Garage();
        var vehiclesList = new List<Vehicle>();
       
        var testCar = new Car(new Guid().ToString());
        vehiclesList.Add(new Truck(new Guid().ToString())); 
        vehiclesList.Add(new Truck(new Guid().ToString()));
        for (int i = 0; i < 2; i++)
        {
            garage1.Spots.Add(new SmallSpot(new Guid().ToString()));
            garage1.Spots.Add(new LargeSpot(new Guid().ToString()));
            vehiclesList.Add(new Car(new Guid().ToString()));
            
        }
        vehiclesList.ForEach(vehicle=> vehicle.Park(garage1.Spots));
        testCar.Park(garage1.Spots);
        
        Assert.That(testCar.IsParked, Is.False);
    }
    
    [Test]
    public void Ticket_Test()
    {
        var garage1 = new Garage();
        var vehiclesList = new List<Vehicle>();
       
        var testCar = new Car(new Guid().ToString());
        
        vehiclesList.Add(new Truck(new Guid().ToString()));
        for (int i = 0; i < 2; i++)
        {
            garage1.Spots.Add(new SmallSpot(new Guid().ToString()));
            garage1.Spots.Add(new LargeSpot(new Guid().ToString()));
            vehiclesList.Add(new Car(new Guid().ToString()));
            
        }
        vehiclesList.ForEach(vehicle=> vehicle.Park(garage1.Spots));
        testCar.Park(garage1.Spots);
        
        Assert.That(testCar.Ticket.VehicleID, Is.EqualTo(testCar.ID));
    }
}