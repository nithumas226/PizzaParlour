using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlour
{
    public partial class Form1 : Form
    {
        double basePrice = 7.00;
        double topPrice = 1.25;
        double numTop;
        double totalPrice;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numTop = Convert.ToDouble(toppingsInput.Text);
                totalPrice = numTop * topPrice + basePrice;
                priceLabel.Text = $"The price of a pizza with {numTop} toppings is: {totalPrice.ToString("C")}";
               // priceLabel.Text = totalPrice.ToString("C");
            }
            catch
            {
                priceLabel.Text = "The toppings has to be a number";
            }
        }
    }
}
