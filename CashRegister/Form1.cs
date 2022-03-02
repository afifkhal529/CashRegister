using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            try
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
            catch
            {
                subTotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";
            }
        }
        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            tender = Convert.ToDouble(tenderInput.Text);

            change = Convert.ToDouble(tenderInput.Text);

            change = tender - total;

            changeOutput.Text = $"{change.ToString("C")}";

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            receiptOutputLabel.Text += $"\n        The Authentic Cuisine";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n Fries                    x{fries}  $ 2.00";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n Pasta                    x{pasta}  $ 2.00";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n Drinks                   x{drinks}  $ 2.00";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n Subtotal                     $ {subtotal}.00";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n Tax                          $ {tax}";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n Total                        $ {total}";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n Tendered                   $ {tender}.00";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

            receiptOutputLabel.Text += $"\n Change                     $ {change}";
            receiptOutputLabel.Refresh();
            Thread.Sleep(300);

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