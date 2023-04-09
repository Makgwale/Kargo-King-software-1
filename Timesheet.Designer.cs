namespace Orange_Design_Login
{
    partial class Timesheet
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
            this.pnlTimesheet = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBxTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtBxPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtBxFullname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtBxExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.cmbBxType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBxHoursWorked = new System.Windows.Forms.TextBox();
            this.txtBxPayRate = new System.Windows.Forms.TextBox();
            this.txtBxPay = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnSave = new ePOSOne.btnProduct.Button_WOC();
            this.btnEdit = new ePOSOne.btnProduct.Button_WOC();
            this.pnlTimesheet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTimesheet
            // 
            this.pnlTimesheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimesheet.Controls.Add(this.groupBox1);
            this.pnlTimesheet.Controls.Add(this.cmbEmployeeID);
            this.pnlTimesheet.Controls.Add(this.lblEmployeeID);
            this.pnlTimesheet.Controls.Add(this.txtBxExtra);
            this.pnlTimesheet.Controls.Add(this.lblExtra);
            this.pnlTimesheet.Controls.Add(this.btnSave);
            this.pnlTimesheet.Controls.Add(this.btnEdit);
            this.pnlTimesheet.Controls.Add(this.cmbBxType);
            this.pnlTimesheet.Controls.Add(this.dateTimePicker1);
            this.pnlTimesheet.Controls.Add(this.txtBxHoursWorked);
            this.pnlTimesheet.Controls.Add(this.txtBxPayRate);
            this.pnlTimesheet.Controls.Add(this.txtBxPay);
            this.pnlTimesheet.Controls.Add(this.lblDate);
            this.pnlTimesheet.Controls.Add(this.lblHoursWorked);
            this.pnlTimesheet.Controls.Add(this.lblPayRate);
            this.pnlTimesheet.Controls.Add(this.lblPay);
            this.pnlTimesheet.Controls.Add(this.lblEmployeeType);
            this.pnlTimesheet.Controls.Add(this.lblHeading);
            this.pnlTimesheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimesheet.Location = new System.Drawing.Point(0, 0);
            this.pnlTimesheet.Name = "pnlTimesheet";
            this.pnlTimesheet.Size = new System.Drawing.Size(1158, 547);
            this.pnlTimesheet.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBxTax);
            this.groupBox1.Controls.Add(this.lblTax);
            this.groupBox1.Controls.Add(this.txtBxPosition);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.txtBxFullname);
            this.groupBox1.Controls.Add(this.lblFullname);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(564, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 198);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // txtBxTax
            // 
            this.txtBxTax.Location = new System.Drawing.Point(138, 141);
            this.txtBxTax.Name = "txtBxTax";
            this.txtBxTax.Size = new System.Drawing.Size(185, 21);
            this.txtBxTax.TabIndex = 22;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(6, 148);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(48, 16);
            this.lblTax.TabIndex = 21;
            this.lblTax.Text = "Tax No";
            // 
            // txtBxPosition
            // 
            this.txtBxPosition.Location = new System.Drawing.Point(138, 96);
            this.txtBxPosition.Name = "txtBxPosition";
            this.txtBxPosition.Size = new System.Drawing.Size(185, 21);
            this.txtBxPosition.TabIndex = 20;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(6, 103);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(110, 16);
            this.lblPosition.TabIndex = 19;
            this.lblPosition.Text = "Employee position";
            // 
            // txtBxFullname
            // 
            this.txtBxFullname.Location = new System.Drawing.Point(135, 51);
            this.txtBxFullname.Name = "txtBxFullname";
            this.txtBxFullname.Size = new System.Drawing.Size(185, 21);
            this.txtBxFullname.TabIndex = 18;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(6, 51);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(119, 16);
            this.lblFullname.TabIndex = 17;
            this.lblFullname.Text = "Employee Fullname";
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(304, 93);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployeeID.TabIndex = 105;
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(206, 98);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(84, 16);
            this.lblEmployeeID.TabIndex = 104;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // txtBxExtra
            // 
            this.txtBxExtra.Location = new System.Drawing.Point(304, 311);
            this.txtBxExtra.Name = "txtBxExtra";
            this.txtBxExtra.Size = new System.Drawing.Size(200, 20);
            this.txtBxExtra.TabIndex = 103;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra.Location = new System.Drawing.Point(206, 317);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(71, 16);
            this.lblExtra.TabIndex = 102;
            this.lblExtra.Text = "Extra Time";
            // 
            // cmbBxType
            // 
            this.cmbBxType.FormattingEnabled = true;
            this.cmbBxType.Items.AddRange(new object[] {
            "Mechanic",
            "Driver"});
            this.cmbBxType.Location = new System.Drawing.Point(304, 136);
            this.cmbBxType.Name = "cmbBxType";
            this.cmbBxType.Size = new System.Drawing.Size(200, 21);
            this.cmbBxType.TabIndex = 99;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(304, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 98;
            // 
            // txtBxHoursWorked
            // 
            this.txtBxHoursWorked.Location = new System.Drawing.Point(304, 234);
            this.txtBxHoursWorked.Name = "txtBxHoursWorked";
            this.txtBxHoursWorked.Size = new System.Drawing.Size(200, 20);
            this.txtBxHoursWorked.TabIndex = 97;
            // 
            // txtBxPayRate
            // 
            this.txtBxPayRate.Location = new System.Drawing.Point(304, 274);
            this.txtBxPayRate.Name = "txtBxPayRate";
            this.txtBxPayRate.Size = new System.Drawing.Size(200, 20);
            this.txtBxPayRate.TabIndex = 96;
            // 
            // txtBxPay
            // 
            this.txtBxPay.Enabled = false;
            this.txtBxPay.Location = new System.Drawing.Point(304, 356);
            this.txtBxPay.Name = "txtBxPay";
            this.txtBxPay.Size = new System.Drawing.Size(200, 20);
            this.txtBxPay.TabIndex = 95;
            this.txtBxPay.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(206, 189);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 16);
            this.lblDate.TabIndex = 94;
            this.lblDate.Text = "Date";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(206, 235);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(88, 16);
            this.lblHoursWorked.TabIndex = 93;
            this.lblHoursWorked.Text = "Hours Worked";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(206, 275);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(59, 16);
            this.lblPayRate.TabIndex = 92;
            this.lblPayRate.Text = "Pay Rate";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Enabled = false;
            this.lblPay.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(206, 362);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(62, 16);
            this.lblPay.TabIndex = 91;
            this.lblPay.Text = "Total Pay";
            this.lblPay.Visible = false;
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeType.Location = new System.Drawing.Point(206, 141);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(92, 16);
            this.lblEmployeeType.TabIndex = 90;
            this.lblEmployeeType.Text = "Employee Type";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(437, 19);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(197, 23);
            this.lblHeading.TabIndex = 84;
            this.lblHeading.Text = "Employee Timesheet";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(419, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSave.Size = new System.Drawing.Size(139, 50);
            this.btnSave.TabIndex = 101;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEdit.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(564, 425);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnEdit.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnEdit.Size = new System.Drawing.Size(139, 50);
            this.btnEdit.TabIndex = 100;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Timesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 547);
            this.Controls.Add(this.pnlTimesheet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Timesheet";
            this.Text = "Timesheet";
            this.pnlTimesheet.ResumeLayout(false);
            this.pnlTimesheet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTimesheet;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cmbBxType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBxHoursWorked;
        private System.Windows.Forms.TextBox txtBxPayRate;
        private System.Windows.Forms.TextBox txtBxPay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblEmployeeType;
        private ePOSOne.btnProduct.Button_WOC btnSave;
        private ePOSOne.btnProduct.Button_WOC btnEdit;
        private System.Windows.Forms.TextBox txtBxExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBxFullname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox txtBxPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtBxTax;
        private System.Windows.Forms.Label lblTax;
    }
}