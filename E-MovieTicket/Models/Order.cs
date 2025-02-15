using System.ComponentModel.DataAnnotations.Schema;

namespace E_MovieTicket.Models;

public class Order
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string UserId {get; set;}
    [ForeignKey(nameof(UserId))]
    public ApplicationUser User {get; set;}
    public List<OrderItem> Items { get; set; }
}