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
    public partial class AccountPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();
        public AccountPage()
        {
            InitializeComponent();
            
            //datagridView1 properties;
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Surname";
            dataGridView1.Columns[3].Name = "PhoneNO";
            dataGridView1.Columns[4].Name = "Email"; /*(ProgrammingWizards TV, 2016)*/
            dataGridView1.Columns[5].Name = "Username";
            dataGridView1.Columns[6].Name = "Password";
            dataGridView1.Columns[7].Name = "HomeAddress";
            dataGridView1.Columns[8].Name = "CompanyName";
           

            //automatically resize datagridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/
            //Selection Mode
            //Selecting the whole row
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        //populate datagridview
        private void Populate(string id, string name, string surname, string phone, string email, string username, string password, string address,string company)
        {
            dataGridView1.Rows.Add(id, name, surname, phone, email,username, password, address, company);
        }
        //Retrieving data from the database
        private void Retrieve()
        {
            dataGridView1.Rows.Clear();
            //sql statements
            String sql = "SELECT * FROM CLIENT_ACCOUNT ";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                dataAdapter.Fill(dataTable);
                //Looping through the datatable
                foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(),row[8].ToString());
                }

                con.Close();
                //clearing the datatable
                dataTable.Rows.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Retrieve();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            // adding data to the datagrid
            txtBxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtBxName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtBxSurname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();/*(ProgrammingWizards TV, 2016)*/
            txtBxPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtBxEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtBxUsername.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtBxPassword.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            rchTxtBxAddress.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtBxCompanyName.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //sql statements
            string sql = "UPDATE CLIENT_ACCOUNT SET CLIENT_ID = "+txtBxID.Text+",CLIENT_NAME ='" + txtBxName.Text + "',  CLIENT_SURNAME = '" + txtBxSurname.Text + "', CLIENT_PHONE_NO = '" + txtBxPhone.Text + "', CLIENT_EMAIL = '" + txtBxEmail.Text + "',CLIENT_USERNAME = '" + txtBxUsername.Text + "', CLIENT_PASSWORD = '" + txtBxPassword.Text + "', CLIENT_HOME_ADDRESS = '" + rchTxtBxAddress.Text + "',COMPANY_NAME = '"+txtBxCompanyName.Text+"' WHERE CLIENT_ID = "+txtBxID.Text+ " ";

            cmd = new SqlCommand(sql, con);/*(ProgrammingWizards TV, 2016)*/

            //Open con, update and retrieve datagridView1
            try
            {
                con.Open();
                dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/
                dataAdapter.UpdateCommand = con.CreateCommand();
                dataAdapter.UpdateCommand.CommandText = sql;

                if (dataAdapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    //Clear();
                    MessageBox.Show("Update successful");
                }

                con.Close();
                //refresh datagridView1
                Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();

            }
        }
    }
}
