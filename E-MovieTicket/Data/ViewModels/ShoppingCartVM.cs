using E_MovieTicket.Data.Cart;

namespace E_MovieTicket.Data.ViewModels;

public class ShoppingCartVM
{
    public ShoppingCart ShoppingCart { get; set; }
    public double ShoppingCartTotal { get; set; }
}