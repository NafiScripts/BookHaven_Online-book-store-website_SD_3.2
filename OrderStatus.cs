// Importing necessary namespaces for data annotations and database schema attributes
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Defining a model class named OrderStatus in the namespace BookShoppingCartMvcUI.Models
namespace BookShoppingCartMvcUI.Models
{
    // Defining that instances of this class should be stored in a database table named "OrderStatus"
    [Table("OrderStatus")]
    public class OrderStatus
    {
        // Primary key property for the OrderStatus entity
        public int Id { get; set; }

        // Property representing the status identifier, marked as required
        [Required]
        public int StatusId { get; set; }

        // Property representing the status name, marked as required and having a maximum length of 20 characters
        [Required, MaxLength(20)]
        public string? StatusName { get; set; }
    }
}
