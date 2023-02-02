namespace CarRental.Data.Model;

public class CarModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    IList<Car> Cars { get; set; }

    public CarType Type { get; set; }

    public ManufactureCompany ManufactureCompany { get; set; }
}
