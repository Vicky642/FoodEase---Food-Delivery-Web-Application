using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodEase.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public int Amount { get; set; }
        public string Paymode { get; set; }
    }
}
