namespace DebtSnowball
{
    partial class frmExtraPayment
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
            this.chkIndefinite = new System.Windows.Forms.CheckBox();
            this.txtExtraPaymentAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpExtraPaymentStop = new System.Windows.Forms.DateTimePicker();
            this.dtpExtraPaymentStart = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlFrequency = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExtraPaymentName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkIndefinite
            // 
            this.chkIndefinite.AutoSize = true;
            this.chkIndefinite.Checked = true;
            this.chkIndefinite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIndefinite.Location = new System.Drawing.Point(221, 105);
            this.chkIndefinite.Name = "chkIndefinite";
            this.chkIndefinite.Size = new System.Drawing.Size(69, 17);
            this.chkIndefinite.TabIndex = 47;
            this.chkIndefinite.Text = "Indefinite";
            this.chkIndefinite.UseVisualStyleBackColor = true;
            this.chkIndefinite.CheckedChanged += new System.EventHandler(this.chkIndefinite_CheckedChanged);
            // 
            // txtExtraPaymentAmount
            // 
            this.txtExtraPaymentAmount.Location = new System.Drawing.Point(221, 33);
            this.txtExtraPaymentAmount.Name = "txtExtraPaymentAmount";
            this.txtExtraPaymentAmount.Size = new System.Drawing.Size(50, 20);
            this.txtExtraPaymentAmount.TabIndex = 36;
            this.txtExtraPaymentAmount.Text = "23";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(209, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Stop:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Start:";
            // 
            // dtpExtraPaymentStop
            // 
            this.dtpExtraPaymentStop.Enabled = false;
            this.dtpExtraPaymentStop.Location = new System.Drawing.Point(221, 81);
            this.dtpExtraPaymentStop.Name = "dtpExtraPaymentStop";
            this.dtpExtraPaymentStop.Size = new System.Drawing.Size(200, 20);
            this.dtpExtraPaymentStop.TabIndex = 43;
            // 
            // dtpExtraPaymentStart
            // 
            this.dtpExtraPaymentStart.Location = new System.Drawing.Point(15, 81);
            this.dtpExtraPaymentStart.Name = "dtpExtraPaymentStart";
            this.dtpExtraPaymentStart.Size = new System.Drawing.Size(200, 20);
            this.dtpExtraPaymentStart.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Frequency:";
            // 
            // ddlFrequency
            // 
            this.ddlFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFrequency.FormattingEnabled = true;
            this.ddlFrequency.Items.AddRange(new object[] {
            "Once",
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.ddlFrequency.Location = new System.Drawing.Point(277, 33);
            this.ddlFrequency.Name = "ddlFrequency";
            this.ddlFrequency.Size = new System.Drawing.Size(121, 21);
            this.ddlFrequency.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Extra Payment Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Amount:";
            // 
            // txtExtraPaymentName
            // 
            this.txtExtraPaymentName.Location = new System.Drawing.Point(15, 33);
            this.txtExtraPaymentName.Name = "txtExtraPaymentName";
            this.txtExtraPaymentName.Size = new System.Drawing.Size(188, 20);
            this.txtExtraPaymentName.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(370, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmExtraPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 192);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIndefinite);
            this.Controls.Add(this.txtExtraPaymentAmount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpExtraPaymentStop);
            this.Controls.Add(this.dtpExtraPaymentStart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ddlFrequency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtExtraPaymentName);
            this.Name = "frmExtraPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Extra Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIndefinite;
        private System.Windows.Forms.TextBox txtExtraPaymentAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpExtraPaymentStop;
        private System.Windows.Forms.DateTimePicker dtpExtraPaymentStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlFrequency;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExtraPaymentName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}