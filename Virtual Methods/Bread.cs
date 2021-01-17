using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    public class Bread:Product
    {
        private string _kind;

        public string Kind
        {
            get { return _kind; }
            set { _kind = value; }
        }

        // VAT for bread is 0.08
        // So, we should override the method that is in Product class.
        // Virtuals is overriden by the keyword "override".
        public override decimal IncVAT()
        {
            return Price + Price * 8 / 100;
        }
    }
}
