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
    public partial class uc_customerdetails : UserControl
    {
        function fn = new function();
        String query;
        public uc_customerdetails()
        {
            InitializeComponent();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBy.SelectedIndex == 0)
            {
                query = " select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.room_no, rooms.room_type, rooms.bed, rooms.price from customer inner join rooms on customer.room_id = rooms.room_id";
                DataSet ds = fn.getData(query);
                DataGridCustDetails.DataSource = ds.Tables[0];
            }
            else if(txtSearchBy.SelectedIndex == 1)
            {
                query = " select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.room_no, rooms.room_type, rooms.bed, rooms.price from customer inner join rooms on customer.room_id = rooms.room_id where checkout is null";
                DataSet ds = fn.getData(query);
                DataGridCustDetails.DataSource = ds.Tables[0];
            }
            else if(txtSearchBy.SelectedIndex == 1)
            {
                query = " select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.room_no, rooms.room_type, rooms.bed, rooms.price from customer inner join rooms on customer.room_id = rooms.room_id where checkout is not null";
                DataSet ds = fn.getData(query);
                DataGridCustDetails.DataSource = ds.Tables[0];
            }
        }
    }
}
