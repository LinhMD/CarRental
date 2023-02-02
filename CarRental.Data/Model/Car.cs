namespace CarRental.Data.Model;

public class Car
{
    public int Id { get; set; }

    public string LicensePlates { get; set; }

    public string TransmissionTypes { get; set; }

    public string FuelType { get; set; }

    public int Seater { get; set; }

    public CarOwner Owner { get; set; }

    public CarModel Model { get; set; }

    public IList<CarLicense> Liceneses { get; set; }

    public ShowRoom? ShowRoom { get; set; }



}
