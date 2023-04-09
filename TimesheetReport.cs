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
    public partial class TimesheetReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();

        public TimesheetReport()
        {
            InitializeComponent();
            FillCombo();
            //datagridView1 properties;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "EmployeeId";
            dataGridView1.Columns[1].Name = "EmployeeType";
            dataGridView1.Columns[2].Name = "Date";
            dataGridView1.Columns[3].Name = "HoursWorked"; /*(ProgrammingWizards TV, 2016)*/
            dataGridView1.Columns[4].Name = "PayRate";
            dataGridView1.Columns[5].Name = "ExtraTime";
            dataGridView1.Columns[6].Name = "TotalPay";

            //automatically resize datagridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/


        }
        void FillCombo()
        {
            string query = "Select EMPLOYEE_ID from EMPLOYEE_DETAILS ";
            cmd = new SqlCommand(query, con);
            SqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string orderID = dataReader["EMPLOYEE_ID"].ToString();
                    cmbEmployeeID.Items.Add(orderID);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //populate datagridview
        private void Populate(string employeeId, string employeeType, string date, string hours, string rate, string time, string pay)
        {
            dataGridView1.Rows.Add(employeeId, employeeType, date, hours, rate, time, pay);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (radBtnDaily.Checked == true)
            {

                dataGridView1.Rows.Clear();
                //sql statements
                string sql = "SELECT * FROM TIMESHEET WHERE DATE='" + dateTimePicker1.Text + "' AND EMPLOYEE_ID = '" + cmbEmployeeID.Text + "'";
                cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                    dataAdapter.Fill(dataTable);
                    //Looping through the datatable
                    foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
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
            if (radBtnWeekly.Checked == true)
            {
                dataGridView1.Rows.Clear();
                //sql statements
                String sql = "SELECT * FROM TIMESHEET WHERE DATE >= '" + dateTimePicker2.Text + "' AND DATE <= '" + dateTimePicker1.Text + "'";
                cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                    dataAdapter.Fill(dataTable);
                    //Looping through the datatable
                    foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
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
            if (radBtnMonthly.Checked == true)
            {
                dataGridView1.Rows.Clear();
                //sql statements
                String sql = "SELECT * FROM TIMESHEET WHERE DATE >= '" + dateTimePicker1.Text + "' AND DATE <= '" + dateTimePicker2.Text + "'";
                cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                    dataAdapter.Fill(dataTable);
                    //Looping through the datatable
                    foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
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
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
