namespace Health_Care_Plus_00174336
{
    partial class frmAddPatientToRoom
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
            this.pnlAddPatientToRoom = new System.Windows.Forms.Panel();
            this.tbxPatientLastName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxPatientFirstName = new System.Windows.Forms.TextBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProcedures = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxRoomNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPatientNo = new System.Windows.Forms.TextBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAddPatientToRoom.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(19, 18);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(312, 22);
            this.tbxSearch.TabIndex = 21;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lbxPatients
            // 
            this.lbxPatients.FormattingEnabled = true;
            this.lbxPatients.ItemHeight = 16;
            this.lbxPatients.Location = new System.Drawing.Point(19, 56);
            this.lbxPatients.Name = "lbxPatients";
            this.lbxPatients.Size = new System.Drawing.Size(312, 532);
            this.lbxPatients.TabIndex = 20;
            this.lbxPatients.SelectedIndexChanged += new System.EventHandler(this.lbxPatients_SelectedIndexChanged);
            // 
            // pnlAddPatientToRoom
            // 
            this.pnlAddPatientToRoom.Controls.Add(this.tbxPatientLastName);
            this.pnlAddPatientToRoom.Controls.Add(this.panel2);
            this.pnlAddPatientToRoom.Controls.Add(this.tbxPatientFirstName);
            this.pnlAddPatientToRoom.Controls.Add(this.dtpDateFrom);
            this.pnlAddPatientToRoom.Controls.Add(this.label5);
            this.pnlAddPatientToRoom.Controls.Add(this.label4);
            this.pnlAddPatientToRoom.Controls.Add(this.label6);
            this.pnlAddPatientToRoom.Controls.Add(this.label1);
            this.pnlAddPatientToRoom.Controls.Add(this.tbxProcedures);
            this.pnlAddPatientToRoom.Controls.Add(this.label3);
            this.pnlAddPatientToRoom.Controls.Add(this.tbxRoomNo);
            this.pnlAddPatientToRoom.Controls.Add(this.label2);
            this.pnlAddPatientToRoom.Controls.Add(this.tbxPatientNo);
            this.pnlAddPatientToRoom.Location = new System.Drawing.Point(689, 12);
            this.pnlAddPatientToRoom.Name = "pnlAddPatientToRoom";
            this.pnlAddPatientToRoom.Size = new System.Drawing.Size(415, 576);
            this.pnlAddPatientToRoom.TabIndex = 22;
            // 
            // tbxPatientLastName
            // 
            this.tbxPatientLastName.Location = new System.Drawing.Point(6, 180);
            this.tbxPatientLastName.Name = "tbxPatientLastName";
            this.tbxPatientLastName.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientLastName.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(3, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 52);
            this.panel2.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(205, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(89, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxPatientFirstName
            // 
            this.tbxPatientFirstName.Location = new System.Drawing.Point(6, 100);
            this.tbxPatientFirstName.Name = "tbxPatientFirstName";
            this.tbxPatientFirstName.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientFirstName.TabIndex = 20;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(6, 336);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(395, 22);
            this.dtpDateFrom.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Patient Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Room No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Patient First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patient No";
            // 
            // tbxProcedures
            // 
            this.tbxProcedures.Location = new System.Drawing.Point(6, 416);
            this.tbxProcedures.Multiline = true;
            this.tbxProcedures.Name = "tbxProcedures";
            this.tbxProcedures.Size = new System.Drawing.Size(395, 93);
            this.tbxProcedures.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date From";
            // 
            // tbxRoomNo
            // 
            this.tbxRoomNo.Enabled = false;
            this.tbxRoomNo.Location = new System.Drawing.Point(6, 255);
            this.tbxRoomNo.Name = "tbxRoomNo";
            this.tbxRoomNo.Size = new System.Drawing.Size(395, 22);
            this.tbxRoomNo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Procedures";
            // 
            // tbxPatientNo
            // 
            this.tbxPatientNo.Location = new System.Drawing.Point(6, 25);
            this.tbxPatientNo.Name = "tbxPatientNo";
            this.tbxPatientNo.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientNo.TabIndex = 16;
            // 
            // dgvRooms
            // 
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNo,
            this.ava});
            this.dgvRooms.Location = new System.Drawing.Point(352, 12);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.Size = new System.Drawing.Size(318, 576);
            this.dgvRooms.TabIndex = 23;
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // roomNo
            // 
            this.roomNo.HeaderText = "Room No";
            this.roomNo.Name = "roomNo";
            this.roomNo.Width = 60;
            // 
            // ava
            // 
            this.ava.HeaderText = "Status";
            this.ava.Name = "ava";
            this.ava.Width = 120;
            // 
            // frmAddPatientToRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 600);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.pnlAddPatientToRoom);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lbxPatients);
            this.Name = "frmAddPatientToRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient To Room";
            this.Load += new System.EventHandler(this.frmAddPatientToRoom_Load);
            this.pnlAddPatientToRoom.ResumeLayout(false);
            this.pnlAddPatientToRoom.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListBox lbxPatients;
        private System.Windows.Forms.Panel pnlAddPatientToRoom;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProcedures;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPatientNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxRoomNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxPatientLastName;
        private System.Windows.Forms.TextBox tbxPatientFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ava;
    }
}