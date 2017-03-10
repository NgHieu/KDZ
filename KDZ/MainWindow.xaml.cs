using System;
using System.Collections.Generic;
using System.IO;
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

namespace KDZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        const string file = "Data.text";
        List<PersonalData> _ps = new List<PersonalData>();
        List<CardMonth> _cardmonth = new List<CardMonth>();
        List<CardYear> _cardyear = new List<CardYear>();

        public MainWindow()
        {
            
            InitializeComponent();
            //ImageBrush myBrush = new ImageBrush();
            //myBrush.ImageSource =
            //    new BitmapImage(new Uri("Stadium.png", UriKind.Absolute));
            //this.Background = myBrush;


            
        }
        private void Save()
        {
            using (var sw = new StreamWriter(file))
            {
                foreach (var user in _ps)
                {
                    sw.WriteLine($"{user.Name}' '{user.Lastname} - {user.Telephone} - {user.Email}");
                }
            }
        }
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void buttonContinue_Click(object sender, RoutedEventArgs e)
        {
            //var window = new ConfirmPersonalData();
            //{

            //}
            ConfirmData_Match window = new ConfirmData_Match();
            window.Show();
            this.Close();
            
        }
    }
}
