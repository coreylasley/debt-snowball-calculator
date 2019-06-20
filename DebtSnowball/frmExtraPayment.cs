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
    public partial class frmExtraPayment : Form
    {
        public DialogResult Value { get; set; }

        public string ExtraPaymentName
        {
            get
            {
                return txtExtraPaymentName.Text;
            }
            set
            {
                txtExtraPaymentName.Text = value;
            }
        }

        public double Amount
        {
            get
            {
                return Convert.ToDouble(txtExtraPaymentAmount.Text);
            }
            set
            {
                txtExtraPaymentAmount.Text = value.ToString();
            }
        }
        public DateTime StartDate
        {
            get
            {
                return dtpExtraPaymentStart.Value;
            }
            set
            {
                dtpExtraPaymentStart.Value = value;
            }
        }
        public DateTime StopDate
        {
            get
            {
                return dtpExtraPaymentStop.Value;
            }
            set
            {
                dtpExtraPaymentStop.Value = value;
            }
        }
        public bool IndefiniteStopDate
        {
            get
            {
                return chkIndefinite.Checked;
            }
            set
            {
                chkIndefinite.Checked = value;
            }
        }
        public ExtraPayment.Frequecy Recurring
        {
            get
            {
                ExtraPayment.Frequecy ret = ExtraPayment.Frequecy.Monthly;

                switch (ddlFrequency.SelectedItem.ToString())
                {
                    case "Once":
                        ret = ExtraPayment.Frequecy.Once;
                        break;
                    case "Daily":
                        ret = ExtraPayment.Frequecy.Daily;
                        break;
                    case "Weekly":
                        ret = ExtraPayment.Frequecy.Weekly;
                        break;
                    case "Monthly":
                        ret = ExtraPayment.Frequecy.Monthly;
                        break;
                    case "Yearly":
                        ret = ExtraPayment.Frequecy.Annualy;
                        break;
                }

                return ret;
            }
            set
            {
                switch (value)
                {
                    case ExtraPayment.Frequecy.Once:
                        ddlFrequency.SelectedIndex = 0;
                        break;
                    case ExtraPayment.Frequecy.Daily:
                        ddlFrequency.SelectedIndex = 1;
                        break;
                    case ExtraPayment.Frequecy.Weekly:
                        ddlFrequency.SelectedIndex = 2;
                        break;
                    case ExtraPayment.Frequecy.Monthly:
                        ddlFrequency.SelectedIndex = 3;
                        break;
                    case ExtraPayment.Frequecy.Annualy:
                        ddlFrequency.SelectedIndex = 4;
                        break;
                }
                
            }
        }

        public frmExtraPayment()
        {
            InitializeComponent();

            ddlFrequency.SelectedIndex = 3;
        }

        public frmExtraPayment(ExtraPayment ep)
        {
            InitializeComponent();

            ExtraPaymentName = ep.Name;
            Recurring = ep.Recurring;
            StartDate = ep.StartDate;
            StopDate = ep.StopDate;
            IndefiniteStopDate = ep.IndefiniteStopDate;
            Amount = ep.Amount;
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

        private void chkIndefinite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndefinite.Checked)
            {
                dtpExtraPaymentStop.Enabled = false;
            }
            else
            {
                dtpExtraPaymentStop.Enabled = true;
            }
        }
    }
}
