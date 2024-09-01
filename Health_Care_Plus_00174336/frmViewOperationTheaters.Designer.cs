namespace Health_Care_Plus_00174336
{
    partial class frmViewOperationTheaters
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lbxPatients = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnEditProcedures = new System.Windows.Forms.Button();
            this.btnEditDate = new System.Windows.Forms.Button();
            this.tbxProcedures = new System.Windows.Forms.TextBox();
            this.tbxPatientLastName = new System.Windows.Forms.TextBox();
            this.tbxPatientFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPatientNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTheaterNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxCharge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvOperationTheaters = new System.Windows.Forms.DataGridView();
            this.btnChangePatient = new System.Windows.Forms.Button();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationTheaters)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Enabled = false;
            this.tbxSearch.Location = new System.Drawing.Point(23, 26);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(312, 22);
            this.tbxSearch.TabIndex = 31;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lbxPatients
            // 
            this.lbxPatients.Enabled = false;
            this.lbxPatients.FormattingEnabled = true;
            this.lbxPatients.ItemHeight = 16;
            this.lbxPatients.Location = new System.Drawing.Point(23, 65);
            this.lbxPatients.Name = "lbxPatients";
            this.lbxPatients.Size = new System.Drawing.Size(312, 644);
            this.lbxPatients.TabIndex = 30;
            this.lbxPatients.SelectedIndexChanged += new System.EventHandler(this.lbxPatients_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(483, 731);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(203, 37);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset Operation Theater";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(876, 731);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 37);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.tbxUpdate_Click);
            // 
            // btnDischarge
            // 
            this.btnDischarge.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDischarge.Enabled = false;
            this.btnDischarge.ForeColor = System.Drawing.Color.White;
            this.btnDischarge.Location = new System.Drawing.Point(1080, 731);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(203, 37);
            this.btnDischarge.TabIndex = 28;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.UseVisualStyleBackColor = false;
            this.btnDischarge.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Patient No";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Location = new System.Drawing.Point(3, 403);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(395, 22);
            this.dtpDateFrom.TabIndex = 15;
            // 
            // btnEditProcedures
            // 
            this.btnEditProcedures.Enabled = false;
            this.btnEditProcedures.Location = new System.Drawing.Point(268, 595);
            this.btnEditProcedures.Name = "btnEditProcedures";
            this.btnEditProcedures.Size = new System.Drawing.Size(130, 30);
            this.btnEditProcedures.TabIndex = 16;
            this.btnEditProcedures.Text = "Edit";
            this.btnEditProcedures.UseVisualStyleBackColor = true;
            this.btnEditProcedures.Click += new System.EventHandler(this.btnEditProcedures_Click);
            // 
            // btnEditDate
            // 
            this.btnEditDate.Enabled = false;
            this.btnEditDate.Location = new System.Drawing.Point(268, 431);
            this.btnEditDate.Name = "btnEditDate";
            this.btnEditDate.Size = new System.Drawing.Size(130, 30);
            this.btnEditDate.TabIndex = 16;
            this.btnEditDate.Text = "Edit";
            this.btnEditDate.UseVisualStyleBackColor = true;
            this.btnEditDate.Click += new System.EventHandler(this.btnEditDate_Click);
            // 
            // tbxProcedures
            // 
            this.tbxProcedures.Enabled = false;
            this.tbxProcedures.Location = new System.Drawing.Point(3, 509);
            this.tbxProcedures.Multiline = true;
            this.tbxProcedures.Name = "tbxProcedures";
            this.tbxProcedures.Size = new System.Drawing.Size(395, 80);
            this.tbxProcedures.TabIndex = 12;
            // 
            // tbxPatientLastName
            // 
            this.tbxPatientLastName.Enabled = false;
            this.tbxPatientLastName.Location = new System.Drawing.Point(3, 248);
            this.tbxPatientLastName.Name = "tbxPatientLastName";
            this.tbxPatientLastName.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientLastName.TabIndex = 12;
            // 
            // tbxPatientFirstName
            // 
            this.tbxPatientFirstName.Enabled = false;
            this.tbxPatientFirstName.Location = new System.Drawing.Point(3, 169);
            this.tbxPatientFirstName.Name = "tbxPatientFirstName";
            this.tbxPatientFirstName.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientFirstName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Procedures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Patient Last Name";
            // 
            // tbxPatientNo
            // 
            this.tbxPatientNo.Enabled = false;
            this.tbxPatientNo.Location = new System.Drawing.Point(3, 96);
            this.tbxPatientNo.Name = "tbxPatientNo";
            this.tbxPatientNo.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientNo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Patient First Name";
            // 
            // pnlRooms
            // 
            this.pnlRooms.Controls.Add(this.label6);
            this.pnlRooms.Controls.Add(this.tbxTheaterNo);
            this.pnlRooms.Controls.Add(this.label7);
            this.pnlRooms.Controls.Add(this.tbxType);
            this.pnlRooms.Controls.Add(this.dtpDateFrom);
            this.pnlRooms.Controls.Add(this.label1);
            this.pnlRooms.Controls.Add(this.btnEditProcedures);
            this.pnlRooms.Controls.Add(this.btnEditDate);
            this.pnlRooms.Controls.Add(this.tbxProcedures);
            this.pnlRooms.Controls.Add(this.tbxCharge);
            this.pnlRooms.Controls.Add(this.tbxPatientLastName);
            this.pnlRooms.Controls.Add(this.tbxPatientFirstName);
            this.pnlRooms.Controls.Add(this.label9);
            this.pnlRooms.Controls.Add(this.label3);
            this.pnlRooms.Controls.Add(this.label8);
            this.pnlRooms.Controls.Add(this.label2);
            this.pnlRooms.Controls.Add(this.label4);
            this.pnlRooms.Controls.Add(this.tbxPatientNo);
            this.pnlRooms.Controls.Add(this.label5);
            this.pnlRooms.Location = new System.Drawing.Point(1090, 21);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(407, 693);
            this.pnlRooms.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Operation Theater No";
            // 
            // tbxTheaterNo
            // 
            this.tbxTheaterNo.Enabled = false;
            this.tbxTheaterNo.Location = new System.Drawing.Point(3, 21);
            this.tbxTheaterNo.Name = "tbxTheaterNo";
            this.tbxTheaterNo.Size = new System.Drawing.Size(395, 22);
            this.tbxTheaterNo.TabIndex = 22;
            this.tbxTheaterNo.TextChanged += new System.EventHandler(this.tbxTheaterNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Operation Theater Type";
            // 
            // tbxType
            // 
            this.tbxType.Enabled = false;
            this.tbxType.Location = new System.Drawing.Point(3, 329);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(395, 22);
            this.tbxType.TabIndex = 20;
            // 
            // tbxCharge
            // 
            this.tbxCharge.Location = new System.Drawing.Point(204, 665);
            this.tbxCharge.Name = "tbxCharge";
            this.tbxCharge.Size = new System.Drawing.Size(172, 22);
            this.tbxCharge.TabIndex = 12;
            this.tbxCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 668);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = ".00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 668);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Operation Charge (LKR)";
            // 
            // dgvOperationTheaters
            // 
            this.dgvOperationTheaters.BackgroundColor = System.Drawing.Color.White;
            this.dgvOperationTheaters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOperationTheaters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperationTheaters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNo,
            this.date,
            this.ava,
            this.procedures,
            this.type});
            this.dgvOperationTheaters.Location = new System.Drawing.Point(358, 21);
            this.dgvOperationTheaters.Name = "dgvOperationTheaters";
            this.dgvOperationTheaters.RowTemplate.Height = 24;
            this.dgvOperationTheaters.Size = new System.Drawing.Size(721, 693);
            this.dgvOperationTheaters.TabIndex = 24;
            this.dgvOperationTheaters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperationTheaters_CellContentClick);
            // 
            // btnChangePatient
            // 
            this.btnChangePatient.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnChangePatient.Enabled = false;
            this.btnChangePatient.Location = new System.Drawing.Point(77, 731);
            this.btnChangePatient.Name = "btnChangePatient";
            this.btnChangePatient.Size = new System.Drawing.Size(203, 37);
            this.btnChangePatient.TabIndex = 26;
            this.btnChangePatient.Text = "Change Patient";
            this.btnChangePatient.UseVisualStyleBackColor = false;
            this.btnChangePatient.Click += new System.EventHandler(this.tbxChangePatient_Click);
            // 
            // roomNo
            // 
            this.roomNo.HeaderText = "Room No";
            this.roomNo.Name = "roomNo";
            this.roomNo.Width = 80;
            // 
            // date
            // 
            this.date.HeaderText = "Date From";
            this.date.Name = "date";
            this.date.Width = 130;
            // 
            // ava
            // 
            this.ava.HeaderText = "Status";
            this.ava.Name = "ava";
            this.ava.Width = 90;
            // 
            // procedures
            // 
            this.procedures.HeaderText = "Procedures";
            this.procedures.Name = "procedures";
            this.procedures.Visible = false;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.Width = 200;
            // 
            // frmViewOperationTheaters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 780);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lbxPatients);
            this.Controls.Add(this.btnChangePatient);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDischarge);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.dgvOperationTheaters);
            this.Name = "frmViewOperationTheaters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Operation Theaters";
            this.Load += new System.EventHandler(this.frmViewOperationTheaters_Load);
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationTheaters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListBox lbxPatients;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Button btnEditProcedures;
        private System.Windows.Forms.Button btnEditDate;
        private System.Windows.Forms.TextBox tbxProcedures;
        private System.Windows.Forms.TextBox tbxPatientLastName;
        private System.Windows.Forms.TextBox tbxPatientFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPatientNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.DataGridView dgvOperationTheaters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxTheaterNo;
        private System.Windows.Forms.Button btnChangePatient;
        private System.Windows.Forms.TextBox tbxCharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ava;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedures;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}