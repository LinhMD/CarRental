namespace CarRental.Data.Model;

public class CarOwner
{

    public int Id { get; set; }

    public string Address { get; set; }

    public IList<Car> Car { get; set; }

    public User User { get; set; }

}
