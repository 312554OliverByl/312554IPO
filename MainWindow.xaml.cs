/* 
 * Oliver Byl
 * February 5, 2020
 * Deck area calculator. 
 */
using System.Windows;

namespace _312554IPO
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnBtnCalculateClick(object sender, RoutedEventArgs e)
        {
            // This is different from McT's example. The doubles aren't declared
            // beforehand and then assigned, but declared within TryParse itself.
            // SYNTACTIC SUGAR
            double.TryParse(txtLength.Text, out double length);
            double.TryParse(txtWidth.Text, out double width);

            double area = length * width;
            
            if (area <= 0)
                lblOutput.Content = "Length or width is invalid.";
            else
                lblOutput.Content = "The area is: " + area.ToString("#.00");
        }
    }
}