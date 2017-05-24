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
    /// Interaction logic for Seats_stadium.xaml
    /// </summary>
    public partial class Seats_stadium : Window
    {
        public Seats_stadium()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ConfirmPersonalData window = new ConfirmPersonalData();
            window.Show();
            this.Close();
        }

        //Define variables for each zone
        private void A_1a_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 0;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void A_1b_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 40;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            ConfirmData_Match window = new ConfirmData_Match();
            window.Show();
            this.Close();
        }

        private void button4_Copy15_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3440;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy34_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 80;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy35_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 120;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy36_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 160;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy37_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 200;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy38_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 240;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy63_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 280;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy40_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 320;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy39_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 360;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy41_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone =400;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy42_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 440;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy66_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 480;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy43_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 520;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy44_Click_1(object sender, RoutedEventArgs e)
        {
            Global.Zone = 560;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy64_Click_1(object sender, RoutedEventArgs e)
        {
            Global.Zone = 600;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy69_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 640;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy50_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 680;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy46_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone =720;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy45_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 760;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy71_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 800;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy49_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 840;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy48_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 880;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy70_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 920;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy51_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 960;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy52_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone =1000;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy53_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1040;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy54_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1080;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy55_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone =1120;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy56_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1160;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy57_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1200;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy58_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1240;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy61_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1280;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy60_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1320;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy59_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1360;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy62_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1400;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1440;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1480;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1520;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1560;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1600;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1640;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1680;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1720;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy7_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1760;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy8_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1800;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy9_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1840;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy10_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1880;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy68_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1920;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy11_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 1960;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy12_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2000;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy13_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2040;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy14_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2080;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy15_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2120;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy16_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2160;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy67_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2200;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy32_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2240;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy17_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2280;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy18_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2320;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy19_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2360;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy20_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2400;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy31_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2440;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy22_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2480;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy21_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2520;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy30_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2560;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy23_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2600;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy24_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2640;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy25_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2680;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy28_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2720;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy26_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2760;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy27_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2800;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button_Copy29_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2840;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button3_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2880;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button2_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2920;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 2960;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy9_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3000;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy10_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3040;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy11_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3080;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy13_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3120;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy12_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3160;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button1_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3200;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button3_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3240;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button2_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3280;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy8_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3320;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy16_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3360;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy14_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3400;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3480;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3520;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3560;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3600;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3640;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy7_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3680;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3720;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3760;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void button4_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Global.Zone = 3800;
            Seats window = new Seats();
            window.Show();
            this.Close();
        }
    }
}
