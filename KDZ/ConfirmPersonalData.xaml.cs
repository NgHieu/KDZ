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
    /// Interaction logic for ConfirmPersonalData.xaml
    /// </summary>
    public partial class ConfirmPersonalData : Window
    {
        public ConfirmPersonalData()
        {
            InitializeComponent();
        }
        private void buttonContinue_Click(object sender, RoutedEventArgs e)
        {
            // Check user's information
            int TelNo;
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter your information correctly");
                textBoxName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Please enter your information correctly");
                textBoxLastName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter your information correctly");
                textBoxEmail.Focus();
                return;
            }
            if (!int.TryParse(textBoxPhone2.Text, out TelNo))

            {
                MessageBox.Show("Please fill in your telephone number correctly");
                textBoxPhone2.Focus();
                return;
            }

            if (TelNo < 1000000 || TelNo > 9999999)
            {
                MessageBox.Show("Your telephone number must contain 11 numbers in total ");
                textBoxPhone2.Focus();
                return;
            }
   
            BankCard window = new BankCard();
            window.Show();
            this.Close();

            //Read information before saving
            Global.FullName[Global.index][Global._seat]=textBoxName.Text+ textBoxLastName.Text;
            Global.PhoneNumber[Global.index][Global._seat] = textBoxPhone.Text + textBoxPhone2.Text;
            Global.Email[Global.index][Global._seat] = textBoxEmail.Text;
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            Seats window = new Seats();
            window.Show();
            this.Close();
        }

        private void textBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    

        private void textBoxPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            string x;
            x = textBoxPhone.Text;
            if (x.Length == 3)
            {
                textBoxPhone2.Focus();
            }

        }
       
   
    }
}
