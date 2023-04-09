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
    public partial class ClientLoginPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        public static string username;
        public static string user
        {
            get { return username; }
            set { username = value; }
        }
        public ClientLoginPage()
        {
            InitializeComponent();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            ClientRegistrationPage popup = new ClientRegistrationPage();
            popup.ShowDialog();
        }

        private void picBxLogin_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "Select * from CLIENT_ACCOUNT where CLIENT_USERNAME = '" + txtBxUsername.Text.Trim() + "' and CLIENT_PASSWORD = '" + txtBxPassword.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                user = txtBxUsername.Text;
                MessageBox.Show("login successful");
                //navigating to the main page
                HomePage page = new HomePage();
                Hide();
                page.ShowDialog();


            }
            else
            {
                MessageBox.Show("Invaild credentials, Username or Password incorrect");
            }


        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            ClientRegistrationPage registrationPage = new ClientRegistrationPage();
            registrationPage.ShowDialog();
        }
    }
}
