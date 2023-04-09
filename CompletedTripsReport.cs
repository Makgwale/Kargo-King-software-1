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
    public partial class CompletedTripsReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();

        public CompletedTripsReport()
        {
            InitializeComponent();
            //datagridView1 properties;
            dataGridViewrReport.ColumnCount = 7;
            dataGridViewrReport.Columns[0].Name = "OrderID";
            dataGridViewrReport.Columns[1].Name = "OrderStatus";
            dataGridViewrReport.Columns[2].Name = "GarageName";
            dataGridViewrReport.Columns[3].Name = "DepartureAddress"; /*(ProgrammingWizards TV, 2016)*/
            dataGridViewrReport.Columns[4].Name = "DestinationAddress";
            dataGridViewrReport.Columns[5].Name = "TotalKilometres";
            dataGridViewrReport.Columns[6].Name = "DeliveryDate";

            //automatically resize datagridView
            dataGridViewrReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/
        }
        //populate datagridview
        private void Populate(string orderId, string status, string name,string departure, string destination, string km, string date)
        {
            dataGridViewrReport.Rows.Add(orderId, status, name, departure, destination, km, date);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(radBtnDaily.Checked == true)
            {
                dataGridViewrReport.Rows.Clear();
                //sql statements
                string sql = "SELECT * FROM TRIP_STATUS WHERE DELIVERY_DATE='" + dateTimePicker1.Text + "'";
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
            if(radBtnWeekly.Checked == true)
            {
                dataGridViewrReport.Rows.Clear();
                //sql statements
                String sql = "SELECT * FROM TRIP_STATUS WHERE DELIVERY_DATE >= '" + dateTimePicker2.Text + "' AND DELIVERY_DATE <= '" + dateTimePicker1.Text + "'";
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
            if(radBtnMonthly.Checked == true)
            {
                dataGridViewrReport.Rows.Clear();
                //sql statements
                String sql = "SELECT * FROM TRIP_STATUS WHERE DELIVERY_DATE >= '" + dateTimePicker1.Text + "' AND DELIVERY_DATE <= '" + dateTimePicker2.Text + "'";
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
    }
}
