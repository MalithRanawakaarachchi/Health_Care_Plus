namespace Health_Care_Plus_00174336
{
    partial class frmMediOut
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
            this.dgvMedications = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMediList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxMediID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMediName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxQTY = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxprice = new System.Windows.Forms.TextBox();
            this.tbxSearchPatients = new System.Windows.Forms.TextBox();
            this.lbxPatients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPatientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPatientName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedications
            // 
            this.dgvMedications.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.frequency,
            this.qty,
            this.price});
            this.dgvMedications.Location = new System.Drawing.Point(32, 35);
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.RowTemplate.Height = 24;
            this.dgvMedications.Size = new System.Drawing.Size(588, 576);
            this.dgvMedications.TabIndex = 1;
            this.dgvMedications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedications_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Medication Name";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // type
            // 
            this.type.HeaderText = "Medication Type";
            this.type.Name = "type";
            this.type.Width = 70;
            // 
            // frequency
            // 
            this.frequency.HeaderText = "Frequency";
            this.frequency.Name = "frequency";
            // 
            // qty
            // 
            this.qty.HeaderText = "In Stock";
            this.qty.Name = "qty";
            this.qty.Width = 60;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.Visible = false;
            // 
            // dgvMediList
            // 
            this.dgvMediList.BackgroundColor = System.Drawing.Color.White;
            this.dgvMediList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMediList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.qty_,
            this.price_,
            this.patient_id});
            this.dgvMediList.Location = new System.Drawing.Point(986, 302);
            this.dgvMediList.Name = "dgvMediList";
            this.dgvMediList.RowTemplate.Height = 24;
            this.dgvMediList.Size = new System.Drawing.Size(522, 309);
            this.dgvMediList.TabIndex = 1;
            this.dgvMediList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMediList_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Medi ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Medi Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // qty_
            // 
            this.qty_.HeaderText = "Qty";
            this.qty_.Name = "qty_";
            // 
            // price_
            // 
            this.price_.HeaderText = "";
            this.price_.Name = "price_";
            this.price_.Visible = false;
            // 
            // patient_id
            // 
            this.patient_id.HeaderText = "patientID";
            this.patient_id.Name = "patient_id";
            this.patient_id.Visible = false;
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnIssue.Location = new System.Drawing.Point(1144, 636);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(110, 34);
            this.btnIssue.TabIndex = 11;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1277, 636);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxMediID
            // 
            this.tbxMediID.Enabled = false;
            this.tbxMediID.Location = new System.Drawing.Point(983, 63);
            this.tbxMediID.Name = "tbxMediID";
            this.tbxMediID.Size = new System.Drawing.Size(124, 22);
            this.tbxMediID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(983, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Medication ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1197, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Medication Name";
            // 
            // tbxMediName
            // 
            this.tbxMediName.Enabled = false;
            this.tbxMediName.Location = new System.Drawing.Point(1197, 63);
            this.tbxMediName.Name = "tbxMediName";
            this.tbxMediName.Size = new System.Drawing.Size(311, 22);
            this.tbxMediName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(986, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "QTY";
            // 
            // tbxQTY
            // 
            this.tbxQTY.Enabled = false;
            this.tbxQTY.Location = new System.Drawing.Point(986, 205);
            this.tbxQTY.Name = "tbxQTY";
            this.tbxQTY.Size = new System.Drawing.Size(103, 22);
            this.tbxQTY.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(986, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 34);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add to list";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxprice
            // 
            this.tbxprice.Enabled = false;
            this.tbxprice.Location = new System.Drawing.Point(1017, 253);
            this.tbxprice.Name = "tbxprice";
            this.tbxprice.Size = new System.Drawing.Size(44, 22);
            this.tbxprice.TabIndex = 12;
            this.tbxprice.Visible = false;
            // 
            // tbxSearchPatients
            // 
            this.tbxSearchPatients.Location = new System.Drawing.Point(647, 37);
            this.tbxSearchPatients.Name = "tbxSearchPatients";
            this.tbxSearchPatients.Size = new System.Drawing.Size(312, 22);
            this.tbxSearchPatients.TabIndex = 20;
            this.tbxSearchPatients.TextChanged += new System.EventHandler(this.tbxSearchPatients_TextChanged);
            // 
            // lbxPatients
            // 
            this.lbxPatients.FormattingEnabled = true;
            this.lbxPatients.ItemHeight = 16;
            this.lbxPatients.Location = new System.Drawing.Point(647, 79);
            this.lbxPatients.Name = "lbxPatients";
            this.lbxPatients.Size = new System.Drawing.Size(312, 532);
            this.lbxPatients.TabIndex = 19;
            this.lbxPatients.SelectedIndexChanged += new System.EventHandler(this.lbxPatients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(983, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Patient ID";
            // 
            // tbxPatientID
            // 
            this.tbxPatientID.Enabled = false;
            this.tbxPatientID.Location = new System.Drawing.Point(983, 137);
            this.tbxPatientID.Name = "tbxPatientID";
            this.tbxPatientID.Size = new System.Drawing.Size(124, 22);
            this.tbxPatientID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1197, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Patient Name";
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.Enabled = false;
            this.tbxPatientName.Location = new System.Drawing.Point(1197, 137);
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.Size = new System.Drawing.Size(311, 22);
            this.tbxPatientName.TabIndex = 12;
            // 
            // frmMediOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1531, 682);
            this.Controls.Add(this.tbxSearchPatients);
            this.Controls.Add(this.lbxPatients);
            this.Controls.Add(this.tbxQTY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPatientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMediName);
            this.Controls.Add(this.tbxPatientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMediID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.dgvMediList);
            this.Controls.Add(this.dgvMedications);
            this.Controls.Add(this.tbxprice);
            this.Name = "frmMediOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediOut";
            this.Load += new System.EventHandler(this.frmMediOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedications;
        private System.Windows.Forms.DataGridView dgvMediList;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbxMediID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMediName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxQTY;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.TextBox tbxprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id;
        private System.Windows.Forms.TextBox tbxSearchPatients;
        private System.Windows.Forms.ListBox lbxPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPatientName;
    }
}