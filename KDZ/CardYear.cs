using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ
{
    class CardYear
    {
        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public CardYear(int year)
        {
            _year = year;
        }
    }
}
