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
            // Check user's information
            int cvv;
            int x,x1,x2,x3;
            if (!int.TryParse(textBoxCardNum.Text, out x))

            {
                MessageBox.Show("Please fill in your credit card's number correctly");
                textBoxCardNum.Focus();
                return;
            }
            if (!int.TryParse(textBoxCardNum2.Text, out x1))

            {
                MessageBox.Show("Please fill in your credit card's number correctly");
                textBoxCardNum2.Focus();
                return;
            }

            if (!int.TryParse(textBoxCardNum3.Text, out x2))

            {
                MessageBox.Show("Please fill in your credit card's number correctly");
                textBoxCardNum3.Focus();
                return;
            }
            if (!int.TryParse(textBoxCardNum4.Text, out x3))

            {
                MessageBox.Show("Please fill in your credit card's number correctly");
                textBoxCardNum4.Focus();
                return;
            }
            if (x<1000||x>9999)
            {
                MessageBox.Show("Please fill in your credit card's number correctly");
                textBoxCVV.Focus();
                return;
            }
            if (x1 < 1000 || x1 > 9999)
            {
                MessageBox.Show("Please fill in your credit card's number correctly");
                textBoxCVV.Focus();
                return;
            }
            if (x2 < 1000 || x2 > 9999)
            {
                MessageBox.Show("Please fill in your credit card's number correctly");
                textBoxCVV.Focus();
                return;
            }
            if (x3 < 1000 || x3 > 9999)
            {
                MessageBox.Show("Please fill in your credit card's number correctly");
                textBoxCVV.Focus();
                return;
            }
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
            

            if (!int.TryParse(textBoxCVV.Text, out cvv))
            {
                MessageBox.Show("Please enter a three-digit number for cvv ");
                textBoxCVV.Focus();
                return;
            }

            if (cvv < 100 || cvv >999)
            {
                MessageBox.Show("CVV is a three-digit number, please re-enter it correctly");
                textBoxCVV.Focus();
                return;
            }
            
            Checkout window = new Checkout();
            window.Show();
            this.Close();
            //Read information before saving
            Global.CCNumber[Global.index][Global._seat] = textBoxCardNum.Text + textBoxCardNum2.Text + textBoxCardNum3.Text + textBoxCardNum4.Text;
            Global.Expire[Global.index][Global._seat] = comboBoxMonth.Text + "/20" + comboBoxYear.Text;
            Global.CVV[Global.index][Global._seat] = textBoxCVV.Text;
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

        private void textBoxCardNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string x;
            x = textBoxCardNum2.Text;
            if (x.Length == 4)
            {
                textBoxCardNum3.Focus();
            }
        }

        private void textBoxCardNum3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string x;
            x = textBoxCardNum3.Text;
            if (x.Length == 4)
            {
                textBoxCardNum4.Focus();
            }
        }
      
        private void textBoxCardNum4_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string x;
            x = textBoxCardNum4.Text;
            if (x.Length == 4)
            {
                comboBoxMonth.Focus();
            }
        }
    }
    }

