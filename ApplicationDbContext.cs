// Import necessary namespaces for the ApplicationDbContext class
using BookShoppingCartMvcUI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

// Define the namespace for the ApplicationDbContext class within the Data folder
namespace BookShoppingCartMvcUI.Data
{
    // ApplicationDbContext class inherits from IdentityDbContext, which is used for user authentication in ASP.NET Core Identity
    public class ApplicationDbContext : IdentityDbContext
    {
        // Constructor for ApplicationDbContext, taking DbContextOptions as a parameter
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // Empty constructor body as the base class constructor is invoked with the provided options
        }

        // Define DbSet properties for each entity in the database
        public DbSet<Genre> Genres { get; set; }               // DbSet for Genre entity
        public DbSet<Book> Books { get; set; }                 // DbSet for Book entity
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } // DbSet for ShoppingCart entity
        public DbSet<CartDetail> CartDetails { get; set; }     // DbSet for CartDetail entity
        public DbSet<Order> Orders { get; set; }               // DbSet for Order entity
        public DbSet<OrderDetail> OrderDetails { get; set; }   // DbSet for OrderDetail entity

        // DbSet for OrderStatus entity
        public DbSet<OrderStatus> orderStatuses { get; set; }

    }
}
