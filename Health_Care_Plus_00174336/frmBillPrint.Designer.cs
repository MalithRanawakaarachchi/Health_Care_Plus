namespace Health_Care_Plus_00174336
{
    partial class frmBillPrint
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxOperationCharge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxMedicationCharge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxRoomCharge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDoctorCharge = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMedications = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxDoctorCharges = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxRoomCharges = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxMedicationCharges = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxOperationCharges = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbxTotalCharge = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tbxRoomNo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbxNoOfDays = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.pnlPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(198, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVOICE";
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.White;
            this.pnlPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrint.Controls.Add(this.tbxDate);
            this.pnlPrint.Controls.Add(this.label5);
            this.pnlPrint.Controls.Add(this.tbxTotal);
            this.pnlPrint.Controls.Add(this.label10);
            this.pnlPrint.Controls.Add(this.tbxOperationCharge);
            this.pnlPrint.Controls.Add(this.label9);
            this.pnlPrint.Controls.Add(this.tbxMedicationCharge);
            this.pnlPrint.Controls.Add(this.label8);
            this.pnlPrint.Controls.Add(this.tbxRoomCharge);
            this.pnlPrint.Controls.Add(this.label7);
            this.pnlPrint.Controls.Add(this.tbxDoctorCharge);
            this.pnlPrint.Controls.Add(this.label15);
            this.pnlPrint.Controls.Add(this.label6);
            this.pnlPrint.Controls.Add(this.tbxID);
            this.pnlPrint.Controls.Add(this.label4);
            this.pnlPrint.Controls.Add(this.tbxPatientName);
            this.pnlPrint.Controls.Add(this.label3);
            this.pnlPrint.Controls.Add(this.label11);
            this.pnlPrint.Controls.Add(this.label14);
            this.pnlPrint.Controls.Add(this.label13);
            this.pnlPrint.Controls.Add(this.label12);
            this.pnlPrint.Controls.Add(this.label2);
            this.pnlPrint.Controls.Add(this.label1);
            this.pnlPrint.Location = new System.Drawing.Point(751, 51);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(505, 662);
            this.pnlPrint.TabIndex = 1;
            // 
            // tbxDate
            // 
            this.tbxDate.BackColor = System.Drawing.Color.White;
            this.tbxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDate.Location = new System.Drawing.Point(314, 212);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(161, 15);
            this.tbxDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date   :";
            // 
            // tbxTotal
            // 
            this.tbxTotal.BackColor = System.Drawing.Color.White;
            this.tbxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotal.Location = new System.Drawing.Point(341, 514);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(118, 15);
            this.tbxTotal.TabIndex = 2;
            this.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total Charge";
            // 
            // tbxOperationCharge
            // 
            this.tbxOperationCharge.BackColor = System.Drawing.Color.White;
            this.tbxOperationCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOperationCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOperationCharge.Location = new System.Drawing.Point(341, 426);
            this.tbxOperationCharge.Name = "tbxOperationCharge";
            this.tbxOperationCharge.Size = new System.Drawing.Size(118, 15);
            this.tbxOperationCharge.TabIndex = 2;
            this.tbxOperationCharge.Text = "0.00";
            this.tbxOperationCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Operation / Report Charge";
            // 
            // tbxMedicationCharge
            // 
            this.tbxMedicationCharge.BackColor = System.Drawing.Color.White;
            this.tbxMedicationCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMedicationCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMedicationCharge.Location = new System.Drawing.Point(341, 384);
            this.tbxMedicationCharge.Name = "tbxMedicationCharge";
            this.tbxMedicationCharge.Size = new System.Drawing.Size(118, 15);
            this.tbxMedicationCharge.TabIndex = 2;
            this.tbxMedicationCharge.Text = "0.00";
            this.tbxMedicationCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Medication Charge";
            // 
            // tbxRoomCharge
            // 
            this.tbxRoomCharge.BackColor = System.Drawing.Color.White;
            this.tbxRoomCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRoomCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoomCharge.Location = new System.Drawing.Point(341, 342);
            this.tbxRoomCharge.Name = "tbxRoomCharge";
            this.tbxRoomCharge.Size = new System.Drawing.Size(118, 15);
            this.tbxRoomCharge.TabIndex = 2;
            this.tbxRoomCharge.Text = "0.00";
            this.tbxRoomCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Room Charge";
            // 
            // tbxDoctorCharge
            // 
            this.tbxDoctorCharge.BackColor = System.Drawing.Color.White;
            this.tbxDoctorCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDoctorCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDoctorCharge.Location = new System.Drawing.Point(341, 300);
            this.tbxDoctorCharge.Name = "tbxDoctorCharge";
            this.tbxDoctorCharge.Size = new System.Drawing.Size(118, 15);
            this.tbxDoctorCharge.TabIndex = 2;
            this.tbxDoctorCharge.Text = "0.00";
            this.tbxDoctorCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(429, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "LKR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Appointment / Doctor Charge";
            // 
            // tbxID
            // 
            this.tbxID.BackColor = System.Drawing.Color.White;
            this.tbxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(81, 212);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(101, 15);
            this.tbxID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID   :";
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.BackColor = System.Drawing.Color.White;
            this.tbxPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPatientName.Location = new System.Drawing.Point(161, 176);
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Size = new System.Drawing.Size(267, 15);
            this.tbxPatientName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Patient\'s name   :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(104, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(291, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "No 139/A, Dharmapala Mawatha,Colombo 07";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 606);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "healthcareplus@gmail.com";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 592);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "0110 662 662";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 577);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Health Care Plus Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Health Care Plus";
            // 
            // dgvMedications
            // 
            this.dgvMedications.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Medication,
            this.QTY,
            this.Unit_price,
            this.Amount});
            this.dgvMedications.Location = new System.Drawing.Point(47, 222);
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.RowTemplate.Height = 24;
            this.dgvMedications.Size = new System.Drawing.Size(657, 308);
            this.dgvMedications.TabIndex = 2;
            this.dgvMedications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedications_CellContentClick);
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 60;
            // 
            // Medication
            // 
            this.Medication.HeaderText = "Medication";
            this.Medication.Name = "Medication";
            this.Medication.Width = 150;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.Width = 80;
            // 
            // Unit_price
            // 
            this.Unit_price.HeaderText = "Unit Price (LKR)";
            this.Unit_price.Name = "Unit_price";
            this.Unit_price.Width = 80;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount (LKR)";
            this.Amount.Name = "Amount";
            this.Amount.Width = 80;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(44, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Appointment / Doctor Charges";
            // 
            // tbxDoctorCharges
            // 
            this.tbxDoctorCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDoctorCharges.Location = new System.Drawing.Point(248, 62);
            this.tbxDoctorCharges.Name = "tbxDoctorCharges";
            this.tbxDoctorCharges.Size = new System.Drawing.Size(143, 22);
            this.tbxDoctorCharges.TabIndex = 2;
            this.tbxDoctorCharges.Text = "0.00";
            this.tbxDoctorCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(44, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Room Charge";
            // 
            // tbxRoomCharges
            // 
            this.tbxRoomCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoomCharges.Location = new System.Drawing.Point(247, 101);
            this.tbxRoomCharges.Name = "tbxRoomCharges";
            this.tbxRoomCharges.Size = new System.Drawing.Size(144, 22);
            this.tbxRoomCharges.TabIndex = 2;
            this.tbxRoomCharges.Text = "0.00";
            this.tbxRoomCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(338, 544);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "All Medication Charges";
            // 
            // tbxMedicationCharges
            // 
            this.tbxMedicationCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMedicationCharges.Location = new System.Drawing.Point(511, 541);
            this.tbxMedicationCharges.Name = "tbxMedicationCharges";
            this.tbxMedicationCharges.Size = new System.Drawing.Size(193, 22);
            this.tbxMedicationCharges.TabIndex = 2;
            this.tbxMedicationCharges.Text = "0.00";
            this.tbxMedicationCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(44, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(176, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Operation / Report Charge";
            // 
            // tbxOperationCharges
            // 
            this.tbxOperationCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOperationCharges.Location = new System.Drawing.Point(248, 140);
            this.tbxOperationCharges.Name = "tbxOperationCharges";
            this.tbxOperationCharges.Size = new System.Drawing.Size(143, 22);
            this.tbxOperationCharges.TabIndex = 2;
            this.tbxOperationCharges.Text = "0.00";
            this.tbxOperationCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(44, 202);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Medication Charges";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::Health_Care_Plus_00174336.Properties.Resources.printer_print;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(634, 646);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 70);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1260, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = " X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(37, 669);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 44);
            this.label22.TabIndex = 6;
            this.label22.Text = "LKR";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(234, 601);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(130, 55);
            this.label23.TabIndex = 5;
            this.label23.Text = "Total";
            // 
            // tbxTotalCharge
            // 
            this.tbxTotalCharge.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxTotalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalCharge.Location = new System.Drawing.Point(136, 660);
            this.tbxTotalCharge.Name = "tbxTotalCharge";
            this.tbxTotalCharge.Size = new System.Drawing.Size(324, 56);
            this.tbxTotalCharge.TabIndex = 4;
            this.tbxTotalCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tbxRoomNo
            // 
            this.tbxRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoomNo.Location = new System.Drawing.Point(484, 101);
            this.tbxRoomNo.Name = "tbxRoomNo";
            this.tbxRoomNo.Size = new System.Drawing.Size(59, 22);
            this.tbxRoomNo.TabIndex = 2;
            this.tbxRoomNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(414, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Room No";
            // 
            // tbxNoOfDays
            // 
            this.tbxNoOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNoOfDays.Location = new System.Drawing.Point(645, 101);
            this.tbxNoOfDays.Name = "tbxNoOfDays";
            this.tbxNoOfDays.Size = new System.Drawing.Size(59, 22);
            this.tbxNoOfDays.TabIndex = 2;
            this.tbxNoOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(563, 104);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "No of days";
            // 
            // frmBillPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 754);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tbxTotalCharge);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvMedications);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbxDoctorCharges);
            this.Controls.Add(this.tbxOperationCharges);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbxNoOfDays);
            this.Controls.Add(this.tbxRoomNo);
            this.Controls.Add(this.tbxRoomCharges);
            this.Controls.Add(this.tbxMedicationCharges);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBillPrint";
            this.Load += new System.EventHandler(this.frmBillPrint_Load);
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxOperationCharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMedicationCharge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxRoomCharge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDoctorCharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvMedications;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxDoctorCharges;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbxRoomCharges;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxMedicationCharges;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxOperationCharges;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbxTotalCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medication;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox tbxRoomNo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbxNoOfDays;
        private System.Windows.Forms.Label label24;
    }
}