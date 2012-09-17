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

namespace BillCalc2
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            string starting = balanceBox.Text;
            string rent = rentBox.Text;
            string lights = lightBox.Text;
            string cable = cableBox.Text;
            string water = waterBox.Text;
            string cell = cellBox.Text;
            string car1 = carBox1.Text;
            string car2 = carBox2.Text;
            string insurance = insBox.Text;
            string other = otherBox.Text;
            
            string balance = (
                Convert.ToDecimal(starting) -
                Convert.ToDecimal(rent) -
                Convert.ToDecimal(lights) -
                Convert.ToDecimal(cable) -
                Convert.ToDecimal(water) -
                Convert.ToDecimal(cell) -
                Convert.ToDecimal(car1) -
                Convert.ToDecimal(car2) -
                Convert.ToDecimal(insurance) -
                Convert.ToDecimal(other)).ToString();

            remainingBalance.Text = "Remaining Balance: " + "$" + balance;
        }
    }
}
