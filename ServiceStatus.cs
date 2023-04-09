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
    public partial class ServiceStatus : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();

        public ServiceStatus()
        {
            InitializeComponent();
            FillCombo();
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
            string query = "select VEHICLE_REGISTRATION, VEHICLE_TYPE, VEHICLE_MANUFACTURER, ENGINE_SIZE, [CURRENT_ODOMETER_ READING], NEXT_SERVICE_ODOMETER_READING from VEHICLE where VEHICLE_REGISTRATION ='" + cmbBxReg.Text + "'";
           // string query2 = "select VEHICLE_REGISTRATION, APPOINTMENT_DATE from SERVICE_APPOINTMENT where VEHICLE_REGISTRATION = '" + cmbBxReg.Text + "'";
            cmd = new SqlCommand(query, con);
           // cmd = new SqlCommand(query2, con); 

            SqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string type = dataReader.GetString(1);
                    string manufacturer = dataReader.GetString(2);
                    string size = dataReader.GetString(3);
                    string current = dataReader.GetString(4);
                    string next = dataReader.GetString(5);
                   // string date = dataReader.GetString(1);
                    txtBxType.Text = type;
                    txtBxManufacturer.Text = manufacturer;
                    txtBxEngine.Text = size;
                    txtBxCurrentMeter.Text = current;
                    dateTimePicker1.Text = next;
                   // dateTimePicker2.Text = date;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            string query2 = "select VEHICLE_REGISTRATION, APPOINTMENT_DATE from SERVICE_APPOINTMENT where VEHICLE_REGISTRATION = '" + cmbBxReg.Text + "'";
            cmd = new SqlCommand(query2, con); 

            SqlDataReader dataReader2;
            try
            {
                con.Open();
                dataReader2 = cmd.ExecuteReader();

                while (dataReader2.Read())
                {
                  
                    string date = dataReader2.GetString(1);
                    dateTimePicker2.Text = date;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //connecting to the database, entering input data into the database
            SqlCommand cmd = new SqlCommand(@"INSERT INTO SERVICE_STATUS(VEHICLE_REGISTRATION,SERVICE_STATUS,COMPLETE_COST,VEHICLE_TYPE,ENGINE_SIZE, CURRENT_ODOMETER_READING, NEXT_SERVICE_ODOMETER_READING, APPOINTMENT_DATE) 
            VALUES ('" + cmbBxReg.Text + "', '" + cmbBxStatus.Text + "', '" + txtBxCost.Text + "', '" + txtBxType.Text + "','" + txtBxEngine.Text + "', '" + txtBxCurrentMeter.Text + "', '" + dateTimePicker1.Text + "', '"+dateTimePicker2.Text+"')", con);
            con.Open();

            //Opening our connection and inserting data
            try
            {

                if (cmd.ExecuteNonQuery() > 0)/*(ProgrammingWizards TV, 2016)*/
                {

                    MessageBox.Show("Service Status Successfully Saved, \nTo make change edit the changes in the textboxes \nThen click Update...");
                }

                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //sql statements
            string sql = "UPDATE SERVICE_STATUS SET VEHICLE_REGISTRATION ='" + cmbBxReg.Text + "',SERVICE_STATUS = '" + cmbBxStatus.Text + "', COMPLETE_COST = '" + txtBxCost.Text + "', VEHICLE_TYPE = '" + txtBxType.Text + "',ENGINE_SIZE = '" + txtBxEngine.Text + "', CURRENT_ODOMETER_READING ='" + txtBxCurrentMeter.Text + "', NEXT_SERVICE_ODOMETER_READING = '" + dateTimePicker1.Text + "', APPOINTMENT_DATE= '"+dateTimePicker2.Text+"' WHERE VEHICLE_REGISTRATION = '" + cmbBxReg.Text + "' ";

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

                    MessageBox.Show("Update successful");
                }

                con.Close();
                //refresh datagridView1

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();

            }
        }
    }
}
