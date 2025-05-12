// Import necessary namespaces for data annotations and attributes
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

// Define the namespace and class for the Genre model
namespace BookShoppingCartMvcUI.Models
{
    // Map the class to a database table named "Genre" using the Table attribute
    [Table("Genre")]
    public class Genre
    {
        // Primary key property for the Genre model
        public int Id { get; set; }

        // Specify that the GenreName property is required and has a maximum length of 40 characters
        [Required]
        [MaxLength(40)]
        public string GenreName { get; set; }

        // Navigation property representing a collection of associated Book objects
        public List<Book> Books { get; set; }
    }
}

