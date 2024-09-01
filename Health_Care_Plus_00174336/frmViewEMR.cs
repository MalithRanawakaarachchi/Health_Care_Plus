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
    public partial class frmViewEMR : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmViewEMR()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmViewEMR_Load(object sender, EventArgs e)
        {
            try
            {
                managePatients managePatients = new managePatients();
                managePatients.LoadPatients(lbxEMR);

                if (frmLogin.userType == "Hospital Administrator" || frmLogin.userType == "Nursing Supervisor")
                {
                    btnEdit.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    pnlViewEMRs.Enabled = true;
                    pnlViewEMRs2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbxEMR.Items.Clear();
                lbxEMR.Refresh();

                string searchText = tbxSearch.Text;
                managePatients managePatients = new managePatients();
                managePatients.SearchPatients(lbxEMR, searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void lbxEMR_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedName = lbxEMR.SelectedItem.ToString();

                manageEMRs emr = new manageEMRs();
                emr.GetEMRsByName(dgvEMR, selectedName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void dgvEMR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvEMR.Rows[e.RowIndex];

                tbxReportID.Text = Row.Cells[0].Value.ToString();
                tbxWeight.Text = Row.Cells[3].Value.ToString();
                tbxHeight.Text = Row.Cells[4].Value.ToString();
                cbbxBloodCategories.Text = Row.Cells[5].Value.ToString();
                tbxBloodSugar.Text = Row.Cells[6].Value.ToString();
                tbxBloodPressure.Text = Row.Cells[7].Value.ToString();
                tbxHeartRate.Text = Row.Cells[8].Value.ToString();
                tbxTemperature.Text = Row.Cells[9].Value.ToString();
                tbxBMI.Text = Row.Cells[10].Value.ToString();
                tbxDiagnosis.Text = Row.Cells[11].Value.ToString();
                tbxPrescription.Text = Row.Cells[12].Value.ToString();
                tbxBloodTests.Text = Row.Cells[13].Value.ToString();
                tbxRadiologyReports.Text = Row.Cells[14].Value.ToString();
                tbxPathologyReports.Text = Row.Cells[15].Value.ToString();
                tbxSurgeryAndOperationReports.Text = Row.Cells[16].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pnlViewEMRs.Enabled == false && pnlViewEMRs2.Enabled == false)
            {
                pnlViewEMRs.Enabled = true;
                pnlViewEMRs2.Enabled = true;
            }
            else
            {
                pnlViewEMRs.Enabled = false;
                pnlViewEMRs2.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    int id = Convert.ToInt32(tbxReportID.Text);

                    EMR emr = new EMR
                    {
                        id = Convert.ToInt32(tbxReportID.Text),
                        height = tbxHeight.Text,
                        weight = tbxWeight.Text,
                        blood_category = cbbxBloodCategories.Text,
                        blood_sugar = tbxBloodSugar.Text,
                        blood_pressure = tbxBloodPressure.Text,
                        heart_rate = tbxHeartRate.Text,
                        temperature = tbxTemperature.Text,
                        BMI = tbxBMI.Text,
                        diagnosis = tbxDiagnosis.Text,
                        prescription = tbxPrescription.Text,
                        blood_tests = tbxBloodTests.Text,
                        radiology_reports = tbxRadiologyReports.Text,
                        pathology_reports = tbxPathologyReports.Text,
                        surgery_and_operation_reports = tbxSurgeryAndOperationReports.Text,
                    };

                    manageEMRs manageEMRs = new manageEMRs();
                    manageEMRs.UpdateEMRById(id, emr);

                    dgvEMR.Rows.Clear();
                    dgvEMR.Refresh();
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
                int id = Convert.ToInt32(tbxReportID.Text);
                manageEMRs manageEMRs = new manageEMRs();
                manageEMRs.DelteEMR(id);

                dgvEMR.Rows.Clear();
                dgvEMR.Refresh();

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


                if (dgvEMR.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);

                    progressBar.Maximum = dgvEMR.Rows.Count; // Set the progress bar maximum to the total rows

                    for (int i = 1; i < dgvEMR.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dgvEMR.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvEMR.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvEMR.Columns.Count; j++)
                        {
                            if (dgvEMR.Rows[i].Cells[j].Value != null)
                            {
                                MExcel.Cells[i + 2, j + 1] = dgvEMR.Rows[i].Cells[j].Value.ToString();
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

        private void ClearAll()
        {
            tbxReportID.Clear();
            tbxWeight.Clear();
            tbxHeight.Clear();
            cbbxBloodCategories.Text = "Select Blood Category";
            tbxBloodSugar.Clear();
            tbxBloodPressure.Clear();
            tbxHeartRate.Clear();
            tbxTemperature.Clear();
            tbxBMI.Clear();
            tbxDiagnosis.Clear();
            tbxPrescription.Clear();
            tbxBloodTests.Clear();
            tbxRadiologyReports.Clear();
            tbxPathologyReports.Clear();
            tbxSurgeryAndOperationReports.Clear();
        }

        private void tbxReportID_TextChanged(object sender, EventArgs e)
        {
            if(tbxReportID.Text != "")
            {
                if(frmLogin.userType == "Hospital Administrator" || frmLogin.userType == "Nursing Supervisor")
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }
    }
}
