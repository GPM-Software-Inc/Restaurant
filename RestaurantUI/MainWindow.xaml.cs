using Restaurant.Controls;
using System.Windows;
using System.Windows.Controls;

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
        }

        public static void ShowControl(UserControl userControl)
        {
            userControl.Visibility = Visibility.Visible;
        }

        public static void HideControl(UserControl userControl)
        {
            userControl.Visibility = Visibility.Hidden;
        }
    }
}
