using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.User_controlls;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnlMovingPannel.Left = btnCheckOut.Left + 18;
            uc_CustomerCheckout1.Visible = true;
            uc_CustomerCheckout1.BringToFront();
            
            
        }

        private void btnCustReg_Click(object sender, EventArgs e)
        {
            pnlMovingPannel.Left = btnCustReg.Left+18;
            uc_cutomerRegistration1.Visible = true;
            uc_cutomerRegistration1.BringToFront();
            
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            pnlMovingPannel.Left = btnAddRoom.Left + 18;
            uc_AddRoom1.Visible = true;
            uc_AddRoom1.BringToFront();

        }

        private void btnCustDetails_Click(object sender, EventArgs e)
        {
            pnlMovingPannel.Left = btnCustDetails.Left + 18;
            uc_customerdetails1.Visible = true;
            uc_customerdetails1.BringToFront();
            
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlMovingPannel.Left =btnEmployee.Left + 18;
            uc_employee1.Visible = true;
            uc_employee1.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uc_AddRoom1.Visible = false;
            //uc_CutomerRegistration.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void uc_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void uc_customerReg1_Load(object sender, EventArgs e)
        {

        }

        private void uc_cutomerRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
