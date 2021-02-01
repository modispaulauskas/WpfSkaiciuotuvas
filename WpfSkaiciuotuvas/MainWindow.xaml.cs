using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfSkaiciuotuvas
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

        private void ButtonSudetis(object sender, RoutedEventArgs e)
        {
            int x1 = int.Parse(textboxPirmas.Text);
            int x2 = int.Parse(textboxAntras.Text);
            labelAts.Content = $"Atsakymas: {x1 + x2}";

        }

        private void ButtonAtimtis(object sender, RoutedEventArgs e)
        {
            int x1 = int.Parse(textboxPirmas.Text);
            int x2 = int.Parse(textboxAntras.Text);
            labelAts.Content = $"Atsakymas: {x1 - x2}";
        }

        private void ButtonDalyba(object sender, RoutedEventArgs e)
        {
            int x1 = int.Parse(textboxPirmas.Text);
            int x2 = int.Parse(textboxAntras.Text);
            labelAts.Content = $"Atsakymas: {x1 / x2}";
        }

        private void ButtonDaugyba(object sender, RoutedEventArgs e)
        {
            int x1 = int.Parse(textboxPirmas.Text);
            int x2 = int.Parse(textboxAntras.Text);
            labelAts.Content = $"Atsakymas: {x1 * x2}";
        }
    }
}
