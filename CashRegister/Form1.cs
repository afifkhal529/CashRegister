using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    

    public partial class appetizerLabel : Form
    {
        double fries = 0;
        double samosas = 0;
        double drinks = 0;
        double total = 0;
        double subtotal = 0;
        double tax = 0;
        double tender = 0;
        double change = 0;


        public appetizerLabel()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            fries = Convert.ToDouble(friesInput.Text);

            samosas = Convert.ToDouble(samosaInput.Text);

            drinks = Convert.ToDouble(drinksInput.Text);

            subtotal = (fries + samosas + drinks) * 2.00;

            tax = subtotal * 0.13;

            total = subtotal + tax;

            subTotalOutput.Text = $"{subtotal.ToString("C")}";

            taxOutput.Text = $"{tax.ToString("C")}";

            totalOutput.Text = $"{total.ToString("C")}";

        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            tender = Convert.ToDouble(tenderInput.Text);

            change = tender - total;

            changeOutput.Text = $"{change.ToString("C")}";

        }

        private void printLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}