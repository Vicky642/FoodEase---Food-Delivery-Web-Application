using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodEase.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public int PaymentId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
    