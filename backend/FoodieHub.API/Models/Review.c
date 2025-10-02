using System.ComponentModel.DataAnnotations;

namespace FoodieHub.API.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        public int UserID { get; set; }
        public int MenuItemID { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; }
    }
}
