namespace Health_Care_Plus_00174336
{
    partial class frmViewRooms
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
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPatientNo = new System.Windows.Forms.TextBox();
            this.tbxPatientFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditProcedures = new System.Windows.Forms.Button();
            this.btnEditDate = new System.Windows.Forms.Button();
            this.tbxProcedures = new System.Windows.Forms.TextBox();
            this.tbxPatientLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRoomNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lbxPatients = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnChangePatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.pnlRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNo,
            this.date,
            this.ava,
            this.procedures});
            this.dgvRooms.Location = new System.Drawing.Point(352, 19);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.Size = new System.Drawing.Size(493, 569);
            this.dgvRooms.TabIndex = 0;
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
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
            // 
            // procedures
            // 
            this.procedures.HeaderText = "Procedures";
            this.procedures.Name = "procedures";
            this.procedures.Visible = false;
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
            // tbxPatientNo
            // 
            this.tbxPatientNo.Enabled = false;
            this.tbxPatientNo.Location = new System.Drawing.Point(3, 96);
            this.tbxPatientNo.Name = "tbxPatientNo";
            this.tbxPatientNo.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientNo.TabIndex = 11;
            this.tbxPatientNo.TextChanged += new System.EventHandler(this.tbxPatientNo_TextChanged);
            // 
            // tbxPatientFirstName
            // 
            this.tbxPatientFirstName.Enabled = false;
            this.tbxPatientFirstName.Location = new System.Drawing.Point(3, 169);
            this.tbxPatientFirstName.Name = "tbxPatientFirstName";
            this.tbxPatientFirstName.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientFirstName.TabIndex = 12;
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
            this.pnlRooms.Controls.Add(this.dtpDateFrom);
            this.pnlRooms.Controls.Add(this.label6);
            this.pnlRooms.Controls.Add(this.label1);
            this.pnlRooms.Controls.Add(this.btnEditProcedures);
            this.pnlRooms.Controls.Add(this.btnEditDate);
            this.pnlRooms.Controls.Add(this.tbxProcedures);
            this.pnlRooms.Controls.Add(this.tbxPatientLastName);
            this.pnlRooms.Controls.Add(this.tbxPatientFirstName);
            this.pnlRooms.Controls.Add(this.label3);
            this.pnlRooms.Controls.Add(this.label2);
            this.pnlRooms.Controls.Add(this.tbxRoomNo);
            this.pnlRooms.Controls.Add(this.label4);
            this.pnlRooms.Controls.Add(this.tbxPatientNo);
            this.pnlRooms.Controls.Add(this.label5);
            this.pnlRooms.Location = new System.Drawing.Point(859, 11);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(407, 574);
            this.pnlRooms.TabIndex = 15;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Location = new System.Drawing.Point(3, 331);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(395, 22);
            this.dtpDateFrom.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Room No";
            // 
            // btnEditProcedures
            // 
            this.btnEditProcedures.Enabled = false;
            this.btnEditProcedures.Location = new System.Drawing.Point(268, 523);
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
            this.btnEditDate.Location = new System.Drawing.Point(268, 359);
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
            this.tbxProcedures.Location = new System.Drawing.Point(3, 437);
            this.tbxProcedures.Multiline = true;
            this.tbxProcedures.Name = "tbxProcedures";
            this.tbxProcedures.Size = new System.Drawing.Size(395, 80);
            this.tbxProcedures.TabIndex = 12;
            // 
            // tbxPatientLastName
            // 
            this.tbxPatientLastName.Enabled = false;
            this.tbxPatientLastName.Location = new System.Drawing.Point(3, 249);
            this.tbxPatientLastName.Name = "tbxPatientLastName";
            this.tbxPatientLastName.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientLastName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Procedures";
            // 
            // tbxRoomNo
            // 
            this.tbxRoomNo.Enabled = false;
            this.tbxRoomNo.Location = new System.Drawing.Point(3, 22);
            this.tbxRoomNo.Name = "tbxRoomNo";
            this.tbxRoomNo.Size = new System.Drawing.Size(395, 22);
            this.tbxRoomNo.TabIndex = 11;
            this.tbxRoomNo.TextChanged += new System.EventHandler(this.tbxRoomNo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Patient Last Name";
            // 
            // btnDischarge
            // 
            this.btnDischarge.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDischarge.Enabled = false;
            this.btnDischarge.ForeColor = System.Drawing.Color.White;
            this.btnDischarge.Location = new System.Drawing.Point(1063, 601);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(203, 37);
            this.btnDischarge.TabIndex = 16;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.UseVisualStyleBackColor = false;
            this.btnDischarge.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(859, 601);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 37);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.tbxUpdate_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Enabled = false;
            this.tbxSearch.Location = new System.Drawing.Point(21, 19);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(312, 22);
            this.tbxSearch.TabIndex = 23;
            // 
            // lbxPatients
            // 
            this.lbxPatients.Enabled = false;
            this.lbxPatients.FormattingEnabled = true;
            this.lbxPatients.ItemHeight = 16;
            this.lbxPatients.Location = new System.Drawing.Point(21, 56);
            this.lbxPatients.Name = "lbxPatients";
            this.lbxPatients.Size = new System.Drawing.Size(312, 532);
            this.lbxPatients.TabIndex = 22;
            this.lbxPatients.SelectedIndexChanged += new System.EventHandler(this.lbxPatients_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(481, 601);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(203, 37);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset Room";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangePatient
            // 
            this.btnChangePatient.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnChangePatient.Enabled = false;
            this.btnChangePatient.Location = new System.Drawing.Point(71, 601);
            this.btnChangePatient.Name = "btnChangePatient";
            this.btnChangePatient.Size = new System.Drawing.Size(203, 37);
            this.btnChangePatient.TabIndex = 27;
            this.btnChangePatient.Text = "Change Patient";
            this.btnChangePatient.UseVisualStyleBackColor = false;
            this.btnChangePatient.Click += new System.EventHandler(this.tbxChangePatient_Click);
            // 
            // frmViewRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 650);
            this.Controls.Add(this.btnChangePatient);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lbxPatients);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDischarge);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.dgvRooms);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmViewRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.frmRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPatientNo;
        private System.Windows.Forms.TextBox tbxPatientFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.TextBox tbxProcedures;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.TextBox tbxPatientLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxRoomNo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListBox lbxPatients;
        private System.Windows.Forms.Button btnEditProcedures;
        private System.Windows.Forms.Button btnEditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ava;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedures;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnChangePatient;
    }
}