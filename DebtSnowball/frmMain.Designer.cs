namespace DebtSnowball
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.calculate = new System.Windows.Forms.Button();
            this.gvDebts = new System.Windows.Forms.DataGridView();
            this.gvSnowball = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtExtraPayment = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDebtDown = new System.Windows.Forms.Button();
            this.btnDebtUp = new System.Windows.Forms.Button();
            this.btnDebtDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculatePlan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvExtraPayments = new System.Windows.Forms.DataGridView();
            this.btnAddExtraPayment = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblDebtFree = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvNonSnowball = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopySnowballPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.nonSnowballPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvDebts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSnowball)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraPayments)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonSnowball)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(572, 17);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(64, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Add";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // gvDebts
            // 
            this.gvDebts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDebts.Location = new System.Drawing.Point(11, 17);
            this.gvDebts.Name = "gvDebts";
            this.gvDebts.RowHeadersVisible = false;
            this.gvDebts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDebts.Size = new System.Drawing.Size(559, 188);
            this.gvDebts.TabIndex = 5;
            this.gvDebts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDebts_CellDoubleClick);
            this.gvDebts.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvDebts_CellMouseUp);
            this.gvDebts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDebts_CellValueChanged);
            // 
            // gvSnowball
            // 
            this.gvSnowball.AllowUserToAddRows = false;
            this.gvSnowball.AllowUserToDeleteRows = false;
            this.gvSnowball.AllowUserToResizeRows = false;
            this.gvSnowball.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvSnowball.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSnowball.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSnowball.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvSnowball.Location = new System.Drawing.Point(3, 3);
            this.gvSnowball.Name = "gvSnowball";
            this.gvSnowball.ReadOnly = true;
            this.gvSnowball.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvSnowball.RowHeadersVisible = false;
            this.gvSnowball.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gvSnowball.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSnowball.Size = new System.Drawing.Size(1017, 359);
            this.gvSnowball.TabIndex = 12;
            this.gvSnowball.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvSnowball_CellFormatting);
            this.gvSnowball.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvSnowball_DataBindingComplete);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1037, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(3);
            this.lblStatus.Size = new System.Drawing.Size(45, 21);
            this.lblStatus.Text = "Ready";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1037, 647);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 250);
            this.panel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1037, 250);
            this.tabControl2.TabIndex = 20;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtExtraPayment);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.btnDebtDown);
            this.tabPage3.Controls.Add(this.btnDebtUp);
            this.tabPage3.Controls.Add(this.btnDebtDelete);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnCalculatePlan);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.gvDebts);
            this.tabPage3.Controls.Add(this.calculate);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1029, 224);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Debts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtExtraPayment
            // 
            this.txtExtraPayment.Location = new System.Drawing.Point(666, 131);
            this.txtExtraPayment.Name = "txtExtraPayment";
            this.txtExtraPayment.Size = new System.Drawing.Size(77, 20);
            this.txtExtraPayment.TabIndex = 22;
            this.txtExtraPayment.Text = "25";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(654, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "$";
            // 
            // btnDebtDown
            // 
            this.btnDebtDown.Location = new System.Drawing.Point(572, 112);
            this.btnDebtDown.Name = "btnDebtDown";
            this.btnDebtDown.Size = new System.Drawing.Size(64, 23);
            this.btnDebtDown.TabIndex = 26;
            this.btnDebtDown.Text = "Down";
            this.btnDebtDown.UseVisualStyleBackColor = true;
            this.btnDebtDown.Click += new System.EventHandler(this.btnDebtDown_Click);
            // 
            // btnDebtUp
            // 
            this.btnDebtUp.Location = new System.Drawing.Point(572, 88);
            this.btnDebtUp.Name = "btnDebtUp";
            this.btnDebtUp.Size = new System.Drawing.Size(64, 23);
            this.btnDebtUp.TabIndex = 25;
            this.btnDebtUp.Text = "Up";
            this.btnDebtUp.UseVisualStyleBackColor = true;
            this.btnDebtUp.Click += new System.EventHandler(this.btnDebtUp_Click);
            // 
            // btnDebtDelete
            // 
            this.btnDebtDelete.Location = new System.Drawing.Point(572, 183);
            this.btnDebtDelete.Name = "btnDebtDelete";
            this.btnDebtDelete.Size = new System.Drawing.Size(64, 23);
            this.btnDebtDelete.TabIndex = 24;
            this.btnDebtDelete.Text = "Delete";
            this.btnDebtDelete.UseVisualStyleBackColor = true;
            this.btnDebtDelete.Click += new System.EventHandler(this.btnDebtDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Initial Snowball:";
            // 
            // btnCalculatePlan
            // 
            this.btnCalculatePlan.Location = new System.Drawing.Point(818, 178);
            this.btnCalculatePlan.Name = "btnCalculatePlan";
            this.btnCalculatePlan.Size = new System.Drawing.Size(93, 29);
            this.btnCalculatePlan.TabIndex = 14;
            this.btnCalculatePlan.Text = "Calculate Plan";
            this.btnCalculatePlan.UseVisualStyleBackColor = true;
            this.btnCalculatePlan.Click += new System.EventHandler(this.btnCalculatePlan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(666, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Snowball Approach:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lowest Balance",
            "Highest Interest Rate"});
            this.comboBox1.Location = new System.Drawing.Point(666, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(746, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Start Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(749, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvExtraPayments);
            this.tabPage4.Controls.Add(this.btnAddExtraPayment);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1029, 224);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Extra Payments";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvExtraPayments
            // 
            this.dgvExtraPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExtraPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtraPayments.Location = new System.Drawing.Point(11, 16);
            this.dgvExtraPayments.Name = "dgvExtraPayments";
            this.dgvExtraPayments.RowHeadersVisible = false;
            this.dgvExtraPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtraPayments.Size = new System.Drawing.Size(574, 190);
            this.dgvExtraPayments.TabIndex = 24;
            this.dgvExtraPayments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtraPayments_CellDoubleClick);
            this.dgvExtraPayments.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExtraPayments_CellMouseUp);
            this.dgvExtraPayments.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtraPayments_CellValueChanged);
            // 
            // btnAddExtraPayment
            // 
            this.btnAddExtraPayment.Location = new System.Drawing.Point(591, 16);
            this.btnAddExtraPayment.Name = "btnAddExtraPayment";
            this.btnAddExtraPayment.Size = new System.Drawing.Size(75, 23);
            this.btnAddExtraPayment.TabIndex = 23;
            this.btnAddExtraPayment.Text = "Add";
            this.btnAddExtraPayment.UseVisualStyleBackColor = true;
            this.btnAddExtraPayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 253);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 391);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gvSnowball);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1023, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Snowball Plan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblDebtFree);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1023, 365);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Summary";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblDebtFree
            // 
            this.lblDebtFree.AutoSize = true;
            this.lblDebtFree.Location = new System.Drawing.Point(25, 25);
            this.lblDebtFree.Name = "lblDebtFree";
            this.lblDebtFree.Size = new System.Drawing.Size(57, 13);
            this.lblDebtFree.TabIndex = 0;
            this.lblDebtFree.Text = "Debt Free:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvNonSnowball);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Non-Snowball Plan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvNonSnowball
            // 
            this.dgvNonSnowball.AllowUserToAddRows = false;
            this.dgvNonSnowball.AllowUserToDeleteRows = false;
            this.dgvNonSnowball.AllowUserToResizeRows = false;
            this.dgvNonSnowball.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNonSnowball.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonSnowball.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNonSnowball.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNonSnowball.Location = new System.Drawing.Point(3, 3);
            this.dgvNonSnowball.Name = "dgvNonSnowball";
            this.dgvNonSnowball.ReadOnly = true;
            this.dgvNonSnowball.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNonSnowball.RowHeadersVisible = false;
            this.dgvNonSnowball.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvNonSnowball.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNonSnowball.Size = new System.Drawing.Size(1017, 359);
            this.dgvNonSnowball.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debtsToolStripMenuItem,
            this.mnuCopySnowballPlan,
            this.nonSnowballPlanToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // debtsToolStripMenuItem
            // 
            this.debtsToolStripMenuItem.Name = "debtsToolStripMenuItem";
            this.debtsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.debtsToolStripMenuItem.Text = "Debts";
            // 
            // mnuCopySnowballPlan
            // 
            this.mnuCopySnowballPlan.Name = "mnuCopySnowballPlan";
            this.mnuCopySnowballPlan.Size = new System.Drawing.Size(176, 22);
            this.mnuCopySnowballPlan.Text = "Snowball Plan";
            this.mnuCopySnowballPlan.Click += new System.EventHandler(this.mnuCopySnowballPlan_Click);
            // 
            // nonSnowballPlanToolStripMenuItem
            // 
            this.nonSnowballPlanToolStripMenuItem.Name = "nonSnowballPlanToolStripMenuItem";
            this.nonSnowballPlanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nonSnowballPlanToolStripMenuItem.Text = "Non-Snowball Plan";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 697);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Advanced Debt Snowball Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDebts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSnowball)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraPayments)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonSnowball)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.DataGridView gvDebts;
        private System.Windows.Forms.DataGridView gvSnowball;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCalculatePlan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCopySnowballPlan;
        private System.Windows.Forms.ToolStripMenuItem nonSnowballPlanToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvExtraPayments;
        private System.Windows.Forms.Button btnAddExtraPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExtraPayment;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDebtDown;
        private System.Windows.Forms.Button btnDebtUp;
        private System.Windows.Forms.Button btnDebtDelete;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblDebtFree;
        private System.Windows.Forms.DataGridView dgvNonSnowball;
    }
}

