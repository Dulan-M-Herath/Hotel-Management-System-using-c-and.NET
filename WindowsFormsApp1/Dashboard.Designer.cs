using WindowsFormsApp1.User_controlls;

namespace WindowsFormsApp1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMovingPannel = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustReg = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uc_customerdetails1 = new WindowsFormsApp1.User_controlls.uc_customerdetails();
            this.uc_CustomerCheckout1 = new WindowsFormsApp1.User_controlls.uc_CustomerCheckout();
            this.uc_AddRoom1 = new WindowsFormsApp1.User_controlls.uc_AddRoom();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uc_cutomerRegistration1 = new WindowsFormsApp1.User_controlls.uc_cutomerRegistration();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pnlMovingPannel);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustDetails);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCustReg);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(84, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 130);
            this.panel1.TabIndex = 0;
            // 
            // pnlMovingPannel
            // 
            this.pnlMovingPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMovingPannel.Location = new System.Drawing.Point(36, 112);
            this.pnlMovingPannel.Name = "pnlMovingPannel";
            this.pnlMovingPannel.Size = new System.Drawing.Size(200, 5);
            this.pnlMovingPannel.TabIndex = 0;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 20;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployee.Location = new System.Drawing.Point(1144, 21);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(236, 85);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustDetails
            // 
            this.btnCustDetails.BorderRadius = 20;
            this.btnCustDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustDetails.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnCustDetails.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnCustDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustDetails.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.btnCustDetails.CheckedState.Parent = this.btnCustDetails;
            this.btnCustDetails.CustomImages.Parent = this.btnCustDetails;
            this.btnCustDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCustDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustDetails.HoverState.Parent = this.btnCustDetails;
            this.btnCustDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCustDetails.Image")));
            this.btnCustDetails.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustDetails.Location = new System.Drawing.Point(852, 21);
            this.btnCustDetails.Name = "btnCustDetails";
            this.btnCustDetails.ShadowDecoration.Parent = this.btnCustDetails;
            this.btnCustDetails.Size = new System.Drawing.Size(262, 85);
            this.btnCustDetails.TabIndex = 3;
            this.btnCustDetails.Text = "Customer Details";
            this.btnCustDetails.Click += new System.EventHandler(this.btnCustDetails_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 20;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCheckOut.Location = new System.Drawing.Point(567, 21);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(236, 85);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnCustReg
            // 
            this.btnCustReg.BorderRadius = 20;
            this.btnCustReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustReg.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnCustReg.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnCustReg.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustReg.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.btnCustReg.CheckedState.Parent = this.btnCustReg;
            this.btnCustReg.CustomImages.Parent = this.btnCustReg;
            this.btnCustReg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCustReg.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustReg.ForeColor = System.Drawing.Color.White;
            this.btnCustReg.HoverState.Parent = this.btnCustReg;
            this.btnCustReg.Image = ((System.Drawing.Image)(resources.GetObject("btnCustReg.Image")));
            this.btnCustReg.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustReg.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCustReg.Location = new System.Drawing.Point(306, 21);
            this.btnCustReg.Name = "btnCustReg";
            this.btnCustReg.ShadowDecoration.Parent = this.btnCustReg;
            this.btnCustReg.Size = new System.Drawing.Size(255, 85);
            this.btnCustReg.TabIndex = 1;
            this.btnCustReg.Text = "Customer Registration";
            this.btnCustReg.Click += new System.EventHandler(this.btnCustReg_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 20;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddRoom.Location = new System.Drawing.Point(19, 21);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(236, 85);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_cutomerRegistration1);
            this.panel2.Controls.Add(this.uc_customerdetails1);
            this.panel2.Controls.Add(this.uc_CustomerCheckout1);
            this.panel2.Controls.Add(this.uc_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(40, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1484, 793);
            this.panel2.TabIndex = 1;
            // 
            // uc_customerdetails1
            // 
            this.uc_customerdetails1.BackColor = System.Drawing.Color.White;
            this.uc_customerdetails1.Location = new System.Drawing.Point(3, 3);
            this.uc_customerdetails1.Name = "uc_customerdetails1";
            this.uc_customerdetails1.Size = new System.Drawing.Size(1431, 768);
            this.uc_customerdetails1.TabIndex = 3;
            // 
            // uc_CustomerCheckout1
            // 
            this.uc_CustomerCheckout1.BackColor = System.Drawing.Color.White;
            this.uc_CustomerCheckout1.Location = new System.Drawing.Point(3, 3);
            this.uc_CustomerCheckout1.Name = "uc_CustomerCheckout1";
            this.uc_CustomerCheckout1.Size = new System.Drawing.Size(1431, 771);
            this.uc_CustomerCheckout1.TabIndex = 2;
            // 
            // uc_AddRoom1
            // 
            this.uc_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uc_AddRoom1.Location = new System.Drawing.Point(3, 3);
            this.uc_AddRoom1.Name = "uc_AddRoom1";
            this.uc_AddRoom1.Size = new System.Drawing.Size(1431, 771);
            this.uc_AddRoom1.TabIndex = 0;
            this.uc_AddRoom1.Visible = false;
            this.uc_AddRoom1.Load += new System.EventHandler(this.uc_AddRoom1_Load);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(12, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(52, 56);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMinimize.Location = new System.Drawing.Point(12, 94);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(52, 56);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // uc_cutomerRegistration1
            // 
            this.uc_cutomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uc_cutomerRegistration1.Location = new System.Drawing.Point(3, 3);
            this.uc_cutomerRegistration1.Name = "uc_cutomerRegistration1";
            this.uc_cutomerRegistration1.Size = new System.Drawing.Size(1431, 771);
            this.uc_cutomerRegistration1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1513, 1034);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustDetails;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustReg;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.Panel pnlMovingPannel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private User_controlls.uc_AddRoom uc_AddRoom1;
        private User_controlls.uc_cutomerRegistration uc_CutomerRegistration;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private uc_CustomerCheckout uc_CustomerCheckout1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private uc_customerdetails uc_customerdetails1;
        private uc_cutomerRegistration uc_cutomerRegistration1;
    }
}