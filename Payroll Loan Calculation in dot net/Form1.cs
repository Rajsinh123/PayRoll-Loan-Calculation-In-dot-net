using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Payroll_Loan_Calculation_in_dot_net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTot_TextChanged(object sender, EventArgs e)
       {
       }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount, interset,monthpayment;
            int month;
            amount = double.Parse(textAmount.Text);
            month = int.Parse(textMonth.Text);

            interset = double.Parse(textInterset.Text);
            monthpayment = amount * interset / month;
            double fullpayment = monthpayment / month;

            txtAm.Text = amount.ToString("C2",CultureInfo.CurrentCulture);
            txtMpay.Text = monthpayment.ToString("C2", CultureInfo.CurrentCulture);
            txtTot.Text = fullpayment.ToString("C2", CultureInfo.CurrentCulture);

        }
    }
}
