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
    public partial class frmAddEMR : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmAddEMR()
        {
            InitializeComponent();
        }

        private void frmAddEMR_Load(object sender, EventArgs e)
        {
            if (ds.Tables["tblPatients"] != null)
            {
                ds.Tables["tblPatients"].Clear();
            }
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblPatients", con);
            da.Fill(ds, "tblPatients");
            con.Close();

            int currentRow = 0;
            int rowcount = ds.Tables["tblPatients"].Rows.Count;

            while (currentRow < rowcount)
            {
                string fname = ds.Tables["tblPatients"].Rows[currentRow].ItemArray[1].ToString();
                string lname = ds.Tables["tblPatients"].Rows[currentRow].ItemArray[2].ToString();
                string fullname = fname + " " + lname;
                lbxPatients.Items.Add(fullname);
                currentRow++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pnlEMR.Enabled == false)
            {
                pnlEMR.Enabled = true;
            }
            else
            {
                pnlEMR.Enabled = false;
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (ds.Tables["tblPatients"] != null)
            {
                ds.Tables["tblPatients"].Clear();
            }
            lbxPatients.Items.Clear();
            lbxPatients.Refresh();
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblPatients WHERE first_name + ' ' + last_name LIKE '%" + tbxSearch.Text + "%'", con);
            da.Fill(ds, "tblPatients");
            con.Close();

            int currentRow = 0;
            int rowcount = ds.Tables["tblPatients"].Rows.Count;

            while (currentRow < rowcount)
            {
                string fname = ds.Tables["tblPatients"].Rows[currentRow].ItemArray[1].ToString();
                string lname = ds.Tables["tblPatients"].Rows[currentRow].ItemArray[2].ToString();
                string fullname = fname + " " + lname;
                lbxPatients.Items.Add(fullname);
                currentRow++;
            }
        }

        private void lbxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = lbxPatients.SelectedItem.ToString();
            string[] nameParts = selectedName.Split(' '); // Split the selected name into first_name and last_name parts

            string firstName = nameParts[0]; // Extract the first_name part
            string lastName = nameParts[1]; // Extract the last_name part

            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblPatients WHERE first_name = @firstName AND last_name = @lastName", con);
            da.SelectCommand.Parameters.AddWithValue("@firstName", firstName);
            da.SelectCommand.Parameters.AddWithValue("@lastName", lastName);

            DataSet ds = new DataSet();
            da.Fill(ds, "tblPatients");
            con.Close();

            tbxPatientID.Text = ds.Tables["tblPatients"].Rows[0].ItemArray[0].ToString();
            tbxIDno.Text = ds.Tables["tblPatients"].Rows[0].ItemArray[5].ToString();
            tbxAddress.Text = ds.Tables["tblPatients"].Rows[0].ItemArray[3].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            try
            {
                if (Validation())
                {
                    EMR emr = new EMR
                    {
                        patient_id = Convert.ToInt32(tbxPatientID.Text),
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
                        surgery_and_operation_reports = tbxSurgeryOperationReports.Text,
                        date = DateTime.Now.ToString()

                    };

                    manageEMRs manageEMRs = new manageEMRs();
                    manageEMRs.AddEMRs(emr);
                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }
    
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool Validation()
        {
            if(string.IsNullOrWhiteSpace(tbxPatientID.Text))
            {
                MessageBox.Show("Please select a patient !");
                return false;
            }
            else if(string.IsNullOrWhiteSpace(tbxDiagnosis.Text) || string.IsNullOrWhiteSpace(tbxPrescription.Text))
            {
                MessageBox.Show("Please fill both of Diagnosis and Prescriptions !");
                return false;
            }

            return true;
        }

        private void ClearAll()
        {
            tbxPatientID.Clear();
            tbxIDno.Clear();
            tbxAddress.Clear();
            tbxWeight.Clear();
            tbxHeight.Clear();
            tbxHeartRate.Clear();
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
            tbxSurgeryOperationReports.Clear();
        }
    }
}
