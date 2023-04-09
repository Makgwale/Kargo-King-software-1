namespace Orange_Design_Login
{
    partial class AppointmentReport
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
            this.pnlAppointmentReport = new System.Windows.Forms.Panel();
            this.btnView = new ePOSOne.btnProduct.Button_WOC();
            this.dataGridViewAppointment = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxDateRange = new System.Windows.Forms.GroupBox();
            this.radBtnWeekly = new System.Windows.Forms.RadioButton();
            this.radBtnMonthly = new System.Windows.Forms.RadioButton();
            this.radBtnDaily = new System.Windows.Forms.RadioButton();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlAppointmentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            this.grpBxDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAppointmentReport
            // 
            this.pnlAppointmentReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAppointmentReport.Controls.Add(this.btnView);
            this.pnlAppointmentReport.Controls.Add(this.dataGridViewAppointment);
            this.pnlAppointmentReport.Controls.Add(this.dateTimePicker2);
            this.pnlAppointmentReport.Controls.Add(this.label2);
            this.pnlAppointmentReport.Controls.Add(this.dateTimePicker1);
            this.pnlAppointmentReport.Controls.Add(this.label1);
            this.pnlAppointmentReport.Controls.Add(this.grpBxDateRange);
            this.pnlAppointmentReport.Controls.Add(this.lblHeading);
            this.pnlAppointmentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAppointmentReport.Location = new System.Drawing.Point(0, 0);
            this.pnlAppointmentReport.Name = "pnlAppointmentReport";
            this.pnlAppointmentReport.Size = new System.Drawing.Size(1158, 547);
            this.pnlAppointmentReport.TabIndex = 0;
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
            this.btnView.Location = new System.Drawing.Point(1003, 457);
            this.btnView.Name = "btnView";
            this.btnView.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnView.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnView.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnView.Size = new System.Drawing.Size(114, 45);
            this.btnView.TabIndex = 89;
            this.btnView.Text = "View";
            this.btnView.TextColor = System.Drawing.Color.White;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridViewAppointment
            // 
            this.dataGridViewAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointment.Location = new System.Drawing.Point(25, 181);
            this.dataGridViewAppointment.Name = "dataGridViewAppointment";
            this.dataGridViewAppointment.Size = new System.Drawing.Size(1092, 259);
            this.dataGridViewAppointment.TabIndex = 88;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(562, 143);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "End Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Start Date";
            // 
            // grpBxDateRange
            // 
            this.grpBxDateRange.Controls.Add(this.radBtnWeekly);
            this.grpBxDateRange.Controls.Add(this.radBtnMonthly);
            this.grpBxDateRange.Controls.Add(this.radBtnDaily);
            this.grpBxDateRange.Location = new System.Drawing.Point(10, 74);
            this.grpBxDateRange.Name = "grpBxDateRange";
            this.grpBxDateRange.Size = new System.Drawing.Size(200, 89);
            this.grpBxDateRange.TabIndex = 83;
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
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(156, 22);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(440, 23);
            this.lblHeading.TabIndex = 82;
            this.lblHeading.Text = "Daily/Weekly/Monthly Service Appointment List";
            // 
            // AppointmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 547);
            this.Controls.Add(this.pnlAppointmentReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentReport";
            this.Text = "AppointmentReport";
            this.pnlAppointmentReport.ResumeLayout(false);
            this.pnlAppointmentReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            this.grpBxDateRange.ResumeLayout(false);
            this.grpBxDateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAppointmentReport;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpBxDateRange;
        private System.Windows.Forms.RadioButton radBtnWeekly;
        private System.Windows.Forms.RadioButton radBtnMonthly;
        private System.Windows.Forms.RadioButton radBtnDaily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridViewAppointment;
        private ePOSOne.btnProduct.Button_WOC btnView;
    }
}