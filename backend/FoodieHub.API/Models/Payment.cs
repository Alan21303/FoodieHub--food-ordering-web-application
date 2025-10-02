using System.ComponentModel.DataAnnotations;

namespace FoodieHub.API.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        public int OrderID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public DateTime PaymentDate { get; set; }
    }
}
