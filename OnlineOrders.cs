﻿using System;
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
    public partial class OnlineOrders : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();

        public OnlineOrders()
        {
            InitializeComponent();
            //datagridView1 properties;
            dataGridViewOrders.ColumnCount = 10;
            dataGridViewOrders.Columns[0].Name = "OrderID";
            dataGridViewOrders.Columns[1].Name = "GarageName";
            dataGridViewOrders.Columns[2].Name = "VehicleType";
            dataGridViewOrders.Columns[3].Name = "NoOfVehicles"; /*(ProgrammingWizards TV, 2016)*/
            dataGridViewOrders.Columns[4].Name = "VehicleStatus";
            dataGridViewOrders.Columns[5].Name = "City";
            dataGridViewOrders.Columns[6].Name = "DepartureAddress";
            dataGridViewOrders.Columns[7].Name = "DestinationAddress";
            dataGridViewOrders.Columns[8].Name = "OrderDate";

            //automatically resize datagridView
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/


        }
        //populate datagridview
        private void Populate(string id, string name, string type, string num, string status, string city, string departure, string destination, string date)
        {
            dataGridViewOrders.Rows.Add(id, name, type, num, status, city, departure, destination, date);
        }
        //Retrieving data from the database
        private void Retrieve()
        {
            dataGridViewOrders.Rows.Clear();
            //sql statements
            String sql = "SELECT * FROM ONLINE_ORDERS ";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                dataAdapter.Fill(dataTable);
                //Looping through the datatable
                foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
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
            dataGridViewOrders.Rows.Clear();
            //sql statements
            String sql = "SELECT * FROM ONLINE_ORDERS WHERE ORDER_DATE BETWEEN '"+ dateTimePicker1.Value.ToString()+ "' AND '"+dateTimePicker1.Value.AddDays(1)+"'";
            cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                dataAdapter = new SqlDataAdapter(cmd);/*(ProgrammingWizards TV, 2016)*/

                dataAdapter.Fill(dataTable);
                //Looping through the datatable
                foreach (DataRow row in dataTable.Rows)/*(ProgrammingWizards TV, 2016)*/
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
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

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            Retrieve();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
