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
    public partial class CompletedServicesReport : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();

        public CompletedServicesReport()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "VehicleRegistration";
            dataGridView1.Columns[1].Name = "ServiceStatus";
            dataGridView1.Columns[2].Name = "cost";
            dataGridView1.Columns[3].Name = "VehicleType"; /*(ProgrammingWizards TV, 2016)*/
            dataGridView1.Columns[4].Name = "EngineSize";
            dataGridView1.Columns[5].Name = "CurrentOdometerReading";
            dataGridView1.Columns[6].Name = "NextOdometer";
            dataGridView1.Columns[7].Name = "AppointmentDate";/*(ProgrammingWizards TV, 2016)*/

            //automatically resize datagridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/


        }
        //populate datagridview
        private void Populate(string reg, string status, string cost, string vehicle, string engine, string currentReading, string nextReading, string date)
        {
            dataGridView1.Rows.Add(reg, status, cost, vehicle, engine, currentReading, nextReading, date);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (radBtnDaily.Checked == true)
            {
                dataGridView1.Rows.Clear();
                //sql statements
                string sql = "SELECT * FROM SERVICE_STATUS WHERE APPOINTMENT_DATE='" + dateTimePicker1.Text + "'";
                cmd = new SqlCommand(sql, con);
                //WHERE ORDER_DATE BETWEEN '" + dateTimePicker1.Value.ToString()+ "' AND '"+dateTimePicker1.Value.AddDays(1)+"'";
                try
                {
                    con.Open();
                    dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                    dataAdapter.Fill(dataTable);
                    //Looping through the datatable
                    foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
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
                String sql = "SELECT * FROM SERVICE_STATUS WHERE APPOINTMENT_DATE >= '" + dateTimePicker2.Text + "' AND APPOINTMENT_DATE <= '" + dateTimePicker1.Text + "'";
                cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                    dataAdapter.Fill(dataTable);
                    //Looping through the datatable
                    foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
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
                String sql = "SELECT * FROM SERVICE_STATUS WHERE APPOINTMENT_DATE >= '" + dateTimePicker2.Text + "' AND APPOINTMENT_DATE <= '" + dateTimePicker1.Text + "'";
                cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                    dataAdapter.Fill(dataTable);
                    //Looping through the datatable
                    foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
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
    }
}
