namespace Health_Care_Plus_00174336
{
    partial class frmViewEMR
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
            this.lbxEMR = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dgvEMR = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodSugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heartRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodtests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiology = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathology = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxPrescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBloodSugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxBloodPressure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxHeartRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxBMI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxTemperature = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDiagnosis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxBloodTests = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxRadiologyReports = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxPathologyReports = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxSurgeryAndOperationReports = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlViewEMRs = new System.Windows.Forms.Panel();
            this.tbxReportID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbbxBloodCategories = new System.Windows.Forms.ComboBox();
            this.pnlViewEMRs2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMR)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlViewEMRs.SuspendLayout();
            this.pnlViewEMRs2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxEMR
            // 
            this.lbxEMR.FormattingEnabled = true;
            this.lbxEMR.ItemHeight = 16;
            this.lbxEMR.Location = new System.Drawing.Point(12, 61);
            this.lbxEMR.Name = "lbxEMR";
            this.lbxEMR.Size = new System.Drawing.Size(301, 724);
            this.lbxEMR.TabIndex = 18;
            this.lbxEMR.SelectedIndexChanged += new System.EventHandler(this.lbxEMR_SelectedIndexChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(12, 17);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(301, 22);
            this.tbxSearch.TabIndex = 19;
            this.tbxSearch.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dgvEMR
            // 
            this.dgvEMR.BackgroundColor = System.Drawing.Color.White;
            this.dgvEMR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Date,
            this.patientId,
            this.weight,
            this.height,
            this.bloodCategory,
            this.bloodSugar,
            this.bloodPressure,
            this.heartRate,
            this.temperature,
            this.bmi,
            this.diagnosis,
            this.prescription,
            this.bloodtests,
            this.radiology,
            this.pathology,
            this.surgery});
            this.dgvEMR.Location = new System.Drawing.Point(330, 17);
            this.dgvEMR.Name = "dgvEMR";
            this.dgvEMR.RowTemplate.Height = 24;
            this.dgvEMR.Size = new System.Drawing.Size(730, 266);
            this.dgvEMR.TabIndex = 20;
            this.dgvEMR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEMR_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 140;
            // 
            // patientId
            // 
            this.patientId.HeaderText = "patientId";
            this.patientId.Name = "patientId";
            this.patientId.Visible = false;
            // 
            // weight
            // 
            this.weight.HeaderText = "weight";
            this.weight.Name = "weight";
            this.weight.Visible = false;
            // 
            // height
            // 
            this.height.HeaderText = "height";
            this.height.Name = "height";
            this.height.Visible = false;
            // 
            // bloodCategory
            // 
            this.bloodCategory.HeaderText = "bloodCategory";
            this.bloodCategory.Name = "bloodCategory";
            this.bloodCategory.Visible = false;
            // 
            // bloodSugar
            // 
            this.bloodSugar.HeaderText = "bloodSugar";
            this.bloodSugar.Name = "bloodSugar";
            this.bloodSugar.Visible = false;
            // 
            // bloodPressure
            // 
            this.bloodPressure.HeaderText = "bloodPressure";
            this.bloodPressure.Name = "bloodPressure";
            this.bloodPressure.Visible = false;
            // 
            // heartRate
            // 
            this.heartRate.HeaderText = "heartRate";
            this.heartRate.Name = "heartRate";
            this.heartRate.Visible = false;
            // 
            // temperature
            // 
            this.temperature.HeaderText = "temperature";
            this.temperature.Name = "temperature";
            this.temperature.Visible = false;
            // 
            // bmi
            // 
            this.bmi.HeaderText = "bmi";
            this.bmi.Name = "bmi";
            this.bmi.Visible = false;
            // 
            // diagnosis
            // 
            this.diagnosis.HeaderText = "diagnosis";
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Width = 400;
            // 
            // prescription
            // 
            this.prescription.HeaderText = "prescription";
            this.prescription.Name = "prescription";
            this.prescription.Visible = false;
            // 
            // bloodtests
            // 
            this.bloodtests.HeaderText = "bloodtests";
            this.bloodtests.Name = "bloodtests";
            this.bloodtests.Visible = false;
            // 
            // radiology
            // 
            this.radiology.HeaderText = "radiology";
            this.radiology.Name = "radiology";
            this.radiology.Visible = false;
            // 
            // pathology
            // 
            this.pathology.HeaderText = "pathology";
            this.pathology.Name = "pathology";
            this.pathology.Visible = false;
            // 
            // surgery
            // 
            this.surgery.HeaderText = "surgery";
            this.surgery.Name = "surgery";
            this.surgery.Visible = false;
            // 
            // tbxPrescription
            // 
            this.tbxPrescription.Location = new System.Drawing.Point(569, 23);
            this.tbxPrescription.Multiline = true;
            this.tbxPrescription.Name = "tbxPrescription";
            this.tbxPrescription.Size = new System.Drawing.Size(546, 110);
            this.tbxPrescription.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Prescription";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Location = new System.Drawing.Point(163, 2);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(216, 22);
            this.tbxHeight.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Weight";
            // 
            // tbxWeight
            // 
            this.tbxWeight.Location = new System.Drawing.Point(163, 38);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(216, 22);
            this.tbxWeight.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Blood Category";
            // 
            // tbxBloodSugar
            // 
            this.tbxBloodSugar.Location = new System.Drawing.Point(163, 110);
            this.tbxBloodSugar.Name = "tbxBloodSugar";
            this.tbxBloodSugar.Size = new System.Drawing.Size(216, 22);
            this.tbxBloodSugar.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Blood Sugar";
            // 
            // tbxBloodPressure
            // 
            this.tbxBloodPressure.Location = new System.Drawing.Point(163, 146);
            this.tbxBloodPressure.Name = "tbxBloodPressure";
            this.tbxBloodPressure.Size = new System.Drawing.Size(216, 22);
            this.tbxBloodPressure.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Blood Pressure";
            // 
            // tbxHeartRate
            // 
            this.tbxHeartRate.Location = new System.Drawing.Point(163, 182);
            this.tbxHeartRate.Name = "tbxHeartRate";
            this.tbxHeartRate.Size = new System.Drawing.Size(216, 22);
            this.tbxHeartRate.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Heart Rate";
            // 
            // tbxBMI
            // 
            this.tbxBMI.Location = new System.Drawing.Point(163, 255);
            this.tbxBMI.Name = "tbxBMI";
            this.tbxBMI.Size = new System.Drawing.Size(216, 22);
            this.tbxBMI.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Temperature";
            // 
            // tbxTemperature
            // 
            this.tbxTemperature.Location = new System.Drawing.Point(163, 218);
            this.tbxTemperature.Name = "tbxTemperature";
            this.tbxTemperature.Size = new System.Drawing.Size(216, 22);
            this.tbxTemperature.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-27, 566);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "BMI";
            // 
            // tbxDiagnosis
            // 
            this.tbxDiagnosis.Location = new System.Drawing.Point(8, 84);
            this.tbxDiagnosis.Multiline = true;
            this.tbxDiagnosis.Name = "tbxDiagnosis";
            this.tbxDiagnosis.Size = new System.Drawing.Size(531, 49);
            this.tbxDiagnosis.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Diagnosis";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Laboratory and Imaging Results";
            this.label11.Click += new System.EventHandler(this.label10_Click);
            // 
            // tbxBloodTests
            // 
            this.tbxBloodTests.Location = new System.Drawing.Point(18, 61);
            this.tbxBloodTests.Multiline = true;
            this.tbxBloodTests.Name = "tbxBloodTests";
            this.tbxBloodTests.Size = new System.Drawing.Size(520, 91);
            this.tbxBloodTests.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Blood Tests";
            this.label12.Click += new System.EventHandler(this.label10_Click);
            // 
            // tbxRadiologyReports
            // 
            this.tbxRadiologyReports.Location = new System.Drawing.Point(568, 61);
            this.tbxRadiologyReports.Multiline = true;
            this.tbxRadiologyReports.Name = "tbxRadiologyReports";
            this.tbxRadiologyReports.Size = new System.Drawing.Size(520, 91);
            this.tbxRadiologyReports.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(565, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(305, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Radiology reports (X-rays, MRI, CT scans, etc.)";
            this.label13.Click += new System.EventHandler(this.label10_Click);
            // 
            // tbxPathologyReports
            // 
            this.tbxPathologyReports.Location = new System.Drawing.Point(18, 195);
            this.tbxPathologyReports.Multiline = true;
            this.tbxPathologyReports.Name = "tbxPathologyReports";
            this.tbxPathologyReports.Size = new System.Drawing.Size(520, 90);
            this.tbxPathologyReports.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(352, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Pathology reports (biopsy results, tissue analysis, etc.)";
            this.label14.Click += new System.EventHandler(this.label10_Click);
            // 
            // tbxSurgeryAndOperationReports
            // 
            this.tbxSurgeryAndOperationReports.Location = new System.Drawing.Point(568, 195);
            this.tbxSurgeryAndOperationReports.Multiline = true;
            this.tbxSurgeryAndOperationReports.Name = "tbxSurgeryAndOperationReports";
            this.tbxSurgeryAndOperationReports.Size = new System.Drawing.Size(520, 90);
            this.tbxSurgeryAndOperationReports.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(565, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Surgery and operation theater reports";
            this.label15.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbxBloodTests);
            this.panel1.Controls.Add(this.tbxPathologyReports);
            this.panel1.Controls.Add(this.tbxSurgeryAndOperationReports);
            this.panel1.Controls.Add(this.tbxRadiologyReports);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(8, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 288);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(12, 796);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1431, 52);
            this.panel2.TabIndex = 23;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(543, 11);
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
            this.btnDelete.Location = new System.Drawing.Point(775, 11);
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
            this.btnUpdate.Location = new System.Drawing.Point(659, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlViewEMRs
            // 
            this.pnlViewEMRs.Controls.Add(this.tbxReportID);
            this.pnlViewEMRs.Controls.Add(this.label19);
            this.pnlViewEMRs.Controls.Add(this.panel1);
            this.pnlViewEMRs.Controls.Add(this.tbxDiagnosis);
            this.pnlViewEMRs.Controls.Add(this.tbxPrescription);
            this.pnlViewEMRs.Controls.Add(this.label1);
            this.pnlViewEMRs.Controls.Add(this.label10);
            this.pnlViewEMRs.Enabled = false;
            this.pnlViewEMRs.Location = new System.Drawing.Point(330, 352);
            this.pnlViewEMRs.Name = "pnlViewEMRs";
            this.pnlViewEMRs.Size = new System.Drawing.Size(1123, 431);
            this.pnlViewEMRs.TabIndex = 24;
            // 
            // tbxReportID
            // 
            this.tbxReportID.Enabled = false;
            this.tbxReportID.Location = new System.Drawing.Point(8, 23);
            this.tbxReportID.Name = "tbxReportID";
            this.tbxReportID.Size = new System.Drawing.Size(531, 22);
            this.tbxReportID.TabIndex = 50;
            this.tbxReportID.TextChanged += new System.EventHandler(this.tbxReportID_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 17);
            this.label19.TabIndex = 51;
            this.label19.Text = "Report No";
            // 
            // cbbxBloodCategories
            // 
            this.cbbxBloodCategories.FormattingEnabled = true;
            this.cbbxBloodCategories.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbbxBloodCategories.Location = new System.Drawing.Point(163, 74);
            this.cbbxBloodCategories.Name = "cbbxBloodCategories";
            this.cbbxBloodCategories.Size = new System.Drawing.Size(215, 24);
            this.cbbxBloodCategories.TabIndex = 52;
            this.cbbxBloodCategories.Text = "Select Blood Category";
            // 
            // pnlViewEMRs2
            // 
            this.pnlViewEMRs2.Controls.Add(this.label2);
            this.pnlViewEMRs2.Controls.Add(this.cbbxBloodCategories);
            this.pnlViewEMRs2.Controls.Add(this.label5);
            this.pnlViewEMRs2.Controls.Add(this.tbxBloodSugar);
            this.pnlViewEMRs2.Controls.Add(this.tbxBloodPressure);
            this.pnlViewEMRs2.Controls.Add(this.label6);
            this.pnlViewEMRs2.Controls.Add(this.tbxHeight);
            this.pnlViewEMRs2.Controls.Add(this.label4);
            this.pnlViewEMRs2.Controls.Add(this.label7);
            this.pnlViewEMRs2.Controls.Add(this.tbxTemperature);
            this.pnlViewEMRs2.Controls.Add(this.tbxWeight);
            this.pnlViewEMRs2.Controls.Add(this.tbxHeartRate);
            this.pnlViewEMRs2.Controls.Add(this.label3);
            this.pnlViewEMRs2.Controls.Add(this.label16);
            this.pnlViewEMRs2.Controls.Add(this.label8);
            this.pnlViewEMRs2.Controls.Add(this.tbxBMI);
            this.pnlViewEMRs2.Enabled = false;
            this.pnlViewEMRs2.Location = new System.Drawing.Point(1066, 12);
            this.pnlViewEMRs2.Name = "pnlViewEMRs2";
            this.pnlViewEMRs2.Size = new System.Drawing.Size(387, 284);
            this.pnlViewEMRs2.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "BMI";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Green;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(775, 290);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(267, 42);
            this.btnGenerate.TabIndex = 54;
            this.btnGenerate.Text = "Generate in Excel";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(330, 300);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(439, 23);
            this.progressBar.TabIndex = 55;
            // 
            // frmViewEMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1459, 862);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pnlViewEMRs2);
            this.Controls.Add(this.pnlViewEMRs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvEMR);
            this.Controls.Add(this.lbxEMR);
            this.Controls.Add(this.label9);
            this.Name = "frmViewEMR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View EMRs";
            this.Load += new System.EventHandler(this.frmViewEMR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlViewEMRs.ResumeLayout(false);
            this.pnlViewEMRs.PerformLayout();
            this.pnlViewEMRs2.ResumeLayout(false);
            this.pnlViewEMRs2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEMR;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DataGridView dgvEMR;
        private System.Windows.Forms.TextBox tbxPrescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxBloodSugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxBloodPressure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxHeartRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxBMI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxTemperature;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDiagnosis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxBloodTests;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxRadiologyReports;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxPathologyReports;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxSurgeryAndOperationReports;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlViewEMRs;
        private System.Windows.Forms.TextBox tbxReportID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodSugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn heartRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn bmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodtests;
        private System.Windows.Forms.DataGridViewTextBoxColumn radiology;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathology;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgery;
        private System.Windows.Forms.ComboBox cbbxBloodCategories;
        private System.Windows.Forms.Panel pnlViewEMRs2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}