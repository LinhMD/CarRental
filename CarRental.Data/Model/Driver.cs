namespace CarRental.Data.Model;

public class Driver
{
    public int Id { get; set; }

    public int Name { get; set; }

    public User User { get; set; }

    public Manager Manager { get; set; }

    public IList<DriverCalender> Calender { get; set; }
}
