using Restaurant;
using Restaurant.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace RestaurantUI.ViewModels
{
    public static class MainWindowViewModel
    {
        public static MainWindow mainWindow = App.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public static void ShowControl(UserControl userControl)
        {
            mainWindow.ActiveItem.Content = userControl;
            mainWindow.ActiveItem.Visibility = Visibility.Visible;
        }


    }
}
