﻿using RestaurantLibrary;
using RestaurantLibrary.Models;

namespace RestaurantUI.ViewModels
{
    public static class AutorizeViewModel
    {

        public static User FindUser(string email, string password)
        {
            RestaurantDbContext restaurantDbContext = new RestaurantDbContext();
            if (restaurantDbContext.Users.Local.Count > 0)
            {
                var user = restaurantDbContext.Users;

            }
            return null;
        }

    }
}
