namespace CarRental.Data.Model;

public class Route
{

    public int Id { get; set; }

    public Car Car { get; set; }

    public DateTime Time { get; set; }

    public double Longitude { get; set; }

    public double Latitude { get; set; }


}
