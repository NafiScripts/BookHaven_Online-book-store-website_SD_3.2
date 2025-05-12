using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookShoppingCartMvcUI.Controllers
{
    // The [Authorize] attribute ensures that only authenticated users can access the actions in this controller.
    [Authorize]
    public class CartController : Controller
    {
        // A private field to store the ICartRepository instance.
        private readonly ICartRepository _cartRepo;

        // Constructor that injects an ICartRepository instance.
        public CartController(ICartRepository cartRepo)
        {
            _cartRepo = cartRepo;
        }

        // Action to add an item to the cart.
        public async Task<IActionResult> AddItem(int bookId, int qty = 1, int redirect = 0)
        {
            // Call the AddItem method on the injected cart repository.
            var cartCount = await _cartRepo.AddItem(bookId, qty);

            // Check if the 'redirect' parameter is set to 0, return Ok with the cartCount, else redirect to GetUserCart action.
            if (redirect == 0)
                return Ok(cartCount);
            return RedirectToAction("GetUserCart");
        }

        // Action to remove an item from the cart.
        public async Task<IActionResult> RemoveItem(int bookId)
        {
            // Call the RemoveItem method on the injected cart repository.
            var cartCount = await _cartRepo.RemoveItem(bookId);

            // Redirect to the GetUserCart action after removing the item.
            return RedirectToAction("GetUserCart");
        }

        // Action to get the user's cart.
        public async Task<IActionResult> GetUserCart()
        {
            // Call the GetUserCart method on the injected cart repository and return the result as a View.
            var cart = await _cartRepo.GetUserCart();
            return View(cart);
        }

        // Action to get the total number of items in the cart.
        public async Task<IActionResult> GetTotalItemInCart()
        {
            // Call the GetCartItemCount method on the injected cart repository and return the result as Ok.
            int cartItem = await _cartRepo.GetCartItemCount();
            return Ok(cartItem);
        }

        // Action to perform checkout.
        public async Task<IActionResult> Checkout()
        {
            // Call the DoCheckout method on the injected cart repository to process the checkout.
            bool isCheckedOut = await _cartRepo.DoCheckout();

            // If the checkout is not successful, throw an exception. Otherwise, redirect to the Home/Index action.
            if (!isCheckedOut)
                throw new Exception("Something happened in server side");
            return RedirectToAction("Index", "Home");
        }
    }
}
