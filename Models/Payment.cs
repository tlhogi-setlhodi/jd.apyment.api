namespace PaymentService.Models;

public class Payment
{
    public int Id { get; set; }
    public decimal TotalAmountPaid { get; set; }
    public string UserEmail { get; set; } = string.Empty;
    public string CartId { get; set; } = string.Empty;
    public DateTime PaidAt { get; set; } = DateTime.UtcNow;
}
