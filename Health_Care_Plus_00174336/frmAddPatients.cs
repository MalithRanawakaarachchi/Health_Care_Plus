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
    public partial class frmAddPatients : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmAddPatients()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAddPatient.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearAll();
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


            try
            {
                if (Validate())
                {
                    Patient Patient = new Patient
                    {
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
                    managePatients.AddPatient(Patient);

                    clearAll();
                }
            }
            catch (Exception ex)
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
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(tbxFirstName.Text)|| string.IsNullOrWhiteSpace(tbxLastName.Text)||
                string.IsNullOrWhiteSpace(tbxAddress.Text) || cbbxIDType.Text == "Select ID Type" ||
                string.IsNullOrWhiteSpace(tbxIDno.Text))
            {
                MessageBox.Show("Please fill all feilds");
                return false;
            }
            else if(dtpDOB.Value == DateTime.Now.Date)
            {
                MessageBox.Show("Please select a correct birth day");
                return false;
            }
            else if (rbtnMale.Checked == false && rbtnFemale.Checked == false)
            {
                MessageBox.Show("Please select a gender");
                return false;
            }

            return true;
        }
    }
}