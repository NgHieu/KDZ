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
using System.IO;

namespace KDZ
{
    /// <summary>
    /// Interaction logic for Check.xaml
    /// </summary>
    public partial class Check : Window
    {
        List<Seat> seats = new List<Seat>();
        public Check()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            //Generate seats
            seats = new List<Seat>();
            seats.Add(new Seat { N1 = Global.Zone + 1, N2 = Global.Zone + 2, N3 = Global.Zone + 3, N4 = Global.Zone + 4, N5 = Global.Zone + 5, N6 = Global.Zone + 6, N7 = Global.Zone + 7, N8 = Global.Zone + 8 });
            seats.Add(new Seat { N1 = Global.Zone + 9, N2 = Global.Zone + 10, N3 = Global.Zone + 11, N4 = Global.Zone + 12, N5 = Global.Zone + 13, N6 = Global.Zone + 14, N7 = Global.Zone + 15, N8 = Global.Zone + 16 });
            seats.Add(new Seat { N1 = Global.Zone + 17, N2 = Global.Zone + 18, N3 = Global.Zone + 19, N4 = Global.Zone + 20, N5 = Global.Zone + 21, N6 = Global.Zone + 22, N7 = Global.Zone + 23, N8 = Global.Zone + 24 });
            seats.Add(new Seat { N1 = Global.Zone + 25, N2 = Global.Zone + 26, N3 = Global.Zone + 27, N4 = Global.Zone + 28, N5 = Global.Zone + 29, N6 = Global.Zone + 30, N7 = Global.Zone + 31, N8 = Global.Zone + 32 });
            seats.Add(new Seat { N1 = Global.Zone + 33, N2 = Global.Zone + 34, N3 = Global.Zone + 35, N4 = Global.Zone + 36, N5 = Global.Zone + 37, N6 = Global.Zone + 38, N7 = Global.Zone + 39, N8 = Global.Zone + 40 });
            dataGrid.ItemsSource = seats;
            //Resize datagrid
            dataGrid.Columns[0].Width = 40;
            dataGrid.Columns[1].Width = 40;
            dataGrid.Columns[2].Width = 40;
            dataGrid.Columns[3].Width = 40;
            dataGrid.Columns[4].Width = 40;
            dataGrid.Columns[5].Width = 40;
            dataGrid.Columns[6].Width = 40;
            dataGrid.Columns[7].Width = 40;
            dataGrid.RowHeight = 44.4;

            //Color datagrid's cells
            int s1 = Global.Zone;
            for (int i1 = 0; i1 < 5; i1++)
            {

                for (int j1 = 0; j1 < 8; j1++)
                {
                    s1 = s1 + 1;

                    DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(i1);
                    if (row == null)
                    {
                        dataGrid.UpdateLayout();
                        dataGrid.ScrollIntoView(dataGrid.Items[i1]);
                        row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromIndex(i1);
                    }
                    DataGridCell cell = dataGrid.Columns[j1].GetCellContent(row).Parent as DataGridCell;
                    if (Global.A[Global.index][s1] == 1)
                    {

                        cell.Background = Brushes.DarkOrange;
                    }
                    else
                    {
                        cell.Background = Brushes.Lime;
                    }
                }
            }
        }

        // Button to continue booking
        private void buttonContinue_Click(object sender, RoutedEventArgs e)
        {
            FileText ft = new FileText();
            ft.Filename = "...\\Match.txt";
            ft.ReadData();
            Global.Check = 1;
            ConfirmData_Match window = new ConfirmData_Match();
            window.Show();
            this.Close();
        }
    }
}
