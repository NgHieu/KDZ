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
using System.IO;

namespace KDZ
{
   
    /// <summary>
    /// List of Table
    /// Interaction logic for ConfirmData_Match.xaml
    /// </summary>

    public class Table
    {
        public string match { get; set; }
        public DateTime data { get; set; }
        public DateTime time { get; set; }
         
    }
   

    public partial class ConfirmData_Match : Window
    {
        List<Match> list = new List<Match>();
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
            // Check user's choice
            Match match = dataGridMatch.SelectedItem as Match;
            if (match != null)
            {
                Global.index = match.No-1;
                Seats_stadium window = new Seats_stadium();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a match you would like to watch");
            }

        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void dataGridMatch_Loaded(object sender, RoutedEventArgs e)
        {
            list.Add(new Match { No = 1, Game = "Obolen vs Arsenal", Data = "10/06/2018", Time = "17:30" });
            list.Add(new Match { No = 2, Game = "Obolen vs Monaco", Data = "17/06/2018", Time = "20:00" });
            list.Add(new Match { No = 3, Game = "Obolen vs AS Roma", Data = "22/07/2018", Time = "18:30" });
            list.Add(new Match { No = 4, Game = "Obolen vs Real Madrid", Data = "28/07/2018", Time = "16:45" });
            list.Add(new Match { No = 5, Game = "Obolen vs Liverpool", Data = "18/08/2018", Time = "21:45" });
            list.Add(new Match { No = 6, Game = "Obolen vs Bayern Munich", Data = "09/09/2018", Time = "22:00" });
            list.Add(new Match { No = 7, Game = "Obolen vs AC Milan", Data = "22/09/2018", Time = "15:45" });
            list.Add(new Match { No = 8, Game = "Obolen vs Juventus", Data = "03/10/2018", Time = "20:00" });
            list.Add(new Match { No = 9, Game = "Obolen vs Chelsea", Data = "14/10/2018", Time = "18:30" });
            list.Add(new Match { No = 10, Game = "Obolen vs Barcelona", Data = "28/10/2018", Time = "22:00" });
            list.Add(new Match { No = 11, Game = "Obolen vs Atletico Madrid", Data = "31/10/2018", Time = "20:00" });
            list.Add(new Match { No = 12, Game = "Obolen vs Manchester United", Data = "03/11/2018", Time = "16:45" });
            list.Add(new Match { No = 13, Game = "Obolen vs Dortmund", Data = "11/11/2018", Time = "22:00" });
            list.Add(new Match { No = 14, Game = "Obolen vs Napoli", Data = "09/12/2018", Time = "21:45" });
            list.Add(new Match { No = 15, Game = "Obolen vs PSG", Data = "19/12/2018", Time = "18:30" });
            dataGridMatch.ItemsSource = list;
            //List of matches and transfer it to datagrid

            string Save;      
            Random rnd = new Random();
            for (int i=0; i<Global.n; i++)
            {
                Global.A[i] = new int[3841];
                Global.Price[i] = new int[3841];
                Global.FullName[i] = new string[3841];
                Global.PhoneNumber[i] = new string[3841];
                Global.Email[i] = new string[3841];
                Global.CCNumber[i] = new string[3841];
                Global.Expire[i] = new string[3841];
                Global.CVV[i] = new string[3841];   
                //Define variables for further use             
                for (int j = 0; j < 3840; j++)
                {
                    // Random seats generator
                    if (Global.Check == 0)
                    {
                        Global.A[i][j] = rnd.Next(2);
                    }
                    else
                    {
                        Save= ""+Global.B[i + 1][j];
                        Global.A[i][j] = Convert.ToInt16(Save);
                    }
                    //price
                    if ((j+1 >= 401 & j+1 <= 560) || (j+1 >= 721 & j+1 <= 880) || (j+1 >= 1001 & j+1 <= 1160) || (j+1 >= 1721 & j+1 <= 1880) || (j+1 >= 2001 & j+1 <= 2160) || (j+1 >= 2321 & j+1 <= 2480))
                    {
                        Global.Price[i][j] = 100;
                    }
                    else
                    {
                        Global.Price[i][j] = 50;
                    }
                }
                
            }
        }
       
    }
}
