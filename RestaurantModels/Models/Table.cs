using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantModels.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public Rate Rate { get; set; }
    }
}
