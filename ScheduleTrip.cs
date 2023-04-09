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
    public partial class ScheduleTrip : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();

        public ScheduleTrip()
        {
            InitializeComponent();
            FillCombo();
            FillVehicleCombo();
            FillEmployeeCombo();

            //datagridView1 properties;
            dataGridViewTrips.ColumnCount = 10;
            dataGridViewTrips.Columns[0].Name = "OrderID";
            dataGridViewTrips.Columns[1].Name = "VehicleRegistration";
            dataGridViewTrips.Columns[2].Name = "EmployeeID";
            dataGridViewTrips.Columns[3].Name = "TotalKilometres";
            dataGridViewTrips.Columns[4].Name = "GarageName"; /*(ProgrammingWizards TV, 2016)*/
            dataGridViewTrips.Columns[5].Name = "DepartureAddress";
            dataGridViewTrips.Columns[6].Name = "DestinationAddress";
            dataGridViewTrips.Columns[7].Name = "OrderStatus";
            dataGridViewTrips.Columns[8].Name = "OrderDate";
            dataGridViewTrips.Columns[9].Name = "DeliveryDate";

            //automatically resize datagridView
            dataGridViewTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/

            //Selection Mode
            //Selecting the whole row
            dataGridViewTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTrips.MultiSelect = false;

        }
       
        //Clear textboxes
        private void Clear()
        {
            dataGridViewTrips.Rows.Clear();
            cmbBxOrderID.SelectedIndex = 0;
            cmbBxReg.SelectedIndex = 0;
            cmbEmployeeID.SelectedIndex = 0;
            txtBxKm.Clear();
            txtBxGarage.Clear();
            txtBxDepature.Clear();
            txtBxDestination.Clear();
            cmbBxStatus.SelectedIndex = 0; ;
            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void FillCombo()
        {
            string query = "Select ORDER_ID from ONLINE_ORDERS ";
            cmd = new SqlCommand(query, con);
            SqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string orderID = dataReader["ORDER_ID"].ToString();
                    cmbBxOrderID.Items.Add(orderID);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillVehicleCombo()
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
                    string vehicleReg = dataReader["VEHICLE_REGISTRATION"].ToString();
                    cmbBxReg.Items.Add(vehicleReg);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillEmployeeCombo()
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
                    string employeeeID = dataReader["EMPLOYEE_ID"].ToString();
                    cmbEmployeeID.Items.Add(employeeeID);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbBxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOrderStatus.Visible = true;
            cmbBxStatus.Visible = true;
            string query = "select ORDER_ID, ORDER_DATE, GARAGE_NAME, DEPARTURE_ADDRESS, DESTINATION_ADDRESS from ONLINE_ORDERS where ORDER_ID =" + cmbBxOrderID.Text +"";
            cmd = new SqlCommand(query, con);
            SqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string date = dataReader.GetString(1);
                    string name = dataReader.GetString(2);
                    string departure = dataReader.GetString(3);
                    string destination = dataReader.GetString(4);
                    txtBxGarage.Text = name;
                    txtBxDepature.Text = departure;
                    txtBxDestination.Text = destination;
                    dateTimePicker1.Text = date;

                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
        }

        private void ScheduleTrip_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //connecting to the database, entering input data into the database
            SqlCommand cmd = new SqlCommand(@"INSERT INTO TRIPS(ORDER_ID, VEHICLE_REGISTRATION , EMPLOYEE_ID, TOTAL_KILOMETRES, GARAGE_NAME ,DEPARTURE_ADDRESS, DESTINATION_ADDRESS, ORDER_STATUS, ORDER_DATE, DELIVERY_DATE) 
            VALUES ('" + cmbBxOrderID.Text + "','" + cmbBxReg.Text + "', '" + cmbEmployeeID.Text + "', '" + txtBxKm.Text + "', '" + txtBxGarage.Text + "', '" + txtBxDepature.Text + "', '" + txtBxDestination.Text + "', '" + cmbBxStatus.Text + "', '"+dateTimePicker1.Text+"', '"+dateTimePicker2.Text+"')", con);
            con.Open();

            //Opening our connection and inserting data
            try
            {

                if (cmd.ExecuteNonQuery() > 0)/*(ProgrammingWizards TV, 2016)*/
                {
                    Clear();
                    MessageBox.Show("Trip Schedule Successfully Saved, \nTo make changes the select employee on the table below then make the changes in the textboxes \nThen click Edit...");
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
        //populate datagridview
        private void Populate(string orderId, string reg, string employeeId, string km, string name, string departure, string destination, string status, string date, string dd)
        {
            dataGridViewTrips.Rows.Add(orderId, reg, employeeId, km, name, departure, destination, status, date, dd);
        }
        //Retrieving data from the database
        private void Retrieve()
        {
            dataGridViewTrips.Rows.Clear();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //sql statements
            string sql = "UPDATE TRIPS SET ORDER_ID ='" + cmbBxOrderID.Text + "', VEHICLE_REGISTRATION = '" + cmbBxReg.Text + "', EMPLOYEE_ID = '" + cmbEmployeeID.Text + "', TOTAL_KILOMETRES = '" + txtBxKm.Text + "', GARAGE_NAME = '" + txtBxGarage.Text + "', DEPARTURE_ADDRESS = '" + txtBxDepature.Text + "', DESTINATION_ADDRESS = '" + txtBxDestination.Text + "', ORDER_STATUS = '" + cmbBxStatus.Text + "', ORDER_DATE= '"+dateTimePicker1.Text+"', DELIVERY_DATE= '"+dateTimePicker2.Text+"' WHERE ORDER_ID = '" + cmbBxOrderID.Text + "' ";

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

        private void dataGridViewTrips_MouseClick(object sender, MouseEventArgs e)
        {
            //adding data to the datagrid
            cmbBxOrderID.Text = dataGridViewTrips.SelectedRows[0].Cells[0].Value.ToString();
            cmbBxReg.Text = dataGridViewTrips.SelectedRows[0].Cells[1].Value.ToString();
            cmbEmployeeID.Text = dataGridViewTrips.SelectedRows[0].Cells[2].Value.ToString();/*(ProgrammingWizards TV, 2016)*/
            txtBxKm.Text = dataGridViewTrips.SelectedRows[0].Cells[3].Value.ToString();
            txtBxGarage.Text = dataGridViewTrips.SelectedRows[0].Cells[4].Value.ToString();
            txtBxDepature.Text = dataGridViewTrips.SelectedRows[0].Cells[5].Value.ToString();
            txtBxDestination.Text = dataGridViewTrips.SelectedRows[0].Cells[6].Value.ToString();
            cmbBxStatus.Text = dataGridViewTrips.SelectedRows[0].Cells[7].Value.ToString();
            dateTimePicker1.Text = dataGridViewTrips.SelectedRows[0].Cells[8].Value.ToString();
            dateTimePicker2.Text = dataGridViewTrips.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
