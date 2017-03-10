using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KDZ
{
    /// <summary>
    /// Interaction logic for ConfirmData_Match.xaml
    /// </summary>
    public partial class ConfirmData_Match : Window
    {
        public ConfirmData_Match()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            ConfirmPersonalData window = new ConfirmPersonalData();
            window.Show();
            this.Close();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }
    }
}
