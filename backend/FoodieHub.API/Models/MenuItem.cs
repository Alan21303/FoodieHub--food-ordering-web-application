using System.ComponentModel.DataAnnotations;

namespace FoodieHub.API.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int HotelID { get; set; }
    }
}
