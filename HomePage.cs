using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_Design_Login
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChild(new AccountPage());
            
        }
        private Form activeForm = null;
        private void openChild(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChild(new OrderPage());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            openChild(new PaymentPage());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            openChild(new OrderHistory());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChild(new OurHelpCenter());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
