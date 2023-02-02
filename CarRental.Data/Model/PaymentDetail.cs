namespace CarRental.Data.Model;

public class PaymentDetail
{

    public int Id { get; set; }

    public Order? Order { get; set; }

    public int CostIncurredId { get; set; }


}
