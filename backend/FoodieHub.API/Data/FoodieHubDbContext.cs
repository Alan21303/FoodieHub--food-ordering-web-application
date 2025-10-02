using Microsoft.EntityFrameworkCore;
using FoodieHub.API.Models;

namespace FoodieHub.API.Data
{
    public class FoodieHubDbContext : DbContext
    {
        public FoodieHubDbContext(DbContextOptions<FoodieHubDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Review> Reviews { get; set; }   // ✅ make sure this is here
        public DbSet<HotelDashboard> HotelDashboards { get; set; }
    }
}
