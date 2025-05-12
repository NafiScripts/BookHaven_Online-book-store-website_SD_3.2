// Import necessary namespaces
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

// Declare the namespace for the model
namespace BookShoppingCartMvcUI.Models
{
    // Define the table name for the OrderDetail entity
    [Table("OrderDetail")]
    public class OrderDetail
    {
        // Property to store the unique identifier for OrderDetail
        public int Id { get; set; }

        // Property to store the foreign key for Order entity
        [Required]
        public int OrderId { get; set; }

        // Property to store the foreign key for Book entity
        [Required]
        public int BookId { get; set; }

        // Property to store the quantity of books in the order
        [Required]
        public int Quantity { get; set; }

        // Property to store the unit price of the book
        [Required]
        public double UnitPrice { get; set; }

        // Navigation property to represent the Order related to this OrderDetail
        public Order Order { get; set; }

        // Navigation property to represent the Book related to this OrderDetail
        public Book Book { get; set; }
    }
}
