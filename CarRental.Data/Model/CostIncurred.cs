namespace CarRental.Data.Model;

public class CostIncurred
{
    public int Id { get; set; }

    public double Cost { get; set; }

    public RentalDetail RentalDetail { get; set; }

    public PaymentDetail PaymentDetail { get; set; }




}
