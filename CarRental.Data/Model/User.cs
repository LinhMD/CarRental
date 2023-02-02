namespace CarRental.Data.Model;

public class User
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string Hash { get; set; }

    public string Salt { get; set; }

    public Role Role { get; set; }

}
