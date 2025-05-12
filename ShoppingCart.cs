// Importing necessary namespaces
using Microsoft.Build.Framework; // Namespace for Microsoft Build Framework
using System.ComponentModel.DataAnnotations.Schema; // Namespace for defining database schema
using System.Collections.Generic; // Namespace for using ICollection

// Defining the namespace for the model
namespace BookShoppingCartMvcUI.Models
{
    // Specifying the table name for the ShoppingCart model in the database
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        // Property representing the unique identifier for the shopping cart
        public int Id { get; set; }

        // Property representing the user ID associated with the shopping cart
        [Required] // Annotation indicating that the UserId is required and cannot be null
        public string UserId { get; set; }

        // Property indicating whether the shopping cart is marked as deleted
        public bool IsDeleted { get; set; } = false;

        // Navigation property representing a collection of CartDetail objects associated with this shopping cart
        public ICollection<CartDetail> CartDetails { get; set; }

    }
}
