using RestaurantUI.ViewModels;
using System.Windows.Controls;

namespace Restaurant.Controls
{
    /// <summary>
    /// Interaction logic for ControlAutorize.xaml
    /// </summary>
    public partial class Autorize : UserControl
    {
        public Autorize()
        {
            InitializeComponent();
        }

        private void Button_Ok_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AutorizeViewModel.FindUser(UIEmail.Text, UIPassword.Password);
        }

        private void Button_Cancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
