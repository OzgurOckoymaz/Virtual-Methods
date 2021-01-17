using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            Chocolate c = new Chocolate();
            c.Price = Convert.ToDecimal(textBox1.Text);
            MessageBox.Show($"The price of chocolate with VAT is :{c.IncVAT()}");
            textBox1.Clear();
        }

        private void btnBread_Click(object sender, EventArgs e)
        {
            Bread b = new Bread();
            b.Price = Convert.ToDecimal(textBox2.Text);
            MessageBox.Show($"The price of bread with VAT is :{b.IncVAT()}");
            textBox2.Clear();
        }
    }
}
