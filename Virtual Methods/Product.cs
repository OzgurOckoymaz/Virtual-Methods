using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    public class Product
    {
        private decimal _price;
        private string _name;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // VAT ratio= 0.18
        // VAT ratio can change in terms of product!
        // So, we should use "virtual" method
        public virtual decimal IncVAT()
        {
            return _price + _price * 18 / 100;
        }

    }
}
