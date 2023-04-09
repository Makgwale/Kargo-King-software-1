namespace Orange_Design_Login
{
    partial class PaymentPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.cmbBxType = new System.Windows.Forms.ComboBox();
            this.txtBxCardName = new System.Windows.Forms.TextBox();
            this.txtBxCardNo = new System.Windows.Forms.TextBox();
            this.txtBxCVC = new System.Windows.Forms.TextBox();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtBxMonth = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.btnConfirm = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter payment info";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(301, 94);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(109, 18);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Payment Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(301, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Card Name";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVC.Location = new System.Drawing.Point(303, 258);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(65, 18);
            this.lblCVC.TabIndex = 4;
            this.lblCVC.Text = "CVC No";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.Location = new System.Drawing.Point(301, 208);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(67, 18);
            this.lblCardNo.TabIndex = 6;
            this.lblCardNo.Text = "Card No";
            // 
            // cmbBxType
            // 
            this.cmbBxType.FormattingEnabled = true;
            this.cmbBxType.Items.AddRange(new object[] {
            "Full Payment",
            "Deposit"});
            this.cmbBxType.Location = new System.Drawing.Point(449, 91);
            this.cmbBxType.Name = "cmbBxType";
            this.cmbBxType.Size = new System.Drawing.Size(176, 21);
            this.cmbBxType.TabIndex = 7;
            // 
            // txtBxCardName
            // 
            this.txtBxCardName.Location = new System.Drawing.Point(449, 148);
            this.txtBxCardName.Name = "txtBxCardName";
            this.txtBxCardName.Size = new System.Drawing.Size(176, 20);
            this.txtBxCardName.TabIndex = 9;
            // 
            // txtBxCardNo
            // 
            this.txtBxCardNo.Location = new System.Drawing.Point(449, 209);
            this.txtBxCardNo.Name = "txtBxCardNo";
            this.txtBxCardNo.Size = new System.Drawing.Size(176, 20);
            this.txtBxCardNo.TabIndex = 10;
            // 
            // txtBxCVC
            // 
            this.txtBxCVC.Location = new System.Drawing.Point(449, 259);
            this.txtBxCVC.Name = "txtBxCVC";
            this.txtBxCVC.Size = new System.Drawing.Size(176, 20);
            this.txtBxCVC.TabIndex = 11;
            // 
            // pnlPayment
            // 
            this.pnlPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Controls.Add(this.textBox1);
            this.pnlPayment.Controls.Add(this.cmbBxType);
            this.pnlPayment.Controls.Add(this.txtBxCardName);
            this.pnlPayment.Controls.Add(this.lblType);
            this.pnlPayment.Controls.Add(this.txtBxCardNo);
            this.pnlPayment.Controls.Add(this.txtBxCVC);
            this.pnlPayment.Controls.Add(this.lblName);
            this.pnlPayment.Controls.Add(this.lblCardNo);
            this.pnlPayment.Controls.Add(this.label2);
            this.pnlPayment.Controls.Add(this.lblCVC);
            this.pnlPayment.Controls.Add(this.lblYear);
            this.pnlPayment.Controls.Add(this.lblMonth);
            this.pnlPayment.Controls.Add(this.textBox2);
            this.pnlPayment.Controls.Add(this.txtBxMonth);
            this.pnlPayment.Controls.Add(this.lblExpiryDate);
            this.pnlPayment.Location = new System.Drawing.Point(36, 30);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(910, 431);
            this.pnlPayment.TabIndex = 12;
            this.pnlPayment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPayment_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblYear.Location = new System.Drawing.Point(572, 310);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMonth.Location = new System.Drawing.Point(460, 310);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(36, 13);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "month";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(560, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // txtBxMonth
            // 
            this.txtBxMonth.Location = new System.Drawing.Point(447, 307);
            this.txtBxMonth.Name = "txtBxMonth";
            this.txtBxMonth.Size = new System.Drawing.Size(100, 20);
            this.txtBxMonth.TabIndex = 1;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(303, 305);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(91, 18);
            this.lblExpiryDate.TabIndex = 0;
            this.lblExpiryDate.Text = "Expiry date";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirm.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnConfirm.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(475, 485);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnConfirm.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnConfirm.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnConfirm.Size = new System.Drawing.Size(188, 41);
            this.btnConfirm.TabIndex = 30;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "To finalise your order, you may be guided to your bank\'s \r\n3D secure process to a" +
    "uthenticate your details";
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 547);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentPage";
            this.Text = "PaymentPage";
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.ComboBox cmbBxType;
        private System.Windows.Forms.TextBox txtBxCardName;
        private System.Windows.Forms.TextBox txtBxCardNo;
        private System.Windows.Forms.TextBox txtBxCVC;
        private System.Windows.Forms.Panel pnlPayment;
        private ePOSOne.btnProduct.Button_WOC btnConfirm;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtBxMonth;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}