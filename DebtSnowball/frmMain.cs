using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DebtSnowball
{
    public partial class frmMain : Form
    {

        DebtList debtList;
        string path;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            debtList = new DebtList();
            comboBox1.SelectedIndex = 0;

            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\debtsnowball.xml";
            if (File.Exists(path))
            {
                debtList = DebtList.Load(path);
                RefreshData();
            }

        }

               
        private void calculate_Click(object sender, EventArgs e)
        {
            frmDebt d = new frmDebt();
            d.ShowDialog();
            if (d.Value == DialogResult.OK)
            {
                Debt debt = new Debt(d.DebtName, d.Balance, d.IntrestRate, d.Payment, d.FirstPaymentDate);
                debtList.Debts.Add(debt);

                DebtList.Save(debtList, path);

                RefreshData();
            }
            /*
            double rate = Convert.ToDouble(txtRate.Text);
            double payment = Convert.ToDouble(txtPayment.Text);
            double balance = Convert.ToDouble(txtBalance.Text);
            string name = txtName.Text;
            if (name.Trim() == "")
            {
                name = "Debt " + (debtList.Debts.Count + 1).ToString();
            }

            Debt debt = new Debt(name, balance, rate, payment);
            debtList.Debts.Add(debt);

            DebtList.Save(debtList, path);

            RefreshData();
              */


        }

        public string ToMoney(double v)
        {
            return "$" + Math.Round(v, 2).ToString();
        }

        public void RefreshData()
        {
            try
            {
                try
                {
                    txtExtraPayment.Text = debtList.InitialSnowball.ToString();
                    dateTimePicker1.Value = debtList.InitialSnowballStart;
                }
                catch { }

                gvDebts.DataSource = null;
                gvDebts.DataSource = debtList.Debts;

                gvSnowball.DataSource = null;
                List<DebtPaymentDisplay> dpds = new List<DebtPaymentDisplay>();

                DebtList.SnowballApproaches sa = DebtList.SnowballApproaches.LowestBalanceFirst;
                if (comboBox1.SelectedIndex == 2) sa = DebtList.SnowballApproaches.HighestInterestFirst;

                foreach (DebtPayment dp in debtList.ProcessPlan(true, sa, Convert.ToDouble(txtExtraPayment.Text), dateTimePicker1.Value))
                {
                    dpds.Add(new DebtPaymentDisplay(dp));
                }
                gvSnowball.DataSource = dpds;
                gvSnowball.FirstDisplayedScrollingRowIndex = gvSnowball.RowCount - 1;
                
                /* --------------------- */
                dgvNonSnowball.DataSource = null;
                List<DebtPaymentDisplay> dpds2 = new List<DebtPaymentDisplay>();
                foreach (DebtPayment dp in debtList.ProcessPlan(false, sa, Convert.ToDouble(txtExtraPayment.Text)))
                {
                    dpds2.Add(new DebtPaymentDisplay(dp));
                }
                dgvNonSnowball.DataSource = dpds2;
                dgvNonSnowball.FirstDisplayedScrollingRowIndex = dgvNonSnowball.RowCount - 1;
                /* -----------------------*/
                               
                debtList = DebtList.Load(path);
                gvDebts.DataSource = null;

                List<DebtDisplay> dds = new List<DebtDisplay>();
                foreach (Debt d in debtList.Debts)
                {
                    dds.Add(new DebtDisplay(d));
                }
                gvDebts.DataSource = dds;

                foreach (DataGridViewRow d in gvDebts.Rows)
                {
                    d.Selected = false;
                }
                
                dgvExtraPayments.DataSource = null;

                List<ExtraPaymentDisplay> epds = new List<ExtraPaymentDisplay>();
                foreach (ExtraPayment ep in debtList.ExtraPayments)
                {
                    epds.Add(new ExtraPaymentDisplay(ep));
                }

                dgvExtraPayments.DataSource = epds; //debtList.ExtraPayments;
                foreach (DataGridViewRow d in dgvExtraPayments.Rows)
                {
                    d.Selected = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuCopySnowballPlan_Click(object sender, EventArgs e)
        {
            var newline = System.Environment.NewLine;
            var tab = "\t";
            var clipboard_string = new StringBuilder();

            foreach (DataGridViewRow row in gvSnowball.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i == (row.Cells.Count - 1))
                        clipboard_string.Append(row.Cells[i].Value + newline);
                    else
                        clipboard_string.Append(row.Cells[i].Value + tab);
                }
            }

            Clipboard.SetText(clipboard_string.ToString());
        }                   


        private void btnCalculatePlan_Click(object sender, EventArgs e)
        {
            debtList.InitialSnowball = Convert.ToDouble(txtExtraPayment.Text);
            debtList.InitialSnowballStart = dateTimePicker1.Value;
            DebtList.Save(debtList, path);

            RefreshData();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            frmExtraPayment f = new frmExtraPayment();
            f.ShowDialog();
            if (f.Value == DialogResult.OK)
            {
                ExtraPayment ep = new ExtraPayment();
                ep.Name = f.ExtraPaymentName;
                ep.Amount = f.Amount;
                ep.Recurring = f.Recurring;
                ep.StartDate = f.StartDate;
                ep.StopDate = f.StopDate;
                ep.IndefiniteStopDate = f.IndefiniteStopDate;

                debtList.ExtraPayments.Add(ep);

                DebtList.Save(debtList, path);

                RefreshData();
            }
        }

        private void gvDebts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                bool check = Convert.ToBoolean(gvDebts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                debtList.Debts[e.RowIndex].Enabled = check;

                DebtList.Save(debtList, path);

                RefreshData();
            }
        }

        private void gvDebts_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // End of edition on each click on column of checkbox
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {
                gvDebts.EndEdit();
            }
        }

        private void dgvExtraPayments_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                bool check = Convert.ToBoolean(dgvExtraPayments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                debtList.ExtraPayments[e.RowIndex].Enabled = check;

                DebtList.Save(debtList, path);

                RefreshData();
            }
        }

        private void dgvExtraPayments_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // End of edition on each click on column of checkbox
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                dgvExtraPayments.EndEdit();
            }
        }

        private void chkIndefinite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDebtUp_Click(object sender, EventArgs e)
        {
            int index = -1;
            List<int> toSelect = new List<int>();

            foreach (DataGridViewRow r in gvDebts.Rows)
            {
                index++;
                if (r.Selected && index > 0)
                {
                    Debt dummy = debtList.Debts[index];
                    debtList.Debts[index] = debtList.Debts[index - 1];
                    debtList.Debts[index - 1] = dummy;
                    toSelect.Add(index - 1);

                    DebtList.Save(debtList, path);
                }
            }

            RefreshData();

            foreach (int s in toSelect)
            {
                gvDebts.Rows[s].Selected = true;
            }

        }

        private void btnDebtDown_Click(object sender, EventArgs e)
        {
            int index = -1;
            List<int> toSelect = new List<int>();

            foreach (DataGridViewRow r in gvDebts.Rows)
            {
                index++;
                if (r.Selected && index < gvDebts.Rows.Count - 1)
                {
                    Debt dummy = debtList.Debts[index];
                    debtList.Debts[index] = debtList.Debts[index + 1];
                    debtList.Debts[index + 1] = dummy;
                    toSelect.Add(index + 1);

                    DebtList.Save(debtList, path);
                }
            }

            RefreshData();

            foreach (int s in toSelect)
            {
                gvDebts.Rows[s].Selected = true;
            }
        }

        private void btnDebtDelete_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (DataGridViewRow r in gvDebts.Rows)
            {
                index++;
                if (r.Selected && index > -1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete the \"" + debtList.Debts[index].Name + "\" debt?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        debtList.Debts.RemoveAt(index);
                        DebtList.Save(debtList, path);
                    }
                }
            }

            RefreshData();
        }

        private void gvSnowball_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void gvSnowball_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Color co = Color.White;
            for (int x = 1; x < gvSnowball.Rows.Count; x++)
            {
                if (gvSnowball.Rows[x].Cells[0].Value.ToString() != gvSnowball.Rows[x - 1].Cells[0].Value.ToString())
                {
                    if (co == Color.White)
                    {
                        co = Color.Silver;
                    }
                    else
                    {
                        co = Color.White;
                    }
                }

                gvSnowball.Rows[x].DefaultCellStyle.BackColor = co;

                bool lastTimeOnThis = true;
                for (int y = x + 1; y < gvSnowball.Rows.Count; y++)
                {
                    if (gvSnowball.Rows[x].Cells[1].Value.ToString() == gvSnowball.Rows[y].Cells[1].Value.ToString())
                    {
                        lastTimeOnThis = false;
                        break;
                    }
                }

                if (lastTimeOnThis) gvSnowball.Rows[x].DefaultCellStyle.BackColor = Color.Yellow;

            }
        }

        private void dgvExtraPayments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmExtraPayment f = new frmExtraPayment(debtList.ExtraPayments[e.RowIndex]);
            f.ShowDialog();
            if (f.Value == DialogResult.OK)
            {
                ExtraPayment ep = new ExtraPayment();
                ep.Name = f.ExtraPaymentName;
                ep.Amount = f.Amount;
                ep.Recurring = f.Recurring;
                ep.StartDate = f.StartDate;
                ep.StopDate = f.StopDate;
                ep.IndefiniteStopDate = f.IndefiniteStopDate;

                debtList.ExtraPayments[e.RowIndex] = ep;

                DebtList.Save(debtList, path);

                RefreshData();

            }
        }

        private void gvDebts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDebt d = new frmDebt(debtList.Debts[e.RowIndex]);
            d.ShowDialog();
            if (d.Value == DialogResult.OK)
            {
                Debt debt = new Debt(d.DebtName, d.Balance, d.IntrestRate, d.Payment, d.FirstPaymentDate);
                debtList.Debts[e.RowIndex] = debt;

                DebtList.Save(debtList, path);

                RefreshData();
            }
        }
    }
}
