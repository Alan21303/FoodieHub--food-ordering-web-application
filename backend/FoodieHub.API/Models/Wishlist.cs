using System.ComponentModel.DataAnnotations;

namespace FoodieHub.API.Models
{
    public class Wishlist
    {
        [Key]
        public int WishlistID { get; set; }

        public int UserID { get; set; }
        public int MenuItemID { get; set; }
    }
}
