/* Oliver Byl
 * February 11, 2019
 * Deck area calculator.
 */
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

namespace _312554IPO
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

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double length, width, area;

            double.TryParse(txtLength.Text, out length);
            double.TryParse(txtWidth.Text, out width);

            area = length * width;

            if (area <= 0)
                lblOutput.Content = "Length or width is invalid.";
            else
                lblOutput.Content = "The area is: " + area.ToString("#.00");
        }
    }
}