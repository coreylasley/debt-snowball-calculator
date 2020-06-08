using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtSnowball
{
    public partial class frmDebt : Form
    {

        public DialogResult Value { get; set; }

        public string DebtName
        {
            get
            {
                return txtName.Text;
            }
            set
            {
                txtName.Text = value;
            }
        }

        public double Balance
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtBalance.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                txtBalance.Text = value.ToString();
            }
        }

        public double IntrestRate
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtRate.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                txtRate.Text = value.ToString();
            }
        }

        public double Payment
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtPayment.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                txtPayment.Text = value.ToString();
            }
        }

        public DateTime FirstPaymentDate
        {
            get
            {
                try
                {
                    return dtpFirstPaymentDate.Value;
                }
                catch
                {
                    return DateTime.Now;
                }
            }
            set
            {
                dtpFirstPaymentDate.Value = value;
            }
        }

        public double LoanTermsValue
        {
            get
            {
                try
                {
                    return Convert.ToDouble(txtLoanTermsValue.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                txtLoanTermsValue.Text = value.ToString();
            }
        }


        public frmDebt()
        {
            InitializeComponent();
            ddlTerms.SelectedIndex = 0;
        }

        public frmDebt(Debt debt)
        {
            InitializeComponent();
            ddlTerms.SelectedIndex = 0;

            DebtName = debt.Name;
            Balance = debt.Balance;
            IntrestRate = debt.IntrestRate;
            Payment = debt.Payment;
            FirstPaymentDate = debt.FirstPaymentDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Value = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Value = DialogResult.Cancel;
            this.Close();
        }

        public void CheckNumbers()
        {
            double interest = 0;

            double rate;
            double.TryParse(txtRate.Text, out rate);

            double balance;
            double.TryParse(txtBalance.Text, out balance);

            if (balance > 0 && rate > 0)
            {
                interest = Debt.CalculateInterest(rate, balance, DateTime.Now.Year, DateTime.Now.Month);
            }

            double payment;
            double.TryParse(txtPayment.Text, out payment);

            //txtPayment.Text = Math.Round(interest, 2).ToString();

            if (payment < interest)
            {
                btnSave.Enabled = false;
                lblToLow.Visible = true;
                lblToLow.Text = "Payment must be greater than " + Math.Round(interest, 2).ToString() + " to cover interest";
            }
            else
            {
                btnSave.Enabled = true;
                lblToLow.Visible = false;
            }
        }

        private void btnCalculateMinPayment_Click(object sender, EventArgs e)
        {
            PaymentCalculator pc = new PaymentCalculator();

            pc.DownPayment = 0;
            pc.InterestRate = Convert.ToDecimal(IntrestRate);
            pc.PurchasePrice = Convert.ToDecimal(Balance);
            if (ddlTerms.SelectedIndex == 1)
            {
                pc.LoanTermMonths = Convert.ToDecimal(LoanTermsValue) * 12;
            }
            else
            {
                pc.LoanTermMonths = Convert.ToDecimal(LoanTermsValue);
            }


            decimal payment = pc.CalculatePayment();

            Payment = Convert.ToDouble(payment);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    class PaymentCalculator
    {
        private const int MonthsPerYear = 12;

        /// <summary>
        /// The total purchase price of the item being paid for.
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// The total down payment towards the item being purchased.
        /// </summary>
        public decimal DownPayment { get; set; }

        /// <summary>
        /// Gets the total loan amount. This is the purchase price less
        /// any down payment.
        /// </summary>
        public decimal LoanAmount
        {
            get { return (PurchasePrice - DownPayment); }
        }

        /// <summary>
        /// The annual interest rate to be charged on the loan
        /// </summary>
        public decimal InterestRate { get; set; }

        /// <summary>
        /// The term of the loan in months. This is the number of months
        /// that payments will be made.
        /// </summary>
        public decimal LoanTermMonths { get; set; }

        /// <summary>
        /// The term of the loan in years. This is the number of years
        /// that payments will be made.
        /// </summary>
        public decimal LoanTermYears
        {
            get { return LoanTermMonths / MonthsPerYear; }
            set { LoanTermMonths = (value * MonthsPerYear); }
        }

        /// <summary>
        /// Calculates the monthy payment amount based on current
        /// settings.
        /// </summary>
        /// <returns>Returns the monthly payment amount</returns>
        public decimal CalculatePayment()
        {
            decimal payment = 0;

            if (LoanTermMonths > 0)
            {
                if (InterestRate != 0)
                {
                    decimal rate = ((InterestRate / MonthsPerYear) / 100);
                    decimal factor = (rate + (rate / Convert.ToDecimal((Math.Pow(Convert.ToDouble(rate + 1), Convert.ToDouble(LoanTermMonths)) - 1))));
                    payment = (LoanAmount * factor);
                }
                else payment = (LoanAmount / (decimal)LoanTermMonths);
            }
            return Math.Round(payment, 2);
        }
    }


}
