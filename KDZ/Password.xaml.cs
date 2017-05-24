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
    /// Interaction logic for Password.xaml
    /// </summary>
    public partial class Password : Window
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string pass;
            pass = textBox.Text;
            //Create password(for admin)
            if (pass=="123")
            {
                ConfirmData_Match window = new ConfirmData_Match();
                window.Show();
                this.Close();
            }
            //Check input password
            else
            {
                MessageBox.Show("Password is incorrect. Please try again");
                textBox.Focus();
            }
        }

        private void buttonback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
