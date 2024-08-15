using System.ComponentModel.DataAnnotations.Schema;

namespace web_api.Entities;

public class Order
{
    public int Id { get; set; }
    
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
    
    public int RestaurantId { get; set; }
    [ForeignKey("RestaurantId")]
    public Restaurant Restaurant { get; set; }
    
    public string InvoiceNumber { get; set; }
    
    public DateTime OrderDate { get; set; }
    
    public string EventName { get; set; }
    
    public string DeliveryAddress { get; set; }
    
    public DateTime DeliveryDate { get; set; }
    
    public string DeliveryPerson { get; set; }
    
    public string DeliveryPhone { get; set; }
    
    public string AdditionalRequirement { get; set; }
    
    public double UnitPrice { get; set; }
    
    public double ComboDiscount { get; set; }
    
    public int Quantity { get; set; }
    
    public double TotalAmount { get; set; }
    
    public double PrePaid { get; set; }
    
    public int StatusId { get; set; }
    [ForeignKey("StatusId")]
    public Status Status { get; set; }
}