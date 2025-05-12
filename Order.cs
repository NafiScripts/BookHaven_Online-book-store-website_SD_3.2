// Import necessary namespaces
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

// Declare the namespace for the model
namespace BookShoppingCartMvcUI.Models
{
    // Specify the table name for the Order class in the database
    [Table("Order")]
    public class Order
    {
        // Property for the order ID
        public int Id { get; set; }

        // User ID associated with the order (required field)
        [Required]
        public string UserId { get; set; }

        // Date and time when the order is created, set to current UTC time by default
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        // ID of the order status (required field)
        [Required]
        public int OrderStatusId { get; set; }

        // Flag indicating whether the order is deleted or not, set to false by default
        public bool IsDeleted { get; set; } = false;

        // Navigation property representing the associated order status
        public OrderStatus OrderStatus { get; set; }

        // Collection navigation property representing the order details associated with this order
        public List<OrderDetail> OrderDetail { get; set; }
    }
}
