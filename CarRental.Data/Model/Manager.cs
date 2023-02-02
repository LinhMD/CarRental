namespace CarRental.Data.Model;

public class Manager
{

    public int Id { get; set; }

    public string Name { get; set; }

    public User User { get; set; }

    public IList<Car> ManageCars { get; set; }

    public IList<Driver> Drivers { get; set; }

}
