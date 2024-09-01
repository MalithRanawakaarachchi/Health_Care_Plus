namespace Health_Care_Plus_00174336
{
    partial class frmViewBills
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
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPatientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.tbxSearchBill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCaption2 = new System.Windows.Forms.Label();
            this.tbxRoomNo = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBills
            // 
            this.dgvBills.BackgroundColor = System.Drawing.Color.White;
            this.dgvBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.patient_name,
            this.patient_id_,
            this.type,
            this.amount,
            this.room_id});
            this.dgvBills.Location = new System.Drawing.Point(27, 80);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowTemplate.Height = 24;
            this.dgvBills.Size = new System.Drawing.Size(640, 509);
            this.dgvBills.TabIndex = 0;
            this.dgvBills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // date
            // 
            this.date.HeaderText = "Bill Date";
            this.date.Name = "date";
            this.date.Width = 90;
            // 
            // patient_name
            // 
            this.patient_name.HeaderText = "Patient Name";
            this.patient_name.Name = "patient_name";
            this.patient_name.Width = 150;
            // 
            // patient_id_
            // 
            this.patient_id_.HeaderText = "Patient ID";
            this.patient_id_.Name = "patient_id_";
            this.patient_id_.Visible = false;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.Width = 90;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.Visible = false;
            this.amount.Width = 90;
            // 
            // room_id
            // 
            this.room_id.HeaderText = "room_id";
            this.room_id.Name = "room_id";
            this.room_id.Visible = false;
            // 
            // tbxDate
            // 
            this.tbxDate.Location = new System.Drawing.Point(734, 46);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(257, 22);
            this.tbxDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // tbxPatientID
            // 
            this.tbxPatientID.Location = new System.Drawing.Point(734, 259);
            this.tbxPatientID.Name = "tbxPatientID";
            this.tbxPatientID.Size = new System.Drawing.Size(257, 22);
            this.tbxPatientID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient ID";
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.Location = new System.Drawing.Point(734, 189);
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Size = new System.Drawing.Size(257, 22);
            this.tbxPatientName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(731, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Name";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPay.Location = new System.Drawing.Point(777, 549);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(169, 41);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "View and Print";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tbxSearchBill
            // 
            this.tbxSearchBill.Location = new System.Drawing.Point(27, 46);
            this.tbxSearchBill.Name = "tbxSearchBill";
            this.tbxSearchBill.Size = new System.Drawing.Size(248, 22);
            this.tbxSearchBill.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Search bill by patient ID";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(716, 486);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(286, 17);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "* to check all payments of this patient ";
            this.lblCaption.Visible = false;
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(734, 119);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(257, 22);
            this.tbxType.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(731, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Payment Type";
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(734, 404);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(257, 22);
            this.tbxTotal.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount";
            // 
            // lblCaption2
            // 
            this.lblCaption2.AutoSize = true;
            this.lblCaption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption2.Location = new System.Drawing.Point(774, 513);
            this.lblCaption2.Name = "lblCaption2";
            this.lblCaption2.Size = new System.Drawing.Size(157, 17);
            this.lblCaption2.TabIndex = 2;
            this.lblCaption2.Text = "click \'View and Print\'";
            this.lblCaption2.Visible = false;
            // 
            // tbxRoomNo
            // 
            this.tbxRoomNo.Location = new System.Drawing.Point(734, 336);
            this.tbxRoomNo.Name = "tbxRoomNo";
            this.tbxRoomNo.Size = new System.Drawing.Size(257, 22);
            this.tbxRoomNo.TabIndex = 1;
            this.tbxRoomNo.Visible = false;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(731, 316);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(129, 17);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Room / Theator No";
            this.lblRoom.Visible = false;
            // 
            // frmViewBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 623);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCaption2);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxPatientName);
            this.Controls.Add(this.tbxType);
            this.Controls.Add(this.tbxRoomNo);
            this.Controls.Add(this.tbxPatientID);
            this.Controls.Add(this.tbxSearchBill);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.dgvBills);
            this.Name = "frmViewBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Bills";
            this.Load += new System.EventHandler(this.frmViewBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox tbxSearchBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCaption2;
        private System.Windows.Forms.TextBox tbxRoomNo;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_id;
    }
}