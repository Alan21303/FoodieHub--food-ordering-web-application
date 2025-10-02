using System.ComponentModel.DataAnnotations;

namespace FoodieHub.API.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }

        public int UserID { get; set; }
    }
}
