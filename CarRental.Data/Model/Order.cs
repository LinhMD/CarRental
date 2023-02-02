namespace CarRental.Data.Model;

public class Order
{
    public int Id { get; set; }

    public IList<RentalDetail> RentalDetails { get; set; }

    public IList<PaymentDetail> PaymentDetails { get; set; }

    public Customer Customer { get; set; }


}