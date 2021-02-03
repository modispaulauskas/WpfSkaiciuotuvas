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
            if( int.TryParse(textboxPirmas.Text, out int output1) && int.TryParse(textboxAntras.Text, out int output2))
            {
                labelAts.Content = $"= {int.Parse(textboxPirmas.Text) + int.Parse(textboxAntras.Text)}";
            }
            else
            {
                labelAts.Content = $"= Ne skaiciai";
            }
        }

        private void ButtonAtimtis(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textboxPirmas.Text, out int output1) && int.TryParse(textboxAntras.Text, out int output2))
            {
                labelAts.Content = $"= {int.Parse(textboxPirmas.Text) - int.Parse(textboxAntras.Text)}";
            }
            else
            {
                labelAts.Content = $"= Ne skaiciai";
            }
        }

        private void ButtonDalyba(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textboxPirmas.Text, out int output1) && int.TryParse(textboxAntras.Text, out int output2))
            {
                labelAts.Content = $"= {int.Parse(textboxPirmas.Text) / int.Parse(textboxAntras.Text)}";
            }
            else
            {
                labelAts.Content = $"= Ne skaiciai";
            }
        }

        private void ButtonDaugyba(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textboxPirmas.Text, out int output1) && int.TryParse(textboxAntras.Text, out int output2))
            {
                labelAts.Content = $"= {int.Parse(textboxPirmas.Text) * int.Parse(textboxAntras.Text)}";
            }
            else
            {
                labelAts.Content = $"= Ne skaiciai";
            }
        }

        private void ButtonTrinti(object sender, RoutedEventArgs e)
        {
            labelAts.Content = "= 0";
            textboxPirmas.Text = "";
            textboxAntras.Text = "";
        }

        private void textBoxHistory_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBoxHistory.Text += $"{textboxPirmas} {textboxAntras} {labelAts} \n";
        }
    }
}
