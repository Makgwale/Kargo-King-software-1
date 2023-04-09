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
    public partial class StatusReportPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CHEGBH3B\SQLEXPRESS;Initial Catalog=KING_KARGO;Integrated Security=True");
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dataTable = new DataTable();

        public StatusReportPage()
        {
            InitializeComponent();
            //datagridView1 properties;
            dataGridViewReport.ColumnCount = 7;
            dataGridViewReport.Columns[0].Name = "VehicleNo";
            dataGridViewReport.Columns[1].Name = "VehicleReg";
            dataGridViewReport.Columns[2].Name = "Type";
            dataGridViewReport.Columns[3].Name = "Manufacturer";
            dataGridViewReport.Columns[4].Name = "EngineSize"; /*(ProgrammingWizards TV, 2016)*/
            dataGridViewReport.Columns[5].Name = "CurrentOdometer";
            dataGridViewReport.Columns[6].Name = "NextServiceOdometer";


            //automatically resize datagridView
            dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;/*(ProgrammingWizards TV, 2016)*/

        }
        //populate datagridview
        private void Populate(string num, string reg, string type, string manufacturer, string weight, string current, string service)
        {
            dataGridViewReport.Rows.Add(num, reg, type, manufacturer, weight, current, service);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
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
    }
}
