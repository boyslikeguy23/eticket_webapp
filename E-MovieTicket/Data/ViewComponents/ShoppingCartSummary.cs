// using E_MovieTicket.Data.Cart;
// using Microsoft.AspNetCore.Mvc;
//
// namespace E_MovieTicket.Data.ViewComponents;
//
// public class ShoppingCartSummary
// {
//     private readonly ShoppingCart _shoppingCart;
//     public ShoppingCartSummary(ShoppingCart shoppingCart)
//     {
//         _shoppingCart = shoppingCart;
//     }
//
//     public IViewComponentResult Invoke()
//     {
//         var items = _shoppingCart.GetShoppingCartItems();
//
//         return View(items.Count);
//     }
// }