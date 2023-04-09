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
    public partial class OrderPage : Form
    {
        SqlDataAdapter adapter;
       // SqlCommandBuilder commandBuilder;
       // DataTable dataTable;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        int i = 0;
        public OrderPage()
        {
            InitializeComponent();
        }

        private void pnlQuote_Paint(object sender, PaintEventArgs e)
        {

        }
        void FillCombo()
        {
            lblOrderID.Visible = true;
            cmbBxOrderID.Visible = true;
            string query = "Select ORDER_ID from ONLINE_ORDERS where GARAGE_NAME ='"+ txtBxGarage.Text +"' and  ORDER_DATE = '"+ dateTimePicker1.Value.ToString() + "' ";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            //connecting to the database, entering input data into the database
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO ONLINE_ORDERS([GARAGE_NAME], VEHICLE_TYPE,NO_OF_VEHICLES, VEHICLE_STATUS,CITY, DEPARTURE_ADDRESS, [DESTINATION_ADDRESS], ORDER_DATE, CLIENT_USERNAME) 
            VALUES ('" + txtBxGarage.Text + "','" + txtBxKind.Text + "', '"+txtBxNumOfVehicle.Text+"', '"+txtBxStatus.Text+"', '"+txtBxCity.Text+"', '"+txtBxDepature.Text+"', '"+txtBxDestination.Text+"', '"+dateTimePicker1.Text+"', '"+lblClient.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Order Successfully Saved, \nTo make changes select order id, make changes then click update");

            FillCombo();
        }
        //updating the database
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          string query = "update ONLINE_ORDERS set [GARAGE_NAME] = '"+txtBxGarage.Text +"', VEHICLE_TYPE = '"+txtBxKind.Text+"',NO_OF_VEHICLES = '"+txtBxNumOfVehicle.Text+"', VEHICLE_STATUS = '"+txtBxStatus.Text+"',CITY = '"+txtBxCity.Text+"', DEPARTURE_ADDRESS = '"+txtBxDepature.Text+"', [DESTINATION_ADDRESS] = '"+txtBxDestination.Text+"', ORDER_DATE = '"+dateTimePicker1.Text +"', CLIENT_USERNAME = '"+lblClient.Text+"' where ORDER_ID="+cmbBxOrderID.SelectedItem+" ";
            cmd = new SqlCommand(query, con);/*(ProgrammingWizards TV, 2016)*/

            //Open con, update and retrieve datagridView1
            try
            {
                con.Open();
                adapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = query;
                
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    
                    MessageBox.Show("Update successful");
                    con.Close();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxGarage.Clear();
            txtBxKind.Clear();
            txtBxNumOfVehicle.Clear();
            txtBxStatus.Clear();
            txtBxDepature.Clear();
            txtBxDestination.Clear();
            txtBxCity.Clear();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            lblClient.Text = ClientLoginPage.user;
        }
    }
}
