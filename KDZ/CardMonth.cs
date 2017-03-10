using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ
{
    class CardMonth
    {
        private int _month;

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }
        public CardMonth(int month)
        {
            _month = month;
        }
    }
}
