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
    public partial class RequirementReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();

        public RequirementReport()
        {
            InitializeComponent();
            FillCombo();
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "VehicleRegistration";
            dataGridView1.Columns[1].Name = "ServicesType";
            dataGridView1.Columns[2].Name = "AppointmentDate";
            dataGridView1.Columns[3].Name = "AppointmentTime";
            dataGridView1.Columns[4].Name = "ServicesPerformed";/*(ProgrammingWizards TV, 2016)*/
            dataGridView1.Columns[5].Name = "VehicleType";
            dataGridView1.Columns[6].Name = "VehicleManufacturer"; /*(ProgrammingWizards TV, 2016)*/
            dataGridView1.Columns[7].Name = "EngineSize";
            dataGridView1.Columns[8].Name = "CurrentOdometerReading";
            dataGridView1.Columns[9].Name = "NextOdometer";

            //automatically resize datagridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/

        }
        //populate datagridview
        private void Populate(string reg, string type,string date, string time, string service, string vehicle,string manufacturer, string engine, string currentReading, string nextReading)
        {
            dataGridView1.Rows.Add(reg,type , date, time, service,vehicle ,manufacturer, engine, currentReading, nextReading);
        }
        void FillCombo()
        {
            string query = "Select VEHICLE_REGISTRATION from VEHICLE ";
            cmd = new SqlCommand(query, con);
            SqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string orderID = dataReader["VEHICLE_REGISTRATION"].ToString();
                    cmbBxReg.Items.Add(orderID);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbBxReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //sql statements
            string sql = "SELECT * FROM SERVICE_REQUIREMENTS WHERE VEHICLE_REGISTRATION='" + cmbBxReg.Text + "'";
            cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                dataAdapter.Fill(dataTable);
                //Looping through the datatable
                foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(),row[7].ToString(), row[8].ToString(), row[9].ToString());
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
