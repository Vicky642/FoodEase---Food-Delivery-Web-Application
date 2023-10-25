using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodEase.Models
{
    public class Carts
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity{ get; set; }
        public int UserId { get; set; }
    }
}
