using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.Models
{
    public class Export
    {
        public int Id { get; set; }
        public List<Order> Order { get; set; }
        public List<Menu> Menu { get; set; }
        public DateTime ExportDate { get; set; }
    }
}
