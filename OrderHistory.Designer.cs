namespace Orange_Design_Login
{
    partial class OrderHistory
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
            this.lblHistory = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lnkLblViewAll = new System.Windows.Forms.LinkLabel();
            this.pnlOrderHistory = new System.Windows.Forms.Panel();
            this.lblclient = new System.Windows.Forms.Label();
            this.btnView = new ePOSOne.btnProduct.Button_WOC();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.pnlOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(9, 76);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(169, 18);
            this.lblHistory.TabIndex = 2;
            this.lblHistory.Text = "Order History For the:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lnkLblViewAll
            // 
            this.lnkLblViewAll.AutoSize = true;
            this.lnkLblViewAll.Location = new System.Drawing.Point(8, 224);
            this.lnkLblViewAll.Name = "lnkLblViewAll";
            this.lnkLblViewAll.Size = new System.Drawing.Size(257, 13);
            this.lnkLblViewAll.TabIndex = 31;
            this.lnkLblViewAll.TabStop = true;
            this.lnkLblViewAll.Text = "If you would like to view all previous orders click here";
            this.lnkLblViewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblViewAll_LinkClicked);
            // 
            // pnlOrderHistory
            // 
            this.pnlOrderHistory.BackColor = System.Drawing.Color.White;
            this.pnlOrderHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderHistory.Controls.Add(this.lblclient);
            this.pnlOrderHistory.Controls.Add(this.dateTimePicker1);
            this.pnlOrderHistory.Controls.Add(this.btnView);
            this.pnlOrderHistory.Controls.Add(this.lnkLblViewAll);
            this.pnlOrderHistory.Controls.Add(this.dataGridViewOrders);
            this.pnlOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderHistory.Name = "pnlOrderHistory";
            this.pnlOrderHistory.Size = new System.Drawing.Size(1209, 547);
            this.pnlOrderHistory.TabIndex = 32;
            this.pnlOrderHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrderHistory_Paint);
            // 
            // lblclient
            // 
            this.lblclient.AutoSize = true;
            this.lblclient.Location = new System.Drawing.Point(11, 129);
            this.lblclient.Name = "lblclient";
            this.lblclient.Size = new System.Drawing.Size(35, 13);
            this.lblclient.TabIndex = 32;
            this.lblclient.Text = "label1";
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
            this.btnView.Location = new System.Drawing.Point(11, 193);
            this.btnView.Name = "btnView";
            this.btnView.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnView.OnHoverButtonColor = System.Drawing.Color.PaleGoldenrod;
            this.btnView.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnView.Size = new System.Drawing.Size(154, 28);
            this.btnView.TabIndex = 30;
            this.btnView.Text = "View";
            this.btnView.TextColor = System.Drawing.Color.White;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(304, 42);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(848, 457);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1209, 547);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.pnlOrderHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.pnlOrderHistory.ResumeLayout(false);
            this.pnlOrderHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ePOSOne.btnProduct.Button_WOC btnView;
        private System.Windows.Forms.LinkLabel lnkLblViewAll;
        private System.Windows.Forms.Panel pnlOrderHistory;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label lblclient;
    }
}