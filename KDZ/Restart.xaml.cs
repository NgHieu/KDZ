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
    /// Interaction logic for Restart.xaml
    /// </summary>
    public partial class Restart : Window
    {
        public Restart()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, RoutedEventArgs e)
        {
            //Read from txt file
            FileText ft = new FileText();
            ft.Filename = "...\\Match.txt";
            ft.ReadData();
            Global.Check = 1;
            ConfirmData_Match window = new ConfirmData_Match();
            window.Show();
            this.Close();
        }

        private void buttonNo_Click(object sender, RoutedEventArgs e)
        {
            //Recreate matches randomly
            Global.Check = 0;
            Password window = new Password();
            window.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
