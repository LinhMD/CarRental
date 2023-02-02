namespace CarRental.Data.Model;

public class DriverCalender
{
    public int Id { get; set; }

    public Driver Driver { get; set; }

    public Car Car { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public RentalDetail RentalDetail { get; set; }

}