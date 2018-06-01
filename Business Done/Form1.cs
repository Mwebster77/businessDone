using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Done
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void till1Receipts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till1Accounts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till1WorldPay_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till1Amex_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till150Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till120Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till110Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till15pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till11Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till150p_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till120P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till110P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till15P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till1Copper_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till1Float_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Receipts.Text) || !string.IsNullOrEmpty(till1Accounts.Text) || !string.IsNullOrEmpty(till1WorldPay.Text) || !string.IsNullOrEmpty(till1Amex.Text) || !string.IsNullOrEmpty(till150Pound.Text) || !string.IsNullOrEmpty(till120Pound.Text) || !string.IsNullOrEmpty(till110Pound.Text) || !string.IsNullOrEmpty(till15pound.Text) || !string.IsNullOrEmpty(till11Pound.Text) || !string.IsNullOrEmpty(till150p.Text) || !string.IsNullOrEmpty(till120P.Text) || !string.IsNullOrEmpty(till110P.Text) || !string.IsNullOrEmpty(till15P.Text) || !string.IsNullOrEmpty(till1Copper.Text) || !string.IsNullOrEmpty(till1Float.Text))
                till1Revenue.Text = (Convert.ToDecimal(till1Receipts.Text) + Convert.ToDecimal(till1Accounts.Text) + Convert.ToDecimal(till1WorldPay.Text) + Convert.ToDecimal(till1Amex.Text) + Convert.ToDecimal(till150Pound.Text) + Convert.ToDecimal(till120Pound.Text) + Convert.ToDecimal(till110Pound.Text) + Convert.ToDecimal(till15pound.Text) + Convert.ToDecimal(till11Pound.Text) + Convert.ToDecimal(till150p.Text) + Convert.ToDecimal(till120P.Text) + Convert.ToDecimal(till110P.Text) + Convert.ToDecimal(till15P.Text) + Convert.ToDecimal(till1Copper.Text) - Convert.ToDecimal(till1Float.Text)).ToString();

        }

        private void till1XRead_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Revenue.Text) || !string.IsNullOrEmpty(till1XRead.Text))
                till1Var.Text = (Convert.ToDecimal(till1Revenue.Text) - Convert.ToDecimal(till1XRead.Text)).ToString();
        }

        private void till2Reciepts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till2Accounts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till2WorldPay_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till2Amex_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till250Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till220Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till210Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till25Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till21Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till250P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till220P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till210P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till25P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till2Copper_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till2Float_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till2XRead_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till2Receipts.Text) || !string.IsNullOrEmpty(till2Accounts.Text) || !string.IsNullOrEmpty(till2WorldPay.Text) || !string.IsNullOrEmpty(till2Amex.Text) || !string.IsNullOrEmpty(till250Pound.Text) || !string.IsNullOrEmpty(till220Pound.Text) || !string.IsNullOrEmpty(till210Pound.Text) || !string.IsNullOrEmpty(till25Pound.Text) || !string.IsNullOrEmpty(till21Pound.Text) || !string.IsNullOrEmpty(till250P.Text) || !string.IsNullOrEmpty(till220P.Text) || !string.IsNullOrEmpty(till210P.Text) || !string.IsNullOrEmpty(till25P.Text) || !string.IsNullOrEmpty(till2Copper.Text) || !string.IsNullOrEmpty(till2Float.Text))
                till2Revenue.Text = (Convert.ToDecimal(till2Receipts.Text) + Convert.ToDecimal(till2Accounts.Text) + Convert.ToDecimal(till2WorldPay.Text) + Convert.ToDecimal(till2Amex.Text) + Convert.ToDecimal(till250Pound.Text) + Convert.ToDecimal(till220Pound.Text) + Convert.ToDecimal(till210Pound.Text) + Convert.ToDecimal(till25Pound.Text) + Convert.ToDecimal(till21Pound.Text) + Convert.ToDecimal(till250P.Text) + Convert.ToDecimal(till220P.Text) + Convert.ToDecimal(till210P.Text) + Convert.ToDecimal(till25P.Text) + Convert.ToDecimal(till2Copper.Text) - Convert.ToDecimal(till2Float.Text)).ToString();

        }

        private void till3Receipts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till3Account_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till3WorldPay_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till3Amex_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till350Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till320Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till310Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till35Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till31Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till350P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till20P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till310P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till35P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till3Copper_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till3Float_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till3XRead_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till3Receipts.Text) || !string.IsNullOrEmpty(till3Accounts.Text) || !string.IsNullOrEmpty(till3WorldPay.Text) || !string.IsNullOrEmpty(till3Amex.Text) || !string.IsNullOrEmpty(till350Pound.Text) || !string.IsNullOrEmpty(till320Pound.Text) || !string.IsNullOrEmpty(till310Pound.Text) || !string.IsNullOrEmpty(till35Pound.Text) || !string.IsNullOrEmpty(till31Pound.Text) || !string.IsNullOrEmpty(till350P.Text) || !string.IsNullOrEmpty(till320P.Text) || !string.IsNullOrEmpty(till310P.Text) || !string.IsNullOrEmpty(till35P.Text) || !string.IsNullOrEmpty(till3Copper.Text) || !string.IsNullOrEmpty(till3Float.Text))
                till3Revenue.Text = (Convert.ToDecimal(till3Receipts.Text) + Convert.ToDecimal(till3Accounts.Text) + Convert.ToDecimal(till3WorldPay.Text) + Convert.ToDecimal(till3Amex.Text) + Convert.ToDecimal(till350Pound.Text) + Convert.ToDecimal(till320Pound.Text) + Convert.ToDecimal(till310Pound.Text) + Convert.ToDecimal(till35Pound.Text) + Convert.ToDecimal(till31Pound.Text) + Convert.ToDecimal(till350P.Text) + Convert.ToDecimal(till320P.Text) + Convert.ToDecimal(till310P.Text) + Convert.ToDecimal(till35P.Text) + Convert.ToDecimal(till3Copper.Text) - Convert.ToDecimal(till3Float.Text)).ToString();

        }

        private void till4Receipts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till4Accounts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till4WorldPay_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till4Amex_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till450Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till420Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till410Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till45Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till41Pounud_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till450P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till420P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till410P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till45P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till4Copper_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till4Float_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till4XRead_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till4Receipts.Text) || !string.IsNullOrEmpty(till4Accounts.Text) || !string.IsNullOrEmpty(till4WorldPay.Text) || !string.IsNullOrEmpty(till4Amex.Text) || !string.IsNullOrEmpty(till450Pound.Text) || !string.IsNullOrEmpty(till420Pound.Text) || !string.IsNullOrEmpty(till410Pound.Text) || !string.IsNullOrEmpty(till45Pound.Text) || !string.IsNullOrEmpty(till41Pound.Text) || !string.IsNullOrEmpty(till450P.Text) || !string.IsNullOrEmpty(till420P.Text) || !string.IsNullOrEmpty(till410P.Text) || !string.IsNullOrEmpty(till45P.Text) || !string.IsNullOrEmpty(till4Copper.Text) || !string.IsNullOrEmpty(till4Float.Text))
                till4Revenue.Text = (Convert.ToDecimal(till4Receipts.Text) + Convert.ToDecimal(till4Accounts.Text) + Convert.ToDecimal(till4WorldPay.Text) + Convert.ToDecimal(till4Amex.Text) + Convert.ToDecimal(till450Pound.Text) + Convert.ToDecimal(till420Pound.Text) + Convert.ToDecimal(till410Pound.Text) + Convert.ToDecimal(till45Pound.Text) + Convert.ToDecimal(till41Pound.Text) + Convert.ToDecimal(till450P.Text) + Convert.ToDecimal(till420P.Text) + Convert.ToDecimal(till410P.Text) + Convert.ToDecimal(till45P.Text) + Convert.ToDecimal(till4Copper.Text) - Convert.ToDecimal(till4Float.Text)).ToString();

        }

        private void till5Receipts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till5Accounts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till5WorldPay_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till5Amex_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till550Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till520Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till510Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till55Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till51Pound_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till550P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till520P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till510P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till55P_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till5Copper_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till5Float_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void till5XRead_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till5Receipts.Text) || !string.IsNullOrEmpty(till5Accounts.Text) || !string.IsNullOrEmpty(till5WorldPay.Text) || !string.IsNullOrEmpty(till5Amex.Text) || !string.IsNullOrEmpty(till550Pound.Text) || !string.IsNullOrEmpty(till520Pound.Text) || !string.IsNullOrEmpty(till510Pound.Text) || !string.IsNullOrEmpty(till55Pound.Text) || !string.IsNullOrEmpty(till51Pound.Text) || !string.IsNullOrEmpty(till550P.Text) || !string.IsNullOrEmpty(till520P.Text) || !string.IsNullOrEmpty(till510P.Text) || !string.IsNullOrEmpty(till55P.Text) || !string.IsNullOrEmpty(till5Copper.Text) || !string.IsNullOrEmpty(till5Float.Text))
                till5Revenue.Text = (Convert.ToDecimal(till5Receipts.Text) + Convert.ToDecimal(till5Accounts.Text) + Convert.ToDecimal(till5WorldPay.Text) + Convert.ToDecimal(till5Amex.Text) + Convert.ToDecimal(till550Pound.Text) + Convert.ToDecimal(till520Pound.Text) + Convert.ToDecimal(till510Pound.Text) + Convert.ToDecimal(till55Pound.Text) + Convert.ToDecimal(till51Pound.Text) + Convert.ToDecimal(till550P.Text) + Convert.ToDecimal(till520P.Text) + Convert.ToDecimal(till510P.Text) + Convert.ToDecimal(till55P.Text) + Convert.ToDecimal(till5Copper.Text) - Convert.ToDecimal(till5Float.Text)).ToString();

        }

        private void salesLiquor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(salesLiquor.Text) || !string.IsNullOrEmpty(salesFood.Text) || !string.IsNullOrEmpty(salesConfection.Text) || !string.IsNullOrEmpty(salesCashBack.Text) || !string.IsNullOrEmpty(salesLiquorDisc.Text) || !string.IsNullOrEmpty(salesFoodDisc.Text))
                zSalesTotal.Text = (Convert.ToDecimal(salesLiquor.Text) + Convert.ToDecimal(salesFood.Text) + Convert.ToDecimal(salesConfection.Text) + Convert.ToDecimal(salesCashBack.Text) + Convert.ToDecimal(salesLiquorDisc.Text) + Convert.ToDecimal(salesFoodDisc.Text)).ToString();

        }

        private void salesFood_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(salesLiquor.Text) || !string.IsNullOrEmpty(salesFood.Text) || !string.IsNullOrEmpty(salesConfection.Text) || !string.IsNullOrEmpty(salesCashBack.Text) || !string.IsNullOrEmpty(salesLiquorDisc.Text) || !string.IsNullOrEmpty(salesFoodDisc.Text))
                zSalesTotal.Text = (Convert.ToDecimal(salesLiquor.Text) + Convert.ToDecimal(salesFood.Text) + Convert.ToDecimal(salesConfection.Text) + Convert.ToDecimal(salesCashBack.Text) + Convert.ToDecimal(salesLiquorDisc.Text) + Convert.ToDecimal(salesFoodDisc.Text)).ToString();

        }

        private void salesConfection_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(salesLiquor.Text) || !string.IsNullOrEmpty(salesFood.Text) || !string.IsNullOrEmpty(salesConfection.Text) || !string.IsNullOrEmpty(salesCashBack.Text) || !string.IsNullOrEmpty(salesLiquorDisc.Text) || !string.IsNullOrEmpty(salesFoodDisc.Text))
                zSalesTotal.Text = (Convert.ToDecimal(salesLiquor.Text) + Convert.ToDecimal(salesFood.Text) + Convert.ToDecimal(salesConfection.Text) + Convert.ToDecimal(salesCashBack.Text) + Convert.ToDecimal(salesLiquorDisc.Text) + Convert.ToDecimal(salesFoodDisc.Text)).ToString();

        }

        private void salesCashBack_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(salesLiquor.Text) || !string.IsNullOrEmpty(salesFood.Text) || !string.IsNullOrEmpty(salesConfection.Text) || !string.IsNullOrEmpty(salesCashBack.Text) || !string.IsNullOrEmpty(salesLiquorDisc.Text) || !string.IsNullOrEmpty(salesFoodDisc.Text))
                zSalesTotal.Text = (Convert.ToDecimal(salesLiquor.Text) + Convert.ToDecimal(salesFood.Text) + Convert.ToDecimal(salesConfection.Text) + Convert.ToDecimal(salesCashBack.Text) + Convert.ToDecimal(salesLiquorDisc.Text) + Convert.ToDecimal(salesFoodDisc.Text)).ToString();

        }

        private void salesLiquorDisc_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(salesLiquor.Text) || !string.IsNullOrEmpty(salesFood.Text) || !string.IsNullOrEmpty(salesConfection.Text) || !string.IsNullOrEmpty(salesCashBack.Text) || !string.IsNullOrEmpty(salesLiquorDisc.Text) || !string.IsNullOrEmpty(salesFoodDisc.Text))
                zSalesTotal.Text = (Convert.ToDecimal(salesLiquor.Text) + Convert.ToDecimal(salesFood.Text) + Convert.ToDecimal(salesConfection.Text) + Convert.ToDecimal(salesCashBack.Text) + Convert.ToDecimal(salesLiquorDisc.Text) + Convert.ToDecimal(salesFoodDisc.Text)).ToString();

        }

        private void salesFoodDisc_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(salesLiquor.Text) || !string.IsNullOrEmpty(salesFood.Text) || !string.IsNullOrEmpty(salesConfection.Text) || !string.IsNullOrEmpty(salesCashBack.Text) || !string.IsNullOrEmpty(salesLiquorDisc.Text) || !string.IsNullOrEmpty(salesFoodDisc.Text))
                zSalesTotal.Text = (Convert.ToDecimal(salesLiquor.Text) + Convert.ToDecimal(salesFood.Text) + Convert.ToDecimal(salesConfection.Text) + Convert.ToDecimal(salesCashBack.Text) + Convert.ToDecimal(salesLiquorDisc.Text) + Convert.ToDecimal(salesFoodDisc.Text)).ToString();

        }

        private void zSalesTotal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(salesLiquor.Text) || !string.IsNullOrEmpty(salesFood.Text) || !string.IsNullOrEmpty(salesConfection.Text) || !string.IsNullOrEmpty(salesCashBack.Text) || !string.IsNullOrEmpty(salesLiquorDisc.Text) || !string.IsNullOrEmpty(salesFoodDisc.Text))
                zSalesTotal.Text = (Convert.ToDecimal(salesLiquor.Text) + Convert.ToDecimal(salesFood.Text) + Convert.ToDecimal(salesConfection.Text) + Convert.ToDecimal(salesCashBack.Text) + Convert.ToDecimal(salesLiquorDisc.Text) + Convert.ToDecimal(salesFoodDisc.Text)).ToString();

        }

        private void totalRevenue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(till1Revenue.Text) || !string.IsNullOrEmpty(till2Revenue.Text) || !string.IsNullOrEmpty(till3Revenue.Text) || !string.IsNullOrEmpty(till4Revenue.Text) || !string.IsNullOrEmpty(till5Revenue.Text))
                totalRevenue.Text = (Convert.ToDecimal(till1Revenue.Text) + Convert.ToDecimal(till2Revenue.Text) + Convert.ToDecimal(till3Revenue.Text) + Convert.ToDecimal(till4Revenue.Text) + Convert.ToDecimal(till5Revenue.Text)).ToString();

        }

        private void salesTotalVar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(zSalesTotal.Text) || !string.IsNullOrEmpty(totalRevenue.Text))
                salesTotalVar.Text = (Convert.ToDecimal(zSalesTotal.Text) - Convert.ToDecimal(totalRevenue.Text)).ToString();

        }
    }
}