namespace HackathonMFClever
{
    partial class ReserveForm
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
            this.AddReserve = new System.Windows.Forms.Button();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HoursComboBox = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MinutesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ReservedTimeGrid0 = new System.Windows.Forms.DataGridView();
            this.StartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ReservedTimeGrid1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ReservedTimeGrid2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedTimeGrid3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedTimeGrid4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedTimeGrid5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid0)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid5)).BeginInit();
            this.SuspendLayout();
            // 
            // AddReserve
            // 
            this.AddReserve.Location = new System.Drawing.Point(169, 150);
            this.AddReserve.Name = "AddReserve";
            this.AddReserve.Size = new System.Drawing.Size(105, 38);
            this.AddReserve.TabIndex = 0;
            this.AddReserve.Text = "Add";
            this.AddReserve.UseVisualStyleBackColor = true;
            this.AddReserve.Click += new System.EventHandler(this.AddReserve_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(30, 26);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 17);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(30, 54);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 17);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.Location = new System.Drawing.Point(30, 114);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(55, 17);
            this.ServiceLabel.TabIndex = 3;
            this.ServiceLabel.Text = "Service";
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(139, 107);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(255, 24);
            this.ServiceComboBox.TabIndex = 6;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "";
            this.DateTimePicker.Location = new System.Drawing.Point(139, 49);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(255, 22);
            this.DateTimePicker.TabIndex = 7;
            // 
            // HoursComboBox
            // 
            this.HoursComboBox.FormattingEnabled = true;
            this.HoursComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.HoursComboBox.Location = new System.Drawing.Point(139, 77);
            this.HoursComboBox.Name = "HoursComboBox";
            this.HoursComboBox.Size = new System.Drawing.Size(88, 24);
            this.HoursComboBox.TabIndex = 8;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(30, 80);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(39, 17);
            this.TimeLabel.TabIndex = 9;
            this.TimeLabel.Text = "Time";
            // 
            // MinutesComboBox
            // 
            this.MinutesComboBox.FormattingEnabled = true;
            this.MinutesComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinutesComboBox.Location = new System.Drawing.Point(251, 76);
            this.MinutesComboBox.Name = "MinutesComboBox";
            this.MinutesComboBox.Size = new System.Drawing.Size(143, 24);
            this.MinutesComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = ":";
            // 
            // AddressComboBox
            // 
            this.AddressComboBox.FormattingEnabled = true;
            this.AddressComboBox.Location = new System.Drawing.Point(139, 19);
            this.AddressComboBox.Name = "AddressComboBox";
            this.AddressComboBox.Size = new System.Drawing.Size(255, 24);
            this.AddressComboBox.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(402, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 238);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ReservedTimeGrid0);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "0";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ReservedTimeGrid0
            // 
            this.ReservedTimeGrid0.AllowUserToDeleteRows = false;
            this.ReservedTimeGrid0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedTimeGrid0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTimeColumn,
            this.EndTimeColumn});
            this.ReservedTimeGrid0.Location = new System.Drawing.Point(6, 6);
            this.ReservedTimeGrid0.Name = "ReservedTimeGrid0";
            this.ReservedTimeGrid0.ReadOnly = true;
            this.ReservedTimeGrid0.RowTemplate.Height = 24;
            this.ReservedTimeGrid0.Size = new System.Drawing.Size(412, 200);
            this.ReservedTimeGrid0.TabIndex = 0;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.HeaderText = "StartTimeColumn";
            this.StartTimeColumn.Name = "StartTimeColumn";
            this.StartTimeColumn.ReadOnly = true;
            // 
            // EndTimeColumn
            // 
            this.EndTimeColumn.HeaderText = "EndTimeColumn";
            this.EndTimeColumn.Name = "EndTimeColumn";
            this.EndTimeColumn.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReservedTimeGrid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ReservedTimeGrid1
            // 
            this.ReservedTimeGrid1.AllowUserToDeleteRows = false;
            this.ReservedTimeGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedTimeGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ReservedTimeGrid1.Location = new System.Drawing.Point(4, 4);
            this.ReservedTimeGrid1.Name = "ReservedTimeGrid1";
            this.ReservedTimeGrid1.ReadOnly = true;
            this.ReservedTimeGrid1.RowTemplate.Height = 24;
            this.ReservedTimeGrid1.Size = new System.Drawing.Size(414, 200);
            this.ReservedTimeGrid1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "StartTimeColumn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "EndTimeColumn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ReservedTimeGrid2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(424, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ReservedTimeGrid3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(424, 209);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ReservedTimeGrid4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(424, 209);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.ReservedTimeGrid5);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(424, 209);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "5";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ReservedTimeGrid2
            // 
            this.ReservedTimeGrid2.AllowUserToDeleteRows = false;
            this.ReservedTimeGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedTimeGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ReservedTimeGrid2.Location = new System.Drawing.Point(4, 4);
            this.ReservedTimeGrid2.Name = "ReservedTimeGrid2";
            this.ReservedTimeGrid2.ReadOnly = true;
            this.ReservedTimeGrid2.RowTemplate.Height = 24;
            this.ReservedTimeGrid2.Size = new System.Drawing.Size(414, 200);
            this.ReservedTimeGrid2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "StartTimeColumn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "EndTimeColumn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ReservedTimeGrid3
            // 
            this.ReservedTimeGrid3.AllowUserToDeleteRows = false;
            this.ReservedTimeGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedTimeGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ReservedTimeGrid3.Location = new System.Drawing.Point(4, 4);
            this.ReservedTimeGrid3.Name = "ReservedTimeGrid3";
            this.ReservedTimeGrid3.ReadOnly = true;
            this.ReservedTimeGrid3.RowTemplate.Height = 24;
            this.ReservedTimeGrid3.Size = new System.Drawing.Size(414, 200);
            this.ReservedTimeGrid3.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "StartTimeColumn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "EndTimeColumn";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ReservedTimeGrid4
            // 
            this.ReservedTimeGrid4.AllowUserToDeleteRows = false;
            this.ReservedTimeGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedTimeGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.ReservedTimeGrid4.Location = new System.Drawing.Point(4, 4);
            this.ReservedTimeGrid4.Name = "ReservedTimeGrid4";
            this.ReservedTimeGrid4.ReadOnly = true;
            this.ReservedTimeGrid4.RowTemplate.Height = 24;
            this.ReservedTimeGrid4.Size = new System.Drawing.Size(414, 200);
            this.ReservedTimeGrid4.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "StartTimeColumn";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "EndTimeColumn";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ReservedTimeGrid5
            // 
            this.ReservedTimeGrid5.AllowUserToDeleteRows = false;
            this.ReservedTimeGrid5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedTimeGrid5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.ReservedTimeGrid5.Location = new System.Drawing.Point(4, 4);
            this.ReservedTimeGrid5.Name = "ReservedTimeGrid5";
            this.ReservedTimeGrid5.ReadOnly = true;
            this.ReservedTimeGrid5.RowTemplate.Height = 24;
            this.ReservedTimeGrid5.Size = new System.Drawing.Size(414, 200);
            this.ReservedTimeGrid5.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "StartTimeColumn";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "EndTimeColumn";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 404);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AddressComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinutesComboBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.HoursComboBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.ServiceComboBox);
            this.Controls.Add(this.ServiceLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddReserve);
            this.Name = "ReserveForm";
            this.Text = "Reserve";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid0)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedTimeGrid5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddReserve;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.ComboBox HoursComboBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.ComboBox MinutesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AddressComboBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView ReservedTimeGrid0;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ReservedTimeGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ReservedTimeGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView ReservedTimeGrid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView ReservedTimeGrid4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView ReservedTimeGrid5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}