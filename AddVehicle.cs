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
    public partial class AddVehicle : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();
        int vehicleNo = 0;


        public AddVehicle()
        {
            InitializeComponent();
            //datagridView1 properties;
            dataGridViewVehicle.ColumnCount = 7;
            dataGridViewVehicle.Columns[0].Name = "VehicleNo";
            dataGridViewVehicle.Columns[1].Name = "VehicleReg";
            dataGridViewVehicle.Columns[2].Name = "Type";
            dataGridViewVehicle.Columns[3].Name = "Manufacturer";
            dataGridViewVehicle.Columns[4].Name = "EngineSize"; /*(ProgrammingWizards TV, 2016)*/
            dataGridViewVehicle.Columns[5].Name = "CurrentOdometer";
            dataGridViewVehicle.Columns[6].Name = "NextServiceOdometer";
           

            //automatically resize datagridView
            dataGridViewVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/

            //Selection Mode
            //Selecting the whole row
            dataGridViewVehicle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVehicle.MultiSelect = false;
        }
        private void dataGridViewEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            //adding data to the datagrid
            
            txtBxVehicleReg.Text = dataGridViewVehicle.SelectedRows[0].Cells[1].Value.ToString();
            cmbBxType.Text = dataGridViewVehicle.SelectedRows[0].Cells[2].Value.ToString();/*(ProgrammingWizards TV, 2016)*/
            txtBxManufacturer.Text = dataGridViewVehicle.SelectedRows[0].Cells[3].Value.ToString();
            txtBxEngine.Text = dataGridViewVehicle.SelectedRows[0].Cells[4].Value.ToString();
            txtBxCurrent.Text = dataGridViewVehicle.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridViewVehicle.SelectedRows[0].Cells[6].Value.ToString();
            



        }

        private void grpBxVehicle_Enter(object sender, EventArgs e)
        {

        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ++vehicleNo;
            //txtBxVehicleNo = vehicleNo.ToString();
            //connecting to the database, entering input data into the database
            SqlCommand cmd = new SqlCommand(@"INSERT INTO VEHICLE(VEHICLE_NO, VEHICLE_REGISTRATION , VEHICLE_TYPE, VEHICLE_MANUFACTURER,ENGINE_SIZE ,[CURRENT_ODOMETER_ READING], NEXT_SERVICE_ODOMETER_READING) 
            VALUES (" + vehicleNo + ",'" + txtBxVehicleReg.Text + "', '" +cmbBxType.Text + "', '" + txtBxManufacturer.Text + "', '" + txtBxEngine.Text + "', '" + txtBxCurrent.Text + "', '" + dateTimePicker1.Value.ToString() + "')", con);
            con.Open();

            //Opening our connection and inserting data
            try
            {

                if (cmd.ExecuteNonQuery() > 0)/*(ProgrammingWizards TV, 2016)*/
                {
                   // Clear();
                    MessageBox.Show("Vehicle Successfully Saved, \nTo make changes the select employee on the table below then make the changes in the textboxes \nThen click Edit...");
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
        private void Populate(string num, string reg, string type, string manufacturer, string weight, string current , string service)
        {
            dataGridViewVehicle.Rows.Add(num, reg, type, manufacturer, weight, current, service);
        }
        //Retrieving data from the database
        private void Retrieve()
        {
            dataGridViewVehicle.Rows.Clear();
            //sql statements
            String sql = "SELECT * FROM VEHICLE ";
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
        private void btnView_Click(object sender, EventArgs e)
        {
            Retrieve();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //sql statements
            string sql = "UPDATE VEHICLE SET VEHICLE_NO =" + txtBxVehicleNo.Text + ",  VEHICLE_REGISTRATION = '" + txtBxVehicleReg.Text + "', VEHICLE_TYPE = '"+cmbBxType.Text+"', VEHICLE_MANUFACTURER = '" + txtBxManufacturer.Text + "',ENGINE_SIZE = '" + txtBxEngine.Text + "', [CURRENT_ODOMETER_ READING] = '" + txtBxCurrent.Text + "', NEXT_SERVICE_ODOMETER_READING = '" + dateTimePicker1.Value.ToString() + "' WHERE VEHICLE_NO = '" + txtBxVehicleNo.Text+ "' ";

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

        private void dataGridViewVehicle_MouseClick(object sender, MouseEventArgs e)
        {
            //adding data to the datagrid
            txtBxVehicleNo.Text = dataGridViewVehicle.SelectedRows[0].Cells[0].Value.ToString();
            txtBxVehicleReg.Text = dataGridViewVehicle.SelectedRows[0].Cells[1].Value.ToString();
            cmbBxType.Text = dataGridViewVehicle.SelectedRows[0].Cells[2].Value.ToString();/*(ProgrammingWizards TV, 2016)*/
            txtBxManufacturer.Text = dataGridViewVehicle.SelectedRows[0].Cells[3].Value.ToString();
            txtBxEngine.Text = dataGridViewVehicle.SelectedRows[0].Cells[4].Value.ToString();
            txtBxCurrent.Text = dataGridViewVehicle.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridViewVehicle.SelectedRows[0].Cells[6].Value.ToString();

        }
        //Clear textboxes
        private void Clear()
        {
            dataGridViewVehicle.Rows.Clear();
            txtBxVehicleNo.Clear();
            txtBxVehicleReg.Clear();
            cmbBxType.SelectedIndex = 0;
            txtBxManufacturer.Clear();
            txtBxEngine.Clear();
            txtBxCurrent.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewVehicle.Rows.Clear();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        //Deleting items in the datagridView
        private void Delete(string id)
        {
            //passing the integer for the row that must be deleted
            //sql statement
            String sql = "DELETE FROM VEHICLE WHERE VEHICLE_NO ='" + txtBxVehicleNo.Text + "'";/*(ProgrammingWizards TV, 2016)*/
            cmd = new SqlCommand(sql, con);

            //open connection and execute and close
            try
            {
                con.Open();
                //cmd( is the Oledb command object)
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.DeleteCommand = con.CreateCommand();
                dataAdapter.DeleteCommand.CommandText = sql;

                //Send prompt to user for confirmation
                if (MessageBox.Show("Sure??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("delete successful");

                    }
                }
                con.Close();
                Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String selected = dataGridViewVehicle.SelectedRows[0].Cells[0].Value.ToString();
                string id = (selected);
                Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
