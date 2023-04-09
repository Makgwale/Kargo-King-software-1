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
    public partial class WeeklyPlannedTrips : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();

        public WeeklyPlannedTrips()
        {
            InitializeComponent();
            //datagridView1 properties;
            //datagridView1 properties;
            dataGridViewrReport.ColumnCount = 10;
            dataGridViewrReport.Columns[0].Name = "OrderID";
            dataGridViewrReport.Columns[1].Name = "VehicleRegistration";
            dataGridViewrReport.Columns[2].Name = "EmployeeID";
            dataGridViewrReport.Columns[3].Name = "TotalKilometres";
            dataGridViewrReport.Columns[4].Name = "GarageName"; /*(ProgrammingWizards TV, 2016)*/
            dataGridViewrReport.Columns[5].Name = "DepartureAddress";
            dataGridViewrReport.Columns[6].Name = "DestinationAddress";
            dataGridViewrReport.Columns[7].Name = "OrderStatus";
            dataGridViewrReport.Columns[8].Name = "Date";
            dataGridViewrReport.Columns[9].Name = "DeliveryDate";


            //automatically resize datagridView
            dataGridViewrReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/


        }
        //populate datagridview
        private void Populate(string orderId, string reg, string employeeId, string km, string name, string departure, string destination, string status, string date, string dd)
        {
            dataGridViewrReport.Rows.Add(orderId, reg, employeeId, km, name, departure, destination, status, date, dd);
        }
        //Retrieving data from the database
        private void Retrieve()
        {
            dataGridViewrReport.Rows.Clear();
            //sql statements
            String sql = "SELECT * FROM TRIPS ";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                dataAdapter.Fill(dataTable);
                //Looping through the datatable
                foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[8].ToString());
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridViewrReport.Rows.Clear();
            //sql statements
            String sql = "SELECT * FROM TRIPS WHERE ORDER_DATE >= '" + dateTimePicker1.Text + "' AND ORDER_DATE <= '" + dateTimePicker2.Text + "'";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                dataAdapter.Fill(dataTable);
                //Looping through the datatable
                foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString());
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            dataGridViewrReport.Rows.Clear();
            //sql statements
            string sql = "SELECT * FROM TRIPS WHERE ORDER_DATE='" + dateTimePicker1.Text+"'";
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
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString());
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
