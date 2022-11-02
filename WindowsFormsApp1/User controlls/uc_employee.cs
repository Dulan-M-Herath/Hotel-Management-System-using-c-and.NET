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
    public partial class uc_employee : UserControl
    {
        function fn = new function();
        String q;
        public uc_employee()
        {
            InitializeComponent();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void uc_employee_Load(object sender, EventArgs e)
        {
            getMaxId();
        }

        public void getMaxId()
        {
            q = "select max(eid) from employee";
            DataSet ds = fn.getData(q);

            if (ds.Tables[0].Rows[0][0].ToString() != " ")
            {
                Int64 num = Convert.ToInt64(ds.Tables[0].Rows[0][0].ToString());
                txtEmpID.Text = (num + 1).ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text != "" && txtEmpMail.Text != "" && txtEmpMobile.Text!= "" && txtEmpName.Text!="" && txtEmpUserName.Text!="" && txtEmpPasswdor.Text != "" && cmbGender.Text != "")
            {
                String name = txtEmpName.Text;
                String mobile = txtEmpMobile.Text;
                String gender = cmbGender.Text;
                String email = txtEmpMail.Text;
                String userName = txtEmpUserName.Text;
                String password = txtEmpPasswdor.Text;

                q =  "insert into employee(ename,mobile,gender,email,username,password) values('"+name+"','"+mobile+"',"+gender+"','"+email+"','"+userName+"','"+password+")";

                fn.setData(q, "Employee registered");

                clearAll();

                getMaxId();
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        public void clearAll()
        {
            txtEmpID.Clear();
            txtEmpMail.Clear();
            txtEmpMobile.Clear();
            txtEmpName.Clear();
            txtEmpPasswdor.Clear();
            txtEmpUserName.Clear();
            cmbGender.TabIndex = -1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                getEmpReport();
            }
            else if(tabControl1.SelectedIndex == 2)
            {
                getEmpReport();
            }
        }

        public void getEmpReport()
        {
            q = "select * from employee";
            DataSet ds = fn.getData(q);
            EmpDetailGridView.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            q = "delete from employee where eid= " + txtEmpID.Text + "";
            fn.setData(q, "Deleted");
            tabControl1_SelectedIndexChanged(this, null);

        }
    }
}
