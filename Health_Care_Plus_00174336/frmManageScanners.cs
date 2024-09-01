using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Health_Care_Plus_00174336.Classes;

namespace Health_Care_Plus_00174336
{
    public partial class frmManageScanners : Form
    {
        public frmManageScanners()
        {
            InitializeComponent();
        }

        private void frmManageScanners_Load(object sender, EventArgs e)
        {
            try
            {
                dgvScanners.Rows.Clear();
                dgvScanners.Refresh();
                manageScanners manageResources = new manageScanners();
                manageResources.LoadScanners(dgvScanners);

                if (frmLogin.userType == "Hospital Administrator")
                {
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnGenerate.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnGenerate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void dgvScanners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvScanners.Rows[e.RowIndex];

                tbxScannerID.Text = Row.Cells[0].Value.ToString();
                dtpDate.Text = Row.Cells[1].Value.ToString();
                cbbxScanners.Text = Row.Cells[2].Value.ToString();
                tbxValue.Text = Row.Cells[3].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    Scanners Scanners = new Scanners
                    {
                        stock_date = dtpDate.Value.ToShortDateString(),
                        name = cbbxScanners.Text,
                        value = Convert.ToInt32(tbxValue.Text),
                    };
                    manageScanners manageScanners = new manageScanners();
                    manageScanners.AddScanners(Scanners);

                    dgvScanners.Rows.Clear();
                    dgvScanners.Refresh();
                    manageScanners.LoadScanners(dgvScanners);
                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private bool Validate()
        {
            if (cbbxScanners.Text == "Type of Scanner / Machine")
            {
                MessageBox.Show("Please select scanner type");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxValue.Text))
            {
                MessageBox.Show("Please select a value");
                return false;
            }
            return true;
        }

        private void ClearAll()
        {
            dtpDate.Value = DateTime.Now;
            cbbxScanners.Text = "Type of Scanner / Machine";
            tbxValue.Clear();
            tbxScannerID.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    int id = Convert.ToInt32(tbxScannerID.Text);

                    Scanners Scanners = new Scanners
                    {
                        id = Convert.ToInt32(tbxScannerID.Text),
                        stock_date = dtpDate.Value.ToShortDateString(),
                        name = cbbxScanners.Text,
                        value = Convert.ToInt32(tbxValue.Text),
                    };

                    manageScanners manageScanners = new manageScanners();
                    manageScanners.UpdateScannersById(id, Scanners);

                    dgvScanners.Rows.Clear();
                    dgvScanners.Refresh();
                    manageScanners.LoadScanners(dgvScanners);

                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbxScannerID.Text);
                manageScanners manageScanners = new manageScanners();
                manageScanners.DelteScanner(id);

                dgvScanners.Rows.Clear();
                dgvScanners.Refresh();
                manageScanners.LoadScanners(dgvScanners);

                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar.Visible = true;

                int totalSteps = 10; // Adjust to your total number of steps
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;

                for (int i = 0; i <= totalSteps; i++)
                {
                    int progress = i * 10;

                    // Update the progress bar
                    progressBar.Value = progress;

                    // Sleep for a short duration to slow down the update and make it smoother
                    System.Threading.Thread.Sleep(50); // Adjust the sleep duration as needed
                }


                if (dgvScanners.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);

                    progressBar.Maximum = dgvScanners.Rows.Count; // Set the progress bar maximum to the total rows

                    for (int i = 1; i < dgvScanners.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dgvScanners.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvScanners.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvScanners.Columns.Count; j++)
                        {
                            if (dgvScanners.Rows[i].Cells[j].Value != null)
                            {
                                MExcel.Cells[i + 2, j + 1] = dgvScanners.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                MExcel.Cells[i + 2, j + 1] = string.Empty; // Or handle null values as needed
                            }
                        }
                    }
                    MExcel.Rows.AutoFit();
                    MExcel.Columns.Font.Size = 12;
                    MExcel.Visible = true;
                }
                else
                {
                    MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void cbbxScanners_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbxScanners.Text != "Type of Scanner / Machine" && frmLogin.userType == "Hospital Administrator")
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnSave.Enabled = true;
                btnGenerate.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                btnGenerate.Enabled = false;
            }
        }
    }
}
