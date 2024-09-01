namespace Health_Care_Plus_00174336
{
    partial class frmViewMedications
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
            this.stockfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allegies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlMEdication = new System.Windows.Forms.Panel();
            this.cbbxFrequency = new System.Windows.Forms.ComboBox();
            this.cbbxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.tbxMediID = new System.Windows.Forms.TextBox();
            this.tbxMedicationName = new System.Windows.Forms.TextBox();
            this.dtpStock = new System.Windows.Forms.DateTimePicker();
            this.tbxDosage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAllergies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlMEdication.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedications
            // 
            this.dgvMedications.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.stockfrom,
            this.exp,
            this.name,
            this.type,
            this.dosage,
            this.frequency,
            this.allegies,
            this.qty,
            this.price});
            this.dgvMedications.Location = new System.Drawing.Point(12, 50);
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.RowTemplate.Height = 24;
            this.dgvMedications.Size = new System.Drawing.Size(1160, 763);
            this.dgvMedications.TabIndex = 0;
            this.dgvMedications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedications_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // stockfrom
            // 
            this.stockfrom.HeaderText = "Stock From";
            this.stockfrom.Name = "stockfrom";
            this.stockfrom.Width = 130;
            // 
            // exp
            // 
            this.exp.HeaderText = "EXP Date";
            this.exp.Name = "exp";
            this.exp.Width = 70;
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
            // 
            // dosage
            // 
            this.dosage.HeaderText = "Dosage";
            this.dosage.Name = "dosage";
            this.dosage.Width = 60;
            // 
            // frequency
            // 
            this.frequency.HeaderText = "Frequency";
            this.frequency.Name = "frequency";
            // 
            // allegies
            // 
            this.allegies.HeaderText = "Allegies";
            this.allegies.Name = "allegies";
            this.allegies.Visible = false;
            this.allegies.Width = 200;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.Width = 60;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(1179, 773);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 52);
            this.panel2.TabIndex = 51;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEdit.Location = new System.Drawing.Point(3, 8);
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
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(235, 8);
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
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(119, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlMEdication
            // 
            this.pnlMEdication.Controls.Add(this.cbbxFrequency);
            this.pnlMEdication.Controls.Add(this.cbbxType);
            this.pnlMEdication.Controls.Add(this.label6);
            this.pnlMEdication.Controls.Add(this.dtpExp);
            this.pnlMEdication.Controls.Add(this.tbxMediID);
            this.pnlMEdication.Controls.Add(this.tbxMedicationName);
            this.pnlMEdication.Controls.Add(this.dtpStock);
            this.pnlMEdication.Controls.Add(this.tbxDosage);
            this.pnlMEdication.Controls.Add(this.label7);
            this.pnlMEdication.Controls.Add(this.tbxAllergies);
            this.pnlMEdication.Controls.Add(this.label2);
            this.pnlMEdication.Controls.Add(this.tbxPrice);
            this.pnlMEdication.Controls.Add(this.tbxQuantity);
            this.pnlMEdication.Controls.Add(this.label4);
            this.pnlMEdication.Controls.Add(this.label12);
            this.pnlMEdication.Controls.Add(this.label11);
            this.pnlMEdication.Controls.Add(this.label8);
            this.pnlMEdication.Controls.Add(this.label5);
            this.pnlMEdication.Controls.Add(this.label10);
            this.pnlMEdication.Controls.Add(this.label1);
            this.pnlMEdication.Controls.Add(this.label3);
            this.pnlMEdication.Enabled = false;
            this.pnlMEdication.Location = new System.Drawing.Point(1178, 12);
            this.pnlMEdication.Name = "pnlMEdication";
            this.pnlMEdication.Size = new System.Drawing.Size(348, 742);
            this.pnlMEdication.TabIndex = 50;
            // 
            // cbbxFrequency
            // 
            this.cbbxFrequency.FormattingEnabled = true;
            this.cbbxFrequency.Items.AddRange(new object[] {
            "Once a day",
            "Twice a day",
            "Three times a day",
            "Every 4 hours",
            "Every 6 hours",
            "Every 8 hours",
            "Every 12 hours",
            "As needed (PRN)",
            "Daily",
            "Weekly",
            "Monthly"});
            this.cbbxFrequency.Location = new System.Drawing.Point(3, 523);
            this.cbbxFrequency.Name = "cbbxFrequency";
            this.cbbxFrequency.Size = new System.Drawing.Size(341, 24);
            this.cbbxFrequency.TabIndex = 10;
            this.cbbxFrequency.Text = "Select Frequency";
            // 
            // cbbxType
            // 
            this.cbbxType.FormattingEnabled = true;
            this.cbbxType.Items.AddRange(new object[] {
            "Tablet",
            "Capsule",
            "Syrup",
            "Injection",
            "Cream",
            "Ointment",
            "Drops",
            "Inhaler",
            "Patch",
            "Suppository"});
            this.cbbxType.Location = new System.Drawing.Point(3, 357);
            this.cbbxType.Name = "cbbxType";
            this.cbbxType.Size = new System.Drawing.Size(341, 24);
            this.cbbxType.TabIndex = 10;
            this.cbbxType.Text = "Select Medication Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock From";
            // 
            // dtpExp
            // 
            this.dtpExp.Location = new System.Drawing.Point(3, 191);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(341, 22);
            this.dtpExp.TabIndex = 9;
            // 
            // tbxMediID
            // 
            this.tbxMediID.Location = new System.Drawing.Point(1, 25);
            this.tbxMediID.Name = "tbxMediID";
            this.tbxMediID.Size = new System.Drawing.Size(341, 22);
            this.tbxMediID.TabIndex = 7;
            // 
            // tbxMedicationName
            // 
            this.tbxMedicationName.Location = new System.Drawing.Point(3, 274);
            this.tbxMedicationName.Name = "tbxMedicationName";
            this.tbxMedicationName.Size = new System.Drawing.Size(341, 22);
            this.tbxMedicationName.TabIndex = 7;
            // 
            // dtpStock
            // 
            this.dtpStock.Location = new System.Drawing.Point(3, 108);
            this.dtpStock.Name = "dtpStock";
            this.dtpStock.Size = new System.Drawing.Size(341, 22);
            this.dtpStock.TabIndex = 9;
            // 
            // tbxDosage
            // 
            this.tbxDosage.Location = new System.Drawing.Point(3, 440);
            this.tbxDosage.Name = "tbxDosage";
            this.tbxDosage.Size = new System.Drawing.Size(341, 22);
            this.tbxDosage.TabIndex = 7;
            this.tbxDosage.TextChanged += new System.EventHandler(this.tbxDosage_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "EXP Date";
            // 
            // tbxAllergies
            // 
            this.tbxAllergies.Location = new System.Drawing.Point(3, 606);
            this.tbxAllergies.Multiline = true;
            this.tbxAllergies.Name = "tbxAllergies";
            this.tbxAllergies.Size = new System.Drawing.Size(341, 49);
            this.tbxAllergies.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Medication Type";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(200, 714);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(110, 22);
            this.tbxPrice.TabIndex = 7;
            this.tbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(4, 714);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(142, 22);
            this.tbxQuantity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Frequency";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 690);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Price (LKR)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 690);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Allergies";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Medication ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Medication Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dosage";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(12, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(395, 22);
            this.tbxSearch.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Search";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(312, 717);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = ".00";
            // 
            // frmViewMedications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1536, 827);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMEdication);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvMedications);
            this.Controls.Add(this.tbxSearch);
            this.Name = "frmViewMedications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Medications";
            this.Load += new System.EventHandler(this.frmViewMedications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlMEdication.ResumeLayout(false);
            this.pnlMEdication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedications;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlMEdication;
        private System.Windows.Forms.ComboBox cbbxFrequency;
        private System.Windows.Forms.ComboBox cbbxType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpExp;
        private System.Windows.Forms.TextBox tbxMedicationName;
        private System.Windows.Forms.DateTimePicker dtpStock;
        private System.Windows.Forms.TextBox tbxDosage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAllergies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.TextBox tbxMediID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockfrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn allegies;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label12;
    }
}