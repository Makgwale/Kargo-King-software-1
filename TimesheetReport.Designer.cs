namespace Orange_Design_Login
{
    partial class TimesheetReport
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnView = new ePOSOne.btnProduct.Button_WOC();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxDateRange = new System.Windows.Forms.GroupBox();
            this.radBtnWeekly = new System.Windows.Forms.RadioButton();
            this.radBtnMonthly = new System.Windows.Forms.RadioButton();
            this.radBtnDaily = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBxDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(189, 25);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(401, 23);
            this.lblHeading.TabIndex = 53;
            this.lblHeading.Text = "Daily/Weelky/Monthly Employee Timesheet";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbEmployeeID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grpBxDateRange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 547);
            this.panel1.TabIndex = 54;
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(305, 77);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployeeID.TabIndex = 106;
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(220, 82);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 16);
            this.lblID.TabIndex = 68;
            this.lblID.Text = "EmployeeID";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnView.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(981, 478);
            this.btnView.Name = "btnView";
            this.btnView.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnView.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnView.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnView.Size = new System.Drawing.Size(138, 39);
            this.btnView.TabIndex = 67;
            this.btnView.Text = "View";
            this.btnView.TextColor = System.Drawing.Color.White;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1109, 291);
            this.dataGridView1.TabIndex = 66;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(594, 116);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(305, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Start Date";
            // 
            // grpBxDateRange
            // 
            this.grpBxDateRange.Controls.Add(this.radBtnWeekly);
            this.grpBxDateRange.Controls.Add(this.radBtnMonthly);
            this.grpBxDateRange.Controls.Add(this.radBtnDaily);
            this.grpBxDateRange.Location = new System.Drawing.Point(10, 59);
            this.grpBxDateRange.Name = "grpBxDateRange";
            this.grpBxDateRange.Size = new System.Drawing.Size(200, 89);
            this.grpBxDateRange.TabIndex = 61;
            this.grpBxDateRange.TabStop = false;
            this.grpBxDateRange.Text = "Date Range";
            // 
            // radBtnWeekly
            // 
            this.radBtnWeekly.AutoSize = true;
            this.radBtnWeekly.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnWeekly.Location = new System.Drawing.Point(6, 38);
            this.radBtnWeekly.Name = "radBtnWeekly";
            this.radBtnWeekly.Size = new System.Drawing.Size(67, 20);
            this.radBtnWeekly.TabIndex = 58;
            this.radBtnWeekly.TabStop = true;
            this.radBtnWeekly.Text = "Weekly";
            this.radBtnWeekly.UseVisualStyleBackColor = true;
            // 
            // radBtnMonthly
            // 
            this.radBtnMonthly.AutoSize = true;
            this.radBtnMonthly.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnMonthly.Location = new System.Drawing.Point(6, 55);
            this.radBtnMonthly.Name = "radBtnMonthly";
            this.radBtnMonthly.Size = new System.Drawing.Size(73, 20);
            this.radBtnMonthly.TabIndex = 57;
            this.radBtnMonthly.TabStop = true;
            this.radBtnMonthly.Text = "Monthly";
            this.radBtnMonthly.UseVisualStyleBackColor = true;
            // 
            // radBtnDaily
            // 
            this.radBtnDaily.AutoSize = true;
            this.radBtnDaily.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnDaily.Location = new System.Drawing.Point(6, 19);
            this.radBtnDaily.Name = "radBtnDaily";
            this.radBtnDaily.Size = new System.Drawing.Size(56, 20);
            this.radBtnDaily.TabIndex = 55;
            this.radBtnDaily.TabStop = true;
            this.radBtnDaily.Text = "Daily";
            this.radBtnDaily.UseVisualStyleBackColor = true;
            // 
            // TimesheetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 547);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimesheetReport";
            this.Text = "TimesheetReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBxDateRange.ResumeLayout(false);
            this.grpBxDateRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC btnView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxDateRange;
        private System.Windows.Forms.RadioButton radBtnWeekly;
        private System.Windows.Forms.RadioButton radBtnMonthly;
        private System.Windows.Forms.RadioButton radBtnDaily;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
    }
}