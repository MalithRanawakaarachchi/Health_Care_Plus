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
    public partial class frmViewPatients : Form
    {
        public managePatients patientManager = new managePatients();
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        public static string patient_id = "";

        public frmViewPatients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlPatients.Enabled == false)
            {
                pnlPatients.Enabled = true;
            }
            else
            {
                pnlPatients.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbtnMale.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }

            try
            {
                if (Validation())
                {
                    int id = Convert.ToInt32(tbxPatientID.Text);

                    Patient Patient = new Patient
                    {
                        id = Convert.ToInt32(tbxPatientID.Text),
                        first_name = tbxFirstName.Text,
                        last_name = tbxLastName.Text,
                        address = tbxAddress.Text,
                        id_type = cbbxIDType.Text,
                        id_no = tbxIDno.Text,
                        dob = dtpDOB.Value.ToShortDateString(),
                        gender = gender,
                        email = tbxEmail.Text,
                        mobile = tbxMobile.Text,
                        home = tbxHome.Text,
                        office = tbxOffice.Text
                    };

                    managePatients managePatients = new managePatients();
                    managePatients.UpdatePatientById(id, Patient);


                    lbxPatients.Items.Clear();
                    lbxPatients.Refresh();

                    managePatients.LoadPatients(lbxPatients);

                    clearAll();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void tbxEMPID_TextChanged(object sender, EventArgs e)
        {
            if (tbxPatientID.Text != "" && frmLogin.userType == "Hospital Administrator")
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEmail.Checked == true)
            {
                tbxEmail.Enabled = true;
            }
            else
            {
                tbxEmail.Enabled = false;
            }
        }

        private void cbxMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMobile.Checked == true)
            {
                tbxMobile.Enabled = true;
            }
            else
            {
                tbxMobile.Enabled = false;
            }
        }

        private void cbxHome_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHome.Checked == true)
            {
                tbxHome.Enabled = true;
            }
            else
            {
                tbxHome.Enabled = false;
            }
        }

        private void cbxOffice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxOffice.Checked == true)
            {
                tbxOffice.Enabled = true;
            }
            else
            {
                tbxOffice.Enabled = false;
            }
        }

        private void frmViewPatients_Load(object sender, EventArgs e)
        {
            try
            {
                managePatients managePatients = new managePatients();
                managePatients.LoadPatients(lbxPatients);
                if(frmLogin.userType == "Hospital Administrator")
                {
                    btnEdit.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = true;
                    pnlPatients.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }

        }

        private void RetrievePatientData(string selectedName)
        {
            Patient patient = patientManager.GetPatientByName(selectedName);
           // try
            {
                if (patient != null)
                {
                    // Update your form's controls with the retrieved patient data
                    tbxPatientID.Text = patient.id.ToString();
                    tbxFirstName.Text = patient.first_name;
                    tbxLastName.Text = patient.last_name;
                    tbxAddress.Text = patient.address;
                    cbbxIDType.Text = patient.id_type;
                    tbxIDno.Text = patient.id_no;
                    dtpDOB.Text = patient.dob;
                    if (patient.gender == "male")
                    {
                        rbtnMale.Checked = true;
                    }
                    else
                    {
                        rbtnFemale.Checked = true;
                    }
                    tbxEmail.Text = patient.email;
                    tbxMobile.Text = patient.mobile;
                    tbxHome.Text = patient.home;
                    tbxOffice.Text = patient.office;

                    patient_id = tbxPatientID.Text;
                    // ... (update other controls)
                }
                else
                {
                    // Handle the case where the patient is not found
                    MessageBox.Show("Patient not found.");
                }
            }
           // catch (Exception ex)
            {
           //     MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void lbxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
           // try
            {
                string selectedName = lbxPatients.SelectedItem.ToString();
                RetrievePatientData(selectedName);
            }
           // catch (Exception ex)
            {
            //    MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeletePatient deletePatient = new frmDeletePatient();
                if (deletePatient.ShowDialog() == DialogResult.OK)
                {
                    lbxPatients.Items.Clear();
                    lbxPatients.Refresh();

                    managePatients managePatients = new managePatients();
                    managePatients.LoadPatients(lbxPatients);

                    clearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void tbxSearchPatients_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbxPatients.Items.Clear();
                lbxPatients.Refresh();

                string searchText = tbxSearchPatients.Text;
                managePatients managePatients = new managePatients();
                managePatients.SearchPatients(lbxPatients, searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void clearAll()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxAddress.Clear();
            cbbxIDType.Text = "Select ID Type";
            tbxIDno.Clear();
            dtpDOB.Value = DateTime.Now;
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            cbxEmail.Checked = false;
            cbxMobile.Checked = false;
            cbxHome.Checked = false;
            cbxOffice.Checked = false;
            tbxEmail.Clear();
            tbxMobile.Clear();
            tbxHome.Clear();
            tbxOffice.Clear();
            tbxPatientID.Clear();
        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(tbxFirstName.Text) || string.IsNullOrWhiteSpace(tbxLastName.Text) ||
                string.IsNullOrWhiteSpace(tbxAddress.Text) || cbbxIDType.Text == "Select ID Type" ||
                string.IsNullOrWhiteSpace(tbxIDno.Text) ||string.IsNullOrWhiteSpace(tbxEmail.Text) ||
                string.IsNullOrWhiteSpace(tbxMobile.Text))
            {
                MessageBox.Show("Please fill all feilds");
                return false;
            }
            else if (dtpDOB.Value == DateTime.Now)
            {
                MessageBox.Show("Please select a correct birth day !");
                return false;
            }

            return true;
        }
    }
}
