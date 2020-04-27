using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantLibrary.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public int UserId { get; set; }
        public DateTime TimeOrder { get; set; }
        public DateTime EndOrder { get; set; }
        public bool IsComplete { get; set; }
        public List<Menu> Items { get; set; }
    }
}
