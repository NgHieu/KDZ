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
using System.Windows.Shapes;

namespace KDZ
{
    /// <summary>
    /// Interaction logic for Checkout.xaml
    /// </summary>
    public partial class Checkout : Window
    {
        public Checkout()
        {
            InitializeComponent();
        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            //Save all information
            Global.A[Global.index][Global._seat] = 1;

            FileText ft = new FileText();
            ft.Filename = "...\\Match.txt";
            ft.WriteData(Global.n, Global.A);

            Save ft1 = new Save();
            ft1.Filename = "...\\Data.txt";
            ft1.WriteData(Global.index + 1, Global._seat, Global.FullName[Global.index][Global._seat], Global.PhoneNumber[Global.index][Global._seat], Global.Email[Global.index][Global._seat], Global.CCNumber[Global.index][Global._seat], Global.Expire[Global.index][Global._seat], Global.CVV[Global.index][Global._seat]);
            // Open a window to check
            Check window = new Check();
            window.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Save all information
            Global.A[Global.index][Global._seat] = 1;

            FileText ft = new FileText();
            ft.Filename = "...\\Match.txt";
            ft.WriteData(Global.n, Global.A);

            Save ft1 = new Save();
            ft1.Filename = "...\\Data.txt";
            ft1.WriteData(Global.index + 1, Global._seat, Global.FullName[Global.index][Global._seat], Global.PhoneNumber[Global.index][Global._seat], Global.Email[Global.index][Global._seat], Global.CCNumber[Global.index][Global._seat], Global.Expire[Global.index][Global._seat], Global.CVV[Global.index][Global._seat]);
            //Exit
            this.Close();
        }
    }
}
