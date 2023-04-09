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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientLoginPage loginPage = new ClientLoginPage();
            Hide();
            loginPage.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeLogin login = new EmployeeLogin();
            Hide();
            login.ShowDialog();
        }
    }
}
