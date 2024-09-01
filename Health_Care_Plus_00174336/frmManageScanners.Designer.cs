namespace Health_Care_Plus_00174336
{
    partial class frmManageScanners
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvScanners = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resource_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbbxScanners = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.tbxScannerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScanners)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(48, 532);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 43);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(48, 484);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(267, 43);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Enabled = false;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(48, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(267, 43);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvScanners
            // 
            this.dgvScanners.BackgroundColor = System.Drawing.Color.White;
            this.dgvScanners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScanners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScanners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.StockDate,
            this.Resource_Type,
            this.Value});
            this.dgvScanners.Location = new System.Drawing.Point(377, 35);
            this.dgvScanners.Name = "dgvScanners";
            this.dgvScanners.RowTemplate.Height = 24;
            this.dgvScanners.Size = new System.Drawing.Size(779, 566);
            this.dgvScanners.TabIndex = 17;
            this.dgvScanners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScanners_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // StockDate
            // 
            this.StockDate.HeaderText = "Stock Date";
            this.StockDate.Name = "StockDate";
            // 
            // Resource_Type
            // 
            this.Resource_Type.HeaderText = "Scanner / Machine";
            this.Resource_Type.Name = "Resource_Type";
            this.Resource_Type.Width = 250;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 60;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(48, 111);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(267, 22);
            this.dtpDate.TabIndex = 16;
            // 
            // cbbxScanners
            // 
            this.cbbxScanners.FormattingEnabled = true;
            this.cbbxScanners.Items.AddRange(new object[] {
            "X-ray Machine",
            "MRI Scanner (Magnetic Resonance Imaging)",
            "CT Scanner (Computed Tomography)",
            "Ultrasound Machine",
            "PET Scanner (Positron Emission Tomography)",
            "Fluoroscopy Machine",
            "Mammography Machine",
            "Endoscopy Machine",
            "ECG Machine (Electrocardiogram)",
            "EEG Machine (Electroencephalogram)",
            "Dialysis Machine",
            "Ventilator",
            "Anesthesia Machine",
            "Surgical Robot",
            "Hemodialysis Machine",
            "Infusion Pump",
            "Blood Gas Analyzer",
            "Incubator",
            "Autoclave Machine",
            "Blood Pressure Monitor"});
            this.cbbxScanners.Location = new System.Drawing.Point(48, 173);
            this.cbbxScanners.Name = "cbbxScanners";
            this.cbbxScanners.Size = new System.Drawing.Size(267, 24);
            this.cbbxScanners.TabIndex = 14;
            this.cbbxScanners.Text = "Type of Scanner / Machine";
            this.cbbxScanners.SelectedIndexChanged += new System.EventHandler(this.cbbxScanners_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stock Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Scanner / Machine";
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(124, 236);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(191, 22);
            this.tbxValue.TabIndex = 7;
            // 
            // tbxScannerID
            // 
            this.tbxScannerID.Enabled = false;
            this.tbxScannerID.Location = new System.Drawing.Point(124, 296);
            this.tbxScannerID.Name = "tbxScannerID";
            this.tbxScannerID.Size = new System.Drawing.Size(191, 22);
            this.tbxScannerID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Scanner ID";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Green;
            this.btnGenerate.Enabled = false;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(48, 599);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(267, 42);
            this.btnGenerate.TabIndex = 21;
            this.btnGenerate.Text = "Generate in Excel";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(377, 618);
            this.progressBar.Maximum = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(752, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 22;
            // 
            // frmManageScanners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 672);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvScanners);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbbxScanners);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxScannerID);
            this.Controls.Add(this.tbxValue);
            this.Name = "frmManageScanners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Scanners and Machines";
            this.Load += new System.EventHandler(this.frmManageScanners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScanners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvScanners;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbbxScanners;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.TextBox tbxScannerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resource_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}