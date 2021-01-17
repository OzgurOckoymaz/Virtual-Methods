using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    public class Chocolate:Product
    {
        private string _kind;

        public string Kind
        {
            get { return _kind; }
            set { _kind = value; }
        }

    }
}
