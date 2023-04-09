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
    public partial class ClientRegistrationPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        int client = 5;
        public ClientRegistrationPage()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void ClientRegistrationPage_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            ClientLoginPage popup = new ClientLoginPage();
            popup.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ++client;
            //connecting to the database, entering input data into the database
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO CLIENT_ACCOUNT(CLIENT_ID,CLIENT_NAME, CLIENT_SURNAME, CLIENT_PHONE_NO, CLIENT_EMAIL,CLIENT_USERNAME,CLIENT_PASSWORD ,CLIENT_HOME_ADDRESS,COMPANY_NAME ) VALUES ('" + client+"','"+txtBxName.Text+"','"+txtBxSurname.Text+"','"+txtBxContact.Text+"','"+txtBxEmail.Text+"','" + txtBxUsername.Text + "','" + txtBxPassword.Text + "','"+txtBxAddress.Text+"','"+txtBxCompany.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registration Successfully Saved");
            HomePage page = new HomePage();
            page.ShowDialog();

           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
