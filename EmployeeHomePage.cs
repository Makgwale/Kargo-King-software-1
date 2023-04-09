using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_Design_Login
{
    public partial class EmployeeHomePage : Form
    {
        public EmployeeHomePage()
        {
            InitializeComponent();
            // invoking customizeDesing method into the constructor
            //Must be invoked under the InitializeComponent() method
            customizeDesing();
        }
        //hiding the sub menu panels
        private void customizeDesing()
        {
            pnlSubOrders.Visible = false;
            pnlVehicleSubMenu.Visible = false;
            pnlTripSubMenu.Visible = false;
            pnlServiceSubMenu.Visible = false;
            pnlTimesheetSubMenu.Visible = false;
        }
        //empty type method that hides the sub menu panels that were previously shown 
        private void hideSubMenu()
        {
            if (pnlSubOrders.Visible == true)
                pnlSubOrders.Visible = false;
            if (pnlVehicleSubMenu.Visible == true)
                pnlVehicleSubMenu.Visible = false;
            if (pnlTripSubMenu.Visible == true)
                pnlTripSubMenu.Visible = false;
            if (pnlServiceSubMenu.Visible == true)
                pnlServiceSubMenu.Visible = false;
            if (pnlTimesheetSubMenu.Visible == true)
                pnlTimesheetSubMenu.Visible = false;
        }
        //empty type method that display sub menus of type 'Panel'
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }


        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //invoking subMenu method
            showSubMenu(pnlSubOrders);
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            //opening OnlineOrders in the main form(EmployeeHomePage)'s panel
            openChild(new OnlineOrders());
        }
        private Form activeForm = null;
        //method that opens the childForm in the panel of the EmployeeHomePage
        private void openChild(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        //Employee Details invoked when button is pressed
        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChild(new EmployeeDetails());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the whole applications
            Environment.Exit(0);
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            openChild(new LiveOrderPage());
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            //opening AddVehicle form
            openChild(new AddVehicle());
        }

        private void btnStatusReport_Click(object sender, EventArgs e)
        {
            openChild(new StatusReportPage());
        }

        private void btnVehicleInfo_Click(object sender, EventArgs e)
        {
            //invoking subMenu method
            showSubMenu(pnlVehicleSubMenu);
        }

        private void pnlSubOrders_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            openChild(new ScheduleTrip());

        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            //invoking subMenu method
            showSubMenu(pnlTripSubMenu);
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            openChild(new CompletedTripsPage());
        }

        private void btnPlannedReport_Click(object sender, EventArgs e)
        {
            openChild(new WeeklyPlannedTrips());
        }

        private void btnCompletedReport_Click(object sender, EventArgs e)
        {
            openChild(new CompletedTripsReport());
        }
        private void btnService_Click(object sender, EventArgs e)
        {
            //invoking subMenu method
            showSubMenu(pnlServiceSubMenu);
        }
        private void btnAppointment_Click(object sender, EventArgs e)
        {
            openChild(new VehicleServiceAppointment());
        }
        private void btnRequirements_Click(object sender, EventArgs e)
        {
            openChild(new ServiceRequirements());
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            openChild(new ServiceStatus());
        }

        private void btnServiceReport_Click(object sender, EventArgs e)
        {
            openChild(new AppointmentReport());
        }

        private void btnRequirementsReport_Click(object sender, EventArgs e)
        {
            openChild(new RequirementReport());
        }

        private void btnServicesCompleted_Click(object sender, EventArgs e)
        {
            openChild(new CompletedServicesReport());
        }

        private void btnTimesheet_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlTimesheetSubMenu);
        }

        private void btnCompletedReport_Click_1(object sender, EventArgs e)
        {
            openChild(new CompletedTripsReport());
        }

        private void btnRecordTimesheet_Click(object sender, EventArgs e)
        {
            openChild(new Timesheet());
        }

        private void btnTimesheetReport_Click(object sender, EventArgs e)
        {
            openChild(new TimesheetReport());
        }

        private void EmployeeHomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeHomePage_Shown(object sender, EventArgs e)
        {
            lblType.Text = EmployeeLogin.user;


            if (lblType.Text == "Timesheet Manager")
            {
                btnTimesheet.Enabled = true;
                MessageBox.Show("access Level authorises for timesheet management functions");
            }
            else
            {
                btnTimesheet.Enabled = false;

                MessageBox.Show(this, "Please be  informed this access Level is not authorised for timesheet management");
            }
        }
    }
}
