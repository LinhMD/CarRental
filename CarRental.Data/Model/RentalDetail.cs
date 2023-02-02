namespace CarRental.Data.Model;

public class RentalDetail
{
    public int Id { get; set; }

    public Car Car { get; set; }

    public string DeliveryLocation { get; set; }

    public IList<CostIncurred> CostIncurred { get; set; }

    public IList<Route> Routes { get; set; }

    public int? DriverCalenderId { get; set; }
}
