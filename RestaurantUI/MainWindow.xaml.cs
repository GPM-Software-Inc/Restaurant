using Restaurant.Controls;
using RestaurantUI.ViewModels;
using System.Windows;


namespace Restaurant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel.ShowControl(new Autorize());

        }


    }
}
