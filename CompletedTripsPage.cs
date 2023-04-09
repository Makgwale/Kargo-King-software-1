using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Orange_Design_Login
{
    public partial class CompletedTripsPage : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public CompletedTripsPage()
        {
            InitializeComponent();
            FillCombo();
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
  
        private void txtBxKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKm_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //connecting to the database, entering input data into the database
            SqlCommand cmd = new SqlCommand(@"INSERT INTO TRIP_STATUS(ORDER_ID, ORDER_STATUS,  GARAGE_NAME ,DEPARTURE_ADDRESS, DESTINATION_ADDRESS, TOTAL_KILOMETRES,DELIVERY_DATE) 
            VALUES ('" + cmbBxOrderID.Text + "','"+ cmbBxStatus.Text +"', '" + txtBxGarage.Text + "', '" + txtBxDepature.Text + "', '" + txtBxDestination.Text + "', '" + txtBxKm.Text + "', '"+dateTimePicker2.Text+"')", con);
            con.Open();

            //Opening our connection and inserting data
            try
            {

                if (cmd.ExecuteNonQuery() > 0)/*(ProgrammingWizards TV, 2016)*/
                {
                   
                    MessageBox.Show("Trip Status Successfully Saved, \nTo make change edit the changes in the textboxes \nThen click Update...");
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

        private void cmbBxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select ORDER_ID, ORDER_DATE, GARAGE_NAME, DEPARTURE_ADDRESS, DESTINATION_ADDRESS, TOTAL_KILOMETRES from TRIPS where ORDER_ID =" + cmbBxOrderID.Text + "";
            
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
                    string kilometres = dataReader.GetString(5);
                    txtBxGarage.Text = name;
                    txtBxDepature.Text = departure;
                    txtBxDestination.Text = destination;
                    txtBxKm.Text = kilometres;
                    dateTimePicker1.Text = date;

                }
                con.Close();
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
            string sql = "UPDATE TRIP_STATUS SET ORDER_ID ='" + cmbBxOrderID.Text + "', ORDER_STATUS = '" + cmbBxStatus.Text + "', TOTAL_KILOMETRES = '" + txtBxKm.Text + "', GARAGE_NAME = '" + txtBxGarage.Text + "', DEPARTURE_ADDRESS = '" + txtBxDepature.Text + "', DESTINATION_ADDRESS = '" + txtBxDestination.Text + "', DELIVERY_DATE= '"+dateTimePicker2.Text+"' WHERE ORDER_ID = '" + cmbBxOrderID.Text + "' ";

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
