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
    public partial class uc_CustomerCheckout : UserControl
    {
        function fn = new function();
        String query;
        private readonly object cid;

        public uc_CustomerCheckout()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uc_CustomerCheckout_Load(object sender, EventArgs e)
        {
            query = " select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.room_no, rooms.room_type, rooms.bed, rooms.price from customer inner join rooms on customer.room_id = rooms.room_id where checkout = 'No'";
            DataSet ds = fn.getData(query);
            checkOutGridView.DataSource = ds.Tables[0];


        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            query = " select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.room_no, rooms.room_type, rooms.bed, rooms.price from customer inner join rooms on customer.room_id = rooms.room_id where cname like '" + txtName.Text + " %' and checkout = 'No'";
            DataSet d = fn.getData(query);
            checkOutGridView.DataSource = d.Tables[0]; 
        }

        int id;

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtCheckoutName.Text != " ")
            {
                String cdate = txtCheckOutDate.Text;
                query = "update customer set checkout = 'Yes', checkout = '" + cdate + "' where cid = '" + id + "'";
                fn.setData(query,"Done");
                uc_CustomerCheckout_Load(this, null);
            }
            else
            {
                MessageBox.Show("Not selected");
            }
        }
        


    }
}

