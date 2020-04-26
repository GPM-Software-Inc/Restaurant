using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.Models
{
    public class Price
    {
        public int Id { get; set; }
        public int ItemsId { get; set; }
        public decimal Prices { get; set; }
    }
}
