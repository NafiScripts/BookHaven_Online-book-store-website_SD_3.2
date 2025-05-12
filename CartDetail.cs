using Microsoft.Build.Framework;   // Importing the necessary namespace for using Microsoft.Build.Framework
using System.ComponentModel.DataAnnotations.Schema;   // Importing the necessary namespace for using System.ComponentModel.DataAnnotations.Schema

namespace BookShoppingCartMvcUI.Models
{
    [Table("CartDetail")]   // Attribute specifying the database table name associated with this class
    public class CartDetail
    {
        public int Id { get; set; }   // Auto-implemented property representing the primary key for CartDetail

        [Required]   // Attribute specifying that the property is required
        public int ShoppingCartId { get; set; }   // Property representing the foreign key for linking to ShoppingCart

        [Required]   // Attribute specifying that the property is required
        public int BookId { get; set; }   // Property representing the foreign key for linking to Book

        [Required]   // Attribute specifying that the property is required
        public int Quantity { get; set; }   // Property representing the quantity of books in the cart

        [Required]   // Attribute specifying that the property is required
        public double UnitPrice { get; set; }   // Property representing the unit price of each book in the cart

        public Book Book { get; set; }   // Navigation property representing the associated Book object

        public ShoppingCart ShoppingCart { get; set; }   // Navigation property representing the associated ShoppingCart object
    }
}
