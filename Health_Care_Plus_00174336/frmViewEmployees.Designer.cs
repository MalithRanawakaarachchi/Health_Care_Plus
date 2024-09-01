namespace Health_Care_Plus_00174336
{
    partial class frmViewEmployees
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
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.cbbxIDType = new System.Windows.Forms.ComboBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxIDno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlViewEmployees = new System.Windows.Forms.Panel();
            this.tbxEMPID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.cbxHome = new System.Windows.Forms.CheckBox();
            this.tbxHome = new System.Windows.Forms.TextBox();
            this.cbxMobile = new System.Windows.Forms.CheckBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.cbbxPosition = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cbxGeneratePasword = new System.Windows.Forms.CheckBox();
            this.pnlViewEmployees.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 16;
            this.lbxEmployees.Location = new System.Drawing.Point(12, 56);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(312, 516);
            this.lbxEmployees.TabIndex = 21;
            this.lbxEmployees.SelectedIndexChanged += new System.EventHandler(this.lbxEmployees_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID no";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(17, 37);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(395, 22);
            this.tbxFirstName.TabIndex = 1;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // cbbxIDType
            // 
            this.cbbxIDType.FormattingEnabled = true;
            this.cbbxIDType.Items.AddRange(new object[] {
            "NIC",
            "Postal",
            "Passport",
            "Driving License"});
            this.cbbxIDType.Location = new System.Drawing.Point(17, 271);
            this.cbbxIDType.Name = "cbbxIDType";
            this.cbbxIDType.Size = new System.Drawing.Size(395, 24);
            this.cbbxIDType.TabIndex = 12;
            this.cbbxIDType.Text = "Select ID Type";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(431, 37);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(395, 22);
            this.tbxLastName.TabIndex = 2;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(17, 162);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(395, 66);
            this.tbxAddress.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // tbxFullName
            // 
            this.tbxFullName.Enabled = false;
            this.tbxFullName.Location = new System.Drawing.Point(17, 101);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(809, 22);
            this.tbxFullName.TabIndex = 5;
            this.tbxFullName.TextChanged += new System.EventHandler(this.tbxFullName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Full Name";
            // 
            // tbxIDno
            // 
            this.tbxIDno.Location = new System.Drawing.Point(431, 271);
            this.tbxIDno.Name = "tbxIDno";
            this.tbxIDno.Size = new System.Drawing.Size(395, 22);
            this.tbxIDno.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // pnlViewEmployees
            // 
            this.pnlViewEmployees.Controls.Add(this.tbxEMPID);
            this.pnlViewEmployees.Controls.Add(this.cbxGeneratePasword);
            this.pnlViewEmployees.Controls.Add(this.label10);
            this.pnlViewEmployees.Controls.Add(this.rbtnFemale);
            this.pnlViewEmployees.Controls.Add(this.panel3);
            this.pnlViewEmployees.Controls.Add(this.rbtnMale);
            this.pnlViewEmployees.Controls.Add(this.cbbxPosition);
            this.pnlViewEmployees.Controls.Add(this.dtpDOB);
            this.pnlViewEmployees.Controls.Add(this.label1);
            this.pnlViewEmployees.Controls.Add(this.tbxPassword);
            this.pnlViewEmployees.Controls.Add(this.tbxFirstName);
            this.pnlViewEmployees.Controls.Add(this.label7);
            this.pnlViewEmployees.Controls.Add(this.cbbxIDType);
            this.pnlViewEmployees.Controls.Add(this.tbxLastName);
            this.pnlViewEmployees.Controls.Add(this.label6);
            this.pnlViewEmployees.Controls.Add(this.tbxAddress);
            this.pnlViewEmployees.Controls.Add(this.label5);
            this.pnlViewEmployees.Controls.Add(this.tbxFullName);
            this.pnlViewEmployees.Controls.Add(this.label4);
            this.pnlViewEmployees.Controls.Add(this.tbxIDno);
            this.pnlViewEmployees.Controls.Add(this.label2);
            this.pnlViewEmployees.Controls.Add(this.label3);
            this.pnlViewEmployees.Enabled = false;
            this.pnlViewEmployees.Location = new System.Drawing.Point(335, 12);
            this.pnlViewEmployees.Name = "pnlViewEmployees";
            this.pnlViewEmployees.Size = new System.Drawing.Size(844, 560);
            this.pnlViewEmployees.TabIndex = 20;
            // 
            // tbxEMPID
            // 
            this.tbxEMPID.Enabled = false;
            this.tbxEMPID.Location = new System.Drawing.Point(431, 162);
            this.tbxEMPID.Name = "tbxEMPID";
            this.tbxEMPID.Size = new System.Drawing.Size(395, 22);
            this.tbxEMPID.TabIndex = 25;
            this.tbxEMPID.TextChanged += new System.EventHandler(this.tbxEMPID_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "EMP ID";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(107, 454);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rbtnFemale.TabIndex = 20;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbxEmail);
            this.panel3.Controls.Add(this.tbxEmail);
            this.panel3.Controls.Add(this.tbxMobile);
            this.panel3.Controls.Add(this.cbxHome);
            this.panel3.Controls.Add(this.tbxHome);
            this.panel3.Controls.Add(this.cbxMobile);
            this.panel3.Location = new System.Drawing.Point(331, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 214);
            this.panel3.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Contact Details";
            // 
            // cbxEmail
            // 
            this.cbxEmail.AutoSize = true;
            this.cbxEmail.BackColor = System.Drawing.Color.Transparent;
            this.cbxEmail.Location = new System.Drawing.Point(18, 62);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(64, 21);
            this.cbxEmail.TabIndex = 13;
            this.cbxEmail.Text = "Email";
            this.cbxEmail.UseVisualStyleBackColor = false;
            this.cbxEmail.CheckedChanged += new System.EventHandler(this.cbxEmail_CheckedChanged);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Location = new System.Drawing.Point(118, 60);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(352, 22);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxMobile
            // 
            this.tbxMobile.Enabled = false;
            this.tbxMobile.Location = new System.Drawing.Point(118, 104);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(352, 22);
            this.tbxMobile.TabIndex = 5;
            // 
            // cbxHome
            // 
            this.cbxHome.AutoSize = true;
            this.cbxHome.BackColor = System.Drawing.Color.Transparent;
            this.cbxHome.Location = new System.Drawing.Point(18, 152);
            this.cbxHome.Name = "cbxHome";
            this.cbxHome.Size = new System.Drawing.Size(67, 21);
            this.cbxHome.TabIndex = 13;
            this.cbxHome.Text = "Home";
            this.cbxHome.UseVisualStyleBackColor = false;
            this.cbxHome.CheckedChanged += new System.EventHandler(this.cbxHome_CheckedChanged);
            // 
            // tbxHome
            // 
            this.tbxHome.Enabled = false;
            this.tbxHome.Location = new System.Drawing.Point(118, 150);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(352, 22);
            this.tbxHome.TabIndex = 5;
            // 
            // cbxMobile
            // 
            this.cbxMobile.AutoSize = true;
            this.cbxMobile.BackColor = System.Drawing.Color.Transparent;
            this.cbxMobile.Location = new System.Drawing.Point(18, 106);
            this.cbxMobile.Name = "cbxMobile";
            this.cbxMobile.Size = new System.Drawing.Size(71, 21);
            this.cbxMobile.TabIndex = 13;
            this.cbxMobile.Text = "Mobile";
            this.cbxMobile.UseVisualStyleBackColor = false;
            this.cbxMobile.CheckedChanged += new System.EventHandler(this.cbxMobile_CheckedChanged);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(17, 454);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(59, 21);
            this.rbtnMale.TabIndex = 21;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // cbbxPosition
            // 
            this.cbbxPosition.FormattingEnabled = true;
            this.cbbxPosition.Items.AddRange(new object[] {
            "Hospital Administrator",
            "Chief Executive Officer (CEO)",
            "Chief Medical Officer (CMO)",
            "Chief Nursing Officer (CNO)",
            "Chief Operating Officer (COO)",
            "Chief Financial Officer (CFO)",
            "HR Manager",
            "Medical Director",
            "Nursing Supervisor",
            "Certified Nursing Assistant (CNA)",
            "Operating Officer",
            "Pharmacist",
            "Social Worker"});
            this.cbbxPosition.Location = new System.Drawing.Point(17, 328);
            this.cbbxPosition.Name = "cbbxPosition";
            this.cbbxPosition.Size = new System.Drawing.Size(283, 24);
            this.cbbxPosition.TabIndex = 19;
            this.cbbxPosition.Text = "Select Position";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(17, 388);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(284, 22);
            this.dtpDOB.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Enabled = false;
            this.tbxPassword.Location = new System.Drawing.Point(17, 524);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(276, 22);
            this.tbxPassword.TabIndex = 15;
            this.tbxPassword.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date of Birth";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(413, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(645, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(529, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(12, 580);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 52);
            this.panel1.TabIndex = 23;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(12, 18);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(312, 22);
            this.tbxSearch.TabIndex = 22;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // cbxGeneratePasword
            // 
            this.cbxGeneratePasword.AutoSize = true;
            this.cbxGeneratePasword.BackColor = System.Drawing.Color.Transparent;
            this.cbxGeneratePasword.Location = new System.Drawing.Point(17, 500);
            this.cbxGeneratePasword.Name = "cbxGeneratePasword";
            this.cbxGeneratePasword.Size = new System.Drawing.Size(177, 21);
            this.cbxGeneratePasword.TabIndex = 13;
            this.cbxGeneratePasword.Text = "Generate new Pasword";
            this.cbxGeneratePasword.UseVisualStyleBackColor = false;
            this.cbxGeneratePasword.Visible = false;
            this.cbxGeneratePasword.CheckedChanged += new System.EventHandler(this.cbxEmail_CheckedChanged);
            // 
            // frmViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 644);
            this.Controls.Add(this.lbxEmployees);
            this.Controls.Add(this.pnlViewEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxSearch);
            this.Name = "frmViewEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employees";
            this.Load += new System.EventHandler(this.frmViewEmployees_Load);
            this.pnlViewEmployees.ResumeLayout(false);
            this.pnlViewEmployees.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.ComboBox cbbxIDType;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxIDno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlViewEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.CheckBox cbxHome;
        private System.Windows.Forms.TextBox tbxHome;
        private System.Windows.Forms.CheckBox cbxMobile;
        private System.Windows.Forms.ComboBox cbbxPosition;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxEMPID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbxGeneratePasword;
    }
}