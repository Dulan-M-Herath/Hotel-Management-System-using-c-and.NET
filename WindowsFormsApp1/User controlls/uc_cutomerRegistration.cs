using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.User_controlls
{
    public partial class uc_cutomerRegistration : UserControl
    {
        function fn = new function();
        String query;
        private bool txt;

        public uc_cutomerRegistration()
        {
            InitializeComponent();
        }

        private void uc_cutomerRegistration_Load(object sender, EventArgs e)
        {

        }

        public void setComboBox(String query, ComboBox cmb)
        {
            SqlDataReader sdr = fn.getForCombo(query);

            while (sdr.Read())
            {
                for(int i=0; i<sdr.FieldCount; i++)
                {
                    cmb.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            
                
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomNo.Items.Clear();    
            query = "select room_no from rooms where bed = '" + cmbBed.Text + "' and room_type = '" + cmbRoomType.Text + "' and booked = 'No' ";
            setComboBox(query, cmbRoomNo);
        }

        private void cmbBed_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbRoomNo.SelectedIndex = -1;
            cmbRoomType.SelectedIndex = -1;
        }

        int roomId;
        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,room_id from rooms where room_no = '" + cmbRoomNo.Text + "' ";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            roomId = int.Parse(ds.Tables[0].Rows[0][0].ToString());

        }

        int y = 1;
        private void BtnAllocateRoom_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="" && txtAddress.Text != "" && txtID.Text != "" && txtMobile.Text != "" && txtNationality.Text != "" && txtCheckIn.Text != "" &&txtDOB.Text != "")
            {
                String name = txtName.Text;
                String mobile = txtMobile.Text;
                String nationality = txtNationality.Text;
                String gender = cmbGeder.Text;
                String dob = txtDOB.Text;
                String id = txtID.Text;
                String address = txtAddress.Text;
                String checkIn = txtCheckIn.Text;
                String roomNo = cmbRoomNo.Text;

                query = "Insert into customer (cid,cname,mobile,nationality,dob,idProof,address,checkin,room_id) values ('"+y+"','"+name+"','"+mobile+"','"+nationality+"','"+dob+"','"+id+"','"+address+"','"+checkIn+"','"+roomNo+"') update rooms set booked = 'Yes' where room_no = '"+cmbRoomNo.Text+"' ";
                fn.setData(query, "Room number " + cmbRoomNo.Text + " allocation successful");
                clearAll();
                y++;
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
            txtNationality.Clear();
            txtID.Clear();
            txtMobile.Clear();
            txtDOB.ResetText();
            txtCheckIn.ResetText();
            cmbBed.SelectedIndex = -1;
            cmbRoomNo.Items.Clear();
            cmbRoomType.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void uc_cutomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
