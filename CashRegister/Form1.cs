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
        double pasta = 0;
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

            pasta = Convert.ToDouble(pastaInput.Text);

            drinks = Convert.ToDouble(drinksInput.Text);

            subtotal = (fries + pasta + drinks) * 2.00;

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

        private void printButton_Click(object sender, EventArgs e)
        {
            receiptOutputLabel.Text += $"\n        The Authentic Cuisine";

            receiptOutputLabel.Text += $"\n";

            receiptOutputLabel.Text += $"\n Fries                    x{fries}  $ 2.00";

            receiptOutputLabel.Text += $"\n";

            receiptOutputLabel.Text += $"\n Pasta                    x{pasta}  $ 2.00";

            receiptOutputLabel.Text += $"\n";

            receiptOutputLabel.Text += $"\n Drinks                   x{drinks}  $ 2.00";

            receiptOutputLabel.Text += $"\n";

            receiptOutputLabel.Text += $"\n Subtotal                     $ {subtotal}.00";

            receiptOutputLabel.Text += $"\n Tax                          $ {tax}";

            receiptOutputLabel.Text += $"\n Total                        $ {total}";

            receiptOutputLabel.Text += $"\n";

            receiptOutputLabel.Text += $"\n Tendered                     $ {tender}";

            receiptOutputLabel.Text += $"\n Change                       $ {change}";

            receiptOutputLabel.Text += $"\n         Have a Nice Day :)";
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            friesInput.Text = "";
            pastaInput.Text = "";
            drinksInput.Text = "";
            totalOutput.Text = "";
            subTotalOutput.Text = "";
            taxOutput.Text = "";
            tenderInput.Text = "";
            changeOutput.Text = "";
            receiptOutputLabel.Text = "";
        }
    }
}