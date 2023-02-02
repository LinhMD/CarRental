namespace CarRental.Data.Model;

public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public User User { get; set; }

    public int UserId { get; set; }

    public IList<Order> Order { get; set; }
}
