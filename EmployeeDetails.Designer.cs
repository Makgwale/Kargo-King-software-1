namespace Orange_Design_Login
{
    partial class EmployeeDetails
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
            this.grpBxDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.txtBxFullname = new System.Windows.Forms.TextBox();
            this.txtBxContact = new System.Windows.Forms.TextBox();
            this.txtBxAlternative = new System.Windows.Forms.TextBox();
            this.txtBxPosition = new System.Windows.Forms.TextBox();
            this.txtBxTax = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxResidential = new System.Windows.Forms.TextBox();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblAlternative = new System.Windows.Forms.Label();
            this.lblResidential = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnEdit = new ePOSOne.btnProduct.Button_WOC();
            this.btnSave = new ePOSOne.btnProduct.Button_WOC();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnClear = new ePOSOne.btnProduct.Button_WOC();
            this.btnView = new ePOSOne.btnProduct.Button_WOC();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxDetails
            // 
            this.grpBxDetails.Controls.Add(this.txtBxUsername);
            this.grpBxDetails.Controls.Add(this.txtBxPassword);
            this.grpBxDetails.Controls.Add(this.label1);
            this.grpBxDetails.Controls.Add(this.label2);
            this.grpBxDetails.Controls.Add(this.dataGridViewEmployee);
            this.grpBxDetails.Controls.Add(this.txtBxFullname);
            this.grpBxDetails.Controls.Add(this.txtBxContact);
            this.grpBxDetails.Controls.Add(this.txtBxAlternative);
            this.grpBxDetails.Controls.Add(this.txtBxPosition);
            this.grpBxDetails.Controls.Add(this.txtBxTax);
            this.grpBxDetails.Controls.Add(this.txtBxEmail);
            this.grpBxDetails.Controls.Add(this.txtBxResidential);
            this.grpBxDetails.Controls.Add(this.txtBxID);
            this.grpBxDetails.Controls.Add(this.lblTax);
            this.grpBxDetails.Controls.Add(this.lblPosition);
            this.grpBxDetails.Controls.Add(this.lblAlternative);
            this.grpBxDetails.Controls.Add(this.lblResidential);
            this.grpBxDetails.Controls.Add(this.lblEmail);
            this.grpBxDetails.Controls.Add(this.lblContact);
            this.grpBxDetails.Controls.Add(this.lblFullname);
            this.grpBxDetails.Controls.Add(this.lblID);
            this.grpBxDetails.Location = new System.Drawing.Point(37, 26);
            this.grpBxDetails.Name = "grpBxDetails";
            this.grpBxDetails.Size = new System.Drawing.Size(1001, 415);
            this.grpBxDetails.TabIndex = 0;
            this.grpBxDetails.TabStop = false;
            this.grpBxDetails.Text = "Employee Info";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(53, 237);
            this.dataGridViewEmployee.MultiSelect = false;
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(895, 150);
            this.dataGridViewEmployee.TabIndex = 17;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            this.dataGridViewEmployee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewEmployee_MouseClick);
            // 
            // txtBxFullname
            // 
            this.txtBxFullname.Location = new System.Drawing.Point(297, 105);
            this.txtBxFullname.Name = "txtBxFullname";
            this.txtBxFullname.Size = new System.Drawing.Size(185, 20);
            this.txtBxFullname.TabIndex = 16;
            // 
            // txtBxContact
            // 
            this.txtBxContact.Location = new System.Drawing.Point(297, 150);
            this.txtBxContact.Name = "txtBxContact";
            this.txtBxContact.Size = new System.Drawing.Size(185, 20);
            this.txtBxContact.TabIndex = 15;
            // 
            // txtBxAlternative
            // 
            this.txtBxAlternative.Location = new System.Drawing.Point(297, 210);
            this.txtBxAlternative.Name = "txtBxAlternative";
            this.txtBxAlternative.Size = new System.Drawing.Size(185, 20);
            this.txtBxAlternative.TabIndex = 14;
            // 
            // txtBxPosition
            // 
            this.txtBxPosition.Location = new System.Drawing.Point(634, 53);
            this.txtBxPosition.Name = "txtBxPosition";
            this.txtBxPosition.Size = new System.Drawing.Size(185, 20);
            this.txtBxPosition.TabIndex = 13;
            // 
            // txtBxTax
            // 
            this.txtBxTax.Location = new System.Drawing.Point(634, 98);
            this.txtBxTax.Name = "txtBxTax";
            this.txtBxTax.Size = new System.Drawing.Size(185, 20);
            this.txtBxTax.TabIndex = 12;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(634, 150);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(185, 20);
            this.txtBxEmail.TabIndex = 11;
            // 
            // txtBxResidential
            // 
            this.txtBxResidential.Location = new System.Drawing.Point(634, 210);
            this.txtBxResidential.Name = "txtBxResidential";
            this.txtBxResidential.Size = new System.Drawing.Size(185, 20);
            this.txtBxResidential.TabIndex = 9;
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(297, 53);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(185, 20);
            this.txtBxID.TabIndex = 8;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(518, 105);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(42, 13);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax No";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(518, 60);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(92, 13);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Employee position";
            // 
            // lblAlternative
            // 
            this.lblAlternative.AutoSize = true;
            this.lblAlternative.Location = new System.Drawing.Point(169, 217);
            this.lblAlternative.Name = "lblAlternative";
            this.lblAlternative.Size = new System.Drawing.Size(97, 13);
            this.lblAlternative.TabIndex = 5;
            this.lblAlternative.Text = "Alternative Number";
            // 
            // lblResidential
            // 
            this.lblResidential.AutoSize = true;
            this.lblResidential.Location = new System.Drawing.Point(518, 217);
            this.lblResidential.Name = "lblResidential";
            this.lblResidential.Size = new System.Drawing.Size(103, 13);
            this.lblResidential.TabIndex = 4;
            this.lblResidential.Text = " Residential Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(518, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(168, 157);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(110, 13);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Employee Contact No";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(168, 105);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(98, 13);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.Text = "Employee Fullname";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(168, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Employee ID";
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
            this.btnEdit.Location = new System.Drawing.Point(558, 447);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnEdit.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnEdit.Size = new System.Drawing.Size(114, 28);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnSave.Location = new System.Drawing.Point(318, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSave.Size = new System.Drawing.Size(114, 28);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Location = new System.Drawing.Point(34, 483);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(221, 13);
            this.lblAlert.TabIndex = 33;
            this.lblAlert.Text = "NB.Section is reserved for the office manager";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnClear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(678, 447);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnClear.Size = new System.Drawing.Size(114, 28);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnView.Location = new System.Drawing.Point(438, 447);
            this.btnView.Name = "btnView";
            this.btnView.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnView.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnView.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnView.Size = new System.Drawing.Size(114, 28);
            this.btnView.TabIndex = 36;
            this.btnView.Text = "View";
            this.btnView.TextColor = System.Drawing.Color.White;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(297, 16);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(185, 20);
            this.txtBxUsername.TabIndex = 21;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(634, 9);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(185, 20);
            this.txtBxPassword.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 547);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpBxDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            this.grpBxDetails.ResumeLayout(false);
            this.grpBxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxDetails;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TextBox txtBxFullname;
        private System.Windows.Forms.TextBox txtBxContact;
        private System.Windows.Forms.TextBox txtBxAlternative;
        private System.Windows.Forms.TextBox txtBxPosition;
        private System.Windows.Forms.TextBox txtBxTax;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxResidential;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblAlternative;
        private System.Windows.Forms.Label lblResidential;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblID;
        private ePOSOne.btnProduct.Button_WOC btnEdit;
        private ePOSOne.btnProduct.Button_WOC btnSave;
        private System.Windows.Forms.Label lblAlert;
        private ePOSOne.btnProduct.Button_WOC btnClear;
        private ePOSOne.btnProduct.Button_WOC btnView;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}