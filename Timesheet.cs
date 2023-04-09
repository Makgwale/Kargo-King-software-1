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
    public partial class Timesheet : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();

        public Timesheet()
        {
            InitializeComponent();
            FillCombo();
        }
        void FillCombo()
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
                    string orderID = dataReader["EMPLOYEE_ID"].ToString();
                    cmbEmployeeID.Items.Add(orderID);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int x = 0;
            
            List <double> hours = new List<double>();
            double totalPay = 0;
            List<double> extraTime = new List<double>();
            List<double> payRate = new List<double>();
            hours.Add(double.Parse(txtBxHoursWorked.Text));
            //totalPay.Add(double.Parse(txtBxPay.Text));
            extraTime.Add(double.Parse(txtBxExtra.Text));
            payRate.Add(double.Parse(txtBxPayRate.Text));
            totalPay = (hours[x] + extraTime[x]) * payRate[x];
            txtBxPay.Text = totalPay.ToString();

            lblPay.Visible = true;
            txtBxPay.Visible = true;
            //connecting to the database, entering input data into the database
            SqlCommand cmd = new SqlCommand(@"INSERT INTO TIMESHEET(EMPLOYEE_ID, EMPLOYEE_TYPE, DATE, HOURS_WORKED, PAY_RATE, TOTAL_PAY ,EXTRA_TIME) 
            VALUES ('" + cmbEmployeeID.Text + "','" + cmbBxType.Text + "', '" + dateTimePicker1.Text + "', '" + txtBxHoursWorked.Text + "', '" + txtBxPayRate.Text + "', " + totalPay + ", '" + txtBxExtra.Text + "')", con);
            con.Open();

            //Opening our connection and inserting data
            try
            {

                if (cmd.ExecuteNonQuery() > 0)/*(ProgrammingWizards TV, 2016)*/
                {

                    MessageBox.Show("Timesheet report Successfully Saved, \nTo make change edit the changes in the textboxes \nThen click Update...");
                }

                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            con.Close();
            ++x;
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select FULLNAME, POSITION, TAX_NO from EMPLOYEE_DETAILS where EMPLOYEE_ID ='" + cmbEmployeeID.Text + "'";

            cmd = new SqlCommand(query, con);

            SqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string name = dataReader.GetString(0);
                    string position = dataReader.GetString(1);
                    string taxNo = dataReader.GetString(2);
                    txtBxFullname.Text = name;
                    txtBxPosition.Text = position;
                    txtBxTax.Text = taxNo;
                   
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
            string sql = "UPDATE TIMESHEET SET EMPLOYEE_ID ='" + cmbEmployeeID.Text + "', EMPLOYEE_TYPE = '" + cmbBxType.Text + "',DATE = '" + dateTimePicker1.Text + "', TOTAL_PAY = '" + txtBxPay.Text+ "', EXTRA_TIME = '" + txtBxExtra.Text + "' WHERE EMPLOYEE_ID = '" + cmbEmployeeID.Text + "' AND DATE = '"+dateTimePicker1.Text+"' ";

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
