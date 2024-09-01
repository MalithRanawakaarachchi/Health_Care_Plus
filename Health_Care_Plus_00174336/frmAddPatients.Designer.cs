namespace Health_Care_Plus_00174336
{
    partial class frmAddPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPatients));
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxIDno = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbbxIDType = new System.Windows.Forms.ComboBox();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.cbxMobile = new System.Windows.Forms.CheckBox();
            this.tbxHome = new System.Windows.Forms.TextBox();
            this.cbxHome = new System.Windows.Forms.CheckBox();
            this.tbxOffice = new System.Windows.Forms.TextBox();
            this.cbxOffice = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlAddPatient = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlAddPatient.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFirstName.Location = new System.Drawing.Point(16, 37);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(395, 22);
            this.tbxFirstName.TabIndex = 1;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(430, 37);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(395, 22);
            this.tbxLastName.TabIndex = 2;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(16, 162);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(809, 66);
            this.tbxAddress.TabIndex = 4;
            // 
            // tbxFullName
            // 
            this.tbxFullName.Enabled = false;
            this.tbxFullName.Location = new System.Drawing.Point(16, 101);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(809, 22);
            this.tbxFullName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Location = new System.Drawing.Point(118, 45);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(352, 22);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxIDno
            // 
            this.tbxIDno.Location = new System.Drawing.Point(430, 271);
            this.tbxIDno.Name = "tbxIDno";
            this.tbxIDno.Size = new System.Drawing.Size(395, 22);
            this.tbxIDno.TabIndex = 5;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(16, 354);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(284, 22);
            this.dtpDOB.TabIndex = 11;
            // 
            // cbbxIDType
            // 
            this.cbbxIDType.FormattingEnabled = true;
            this.cbbxIDType.Items.AddRange(new object[] {
            "NIC",
            "Postal",
            "Passport",
            "Driving License"});
            this.cbbxIDType.Location = new System.Drawing.Point(16, 271);
            this.cbbxIDType.Name = "cbbxIDType";
            this.cbbxIDType.Size = new System.Drawing.Size(395, 24);
            this.cbbxIDType.TabIndex = 12;
            this.cbbxIDType.Text = "Select ID Type";
            // 
            // cbxEmail
            // 
            this.cbxEmail.AutoSize = true;
            this.cbxEmail.BackColor = System.Drawing.Color.Transparent;
            this.cbxEmail.Location = new System.Drawing.Point(18, 47);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(64, 21);
            this.cbxEmail.TabIndex = 13;
            this.cbxEmail.Text = "Email";
            this.cbxEmail.UseVisualStyleBackColor = false;
            this.cbxEmail.CheckedChanged += new System.EventHandler(this.cbxEmail_CheckedChanged);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(16, 421);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(59, 21);
            this.rbtnMale.TabIndex = 14;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(106, 421);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rbtnFemale.TabIndex = 14;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // tbxMobile
            // 
            this.tbxMobile.Enabled = false;
            this.tbxMobile.Location = new System.Drawing.Point(118, 89);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(352, 22);
            this.tbxMobile.TabIndex = 5;
            // 
            // cbxMobile
            // 
            this.cbxMobile.AutoSize = true;
            this.cbxMobile.BackColor = System.Drawing.Color.Transparent;
            this.cbxMobile.Location = new System.Drawing.Point(18, 91);
            this.cbxMobile.Name = "cbxMobile";
            this.cbxMobile.Size = new System.Drawing.Size(71, 21);
            this.cbxMobile.TabIndex = 13;
            this.cbxMobile.Text = "Mobile";
            this.cbxMobile.UseVisualStyleBackColor = false;
            this.cbxMobile.CheckedChanged += new System.EventHandler(this.cbxMobile_CheckedChanged);
            // 
            // tbxHome
            // 
            this.tbxHome.Enabled = false;
            this.tbxHome.Location = new System.Drawing.Point(118, 135);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(352, 22);
            this.tbxHome.TabIndex = 5;
            // 
            // cbxHome
            // 
            this.cbxHome.AutoSize = true;
            this.cbxHome.BackColor = System.Drawing.Color.Transparent;
            this.cbxHome.Location = new System.Drawing.Point(18, 137);
            this.cbxHome.Name = "cbxHome";
            this.cbxHome.Size = new System.Drawing.Size(67, 21);
            this.cbxHome.TabIndex = 13;
            this.cbxHome.Text = "Home";
            this.cbxHome.UseVisualStyleBackColor = false;
            this.cbxHome.CheckedChanged += new System.EventHandler(this.cbxHome_CheckedChanged);
            // 
            // tbxOffice
            // 
            this.tbxOffice.Enabled = false;
            this.tbxOffice.Location = new System.Drawing.Point(118, 181);
            this.tbxOffice.Name = "tbxOffice";
            this.tbxOffice.Size = new System.Drawing.Size(352, 22);
            this.tbxOffice.TabIndex = 5;
            // 
            // cbxOffice
            // 
            this.cbxOffice.AutoSize = true;
            this.cbxOffice.BackColor = System.Drawing.Color.Transparent;
            this.cbxOffice.Location = new System.Drawing.Point(18, 183);
            this.cbxOffice.Name = "cbxOffice";
            this.cbxOffice.Size = new System.Drawing.Size(67, 21);
            this.cbxOffice.TabIndex = 13;
            this.cbxOffice.Text = "Office";
            this.cbxOffice.UseVisualStyleBackColor = false;
            this.cbxOffice.CheckedChanged += new System.EventHandler(this.cbxOffice_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 585);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 52);
            this.panel1.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(253, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(485, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(369, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlAddPatient
            // 
            this.pnlAddPatient.Controls.Add(this.panel3);
            this.pnlAddPatient.Controls.Add(this.rbtnFemale);
            this.pnlAddPatient.Controls.Add(this.label1);
            this.pnlAddPatient.Controls.Add(this.rbtnMale);
            this.pnlAddPatient.Controls.Add(this.tbxFirstName);
            this.pnlAddPatient.Controls.Add(this.cbbxIDType);
            this.pnlAddPatient.Controls.Add(this.tbxLastName);
            this.pnlAddPatient.Controls.Add(this.dtpDOB);
            this.pnlAddPatient.Controls.Add(this.tbxAddress);
            this.pnlAddPatient.Controls.Add(this.label5);
            this.pnlAddPatient.Controls.Add(this.tbxFullName);
            this.pnlAddPatient.Controls.Add(this.label4);
            this.pnlAddPatient.Controls.Add(this.tbxIDno);
            this.pnlAddPatient.Controls.Add(this.label7);
            this.pnlAddPatient.Controls.Add(this.label2);
            this.pnlAddPatient.Controls.Add(this.label6);
            this.pnlAddPatient.Controls.Add(this.label3);
            this.pnlAddPatient.Enabled = false;
            this.pnlAddPatient.Location = new System.Drawing.Point(12, 12);
            this.pnlAddPatient.Name = "pnlAddPatient";
            this.pnlAddPatient.Size = new System.Drawing.Size(844, 564);
            this.pnlAddPatient.TabIndex = 0;
            this.pnlAddPatient.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbxEmail);
            this.panel3.Controls.Add(this.tbxEmail);
            this.panel3.Controls.Add(this.cbxOffice);
            this.panel3.Controls.Add(this.tbxMobile);
            this.panel3.Controls.Add(this.cbxHome);
            this.panel3.Controls.Add(this.tbxHome);
            this.panel3.Controls.Add(this.cbxMobile);
            this.panel3.Controls.Add(this.tbxOffice);
            this.panel3.Location = new System.Drawing.Point(330, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 216);
            this.panel3.TabIndex = 15;
            // 
            // frmAddPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddPatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patients";
            this.panel1.ResumeLayout(false);
            this.pnlAddPatient.ResumeLayout(false);
            this.pnlAddPatient.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxIDno;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbbxIDType;
        private System.Windows.Forms.CheckBox cbxEmail;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.CheckBox cbxMobile;
        private System.Windows.Forms.TextBox tbxHome;
        private System.Windows.Forms.CheckBox cbxHome;
        private System.Windows.Forms.TextBox tbxOffice;
        private System.Windows.Forms.CheckBox cbxOffice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAddPatient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}