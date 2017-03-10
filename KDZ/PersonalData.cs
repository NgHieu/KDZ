using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ
{
    class PersonalData
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        private int _telephone;

        public int Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        ////bank card

        //private int _cardnumber;

        //public int Cardnumber
        //{
        //    get { return _cardnumber; }
        //    set { _cardnumber = value; }
        //}

        //private string _holdername ;

        //public string Holdername
        //{
        //    get { return _holdername; }
        //    set { _holdername = value; }
        //}
        //private int _expirydate;

        //public int Expirydate
        //{
        //    get { return _expirydate; }
        //    set { _expirydate = value; }
        //}
        //private int _cvv;

        //public int Cvv
        //{
        //    get { return _cvv; }
        //    set { _cvv = value; }
        //}
        public PersonalData(string name, string lastname,int telephone, string email)
        {
            _name = name;
            _lastname = lastname;
            _telephone = telephone;
            _email = email;
        }

    }
}
