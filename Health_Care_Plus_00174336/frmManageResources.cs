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
    public partial class frmManageResources : Form
    {
        public frmManageResources()
        {
            InitializeComponent();
        }

        private void RetrieveResourcesData(DataGridViewRow selectedRow)
        {
            // Check if a row is selected
            if (selectedRow != null)
            {
                manageResources manageResources = new manageResources();
                Resources resources = manageResources.GetResourcesFromdgv(selectedRow);

                if (resources != null)
                {
                    // Update your form's controls with the retrieved resources data
                    tbxItemID.Text = resources.id.ToString();
                    dtpDate.Text = resources.stock_date;
                    cbbxResouces.Text = resources.type;
                    tbxValue.Text = resources.value.ToString();
                    dtpEXP.Text = resources.exp_date;

                    // ... (update other controls)
                }
                else
                {
                    // Handle the case where the resources data is not found
                    MessageBox.Show("Resources not found.");
                }
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
            {
                    string exp = "";
                    if(dtpEXP.Value.Date==DateTime.Today)
                    {
                        exp = "N/A";
                    }
                    else
                    {
                        exp = dtpEXP.Value.ToShortDateString();
                    }

                    Resources Resources = new Resources
                    {
                        stock_date = dtpDate.Value.ToShortDateString(),
                        type = cbbxResouces.Text,
                        value = Convert.ToInt32(tbxValue.Text),
                        exp_date = exp,
                    };
                    manageResources manageResources = new manageResources();
                    manageResources.AddResources(Resources);

                    dgvResources.Rows.Clear();
                    dgvResources.Refresh();
                    manageResources.LoadResources(dgvResources);
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
            if(cbbxResouces.Text== "Type of Resources" )
            {
                MessageBox.Show("Please select a resources type");
                return false;
            }
            else if(string.IsNullOrWhiteSpace(tbxValue.Text))
            {
                MessageBox.Show("Please select a value");
                return false;
            }
            return true;
        }

        private void ClearAll()
        {
            dtpDate.Value = DateTime.Now;
            cbbxResouces.Text = "Type of Resources";
            tbxValue.Clear();
            dtpEXP.Value = DateTime.Now;
            tbxItemID.Clear();
        }

        private void frmAddResources_Load(object sender, EventArgs e)
        {
            try
            {
                dgvResources.Rows.Clear();
                dgvResources.Refresh();
                manageResources manageResources = new manageResources();
                manageResources.LoadResources(dgvResources);

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

        private void dgvResources_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResources.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvResources.SelectedRows[0]; // Get the first selected row

                // Call the method to retrieve resources data from the selected row
                manageResources manageResources = new manageResources();
                Resources resources = manageResources.GetResourcesFromdgv(selectedRow);

                if (resources != null)
                {
                    // Update your form's controls with the retrieved resources data
                    tbxItemID.Text = resources.id.ToString();
                    dtpDate.Text = resources.stock_date;
                    cbbxResouces.Text = resources.type;
                    tbxValue.Text = resources.value.ToString();
                    dtpEXP.Text = resources.exp_date;

                    // ... (update other controls)
                }
                else
                {
                    // Handle the case where the resources data is not found
                    MessageBox.Show("Resources not found.");
                }
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvResources.Rows[e.RowIndex];

                tbxItemID.Text = Row.Cells[0].Value.ToString();
                dtpDate.Text = Row.Cells[1].Value.ToString();
                cbbxResouces.Text = Row.Cells[2].Value.ToString();
                tbxValue.Text = Row.Cells[3].Value.ToString();
                if (Row.Cells[4].Value.ToString() != "N/A")
                {
                    dtpEXP.Text = Row.Cells[4].Value.ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    string exp = "";
                    if (dtpEXP.Value.Date == DateTime.Today)
                    {
                        exp = "N/A";
                    }
                    else
                    {
                        exp = dtpEXP.Value.ToShortDateString();
                    }

                    int id = Convert.ToInt32(tbxItemID.Text);

                    Resources Resources = new Resources
                    {
                        id = Convert.ToInt32(tbxItemID.Text),
                        stock_date = dtpDate.Value.ToShortDateString(),
                        type = cbbxResouces.Text,
                        value = Convert.ToInt32(tbxValue.Text),
                        exp_date = exp,
                    };

                    manageResources manageResources = new manageResources();
                    manageResources.UpdateResourcesById(id, Resources);

                    dgvResources.Rows.Clear();
                    dgvResources.Refresh();
                    manageResources.LoadResources(dgvResources);

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
                int id = Convert.ToInt32(tbxItemID.Text);
                manageResources manageResources = new manageResources();
                manageResources.DelteItemt(id);

                dgvResources.Rows.Clear();
                dgvResources.Refresh();
                manageResources.LoadResources(dgvResources);

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


                if (dgvResources.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);

                    progressBar.Maximum = dgvResources.Rows.Count; // Set the progress bar maximum to the total rows

                    for (int i = 1; i < dgvResources.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dgvResources.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvResources.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvResources.Columns.Count; j++)
                        {
                            if (dgvResources.Rows[i].Cells[j].Value != null)
                            {
                                MExcel.Cells[i + 2, j + 1] = dgvResources.Rows[i].Cells[j].Value.ToString();
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

        private void cbbxResouces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbxResouces.Text!= "Type of Resources" && frmLogin.userType == "Hospital Administrator")
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
