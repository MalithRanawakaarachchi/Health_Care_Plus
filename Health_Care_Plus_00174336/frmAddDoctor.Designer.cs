namespace Health_Care_Plus_00174336
{
    partial class frmAddDoctor
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.cbxHome = new System.Windows.Forms.CheckBox();
            this.tbxHome = new System.Windows.Forms.TextBox();
            this.cbxMobile = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlAddDoctor = new System.Windows.Forms.Panel();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.cbbxSpecialization = new System.Windows.Forms.ComboBox();
            this.cbbxIDType = new System.Windows.Forms.ComboBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxIDNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxQualifications = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAddDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(253, 9);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 34);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(485, 9);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 34);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.panel3.Location = new System.Drawing.Point(331, 396);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 174);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Contact Details";
            // 
            // cbxEmail
            // 
            this.cbxEmail.AutoSize = true;
            this.cbxEmail.BackColor = System.Drawing.Color.Transparent;
            this.cbxEmail.Location = new System.Drawing.Point(19, 47);
            this.cbxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tbxEmail.Location = new System.Drawing.Point(117, 46);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(352, 22);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxMobile
            // 
            this.tbxMobile.Enabled = false;
            this.tbxMobile.Location = new System.Drawing.Point(117, 89);
            this.tbxMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(352, 22);
            this.tbxMobile.TabIndex = 5;
            // 
            // cbxHome
            // 
            this.cbxHome.AutoSize = true;
            this.cbxHome.BackColor = System.Drawing.Color.Transparent;
            this.cbxHome.Location = new System.Drawing.Point(19, 137);
            this.cbxHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tbxHome.Location = new System.Drawing.Point(117, 135);
            this.tbxHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(352, 22);
            this.tbxHome.TabIndex = 5;
            // 
            // cbxMobile
            // 
            this.cbxMobile.AutoSize = true;
            this.cbxMobile.BackColor = System.Drawing.Color.Transparent;
            this.cbxMobile.Location = new System.Drawing.Point(19, 91);
            this.cbxMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMobile.Name = "cbxMobile";
            this.cbxMobile.Size = new System.Drawing.Size(71, 21);
            this.cbxMobile.TabIndex = 13;
            this.cbxMobile.Text = "Mobile";
            this.cbxMobile.UseVisualStyleBackColor = false;
            this.cbxMobile.CheckedChanged += new System.EventHandler(this.cbxMobile_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(13, 606);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 52);
            this.panel1.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(369, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlAddDoctor
            // 
            this.pnlAddDoctor.Controls.Add(this.panel3);
            this.pnlAddDoctor.Controls.Add(this.rbtnFemale);
            this.pnlAddDoctor.Controls.Add(this.label1);
            this.pnlAddDoctor.Controls.Add(this.rbtnMale);
            this.pnlAddDoctor.Controls.Add(this.tbxFirstName);
            this.pnlAddDoctor.Controls.Add(this.cbbxSpecialization);
            this.pnlAddDoctor.Controls.Add(this.cbbxIDType);
            this.pnlAddDoctor.Controls.Add(this.tbxLastName);
            this.pnlAddDoctor.Controls.Add(this.dtpDOB);
            this.pnlAddDoctor.Controls.Add(this.tbxAddress);
            this.pnlAddDoctor.Controls.Add(this.label5);
            this.pnlAddDoctor.Controls.Add(this.tbxFullName);
            this.pnlAddDoctor.Controls.Add(this.label4);
            this.pnlAddDoctor.Controls.Add(this.tbxQualifications);
            this.pnlAddDoctor.Controls.Add(this.tbxIDNo);
            this.pnlAddDoctor.Controls.Add(this.label7);
            this.pnlAddDoctor.Controls.Add(this.label9);
            this.pnlAddDoctor.Controls.Add(this.label2);
            this.pnlAddDoctor.Controls.Add(this.label6);
            this.pnlAddDoctor.Controls.Add(this.label3);
            this.pnlAddDoctor.Enabled = false;
            this.pnlAddDoctor.Location = new System.Drawing.Point(12, 12);
            this.pnlAddDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddDoctor.Name = "pnlAddDoctor";
            this.pnlAddDoctor.Size = new System.Drawing.Size(844, 590);
            this.pnlAddDoctor.TabIndex = 16;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(107, 548);
            this.rbtnFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rbtnFemale.TabIndex = 14;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
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
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(16, 548);
            this.rbtnMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(59, 21);
            this.rbtnMale.TabIndex = 14;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFirstName.Location = new System.Drawing.Point(16, 37);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(395, 22);
            this.tbxFirstName.TabIndex = 1;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // cbbxSpecialization
            // 
            this.cbbxSpecialization.FormattingEnabled = true;
            this.cbbxSpecialization.Items.AddRange(new object[] {
            "Cardiologist",
            "Dermatologist",
            "Orthopedic Surgeon",
            "Neurologist",
            "Gastroenterologist",
            "Endocrinologist",
            "Ophthalmologist",
            "Otolaryngologist (ENT Specialist)",
            "Pulmonologist",
            "Psychiatrist",
            "Obstetrician/Gynecologist (OB/GYN)",
            "Pediatrician",
            "Rheumatologist",
            "Urologist",
            "Nephrologist",
            "Hematologist",
            "Emergency Medicine Physician",
            "Anesthesiologist",
            "Radiologist",
            "Pathologist",
            "Allergist/Immunologist",
            "Infectious Disease Specialist",
            "Geriatrician",
            "Plastic Surgeon",
            "Sports Medicine Physician"});
            this.cbbxSpecialization.Location = new System.Drawing.Point(16, 396);
            this.cbbxSpecialization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxSpecialization.Name = "cbbxSpecialization";
            this.cbbxSpecialization.Size = new System.Drawing.Size(284, 24);
            this.cbbxSpecialization.TabIndex = 12;
            this.cbbxSpecialization.Text = "Select Specialization";
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
            this.cbbxIDType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxIDType.Name = "cbbxIDType";
            this.cbbxIDType.Size = new System.Drawing.Size(395, 24);
            this.cbbxIDType.TabIndex = 12;
            this.cbbxIDType.Text = "Select ID Type";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(429, 37);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(395, 22);
            this.tbxLastName.TabIndex = 2;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(16, 481);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(284, 22);
            this.dtpDOB.TabIndex = 11;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(16, 162);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(809, 66);
            this.tbxAddress.TabIndex = 4;
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
            // tbxFullName
            // 
            this.tbxFullName.Enabled = false;
            this.tbxFullName.Location = new System.Drawing.Point(16, 101);
            this.tbxFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(809, 22);
            this.tbxFullName.TabIndex = 5;
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
            // tbxIDNo
            // 
            this.tbxIDNo.Location = new System.Drawing.Point(429, 271);
            this.tbxIDNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxIDNo.Name = "tbxIDNo";
            this.tbxIDNo.Size = new System.Drawing.Size(395, 22);
            this.tbxIDNo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date of Birth";
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
            // tbxQualifications
            // 
            this.tbxQualifications.Location = new System.Drawing.Point(16, 337);
            this.tbxQualifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxQualifications.Name = "tbxQualifications";
            this.tbxQualifications.Size = new System.Drawing.Size(808, 22);
            this.tbxQualifications.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Qualifications";
            // 
            // frmAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddDoctor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctor";
            this.Load += new System.EventHandler(this.frmAddDoctor_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlAddDoctor.ResumeLayout(false);
            this.pnlAddDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.CheckBox cbxHome;
        private System.Windows.Forms.TextBox tbxHome;
        private System.Windows.Forms.CheckBox cbxMobile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlAddDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.ComboBox cbbxSpecialization;
        private System.Windows.Forms.ComboBox cbbxIDType;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxIDNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxQualifications;
        private System.Windows.Forms.Label label9;
    }
}