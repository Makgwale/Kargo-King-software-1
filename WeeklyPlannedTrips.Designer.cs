namespace Orange_Design_Login
{
    partial class WeeklyPlannedTrips
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
            this.dataGridViewrReport = new System.Windows.Forms.DataGridView();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWeekly = new ePOSOne.btnProduct.Button_WOC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDaily = new ePOSOne.btnProduct.Button_WOC();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewrReport
            // 
            this.dataGridViewrReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrReport.Location = new System.Drawing.Point(10, 129);
            this.dataGridViewrReport.Name = "dataGridViewrReport";
            this.dataGridViewrReport.Size = new System.Drawing.Size(1106, 352);
            this.dataGridViewrReport.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(255, 23);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(326, 23);
            this.lblHeading.TabIndex = 51;
            this.lblHeading.Text = "Daily/Weelky Planned Trips Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Start Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(389, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "End Date";
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.Color.Transparent;
            this.btnWeekly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWeekly.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnWeekly.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.btnWeekly.FlatAppearance.BorderSize = 0;
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.Location = new System.Drawing.Point(986, 497);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnWeekly.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnWeekly.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnWeekly.Size = new System.Drawing.Size(130, 36);
            this.btnWeekly.TabIndex = 56;
            this.btnWeekly.Text = "View Weekly";
            this.btnWeekly.TextColor = System.Drawing.Color.White;
            this.btnWeekly.UseVisualStyleBackColor = false;
            this.btnWeekly.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDaily);
            this.panel1.Controls.Add(this.btnWeekly);
            this.panel1.Controls.Add(this.dataGridViewrReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 547);
            this.panel1.TabIndex = 57;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDaily
            // 
            this.btnDaily.BackColor = System.Drawing.Color.Transparent;
            this.btnDaily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDaily.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDaily.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.btnDaily.FlatAppearance.BorderSize = 0;
            this.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaily.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.Location = new System.Drawing.Point(850, 497);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDaily.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDaily.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDaily.Size = new System.Drawing.Size(130, 36);
            this.btnDaily.TabIndex = 57;
            this.btnDaily.Text = "View Daily";
            this.btnDaily.TextColor = System.Drawing.Color.White;
            this.btnDaily.UseVisualStyleBackColor = false;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // WeeklyPlannedTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 547);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyPlannedTrips";
            this.Text = "WeeklyPlannedTrips";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewrReport;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Button_WOC btnWeekly;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC btnDaily;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}