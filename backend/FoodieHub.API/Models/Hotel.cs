using System.ComponentModel.DataAnnotations;

namespace FoodieHub.API.Models
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
