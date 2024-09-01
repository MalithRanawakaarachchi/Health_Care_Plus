namespace Health_Care_Plus_00174336
{
    partial class frmAddPatientToOperationTheater
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
            this.dgvOperationTheaters = new System.Windows.Forms.DataGridView();
            this.tbxPatientLastName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxPatientFirstName = new System.Windows.Forms.TextBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAddPatientToRoom = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProcedures = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxTheaterNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPatientNo = new System.Windows.Forms.TextBox();
            this.lbxPatients = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationTheaters)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlAddPatientToRoom.SuspendLayout();
            this.SuspendLayout();
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
            this.procedure,
            this.type});
            this.dgvOperationTheaters.Location = new System.Drawing.Point(353, 21);
            this.dgvOperationTheaters.Name = "dgvOperationTheaters";
            this.dgvOperationTheaters.RowTemplate.Height = 24;
            this.dgvOperationTheaters.Size = new System.Drawing.Size(713, 656);
            this.dgvOperationTheaters.TabIndex = 27;
            this.dgvOperationTheaters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // tbxPatientLastName
            // 
            this.tbxPatientLastName.Enabled = false;
            this.tbxPatientLastName.Location = new System.Drawing.Point(6, 180);
            this.tbxPatientLastName.Name = "tbxPatientLastName";
            this.tbxPatientLastName.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientLastName.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(3, 606);
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
            this.tbxPatientFirstName.Enabled = false;
            this.tbxPatientFirstName.Location = new System.Drawing.Point(6, 100);
            this.tbxPatientFirstName.Name = "tbxPatientFirstName";
            this.tbxPatientFirstName.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientFirstName.TabIndex = 20;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(6, 413);
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
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Operation Theater No";
            // 
            // pnlAddPatientToRoom
            // 
            this.pnlAddPatientToRoom.Controls.Add(this.tbxPatientLastName);
            this.pnlAddPatientToRoom.Controls.Add(this.panel2);
            this.pnlAddPatientToRoom.Controls.Add(this.tbxPatientFirstName);
            this.pnlAddPatientToRoom.Controls.Add(this.dtpDateFrom);
            this.pnlAddPatientToRoom.Controls.Add(this.label5);
            this.pnlAddPatientToRoom.Controls.Add(this.label7);
            this.pnlAddPatientToRoom.Controls.Add(this.label4);
            this.pnlAddPatientToRoom.Controls.Add(this.label6);
            this.pnlAddPatientToRoom.Controls.Add(this.label1);
            this.pnlAddPatientToRoom.Controls.Add(this.tbxProcedures);
            this.pnlAddPatientToRoom.Controls.Add(this.label3);
            this.pnlAddPatientToRoom.Controls.Add(this.tbxType);
            this.pnlAddPatientToRoom.Controls.Add(this.tbxTheaterNo);
            this.pnlAddPatientToRoom.Controls.Add(this.label2);
            this.pnlAddPatientToRoom.Controls.Add(this.tbxPatientNo);
            this.pnlAddPatientToRoom.Location = new System.Drawing.Point(1086, 21);
            this.pnlAddPatientToRoom.Name = "pnlAddPatientToRoom";
            this.pnlAddPatientToRoom.Size = new System.Drawing.Size(415, 660);
            this.pnlAddPatientToRoom.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Operation Theater Type";
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
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patient No";
            // 
            // tbxProcedures
            // 
            this.tbxProcedures.Location = new System.Drawing.Point(6, 493);
            this.tbxProcedures.Multiline = true;
            this.tbxProcedures.Name = "tbxProcedures";
            this.tbxProcedures.Size = new System.Drawing.Size(395, 93);
            this.tbxProcedures.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date From";
            // 
            // tbxType
            // 
            this.tbxType.Enabled = false;
            this.tbxType.Location = new System.Drawing.Point(6, 334);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(395, 22);
            this.tbxType.TabIndex = 16;
            // 
            // tbxTheaterNo
            // 
            this.tbxTheaterNo.Enabled = false;
            this.tbxTheaterNo.Location = new System.Drawing.Point(6, 255);
            this.tbxTheaterNo.Name = "tbxTheaterNo";
            this.tbxTheaterNo.Size = new System.Drawing.Size(395, 22);
            this.tbxTheaterNo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Procedures";
            // 
            // tbxPatientNo
            // 
            this.tbxPatientNo.Enabled = false;
            this.tbxPatientNo.Location = new System.Drawing.Point(6, 25);
            this.tbxPatientNo.Name = "tbxPatientNo";
            this.tbxPatientNo.Size = new System.Drawing.Size(395, 22);
            this.tbxPatientNo.TabIndex = 16;
            // 
            // lbxPatients
            // 
            this.lbxPatients.FormattingEnabled = true;
            this.lbxPatients.ItemHeight = 16;
            this.lbxPatients.Location = new System.Drawing.Point(24, 65);
            this.lbxPatients.Name = "lbxPatients";
            this.lbxPatients.Size = new System.Drawing.Size(312, 612);
            this.lbxPatients.TabIndex = 24;
            this.lbxPatients.SelectedIndexChanged += new System.EventHandler(this.lbxPatients_SelectedIndexChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(24, 27);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(312, 22);
            this.tbxSearch.TabIndex = 25;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // roomNo
            // 
            this.roomNo.HeaderText = "Theater No";
            this.roomNo.Name = "roomNo";
            this.roomNo.Width = 60;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.Width = 130;
            // 
            // ava
            // 
            this.ava.HeaderText = "Status";
            this.ava.Name = "ava";
            this.ava.Width = 90;
            // 
            // procedure
            // 
            this.procedure.HeaderText = "procedure";
            this.procedure.Name = "procedure";
            this.procedure.Visible = false;
            // 
            // type
            // 
            this.type.HeaderText = "type";
            this.type.Name = "type";
            this.type.Width = 200;
            // 
            // frmAddPatientToOperationTheater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1513, 693);
            this.Controls.Add(this.dgvOperationTheaters);
            this.Controls.Add(this.pnlAddPatientToRoom);
            this.Controls.Add(this.lbxPatients);
            this.Controls.Add(this.tbxSearch);
            this.Name = "frmAddPatientToOperationTheater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient To OperationTheater";
            this.Load += new System.EventHandler(this.frmAddPatientToOperationTheater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationTheaters)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlAddPatientToRoom.ResumeLayout(false);
            this.pnlAddPatientToRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperationTheaters;
        private System.Windows.Forms.TextBox tbxPatientLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxPatientFirstName;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlAddPatientToRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProcedures;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTheaterNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPatientNo;
        private System.Windows.Forms.ListBox lbxPatients;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ava;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedure;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}