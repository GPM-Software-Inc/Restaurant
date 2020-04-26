using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Table Table { get; set; }
        public int UserId { get; set; }
        public DateTime TimeOrder { get; set; }
        public DateTime EndOrder { get; set; }
        public List<Menu> Items { get; set; }
    }
}
