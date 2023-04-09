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
    public partial class AppointmentReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();
        public AppointmentReport()
        {
            InitializeComponent();
            dataGridViewAppointment.ColumnCount = 11;
            dataGridViewAppointment.Columns[0].Name = "VehicleRegistration";
            dataGridViewAppointment.Columns[1].Name = "AppointmentDate";
            dataGridViewAppointment.Columns[2].Name = "AppointmentTime";
            dataGridViewAppointment.Columns[3].Name = "ServicesPerformed"; /*(ProgrammingWizards TV, 2016)*/
            dataGridViewAppointment.Columns[4].Name = "ProcedureCode";
            dataGridViewAppointment.Columns[5].Name = "ProcedureDescription";
            dataGridViewAppointment.Columns[6].Name = "VehicleType";
            dataGridViewAppointment.Columns[7].Name = "VehicleManufacturer"; /*(ProgrammingWizards TV, 2016)*/
            dataGridViewAppointment.Columns[8].Name = "EngineSize";
            dataGridViewAppointment.Columns[9].Name = "CurrentOdometerReading";
            dataGridViewAppointment.Columns[10].Name = "NextOdometer";

            //automatically resize datagridView
            dataGridViewAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/

        }
        //populate datagridview
        private void Populate(string reg, string date, string time, string service, string code, string descrip, string type, string manufacturer, string engine, string currentReading, string nextReading)
        {
            dataGridViewAppointment.Rows.Add(reg, date, time, service, code, descrip, type, manufacturer, engine, currentReading, nextReading);
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            if (radBtnDaily.Checked == true)
            {
                dataGridViewAppointment.Rows.Clear();
                //sql statements
                string sql = "SELECT * FROM SERVICE_APPOINTMENT WHERE APPOINTMENT_DATE='" + dateTimePicker1.Text + "'";
                cmd = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                    dataAdapter.Fill(dataTable);
                    //Looping through the datatable
                    foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString());
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
                dataGridViewAppointment.Rows.Clear();
                //sql statements
                String sql = "SELECT * FROM SERVICE_APPOINTMENT WHERE APPOINTMENT_DATE >= '" + dateTimePicker2.Text + "' AND APPOINTMENT_DATE <= '" + dateTimePicker1.Text + "'";
                cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                    dataAdapter.Fill(dataTable);
                    //Looping through the datatable
                    foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString());
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
                dataGridViewAppointment.Rows.Clear();
                //sql statements
                String sql = "SELECT * FROM SERVICE_APPOINTMENT WHERE APPOINTMENT_DATE >= '" + dateTimePicker1.Text + "' AND APPOINTMENT_DATE <= '" + dateTimePicker2.Text + "'";
                cmd = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                    dataAdapter.Fill(dataTable);
                    //Looping through the datatable
                    foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString());
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
