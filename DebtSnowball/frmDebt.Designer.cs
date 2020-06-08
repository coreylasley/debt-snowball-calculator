namespace DebtSnowball
{
    partial class frmDebt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebt));
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToLow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCalculateMinPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLoanTermsValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlTerms = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFirstPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDebtDelete = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.gvDebts = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDebts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(308, 29);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(97, 20);
            this.txtBalance.TabIndex = 32;
            this.txtBalance.Text = "5000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(295, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "$";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(432, 30);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(62, 20);
            this.txtPayment.TabIndex = 31;
            this.txtPayment.Text = "50";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(421, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "$";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(225, 30);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(50, 20);
            this.txtRate.TabIndex = 30;
            this.txtRate.Text = "23";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Debt Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Payment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Original Balance:";
            // 
            // lblToLow
            // 
            this.lblToLow.AutoSize = true;
            this.lblToLow.ForeColor = System.Drawing.Color.DarkRed;
            this.lblToLow.Location = new System.Drawing.Point(17, 152);
            this.lblToLow.Name = "lblToLow";
            this.lblToLow.Size = new System.Drawing.Size(45, 13);
            this.lblToLow.TabIndex = 40;
            this.lblToLow.Text = "Must be";
            this.lblToLow.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Intrest Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "%";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 38;
            // 
            // btnCalculateMinPayment
            // 
            this.btnCalculateMinPayment.Location = new System.Drawing.Point(264, 113);
            this.btnCalculateMinPayment.Name = "btnCalculateMinPayment";
            this.btnCalculateMinPayment.Size = new System.Drawing.Size(189, 25);
            this.btnCalculateMinPayment.TabIndex = 43;
            this.btnCalculateMinPayment.Text = "Calculate Minimum Payment >";
            this.btnCalculateMinPayment.UseVisualStyleBackColor = true;
            this.btnCalculateMinPayment.Click += new System.EventHandler(this.btnCalculateMinPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(498, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLoanTermsValue
            // 
            this.txtLoanTermsValue.Location = new System.Drawing.Point(124, 116);
            this.txtLoanTermsValue.Name = "txtLoanTermsValue";
            this.txtLoanTermsValue.Size = new System.Drawing.Size(33, 20);
            this.txtLoanTermsValue.TabIndex = 45;
            this.txtLoanTermsValue.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Loan Terms:";
            // 
            // ddlTerms
            // 
            this.ddlTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTerms.FormattingEnabled = true;
            this.ddlTerms.Items.AddRange(new object[] {
            "Months",
            "Years"});
            this.ddlTerms.Location = new System.Drawing.Point(158, 116);
            this.ddlTerms.Name = "ddlTerms";
            this.ddlTerms.Size = new System.Drawing.Size(100, 21);
            this.ddlTerms.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Payment Calculator:";
            // 
            // dtpFirstPaymentDate
            // 
            this.dtpFirstPaymentDate.Location = new System.Drawing.Point(225, 75);
            this.dtpFirstPaymentDate.Name = "dtpFirstPaymentDate";
            this.dtpFirstPaymentDate.Size = new System.Drawing.Size(269, 20);
            this.dtpFirstPaymentDate.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "First Payment Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvDebts);
            this.groupBox1.Controls.Add(this.btnDebtDelete);
            this.groupBox1.Controls.Add(this.calculate);
            this.groupBox1.Location = new System.Drawing.Point(15, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 150);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Refinance";
            // 
            // btnDebtDelete
            // 
            this.btnDebtDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDebtDelete.Image")));
            this.btnDebtDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDebtDelete.Location = new System.Drawing.Point(481, 105);
            this.btnDebtDelete.Name = "btnDebtDelete";
            this.btnDebtDelete.Size = new System.Drawing.Size(64, 28);
            this.btnDebtDelete.TabIndex = 26;
            this.btnDebtDelete.Text = "      Delete";
            this.btnDebtDelete.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Image = ((System.Drawing.Image)(resources.GetObject("calculate.Image")));
            this.calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calculate.Location = new System.Drawing.Point(481, 19);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(64, 30);
            this.calculate.TabIndex = 25;
            this.calculate.Text = "    Add";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // gvDebts
            // 
            this.gvDebts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDebts.Location = new System.Drawing.Point(7, 19);
            this.gvDebts.Name = "gvDebts";
            this.gvDebts.RowHeadersVisible = false;
            this.gvDebts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDebts.Size = new System.Drawing.Size(468, 114);
            this.gvDebts.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(202, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 33);
            this.button1.TabIndex = 52;
            this.button1.Text = "  How will this impact me?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 397);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFirstPaymentDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddlTerms);
            this.Controls.Add(this.txtLoanTermsValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalculateMinPayment);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToLow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Debt";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDebts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToLow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCalculateMinPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLoanTermsValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlTerms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFirstPaymentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDebtDelete;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.DataGridView gvDebts;
        private System.Windows.Forms.Button button1;
    }
}