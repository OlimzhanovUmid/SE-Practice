namespace App.Model;
public class Order
{
    public int OrderId { get; set; }
    public int? Price { get; set; }
    public bool? PaymentStatus { get; set; }
    
    public int UserId { get; set; }
    public User? User { get; set; }
    
    public int SessionId { get; set; }
    public Session? Session { get; set; }
}