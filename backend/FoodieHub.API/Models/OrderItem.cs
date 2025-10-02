using System.ComponentModel.DataAnnotations;

namespace FoodieHub.API.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }
        public int MenuItemID { get; set; }
        public int Quantity { get; set; }
    }
}
