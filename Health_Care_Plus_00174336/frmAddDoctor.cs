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
    public partial class frmAddDoctor : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmb = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        int specialization = 0;

        public frmAddDoctor()
        {
            InitializeComponent();
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAddDoctor.Enabled = true;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
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

            if (tbxFirstName.Text == null || tbxLastName.Text == null || tbxAddress.Text == null || cbbxIDType.Text == "Select ID Type" ||
                cbbxSpecialization.Text == "Select Specialization" || tbxIDNo.Text == null || dtpDOB.Value == DateTime.Now || tbxEmail.Text==null ||
                tbxMobile.Text==null)
            {
                MessageBox.Show("fill all feilds");
            }
            else if (rbtnMale.Checked == false && rbtnFemale.Checked == false)
            {
                MessageBox.Show("Please select a gender");
            }
            else
            {
                try
                {
                    if (Validate())
                    {
                        if(rbtnMale.Checked == true)
                        {
                            gender = "male";
                        }
                        else
                        {
                            gender = "female";
                        }

                        Doctor Doctor = new Doctor
                        {
                            first_name = tbxFirstName.Text,
                            last_name = tbxLastName.Text,
                            address = tbxAddress.Text,
                            id_type = cbbxIDType.Text,
                            id_no = tbxIDNo.Text,
                            spec_id = GetSelectedSpecId(),
                            dob = dtpDOB.Value.ToShortDateString(),
                            gender = gender,
                            email = tbxEmail.Text,
                            mobile = tbxMobile.Text,
                            home = tbxHome.Text,
                            schedule = "False",
                            qualifications = tbxQualifications.Text
                        };
                        manageDoctors manageDoctors = new manageDoctors();
                        manageDoctors.AddDoctor(Doctor);

                        ClearAll();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:" + ex.Message);
                }
            }
        }

        private int GetSelectedSpecId()
        {
            string selectedSpec = cbbxSpecialization.SelectedItem.ToString();
            manageDoctors manageDoctors = new manageDoctors();
            int spec_id = manageDoctors.GetSpecializationId(selectedSpec);
            return spec_id;
        }

        private void ClearAll()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxAddress.Clear();
            cbbxIDType.Text = "Select ID Type";
            tbxIDNo.Clear();
            cbbxSpecialization.Text = "Select Specialization";
            dtpDOB.Value = DateTime.Now;
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            cbxEmail.Checked = false;
            cbxMobile.Checked = false;
            cbxHome.Checked = false;
            tbxEmail.Clear();
            tbxMobile.Clear();
            tbxHome.Clear();
            tbxQualifications.Clear();
        }

        private void frmAddDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}

