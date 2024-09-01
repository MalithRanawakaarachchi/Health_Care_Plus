namespace Health_Care_Plus_00174336
{
    partial class frmAddAppointment
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
            this.tbxSearcgPatients = new System.Windows.Forms.TextBox();
            this.tbxPatientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPatientNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAppointment = new System.Windows.Forms.Panel();
            this.tbxDoctorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxChannelingNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxRoomNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTimeTo = new System.Windows.Forms.TextBox();
            this.tbxTimeFrom = new System.Windows.Forms.TextBox();
            this.tbxDocNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxPatient = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxSearchDoctors = new System.Windows.Forms.TextBox();
            this.cbbxSelectSpecialization = new System.Windows.Forms.ComboBox();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.cbxTodayAvailable = new System.Windows.Forms.CheckBox();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAppointment.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSearcgPatients
            // 
            this.tbxSearcgPatients.Location = new System.Drawing.Point(30, 18);
            this.tbxSearcgPatients.Name = "tbxSearcgPatients";
            this.tbxSearcgPatients.Size = new System.Drawing.Size(312, 22);
            this.tbxSearcgPatients.TabIndex = 30;
            this.tbxSearcgPatients.TextChanged += new System.EventHandler(this.tbxSearcgPatients_TextChanged);
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.Enabled = false;
            this.tbxPatientName.Location = new System.Drawing.Point(17, 34);
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Size = new System.Drawing.Size(363, 22);
            this.tbxPatientName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Patient\'s Name";
            // 
            // tbxPatientNo
            // 
            this.tbxPatientNo.Enabled = false;
            this.tbxPatientNo.Location = new System.Drawing.Point(433, 34);
            this.tbxPatientNo.Name = "tbxPatientNo";
            this.tbxPatientNo.Size = new System.Drawing.Size(363, 22);
            this.tbxPatientNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "REG No";
            // 
            // pnlAppointment
            // 
            this.pnlAppointment.Controls.Add(this.tbxDoctorName);
            this.pnlAppointment.Controls.Add(this.label1);
            this.pnlAppointment.Controls.Add(this.tbxPatientName);
            this.pnlAppointment.Controls.Add(this.label4);
            this.pnlAppointment.Controls.Add(this.tbxChannelingNo);
            this.pnlAppointment.Controls.Add(this.label5);
            this.pnlAppointment.Controls.Add(this.tbxRoomNo);
            this.pnlAppointment.Controls.Add(this.label9);
            this.pnlAppointment.Controls.Add(this.label7);
            this.pnlAppointment.Controls.Add(this.label2);
            this.pnlAppointment.Controls.Add(this.tbxTimeTo);
            this.pnlAppointment.Controls.Add(this.tbxTimeFrom);
            this.pnlAppointment.Controls.Add(this.tbxDocNo);
            this.pnlAppointment.Controls.Add(this.label8);
            this.pnlAppointment.Controls.Add(this.tbxPatientNo);
            this.pnlAppointment.Controls.Add(this.label3);
            this.pnlAppointment.Location = new System.Drawing.Point(362, 416);
            this.pnlAppointment.Name = "pnlAppointment";
            this.pnlAppointment.Size = new System.Drawing.Size(812, 291);
            this.pnlAppointment.TabIndex = 28;
            // 
            // tbxDoctorName
            // 
            this.tbxDoctorName.Enabled = false;
            this.tbxDoctorName.Location = new System.Drawing.Point(17, 106);
            this.tbxDoctorName.Name = "tbxDoctorName";
            this.tbxDoctorName.Size = new System.Drawing.Size(363, 22);
            this.tbxDoctorName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doctor\'s Name";
            // 
            // tbxChannelingNo
            // 
            this.tbxChannelingNo.Enabled = false;
            this.tbxChannelingNo.Location = new System.Drawing.Point(433, 251);
            this.tbxChannelingNo.Name = "tbxChannelingNo";
            this.tbxChannelingNo.Size = new System.Drawing.Size(363, 22);
            this.tbxChannelingNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Channelling No";
            // 
            // tbxRoomNo
            // 
            this.tbxRoomNo.Enabled = false;
            this.tbxRoomNo.Location = new System.Drawing.Point(19, 251);
            this.tbxRoomNo.Name = "tbxRoomNo";
            this.tbxRoomNo.Size = new System.Drawing.Size(361, 22);
            this.tbxRoomNo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Time to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Time from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Room No";
            // 
            // tbxTimeTo
            // 
            this.tbxTimeTo.Enabled = false;
            this.tbxTimeTo.Location = new System.Drawing.Point(522, 172);
            this.tbxTimeTo.Name = "tbxTimeTo";
            this.tbxTimeTo.Size = new System.Drawing.Size(274, 22);
            this.tbxTimeTo.TabIndex = 5;
            // 
            // tbxTimeFrom
            // 
            this.tbxTimeFrom.Enabled = false;
            this.tbxTimeFrom.Location = new System.Drawing.Point(106, 172);
            this.tbxTimeFrom.Name = "tbxTimeFrom";
            this.tbxTimeFrom.Size = new System.Drawing.Size(274, 22);
            this.tbxTimeFrom.TabIndex = 5;
            // 
            // tbxDocNo
            // 
            this.tbxDocNo.Enabled = false;
            this.tbxDocNo.Location = new System.Drawing.Point(433, 106);
            this.tbxDocNo.Name = "tbxDocNo";
            this.tbxDocNo.Size = new System.Drawing.Size(363, 22);
            this.tbxDocNo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "DOC ID";
            // 
            // dtpAppointment
            // 
            this.dtpAppointment.Location = new System.Drawing.Point(161, 35);
            this.dtpAppointment.Name = "dtpAppointment";
            this.dtpAppointment.Size = new System.Drawing.Size(340, 22);
            this.dtpAppointment.TabIndex = 18;
            this.dtpAppointment.ValueChanged += new System.EventHandler(this.dtpAppointment_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select another day";
            // 
            // lbxPatient
            // 
            this.lbxPatient.FormattingEnabled = true;
            this.lbxPatient.ItemHeight = 16;
            this.lbxPatient.Location = new System.Drawing.Point(30, 56);
            this.lbxPatient.Name = "lbxPatient";
            this.lbxPatient.Size = new System.Drawing.Size(312, 644);
            this.lbxPatient.TabIndex = 29;
            this.lbxPatient.SelectedIndexChanged += new System.EventHandler(this.lbxPatient_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(458, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(30, 710);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 52);
            this.panel1.TabIndex = 31;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(574, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxSearchDoctors
            // 
            this.tbxSearchDoctors.Location = new System.Drawing.Point(362, 12);
            this.tbxSearchDoctors.Name = "tbxSearchDoctors";
            this.tbxSearchDoctors.Size = new System.Drawing.Size(289, 22);
            this.tbxSearchDoctors.TabIndex = 30;
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
            this.cbbxSelectSpecialization.Location = new System.Drawing.Point(362, 48);
            this.cbbxSelectSpecialization.Name = "cbbxSelectSpecialization";
            this.cbbxSelectSpecialization.Size = new System.Drawing.Size(289, 24);
            this.cbbxSelectSpecialization.TabIndex = 32;
            this.cbbxSelectSpecialization.Text = "Specialization";
            this.cbbxSelectSpecialization.SelectedIndexChanged += new System.EventHandler(this.cbbxSelectSpecialization_SelectedIndexChanged);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullName,
            this.specialization,
            this.from,
            this.to,
            this.date});
            this.dgvDoctors.Location = new System.Drawing.Point(362, 92);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(796, 318);
            this.dgvDoctors.TabIndex = 33;
            this.dgvDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellContentClick);
            // 
            // cbxTodayAvailable
            // 
            this.cbxTodayAvailable.AutoSize = true;
            this.cbxTodayAvailable.Location = new System.Drawing.Point(6, 37);
            this.cbxTodayAvailable.Name = "cbxTodayAvailable";
            this.cbxTodayAvailable.Size = new System.Drawing.Size(131, 21);
            this.cbxTodayAvailable.TabIndex = 34;
            this.cbxTodayAvailable.Text = "Today Available";
            this.cbxTodayAvailable.UseVisualStyleBackColor = true;
            this.cbxTodayAvailable.CheckedChanged += new System.EventHandler(this.cbxTodayAvailable_CheckedChanged);
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.label6);
            this.pnlDate.Controls.Add(this.cbxTodayAvailable);
            this.pnlDate.Controls.Add(this.dtpAppointment);
            this.pnlDate.Enabled = false;
            this.pnlDate.Location = new System.Drawing.Point(657, 12);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(517, 60);
            this.pnlDate.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Doctor";
            this.fullName.Name = "fullName";
            this.fullName.Width = 200;
            // 
            // specialization
            // 
            this.specialization.HeaderText = "Specialization";
            this.specialization.Name = "specialization";
            this.specialization.Width = 200;
            // 
            // from
            // 
            this.from.HeaderText = "from";
            this.from.Name = "from";
            // 
            // to
            // 
            this.to.HeaderText = "to";
            this.to.Name = "to";
            this.to.Visible = false;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.Visible = false;
            // 
            // frmAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 773);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.cbbxSelectSpecialization);
            this.Controls.Add(this.tbxSearchDoctors);
            this.Controls.Add(this.tbxSearcgPatients);
            this.Controls.Add(this.pnlAppointment);
            this.Controls.Add(this.lbxPatient);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.frmAddAppointment_Load);
            this.pnlAppointment.ResumeLayout(false);
            this.pnlAppointment.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearcgPatients;
        private System.Windows.Forms.TextBox tbxPatientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPatientNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAppointment;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxPatient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbxSearchDoctors;
        private System.Windows.Forms.ComboBox cbbxSelectSpecialization;
        private System.Windows.Forms.TextBox tbxDoctorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.TextBox tbxChannelingNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxRoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDocNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxTodayAvailable;
        private System.Windows.Forms.TextBox tbxTimeTo;
        private System.Windows.Forms.TextBox tbxTimeFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}