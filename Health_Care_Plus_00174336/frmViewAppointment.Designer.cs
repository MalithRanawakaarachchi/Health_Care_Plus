namespace Health_Care_Plus_00174336
{
    partial class frmViewAppointment
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
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ttime_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channelling_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSearchDoctors = new System.Windows.Forms.TextBox();
            this.cbbxSelectSpecialization = new System.Windows.Forms.ComboBox();
            this.tbxSearchAppointments = new System.Windows.Forms.TextBox();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDoctorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPatientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxChannelingNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRoomNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDocNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPatientNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlViewAppointments = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTimeTo = new System.Windows.Forms.TextBox();
            this.tbxTimeFrom = new System.Windows.Forms.TextBox();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxTodayAvailable = new System.Windows.Forms.CheckBox();
            this.dtpSelectAppointments = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.pnlEditAppointments = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.pnlViewAppointments.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.pnlEditAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.patient_id,
            this.patientName,
            this.doc_id,
            this.doc_name,
            this.specialization,
            this.Ttime_from,
            this.time_to,
            this.room_no,
            this.channelling_no});
            this.dgvAppointments.Location = new System.Drawing.Point(31, 52);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.Size = new System.Drawing.Size(1228, 301);
            this.dgvAppointments.TabIndex = 0;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // patient_id
            // 
            this.patient_id.HeaderText = "Patient ID";
            this.patient_id.Name = "patient_id";
            // 
            // patientName
            // 
            this.patientName.HeaderText = "Patient Name";
            this.patientName.Name = "patientName";
            this.patientName.Width = 200;
            // 
            // doc_id
            // 
            this.doc_id.HeaderText = "Doctor ID";
            this.doc_id.Name = "doc_id";
            // 
            // doc_name
            // 
            this.doc_name.HeaderText = "Doctor Name";
            this.doc_name.Name = "doc_name";
            this.doc_name.Width = 200;
            // 
            // specialization
            // 
            this.specialization.HeaderText = "Specialization";
            this.specialization.Name = "specialization";
            this.specialization.Width = 178;
            // 
            // Ttime_from
            // 
            this.Ttime_from.HeaderText = "Time From";
            this.Ttime_from.Name = "Ttime_from";
            this.Ttime_from.Visible = false;
            // 
            // time_to
            // 
            this.time_to.HeaderText = "Time To";
            this.time_to.Name = "time_to";
            this.time_to.Visible = false;
            // 
            // room_no
            // 
            this.room_no.HeaderText = "Room No";
            this.room_no.Name = "room_no";
            this.room_no.Visible = false;
            // 
            // channelling_no
            // 
            this.channelling_no.HeaderText = "Channelling No";
            this.channelling_no.Name = "channelling_no";
            this.channelling_no.Visible = false;
            // 
            // tbxSearchDoctors
            // 
            this.tbxSearchDoctors.Location = new System.Drawing.Point(3, 0);
            this.tbxSearchDoctors.Name = "tbxSearchDoctors";
            this.tbxSearchDoctors.Size = new System.Drawing.Size(312, 22);
            this.tbxSearchDoctors.TabIndex = 20;
            this.tbxSearchDoctors.TextChanged += new System.EventHandler(this.tbxSearchDoctors_TextChanged);
            // 
            // cbbxSelectSpecialization
            // 
            this.cbbxSelectSpecialization.FormattingEnabled = true;
            this.cbbxSelectSpecialization.Items.AddRange(new object[] {
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
            this.cbbxSelectSpecialization.Location = new System.Drawing.Point(3, 28);
            this.cbbxSelectSpecialization.Name = "cbbxSelectSpecialization";
            this.cbbxSelectSpecialization.Size = new System.Drawing.Size(312, 24);
            this.cbbxSelectSpecialization.TabIndex = 33;
            this.cbbxSelectSpecialization.Text = "Specialization";
            this.cbbxSelectSpecialization.SelectedIndexChanged += new System.EventHandler(this.cbbxSelectSpecialization_SelectedIndexChanged);
            // 
            // tbxSearchAppointments
            // 
            this.tbxSearchAppointments.Location = new System.Drawing.Point(31, 12);
            this.tbxSearchAppointments.Name = "tbxSearchAppointments";
            this.tbxSearchAppointments.Size = new System.Drawing.Size(312, 22);
            this.tbxSearchAppointments.TabIndex = 20;
            this.tbxSearchAppointments.TextChanged += new System.EventHandler(this.tbxSearchAppointments_TextChanged);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_,
            this.Doctor,
            this.specialization_,
            this.from,
            this.to,
            this.datee});
            this.dgvDoctors.Location = new System.Drawing.Point(3, 113);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(417, 222);
            this.dgvDoctors.TabIndex = 0;
            this.dgvDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellContentClick);
            // 
            // id_
            // 
            this.id_.HeaderText = "id";
            this.id_.Name = "id_";
            this.id_.Visible = false;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.Name = "Doctor";
            this.Doctor.Width = 160;
            // 
            // specialization_
            // 
            this.specialization_.HeaderText = "Specialization";
            this.specialization_.Name = "specialization_";
            this.specialization_.Width = 130;
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.Visible = false;
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.Visible = false;
            // 
            // datee
            // 
            this.datee.HeaderText = "datee";
            this.datee.Name = "datee";
            this.datee.Visible = false;
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(6, 24);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(267, 22);
            this.dtpAppointment.TabIndex = 18;
            this.dtpAppointment.ValueChanged += new System.EventHandler(this.dtpAppointment_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select another day";
            // 
            // tbxDoctorName
            // 
            this.tbxDoctorName.Enabled = false;
            this.tbxDoctorName.Location = new System.Drawing.Point(17, 167);
            this.tbxDoctorName.Name = "tbxDoctorName";
            this.tbxDoctorName.Size = new System.Drawing.Size(363, 22);
            this.tbxDoctorName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doctor\'s Name";
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.Enabled = false;
            this.tbxPatientName.Location = new System.Drawing.Point(17, 91);
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Size = new System.Drawing.Size(363, 22);
            this.tbxPatientName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Patient\'s Name";
            // 
            // tbxChannelingNo
            // 
            this.tbxChannelingNo.Enabled = false;
            this.tbxChannelingNo.Location = new System.Drawing.Point(433, 306);
            this.tbxChannelingNo.Name = "tbxChannelingNo";
            this.tbxChannelingNo.Size = new System.Drawing.Size(363, 22);
            this.tbxChannelingNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Patient No";
            // 
            // tbxRoomNo
            // 
            this.tbxRoomNo.Enabled = false;
            this.tbxRoomNo.Location = new System.Drawing.Point(17, 306);
            this.tbxRoomNo.Name = "tbxRoomNo";
            this.tbxRoomNo.Size = new System.Drawing.Size(363, 22);
            this.tbxRoomNo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Room No";
            // 
            // tbxDocNo
            // 
            this.tbxDocNo.Enabled = false;
            this.tbxDocNo.Location = new System.Drawing.Point(433, 167);
            this.tbxDocNo.Name = "tbxDocNo";
            this.tbxDocNo.Size = new System.Drawing.Size(363, 22);
            this.tbxDocNo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "DOC ID";
            // 
            // tbxPatientNo
            // 
            this.tbxPatientNo.Enabled = false;
            this.tbxPatientNo.Location = new System.Drawing.Point(433, 91);
            this.tbxPatientNo.Name = "tbxPatientNo";
            this.tbxPatientNo.Size = new System.Drawing.Size(363, 22);
            this.tbxPatientNo.TabIndex = 5;
            this.tbxPatientNo.TextChanged += new System.EventHandler(this.tbxPatientNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "REG No";
            // 
            // pnlViewAppointments
            // 
            this.pnlViewAppointments.Controls.Add(this.label9);
            this.pnlViewAppointments.Controls.Add(this.label7);
            this.pnlViewAppointments.Controls.Add(this.tbxTimeTo);
            this.pnlViewAppointments.Controls.Add(this.tbxTimeFrom);
            this.pnlViewAppointments.Controls.Add(this.tbxDoctorName);
            this.pnlViewAppointments.Controls.Add(this.label1);
            this.pnlViewAppointments.Controls.Add(this.tbxDate);
            this.pnlViewAppointments.Controls.Add(this.tbxPatientName);
            this.pnlViewAppointments.Controls.Add(this.label11);
            this.pnlViewAppointments.Controls.Add(this.label4);
            this.pnlViewAppointments.Controls.Add(this.tbxChannelingNo);
            this.pnlViewAppointments.Controls.Add(this.label5);
            this.pnlViewAppointments.Controls.Add(this.tbxRoomNo);
            this.pnlViewAppointments.Controls.Add(this.label2);
            this.pnlViewAppointments.Controls.Add(this.tbxDocNo);
            this.pnlViewAppointments.Controls.Add(this.label8);
            this.pnlViewAppointments.Controls.Add(this.tbxPatientNo);
            this.pnlViewAppointments.Controls.Add(this.label3);
            this.pnlViewAppointments.Location = new System.Drawing.Point(477, 366);
            this.pnlViewAppointments.Name = "pnlViewAppointments";
            this.pnlViewAppointments.Size = new System.Drawing.Size(816, 335);
            this.pnlViewAppointments.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Time to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Time from";
            // 
            // tbxTimeTo
            // 
            this.tbxTimeTo.Enabled = false;
            this.tbxTimeTo.Location = new System.Drawing.Point(522, 224);
            this.tbxTimeTo.Name = "tbxTimeTo";
            this.tbxTimeTo.Size = new System.Drawing.Size(274, 22);
            this.tbxTimeTo.TabIndex = 10;
            // 
            // tbxTimeFrom
            // 
            this.tbxTimeFrom.Enabled = false;
            this.tbxTimeFrom.Location = new System.Drawing.Point(106, 224);
            this.tbxTimeFrom.Name = "tbxTimeFrom";
            this.tbxTimeFrom.Size = new System.Drawing.Size(274, 22);
            this.tbxTimeFrom.TabIndex = 11;
            // 
            // tbxDate
            // 
            this.tbxDate.Enabled = false;
            this.tbxDate.Location = new System.Drawing.Point(17, 25);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(363, 22);
            this.tbxDate.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(12, 713);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 52);
            this.panel1.TabIndex = 35;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(484, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.tbxEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(716, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.tbxDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(600, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.tbxUpdate_Click);
            // 
            // cbxTodayAvailable
            // 
            this.cbxTodayAvailable.AutoSize = true;
            this.cbxTodayAvailable.Location = new System.Drawing.Point(287, 25);
            this.cbxTodayAvailable.Name = "cbxTodayAvailable";
            this.cbxTodayAvailable.Size = new System.Drawing.Size(131, 21);
            this.cbxTodayAvailable.TabIndex = 36;
            this.cbxTodayAvailable.Text = "Today Available";
            this.cbxTodayAvailable.UseVisualStyleBackColor = true;
            this.cbxTodayAvailable.CheckedChanged += new System.EventHandler(this.cbxTodayAvailable_CheckedChanged);
            // 
            // dtpSelectAppointments
            // 
            this.dtpSelectAppointments.Location = new System.Drawing.Point(490, 12);
            this.dtpSelectAppointments.Name = "dtpSelectAppointments";
            this.dtpSelectAppointments.Size = new System.Drawing.Size(267, 22);
            this.dtpSelectAppointments.TabIndex = 18;
            this.dtpSelectAppointments.ValueChanged += new System.EventHandler(this.dtpSelectAppointments_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Search by day";
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.label6);
            this.pnlDate.Controls.Add(this.cbxTodayAvailable);
            this.pnlDate.Controls.Add(this.dtpAppointment);
            this.pnlDate.Enabled = false;
            this.pnlDate.Location = new System.Drawing.Point(3, 55);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(417, 52);
            this.pnlDate.TabIndex = 37;
            // 
            // pnlEditAppointments
            // 
            this.pnlEditAppointments.Controls.Add(this.tbxSearchDoctors);
            this.pnlEditAppointments.Controls.Add(this.pnlDate);
            this.pnlEditAppointments.Controls.Add(this.dgvDoctors);
            this.pnlEditAppointments.Controls.Add(this.cbbxSelectSpecialization);
            this.pnlEditAppointments.Enabled = false;
            this.pnlEditAppointments.Location = new System.Drawing.Point(31, 366);
            this.pnlEditAppointments.Name = "pnlEditAppointments";
            this.pnlEditAppointments.Size = new System.Drawing.Size(426, 335);
            this.pnlEditAppointments.TabIndex = 38;
            // 
            // frmViewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 777);
            this.Controls.Add(this.pnlEditAppointments);
            this.Controls.Add(this.dtpSelectAppointments);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlViewAppointments);
            this.Controls.Add(this.tbxSearchAppointments);
            this.Controls.Add(this.dgvAppointments);
            this.Name = "frmViewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Appointment";
            this.Load += new System.EventHandler(this.frmViewAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.pnlViewAppointments.ResumeLayout(false);
            this.pnlViewAppointments.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlEditAppointments.ResumeLayout(false);
            this.pnlEditAppointments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TextBox tbxSearchDoctors;
        private System.Windows.Forms.ComboBox cbbxSelectSpecialization;
        private System.Windows.Forms.TextBox tbxSearchAppointments;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDoctorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPatientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxChannelingNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDocNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPatientNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlViewAppointments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cbxTodayAvailable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTimeTo;
        private System.Windows.Forms.TextBox tbxTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpSelectAppointments;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Panel pnlEditAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ttime_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelling_no;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization_;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn datee;
    }
}