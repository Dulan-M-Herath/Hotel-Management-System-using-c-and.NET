using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.User_controlls
{
    public partial class uc_AddRoom : UserControl
    {

        function fn = new function();
        String query;

        public uc_AddRoom()
        {
            InitializeComponent();
        }

        private void uc_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoomConfirmation_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" &&  txtPrice.Text != "")
            {
                String room_no = txtRoomNo.Text;
                String type = cmbRoomType.Text;
                String bed = cmbBed.Text;
                int price = int.Parse (txtPrice.Text);
                int x=5;

                

                query = "Insert into rooms(room_id,room_no,room_type,bed,price,booked) values('"+x+"','"+room_no+"','"+type+"','"+bed+"','"+price+"','No')";
                fn.setData(query, "Room Added");
                x++;

                uc_AddRoom_Load(this, null);

            }
            else
            {
                MessageBox.Show("please fill all the fields!!");
            }
        }
        public void clearAll()
        {
            txtRoomNo.Clear();
            txtPrice.Clear();
            cmbBed.SelectedIndex = -1;
            cmbRoomType.SelectedIndex = -1;
        }

        private void uc_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void guna2DataGridView2_Enter(object sender, EventArgs e)
        {
            uc_AddRoom_Load(this, null);
        }
    }
}
