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
    /// Interaction logic for BankCard.xaml
    /// </summary>
    public partial class BankCard : Window
    {
        public BankCard()
        {
            InitializeComponent();
        }

        private void comboBoxMonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            int cvv;
           
            if (comboBoxMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select expiry month");
                comboBoxMonth.Focus();
                return;
            }
            if (comboBoxYear.SelectedItem == null)
            {
                MessageBox.Show("Please select expiry year");
                comboBoxYear.Focus();
                return;
            }
            //if (!int.TryParse(textBoxCardNum.Text, out cn))
            //{
            //    textBoxCardNum.Focus();
            //    return;
            //}

            // CVV

            if (!int.TryParse(textBoxCVV.Text, out cvv))
            /*&&!int.TryParse(textBoxCardNum.Text, out cn) && !int.TryParse(textBoxCardNum2.Text, out cn2) && !int.TryParse(textBoxCardNum3.Text, out cn3) && !int.TryParse(textBoxCardNum4.Text, out cn4))*/
            {
                MessageBox.Show("Please enter a three-digit number ");
                //textBoxCardNum.Focus();
                //textBoxCardNum2.Focus();
                //textBoxCardNum3.Focus();
                //textBoxCardNum4.Focus();
                textBoxCVV.Focus();
                return;
            }

            if (cvv < 100 || cvv > 999)
            {
                MessageBox.Show("CVV is a three-digit number, please re-enter it correctly");
                textBoxCVV.Focus();
                return;
            }
            Checkout window = new Checkout();
            window.Show();
            this.Close();
        }

       
        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            ConfirmPersonalData window = new ConfirmPersonalData();
            window.Show();
            this.Close();
        }

        private void textBoxCardNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            string x;
            x = textBoxCardNum.Text;
            if (x.Length ==4 )
            {
                textBoxCardNum2.Focus();
            }
            
        }
    }
    }

