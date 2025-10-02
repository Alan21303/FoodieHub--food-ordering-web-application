using System.ComponentModel.DataAnnotations;

namespace FoodieHub.API.Models
{
    public class HotelDashboard
    {
        [Key]
        public int DashboardID { get; set; }

        public int HotelID { get; set; }
        public int TotalOrders { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
