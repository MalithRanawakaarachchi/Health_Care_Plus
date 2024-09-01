namespace Health_Care_Plus_00174336
{
    partial class frmViewDoctors
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.cbbxIDType = new System.Windows.Forms.ComboBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxIDNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlViewDoctors = new System.Windows.Forms.Panel();
            this.tbxDOCID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.cbbxSpecialization = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.cbxHome = new System.Windows.Forms.CheckBox();
            this.tbxHome = new System.Windows.Forms.TextBox();
            this.cbxMobile = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQualifications = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxLocation = new System.Windows.Forms.TextBox();
            this.tbxAvailability = new System.Windows.Forms.TextBox();
            this.tbxSearchDoctors = new System.Windows.Forms.TextBox();
            this.cbbxSelectSpecialization = new System.Windows.Forms.ComboBox();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbxLocation = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlViewDoctors.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 326);
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
            this.cbbxIDType.Location = new System.Drawing.Point(17, 346);
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
            this.tbxAddress.Location = new System.Drawing.Point(17, 237);
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
            // tbxIDNo
            // 
            this.tbxIDNo.Location = new System.Drawing.Point(431, 346);
            this.tbxIDNo.Name = "tbxIDNo";
            this.tbxIDNo.Size = new System.Drawing.Size(395, 22);
            this.tbxIDNo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // pnlViewDoctors
            // 
            this.pnlViewDoctors.Controls.Add(this.tbxDOCID);
            this.pnlViewDoctors.Controls.Add(this.label9);
            this.pnlViewDoctors.Controls.Add(this.rbtnFemale);
            this.pnlViewDoctors.Controls.Add(this.rbtnMale);
            this.pnlViewDoctors.Controls.Add(this.cbbxSpecialization);
            this.pnlViewDoctors.Controls.Add(this.dtpDOB);
            this.pnlViewDoctors.Controls.Add(this.label7);
            this.pnlViewDoctors.Controls.Add(this.label6);
            this.pnlViewDoctors.Controls.Add(this.panel3);
            this.pnlViewDoctors.Controls.Add(this.label12);
            this.pnlViewDoctors.Controls.Add(this.label1);
            this.pnlViewDoctors.Controls.Add(this.tbxQualifications);
            this.pnlViewDoctors.Controls.Add(this.tbxFirstName);
            this.pnlViewDoctors.Controls.Add(this.cbbxIDType);
            this.pnlViewDoctors.Controls.Add(this.tbxLastName);
            this.pnlViewDoctors.Controls.Add(this.tbxAddress);
            this.pnlViewDoctors.Controls.Add(this.label5);
            this.pnlViewDoctors.Controls.Add(this.tbxFullName);
            this.pnlViewDoctors.Controls.Add(this.label4);
            this.pnlViewDoctors.Controls.Add(this.tbxIDNo);
            this.pnlViewDoctors.Controls.Add(this.label2);
            this.pnlViewDoctors.Controls.Add(this.label3);
            this.pnlViewDoctors.Enabled = false;
            this.pnlViewDoctors.Location = new System.Drawing.Point(591, 12);
            this.pnlViewDoctors.Name = "pnlViewDoctors";
            this.pnlViewDoctors.Size = new System.Drawing.Size(844, 595);
            this.pnlViewDoctors.TabIndex = 20;
            // 
            // tbxDOCID
            // 
            this.tbxDOCID.Enabled = false;
            this.tbxDOCID.Location = new System.Drawing.Point(431, 237);
            this.tbxDOCID.Name = "tbxDOCID";
            this.tbxDOCID.Size = new System.Drawing.Size(395, 22);
            this.tbxDOCID.TabIndex = 23;
            this.tbxDOCID.TextChanged += new System.EventHandler(this.tbxDOCID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "DOC ID";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(107, 565);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rbtnFemale.TabIndex = 20;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(17, 565);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(59, 21);
            this.rbtnMale.TabIndex = 21;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
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
            this.cbbxSpecialization.Location = new System.Drawing.Point(17, 165);
            this.cbbxSpecialization.Name = "cbbxSpecialization";
            this.cbbxSpecialization.Size = new System.Drawing.Size(284, 24);
            this.cbbxSpecialization.TabIndex = 19;
            this.cbbxSpecialization.Text = "Specialization";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(17, 498);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(284, 22);
            this.dtpDOB.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date of Birth";
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
            this.panel3.Location = new System.Drawing.Point(331, 413);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 173);
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
            this.cbxEmail.Location = new System.Drawing.Point(18, 47);
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
            this.tbxEmail.Location = new System.Drawing.Point(118, 45);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(352, 22);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxMobile
            // 
            this.tbxMobile.Enabled = false;
            this.tbxMobile.Location = new System.Drawing.Point(118, 89);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(352, 22);
            this.tbxMobile.TabIndex = 5;
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
            // tbxHome
            // 
            this.tbxHome.Enabled = false;
            this.tbxHome.Location = new System.Drawing.Point(118, 135);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(352, 22);
            this.tbxHome.TabIndex = 5;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(428, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Qualifications";
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
            // tbxQualifications
            // 
            this.tbxQualifications.Location = new System.Drawing.Point(431, 167);
            this.tbxQualifications.Name = "tbxQualifications";
            this.tbxQualifications.Size = new System.Drawing.Size(395, 22);
            this.tbxQualifications.TabIndex = 1;
            this.tbxQualifications.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(1078, 9);
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
            this.btnDelete.Location = new System.Drawing.Point(1310, 9);
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
            this.btnUpdate.Location = new System.Drawing.Point(1194, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.tbxLocation);
            this.panel1.Controls.Add(this.tbxAvailability);
            this.panel1.Location = new System.Drawing.Point(12, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 52);
            this.panel1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Location";
            // 
            // tbxLocation
            // 
            this.tbxLocation.Location = new System.Drawing.Point(428, 15);
            this.tbxLocation.Name = "tbxLocation";
            this.tbxLocation.Size = new System.Drawing.Size(145, 22);
            this.tbxLocation.TabIndex = 1;
            // 
            // tbxAvailability
            // 
            this.tbxAvailability.Location = new System.Drawing.Point(3, 15);
            this.tbxAvailability.Name = "tbxAvailability";
            this.tbxAvailability.Size = new System.Drawing.Size(307, 22);
            this.tbxAvailability.TabIndex = 1;
            // 
            // tbxSearchDoctors
            // 
            this.tbxSearchDoctors.Location = new System.Drawing.Point(56, 31);
            this.tbxSearchDoctors.Name = "tbxSearchDoctors";
            this.tbxSearchDoctors.Size = new System.Drawing.Size(216, 22);
            this.tbxSearchDoctors.TabIndex = 22;
            this.tbxSearchDoctors.TextChanged += new System.EventHandler(this.tbxSearchDoctors_TextChanged);
            // 
            // cbbxSelectSpecialization
            // 
            this.cbbxSelectSpecialization.FormattingEnabled = true;
            this.cbbxSelectSpecialization.Items.AddRange(new object[] {
            "All",
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
            this.cbbxSelectSpecialization.Location = new System.Drawing.Point(315, 31);
            this.cbbxSelectSpecialization.Name = "cbbxSelectSpecialization";
            this.cbbxSelectSpecialization.Size = new System.Drawing.Size(246, 24);
            this.cbbxSelectSpecialization.TabIndex = 19;
            this.cbbxSelectSpecialization.Text = "Specialization";
            this.cbbxSelectSpecialization.SelectedIndexChanged += new System.EventHandler(this.cbbxSelectSpecialization_SelectedIndexChanged);
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First name";
            this.first_name.Name = "first_name";
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last name";
            this.last_name.Name = "last_name";
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullname,
            this.address,
            this.idtype,
            this.idno,
            this.specialization1,
            this.dob,
            this.gender,
            this.email,
            this.mobile,
            this.home,
            this.id,
            this.schedule,
            this.qualifications});
            this.dgvDoctors.Location = new System.Drawing.Point(12, 133);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(573, 474);
            this.dgvDoctors.TabIndex = 23;
            this.dgvDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Search By";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbxLocation);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.cbbxSelectSpecialization);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbxSearchDoctors);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 100);
            this.panel2.TabIndex = 24;
            // 
            // cbbxLocation
            // 
            this.cbbxLocation.FormattingEnabled = true;
            this.cbbxLocation.Items.AddRange(new object[] {
            "G01",
            "G02",
            "G03",
            "G04",
            "G05",
            "G06",
            "G07",
            "G08",
            "G09",
            "G10",
            "G11",
            "G12",
            "G13",
            "G14",
            "G15",
            "A01",
            "A02",
            "A03",
            "A04",
            "A05",
            "A06",
            "A07",
            "A08",
            "A09",
            "A10",
            "A11",
            "A12",
            "A13",
            "A14",
            "A15",
            "B01",
            "B02",
            "B03",
            "B04",
            "B05",
            "B06",
            "B07",
            "B08",
            "B09",
            "B10",
            "B11",
            "B12",
            "B13",
            "B14",
            "B15"});
            this.cbbxLocation.Location = new System.Drawing.Point(315, 65);
            this.cbbxLocation.Name = "cbbxLocation";
            this.cbbxLocation.Size = new System.Drawing.Size(246, 24);
            this.cbbxLocation.TabIndex = 24;
            this.cbbxLocation.Text = "Location";
            this.cbbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbbxLocation_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(8, 67);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(264, 22);
            this.dtpDate.TabIndex = 23;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpAppointment_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Name";
            // 
            // fullname
            // 
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            this.fullname.Width = 200;
            // 
            // address
            // 
            this.address.HeaderText = "address";
            this.address.Name = "address";
            this.address.Visible = false;
            // 
            // idtype
            // 
            this.idtype.HeaderText = "idtype";
            this.idtype.Name = "idtype";
            this.idtype.Visible = false;
            // 
            // idno
            // 
            this.idno.HeaderText = "idno";
            this.idno.Name = "idno";
            this.idno.Visible = false;
            // 
            // specialization1
            // 
            this.specialization1.HeaderText = "specialization";
            this.specialization1.Name = "specialization1";
            this.specialization1.Width = 185;
            // 
            // dob
            // 
            this.dob.HeaderText = "dob";
            this.dob.Name = "dob";
            this.dob.Visible = false;
            // 
            // gender
            // 
            this.gender.HeaderText = "gender";
            this.gender.Name = "gender";
            this.gender.Visible = false;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.Visible = false;
            // 
            // mobile
            // 
            this.mobile.HeaderText = "mobile";
            this.mobile.Name = "mobile";
            this.mobile.Visible = false;
            // 
            // home
            // 
            this.home.HeaderText = "home";
            this.home.Name = "home";
            this.home.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // schedule
            // 
            this.schedule.HeaderText = "schedule";
            this.schedule.Name = "schedule";
            this.schedule.Visible = false;
            // 
            // qualifications
            // 
            this.qualifications.HeaderText = "qualifications";
            this.qualifications.Name = "qualifications";
            // 
            // frmViewDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1447, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.pnlViewDoctors);
            this.Controls.Add(this.panel1);
            this.Name = "frmViewDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Doctors";
            this.Load += new System.EventHandler(this.frmViewDoctors_Load);
            this.pnlViewDoctors.ResumeLayout(false);
            this.pnlViewDoctors.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.ComboBox cbbxIDType;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxIDNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlViewDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxSearchDoctors;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.ComboBox cbbxSpecialization;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.CheckBox cbxHome;
        private System.Windows.Forms.TextBox tbxHome;
        private System.Windows.Forms.CheckBox cbxMobile;
        private System.Windows.Forms.TextBox tbxAvailability;
        private System.Windows.Forms.ComboBox cbbxSelectSpecialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.TextBox tbxDOCID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxLocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxQualifications;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbbxLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn idno;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualifications;
    }
}