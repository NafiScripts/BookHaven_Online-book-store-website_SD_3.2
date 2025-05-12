// Importing necessary namespaces
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// Namespace declaration for the controller
namespace BookShoppingCartMvcUI.Controllers
{
    // Applying authorization attribute to the controller, ensuring that only authenticated users can access its actions
    [Authorize]
    public class UserOrderController : Controller
    {
        // Declaring a private field to hold the instance of the user order repository
        private readonly IUserOrderRepository _userOrderRepo;

        // Constructor to initialize the controller with an instance of IUserOrderRepository
        public UserOrderController(IUserOrderRepository userOrderRepo)
        {
            _userOrderRepo = userOrderRepo;
        }

        // Action method for handling requests to view user orders
        public async Task<IActionResult> UserOrders()
        {
            // Calling the UserOrders method of the injected user order repository asynchronously
            var orders = await _userOrderRepo.UserOrders();

            // Returning a view with the retrieved user orders
            return View(orders);
        }
    }
}
