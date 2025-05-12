using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookShoppingCartMvcUI.Models
{
    // Defined a data model for the "Book" entity, mapped to a table named "Book" in the database.
    [Table("Book")]
    public class Book
    {
        // Unique identifier for each book.
        public int Id { get; set; }

        // Required attribute specifies that BookName is a mandatory field with a maximum length of 40 characters.
        [Required]
        [MaxLength(40)]
        public string? BookName { get; set; }

        // Required attribute specifies that AuthorName is a mandatory field with a maximum length of 40 characters.
        [Required]
        [MaxLength(40)]
        public string? AuthorName { get; set; }

        // Required attribute specifies that Price is a mandatory field representing the book's price.
        [Required]
        public double Price { get; set; }

        // Image URL for the book.
        public string? Image { get; set; }

        // Required attribute specifies that GenreId is a mandatory foreign key to the Genre entity.
        [Required]
        public int GenreId { get; set; }

        // Navigation property representing the relationship with the Genre entity.
        public Genre Genre { get; set; }

        // Navigation property representing a list of OrderDetail entities associated with this book.
        public List<OrderDetail> OrderDetail { get; set; }

        // Navigation property representing a list of CartDetail entities associated with this book.
        public List<CartDetail> CartDetail { get; set; }

        // NotMapped attribute indicates that GenreName is not mapped to a database column.
        [NotMapped]
        public string GenreName { get; set; }
    }
}
