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
    public partial class EmployeeDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();
        public EmployeeDetails()
        {
            InitializeComponent();

            //datagridView1 properties;
            dataGridViewEmployee.ColumnCount = 10;
            dataGridViewEmployee.Columns[0].Name = "ID";
            dataGridViewEmployee.Columns[1].Name = "FullName";
            dataGridViewEmployee.Columns[2].Name = "ContactNo";
            dataGridViewEmployee.Columns[3].Name = "AlternativeNumber";
            dataGridViewEmployee.Columns[4].Name = "Position"; /*(ProgrammingWizards TV, 2016)*/
            dataGridViewEmployee.Columns[5].Name = "TaxNo";
            dataGridViewEmployee.Columns[6].Name = "Email";
            dataGridViewEmployee.Columns[7].Name = "ResidentialAddress";
            dataGridViewEmployee.Columns[8].Name = "Username";
            dataGridViewEmployee.Columns[9].Name = "Password";

            //automatically resize datagridView
            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/

            //Selection Mode
            //Selecting the whole row
            dataGridViewEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployee.MultiSelect = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //connecting to the database, entering input data into the database
            SqlCommand cmd = new SqlCommand(@"INSERT INTO EMPLOYEE_DETAILS(EMPLOYEE_ID, FULLNAME , CONTACT_NO, ALTERNATIVE_NUMBER,POSITION , TAX_NO, EMAIL, RESIDENTIAL_ADDRESS, Username, Password) 
            VALUES ('" + txtBxID.Text + "','" + txtBxFullname.Text + "', '" + txtBxContact.Text + "', '" + txtBxAlternative.Text + "', '" + txtBxPosition.Text + "', '" + txtBxTax.Text + "', '" + txtBxEmail.Text + "', '" + txtBxResidential.Text + "','"+txtBxUsername.Text+"' ,'"+ txtBxPassword.Text+"')", con);
            con.Open();
          
            //Opening our connection and inserting data
            try
            {
               
                if (cmd.ExecuteNonQuery() > 0)/*(ProgrammingWizards TV, 2016)*/
                {
                    Clear();
                    MessageBox.Show("Employee Successfully Saved, \nTo make changes the select employee on the table below then make the changes in the textboxes \nThen click Edit...");
                }

                con.Close();
                Retrieve();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            con.Close();
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //populate datagridview
        private void Populate(string id, string name, string contact, string alternative, string position, string tax, string email, string address, string username, string password)
        {
            dataGridViewEmployee.Rows.Add(id, name, contact, alternative, position, tax, email, address, username, password);
        }
        //Retrieving data from the database
        private void Retrieve()
        {
            dataGridViewEmployee.Rows.Clear();
            //sql statements
            String sql = "SELECT * FROM EMPLOYEE_DETAILS ";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                dataAdapter.Fill(dataTable);
                //Looping through the datatable
                foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(),row[9].ToString());
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

        private void dataGridViewEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            //adding data to the datagrid
            txtBxID.Text = dataGridViewEmployee.SelectedRows[0].Cells[0].Value.ToString();
            txtBxFullname.Text = dataGridViewEmployee.SelectedRows[0].Cells[1].Value.ToString();
            txtBxContact.Text = dataGridViewEmployee.SelectedRows[0].Cells[2].Value.ToString();/*(ProgrammingWizards TV, 2016)*/
            txtBxAlternative.Text = dataGridViewEmployee.SelectedRows[0].Cells[3].Value.ToString();
            txtBxPosition.Text = dataGridViewEmployee.SelectedRows[0].Cells[4].Value.ToString();
            txtBxTax.Text = dataGridViewEmployee.SelectedRows[0].Cells[5].Value.ToString();
            txtBxEmail.Text = dataGridViewEmployee.SelectedRows[0].Cells[6].Value.ToString();
            txtBxResidential.Text = dataGridViewEmployee.SelectedRows[0].Cells[7].Value.ToString();
            txtBxUsername.Text = dataGridViewEmployee.SelectedRows[0].Cells[8].Value.ToString();
            txtBxPassword.Text = dataGridViewEmployee.SelectedRows[0].Cells[9].Value.ToString();



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //sql statements
            string sql = "UPDATE EMPLOYEE_DETAILS SET EMPLOYEE_ID ='"+txtBxID.Text +"', FULLNAME = '"+txtBxFullname.Text+"', CONTACT_NO = '"+txtBxContact.Text+"', ALTERNATIVE_NUMBER = '"+txtBxAlternative.Text+"', POSITION = '"+txtBxPosition.Text+"', TAX_NO = '"+txtBxTax.Text+"', EMAIL = '"+txtBxEmail.Text+"', RESIDENTIAL_ADDRESS = '"+txtBxResidential.Text+"', Username = '"+txtBxUsername.Text+"', Password= '"+txtBxPassword.Text+"' WHERE EMPLOYEE_ID = '"+txtBxID.Text+"' ";

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
                    Clear();
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

        private void btnView_Click(object sender, EventArgs e)
        {
            Retrieve();
        }

        //Clear textboxes
        private void Clear()
        {
            dataGridViewEmployee.Rows.Clear();
            txtBxID.Clear();
            txtBxFullname.Clear();
            txtBxContact.Clear();
            txtBxAlternative.Clear();
            txtBxPosition.Clear();
            txtBxTax.Clear();
            txtBxEmail.Clear();
            txtBxResidential.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewEmployee.Rows.Clear();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
