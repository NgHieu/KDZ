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
    /// Interaction logic for ConfirmPersonalData.xaml
    /// </summary>
    public partial class ConfirmPersonalData : Window
    {
        public ConfirmPersonalData()
        {
            InitializeComponent();
        }
        //PersonalData _ps;
        //public PersonalData Ps
        //{
        //    get
        //    {
        //        return _ps;
        //    }
        //}

        //PersonalData _newPersonalData;

        private void buttonContinue_Click(object sender, RoutedEventArgs e)
        {
            string x;
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter your information correctly");
                textBoxName.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(textBoxLastName.Text))
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
            x = textBoxEmail.Text;
            //if ()
            //{

            //}
            BankCard window = new BankCard();
            window.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            ConfirmData_Match window = new ConfirmData_Match();
            window.Show();
            this.Close();
        }

        private void textBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
