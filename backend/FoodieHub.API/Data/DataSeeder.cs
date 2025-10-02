using FoodieHub.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodieHub.API.Data
{
    public static class DataSeeder
    {
        public static async Task SeedAdminAsync(FoodieHubDbContext context)
        {
            // Apply pending migrations
            await context.Database.MigrateAsync();

            // Check if any Admin already exists
            if (!await context.Users.AnyAsync(u => u.Role == "Admin"))
            {
                var admin = new User
                {
                    FullName = "Default Admin",
                    Email = "admin@foodiehub.com",
                    Role = "Admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@123") // 🔑 default password
                };

                context.Users.Add(admin);
                await context.SaveChangesAsync();
            }
        }
    }
}
