namespace Health_Care_Plus_00174336
{
    partial class frmAddDoctorSchedule
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
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbxSelectSpecialization = new System.Windows.Forms.ComboBox();
            this.tbxSearchDoctors = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMon = new System.Windows.Forms.CheckBox();
            this.cbxTue = new System.Windows.Forms.CheckBox();
            this.cbxWed = new System.Windows.Forms.CheckBox();
            this.cbxThu = new System.Windows.Forms.CheckBox();
            this.cbxFri = new System.Windows.Forms.CheckBox();
            this.cbxSat = new System.Windows.Forms.CheckBox();
            this.cbxSun = new System.Windows.Forms.CheckBox();
            this.tbxDOCID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlAddDocSchedule = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpWed_to = new System.Windows.Forms.DateTimePicker();
            this.dtpSun_to = new System.Windows.Forms.DateTimePicker();
            this.dtpFri_to = new System.Windows.Forms.DateTimePicker();
            this.dtpMon_to = new System.Windows.Forms.DateTimePicker();
            this.dtpTue_to = new System.Windows.Forms.DateTimePicker();
            this.dtpSat_to = new System.Windows.Forms.DateTimePicker();
            this.dtpWed_from = new System.Windows.Forms.DateTimePicker();
            this.dtpSun_from = new System.Windows.Forms.DateTimePicker();
            this.dtpThu_to = new System.Windows.Forms.DateTimePicker();
            this.dtpFri_from = new System.Windows.Forms.DateTimePicker();
            this.dtpMon_from = new System.Windows.Forms.DateTimePicker();
            this.dtpTue_from = new System.Windows.Forms.DateTimePicker();
            this.dtpSat_from = new System.Windows.Forms.DateTimePicker();
            this.dtpThu_from = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbxLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.pnlAddDocSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullname,
            this.specialization1,
            this.id});
            this.dgvDoctors.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDoctors.Location = new System.Drawing.Point(29, 70);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(573, 533);
            this.dgvDoctors.TabIndex = 26;
            this.dgvDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellContentClick);
            // 
            // fullname
            // 
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            this.fullname.Width = 200;
            // 
            // specialization1
            // 
            this.specialization1.HeaderText = "specialization";
            this.specialization1.Name = "specialization1";
            this.specialization1.Width = 185;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
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
            this.cbbxSelectSpecialization.Location = new System.Drawing.Point(360, 34);
            this.cbbxSelectSpecialization.Name = "cbbxSelectSpecialization";
            this.cbbxSelectSpecialization.Size = new System.Drawing.Size(226, 24);
            this.cbbxSelectSpecialization.TabIndex = 24;
            this.cbbxSelectSpecialization.Text = "Specialization";
            this.cbbxSelectSpecialization.SelectedIndexChanged += new System.EventHandler(this.cbbxSelectSpecialization_SelectedIndexChanged);
            // 
            // tbxSearchDoctors
            // 
            this.tbxSearchDoctors.Location = new System.Drawing.Point(85, 34);
            this.tbxSearchDoctors.Name = "tbxSearchDoctors";
            this.tbxSearchDoctors.Size = new System.Drawing.Size(226, 22);
            this.tbxSearchDoctors.TabIndex = 25;
            this.tbxSearchDoctors.TextChanged += new System.EventHandler(this.tbxSearchDoctors_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Location";
            // 
            // cbxMon
            // 
            this.cbxMon.AutoSize = true;
            this.cbxMon.Location = new System.Drawing.Point(19, 198);
            this.cbxMon.Name = "cbxMon";
            this.cbxMon.Size = new System.Drawing.Size(80, 21);
            this.cbxMon.TabIndex = 28;
            this.cbxMon.Text = "Monday";
            this.cbxMon.UseVisualStyleBackColor = true;
            this.cbxMon.CheckedChanged += new System.EventHandler(this.cbxMon_CheckedChanged);
            // 
            // cbxTue
            // 
            this.cbxTue.AutoSize = true;
            this.cbxTue.Location = new System.Drawing.Point(19, 246);
            this.cbxTue.Name = "cbxTue";
            this.cbxTue.Size = new System.Drawing.Size(85, 21);
            this.cbxTue.TabIndex = 28;
            this.cbxTue.Text = "Tuesday";
            this.cbxTue.UseVisualStyleBackColor = true;
            this.cbxTue.CheckedChanged += new System.EventHandler(this.cbxTue_CheckedChanged);
            // 
            // cbxWed
            // 
            this.cbxWed.AutoSize = true;
            this.cbxWed.Location = new System.Drawing.Point(19, 295);
            this.cbxWed.Name = "cbxWed";
            this.cbxWed.Size = new System.Drawing.Size(105, 21);
            this.cbxWed.TabIndex = 28;
            this.cbxWed.Text = "Wednesday";
            this.cbxWed.UseVisualStyleBackColor = true;
            this.cbxWed.CheckedChanged += new System.EventHandler(this.cbxWed_CheckedChanged);
            // 
            // cbxThu
            // 
            this.cbxThu.AutoSize = true;
            this.cbxThu.Location = new System.Drawing.Point(19, 342);
            this.cbxThu.Name = "cbxThu";
            this.cbxThu.Size = new System.Drawing.Size(90, 21);
            this.cbxThu.TabIndex = 28;
            this.cbxThu.Text = "Thursday";
            this.cbxThu.UseVisualStyleBackColor = true;
            this.cbxThu.CheckedChanged += new System.EventHandler(this.cbxThu_CheckedChanged);
            // 
            // cbxFri
            // 
            this.cbxFri.AutoSize = true;
            this.cbxFri.Location = new System.Drawing.Point(19, 389);
            this.cbxFri.Name = "cbxFri";
            this.cbxFri.Size = new System.Drawing.Size(69, 21);
            this.cbxFri.TabIndex = 28;
            this.cbxFri.Text = "Friday";
            this.cbxFri.UseVisualStyleBackColor = true;
            this.cbxFri.CheckedChanged += new System.EventHandler(this.cbxFri_CheckedChanged);
            // 
            // cbxSat
            // 
            this.cbxSat.AutoSize = true;
            this.cbxSat.Location = new System.Drawing.Point(19, 437);
            this.cbxSat.Name = "cbxSat";
            this.cbxSat.Size = new System.Drawing.Size(87, 21);
            this.cbxSat.TabIndex = 28;
            this.cbxSat.Text = "Saturday";
            this.cbxSat.UseVisualStyleBackColor = true;
            this.cbxSat.CheckedChanged += new System.EventHandler(this.cbxSat_CheckedChanged);
            // 
            // cbxSun
            // 
            this.cbxSun.AutoSize = true;
            this.cbxSun.Location = new System.Drawing.Point(19, 485);
            this.cbxSun.Name = "cbxSun";
            this.cbxSun.Size = new System.Drawing.Size(78, 21);
            this.cbxSun.TabIndex = 28;
            this.cbxSun.Text = "Sunday";
            this.cbxSun.UseVisualStyleBackColor = true;
            this.cbxSun.CheckedChanged += new System.EventHandler(this.cbxSun_CheckedChanged);
            // 
            // tbxDOCID
            // 
            this.tbxDOCID.Enabled = false;
            this.tbxDOCID.Location = new System.Drawing.Point(366, 65);
            this.tbxDOCID.Name = "tbxDOCID";
            this.tbxDOCID.Size = new System.Drawing.Size(155, 22);
            this.tbxDOCID.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "DOC ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Full Name";
            // 
            // tbxFullName
            // 
            this.tbxFullName.Enabled = false;
            this.tbxFullName.Location = new System.Drawing.Point(94, 14);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(427, 22);
            this.tbxFullName.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(825, 627);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 36);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(695, 627);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 36);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(955, 627);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 36);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlAddDocSchedule
            // 
            this.pnlAddDocSchedule.Controls.Add(this.label1);
            this.pnlAddDocSchedule.Controls.Add(this.dtpWed_to);
            this.pnlAddDocSchedule.Controls.Add(this.dtpSun_to);
            this.pnlAddDocSchedule.Controls.Add(this.dtpFri_to);
            this.pnlAddDocSchedule.Controls.Add(this.dtpMon_to);
            this.pnlAddDocSchedule.Controls.Add(this.dtpTue_to);
            this.pnlAddDocSchedule.Controls.Add(this.dtpSat_to);
            this.pnlAddDocSchedule.Controls.Add(this.dtpWed_from);
            this.pnlAddDocSchedule.Controls.Add(this.dtpSun_from);
            this.pnlAddDocSchedule.Controls.Add(this.dtpThu_to);
            this.pnlAddDocSchedule.Controls.Add(this.dtpFri_from);
            this.pnlAddDocSchedule.Controls.Add(this.dtpMon_from);
            this.pnlAddDocSchedule.Controls.Add(this.dtpTue_from);
            this.pnlAddDocSchedule.Controls.Add(this.dtpSat_from);
            this.pnlAddDocSchedule.Controls.Add(this.label4);
            this.pnlAddDocSchedule.Controls.Add(this.dtpThu_from);
            this.pnlAddDocSchedule.Controls.Add(this.label6);
            this.pnlAddDocSchedule.Controls.Add(this.label5);
            this.pnlAddDocSchedule.Controls.Add(this.tbxDOCID);
            this.pnlAddDocSchedule.Controls.Add(this.label7);
            this.pnlAddDocSchedule.Controls.Add(this.label9);
            this.pnlAddDocSchedule.Controls.Add(this.tbxFullName);
            this.pnlAddDocSchedule.Controls.Add(this.cbxSun);
            this.pnlAddDocSchedule.Controls.Add(this.cbbxLocation);
            this.pnlAddDocSchedule.Controls.Add(this.cbxSat);
            this.pnlAddDocSchedule.Controls.Add(this.cbxFri);
            this.pnlAddDocSchedule.Controls.Add(this.cbxThu);
            this.pnlAddDocSchedule.Controls.Add(this.label3);
            this.pnlAddDocSchedule.Controls.Add(this.cbxWed);
            this.pnlAddDocSchedule.Controls.Add(this.cbxMon);
            this.pnlAddDocSchedule.Controls.Add(this.cbxTue);
            this.pnlAddDocSchedule.Enabled = false;
            this.pnlAddDocSchedule.Location = new System.Drawing.Point(617, 12);
            this.pnlAddDocSchedule.Name = "pnlAddDocSchedule";
            this.pnlAddDocSchedule.Size = new System.Drawing.Size(544, 591);
            this.pnlAddDocSchedule.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Day";
            // 
            // dtpWed_to
            // 
            this.dtpWed_to.Enabled = false;
            this.dtpWed_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWed_to.Location = new System.Drawing.Point(398, 292);
            this.dtpWed_to.Name = "dtpWed_to";
            this.dtpWed_to.Size = new System.Drawing.Size(123, 22);
            this.dtpWed_to.TabIndex = 41;
            // 
            // dtpSun_to
            // 
            this.dtpSun_to.Enabled = false;
            this.dtpSun_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSun_to.Location = new System.Drawing.Point(398, 483);
            this.dtpSun_to.Name = "dtpSun_to";
            this.dtpSun_to.Size = new System.Drawing.Size(123, 22);
            this.dtpSun_to.TabIndex = 41;
            // 
            // dtpFri_to
            // 
            this.dtpFri_to.Enabled = false;
            this.dtpFri_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFri_to.Location = new System.Drawing.Point(398, 388);
            this.dtpFri_to.Name = "dtpFri_to";
            this.dtpFri_to.Size = new System.Drawing.Size(123, 22);
            this.dtpFri_to.TabIndex = 41;
            // 
            // dtpMon_to
            // 
            this.dtpMon_to.Enabled = false;
            this.dtpMon_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpMon_to.Location = new System.Drawing.Point(398, 197);
            this.dtpMon_to.Name = "dtpMon_to";
            this.dtpMon_to.Size = new System.Drawing.Size(123, 22);
            this.dtpMon_to.TabIndex = 41;
            // 
            // dtpTue_to
            // 
            this.dtpTue_to.Enabled = false;
            this.dtpTue_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTue_to.Location = new System.Drawing.Point(398, 245);
            this.dtpTue_to.Name = "dtpTue_to";
            this.dtpTue_to.Size = new System.Drawing.Size(123, 22);
            this.dtpTue_to.TabIndex = 41;
            // 
            // dtpSat_to
            // 
            this.dtpSat_to.Enabled = false;
            this.dtpSat_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSat_to.Location = new System.Drawing.Point(398, 436);
            this.dtpSat_to.Name = "dtpSat_to";
            this.dtpSat_to.Size = new System.Drawing.Size(123, 22);
            this.dtpSat_to.TabIndex = 41;
            // 
            // dtpWed_from
            // 
            this.dtpWed_from.Enabled = false;
            this.dtpWed_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWed_from.Location = new System.Drawing.Point(237, 292);
            this.dtpWed_from.Name = "dtpWed_from";
            this.dtpWed_from.Size = new System.Drawing.Size(123, 22);
            this.dtpWed_from.TabIndex = 42;
            // 
            // dtpSun_from
            // 
            this.dtpSun_from.Enabled = false;
            this.dtpSun_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSun_from.Location = new System.Drawing.Point(237, 483);
            this.dtpSun_from.Name = "dtpSun_from";
            this.dtpSun_from.Size = new System.Drawing.Size(123, 22);
            this.dtpSun_from.TabIndex = 42;
            // 
            // dtpThu_to
            // 
            this.dtpThu_to.Enabled = false;
            this.dtpThu_to.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpThu_to.Location = new System.Drawing.Point(398, 341);
            this.dtpThu_to.Name = "dtpThu_to";
            this.dtpThu_to.Size = new System.Drawing.Size(123, 22);
            this.dtpThu_to.TabIndex = 41;
            // 
            // dtpFri_from
            // 
            this.dtpFri_from.Enabled = false;
            this.dtpFri_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFri_from.Location = new System.Drawing.Point(237, 388);
            this.dtpFri_from.Name = "dtpFri_from";
            this.dtpFri_from.Size = new System.Drawing.Size(123, 22);
            this.dtpFri_from.TabIndex = 42;
            // 
            // dtpMon_from
            // 
            this.dtpMon_from.Enabled = false;
            this.dtpMon_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpMon_from.Location = new System.Drawing.Point(237, 197);
            this.dtpMon_from.Name = "dtpMon_from";
            this.dtpMon_from.Size = new System.Drawing.Size(123, 22);
            this.dtpMon_from.TabIndex = 42;
            // 
            // dtpTue_from
            // 
            this.dtpTue_from.Enabled = false;
            this.dtpTue_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTue_from.Location = new System.Drawing.Point(237, 245);
            this.dtpTue_from.Name = "dtpTue_from";
            this.dtpTue_from.Size = new System.Drawing.Size(123, 22);
            this.dtpTue_from.TabIndex = 42;
            // 
            // dtpSat_from
            // 
            this.dtpSat_from.Enabled = false;
            this.dtpSat_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSat_from.Location = new System.Drawing.Point(237, 436);
            this.dtpSat_from.Name = "dtpSat_from";
            this.dtpSat_from.Size = new System.Drawing.Size(123, 22);
            this.dtpSat_from.TabIndex = 42;
            // 
            // dtpThu_from
            // 
            this.dtpThu_from.Enabled = false;
            this.dtpThu_from.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpThu_from.Location = new System.Drawing.Point(237, 341);
            this.dtpThu_from.Name = "dtpThu_from";
            this.dtpThu_from.Size = new System.Drawing.Size(123, 22);
            this.dtpThu_from.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Time Slot";
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
            this.cbbxLocation.Location = new System.Drawing.Point(308, 551);
            this.cbbxLocation.Name = "cbbxLocation";
            this.cbbxLocation.Size = new System.Drawing.Size(213, 24);
            this.cbbxLocation.TabIndex = 24;
            this.cbbxLocation.Text = "Select a Channeling Room";
            this.cbbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbbxLocation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Search";
            // 
            // frmAddDoctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 683);
            this.Controls.Add(this.pnlAddDocSchedule);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.cbbxSelectSpecialization);
            this.Controls.Add(this.tbxSearchDoctors);
            this.Controls.Add(this.label2);
            this.Name = "frmAddDoctorSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctor Schedule";
            this.Load += new System.EventHandler(this.frmDoctorAvailabilityAndLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.pnlAddDocSchedule.ResumeLayout(false);
            this.pnlAddDocSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.ComboBox cbbxSelectSpecialization;
        private System.Windows.Forms.TextBox tbxSearchDoctors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxMon;
        private System.Windows.Forms.CheckBox cbxTue;
        private System.Windows.Forms.CheckBox cbxWed;
        private System.Windows.Forms.CheckBox cbxThu;
        private System.Windows.Forms.CheckBox cbxFri;
        private System.Windows.Forms.CheckBox cbxSat;
        private System.Windows.Forms.CheckBox cbxSun;
        private System.Windows.Forms.TextBox tbxDOCID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Panel pnlAddDocSchedule;
        private System.Windows.Forms.DateTimePicker dtpThu_to;
        private System.Windows.Forms.DateTimePicker dtpThu_from;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFri_to;
        private System.Windows.Forms.DateTimePicker dtpFri_from;
        private System.Windows.Forms.ComboBox cbbxLocation;
        private System.Windows.Forms.DateTimePicker dtpWed_to;
        private System.Windows.Forms.DateTimePicker dtpSun_to;
        private System.Windows.Forms.DateTimePicker dtpMon_to;
        private System.Windows.Forms.DateTimePicker dtpTue_to;
        private System.Windows.Forms.DateTimePicker dtpSat_to;
        private System.Windows.Forms.DateTimePicker dtpWed_from;
        private System.Windows.Forms.DateTimePicker dtpSun_from;
        private System.Windows.Forms.DateTimePicker dtpMon_from;
        private System.Windows.Forms.DateTimePicker dtpTue_from;
        private System.Windows.Forms.DateTimePicker dtpSat_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}