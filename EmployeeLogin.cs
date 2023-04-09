using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Orange_Design_Login
{
    public partial class EmployeeLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        public EmployeeLogin()
        {
            InitializeComponent();
        }
        public static string username;
        public static string user
        {
            get { return username; }
            set { username = value; }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void lblLogin_Click(object sender, EventArgs e)
        {
            //Redirects the login page
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbBxAccess.SelectedIndex == 0)
            {
                string query = "Select * from EMPLOYEE_DETAILS where Username = '" + txtBxUsername.Text.Trim() + "' and Password = '" + txtBxPassword.Text.Trim() + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    //navigating to the main page
                    user = cmbBxAccess.SelectedItem.ToString();
                    EmployeeHomePage homePage = new EmployeeHomePage();
                    Hide();
                    homePage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invaild credentials, Username or Password incorrect");
                }
            }

            if (cmbBxAccess.SelectedIndex == 1)
            {
                string query = "Select * from EMPLOYEE_DETAILS where Username = '" + txtBxUsername.Text.Trim() + "' and Password = '" + txtBxPassword.Text.Trim() + "' and POSITION = '"+cmbBxAccess.Text.Trim()+"'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    //navigating to the main page
                    user = cmbBxAccess.SelectedItem.ToString();
                    EmployeeHomePage homePage = new EmployeeHomePage();
                    Hide();
                    homePage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invaild credentials, Username or Password incorrect");
                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           //Closing the application
            Environment.Exit(0);
        }
    }
}
