using System.ComponentModel.DataAnnotations;

namespace FoodieHub.API.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemID { get; set; }

        public int CartID { get; set; }
        public int MenuItemID { get; set; }
        public int Quantity { get; set; }
    }
}
