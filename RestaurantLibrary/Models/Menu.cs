﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantLibrary.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ExecutantId { get; set; }
    }
}
