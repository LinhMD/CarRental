namespace CarRental.Data.Model;

public class ShowRoom
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string Contact { get; set; }

    public string Imgage { get; set; }

    public IList<Car> Cars { get; set; }


}
