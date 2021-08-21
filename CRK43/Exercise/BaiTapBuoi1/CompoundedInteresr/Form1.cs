using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundedInteresr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double principal = 0.00,
                interestRate = 0.00,
                interestEarned = 0.0;
            double futureValue = 0.00,
                ratePerPeriod = 0.00,
                periods = 0;
            int compoundType = 0;

            principal = double.Parse(txtPrin.Text);

            interestRate = double.Parse(txtRate.Text) / 100;

            if (rdMon.Checked)
                compoundType = 12;
            else if (rdQua.Checked)
                compoundType = 4;
            else if (rdSen.Checked)
                compoundType = 2;
            else
                compoundType = 1;

            periods = double.Parse(txtPer.Text);

            double i = interestRate / periods;
            double n = compoundType * periods;

            ratePerPeriod = interestRate / periods;
            futureValue = principal * Math.Pow(1 + i, n);
            interestEarned = futureValue - principal;

            txtInteresResult.Text = interestEarned.ToString("C");
            txtAmount.Text = futureValue.ToString("C");
        }
    }
}
