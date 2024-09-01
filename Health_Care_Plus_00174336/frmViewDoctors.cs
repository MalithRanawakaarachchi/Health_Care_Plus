using System;
using System.Globalization;
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
    public partial class frmViewDoctors : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        public static string doctor_id = "";

        public frmViewDoctors()
        {
            InitializeComponent();
        }

        private void frmViewDoctors_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDoctors.Rows.Clear();
                dgvDoctors.Refresh();
                manageDoctors manageDoctors = new manageDoctors();
                manageDoctors.LoadDoctors(dgvDoctors);

                if(frmLogin.userType == "Hospital Administrator")
                {
                    btnEdit.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    pnlViewDoctors.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int day = 0;
                DateTime today = DateTime.Today;

                if(today.DayOfWeek == DayOfWeek.Monday)
                {
                    day = 2;
                }
                else if (today.DayOfWeek == DayOfWeek.Tuesday)
                {
                    day = 5;
                }
                else if (today.DayOfWeek == DayOfWeek.Wednesday)
                {
                    day = 8;
                }
                else if (today.DayOfWeek == DayOfWeek.Thursday)
                {
                    day = 11;
                }
                else if (today.DayOfWeek == DayOfWeek.Friday)
                {
                    day = 14;
                }
                else if (today.DayOfWeek == DayOfWeek.Saturday)
                {
                    day = 17;
                }
                else if (today.DayOfWeek == DayOfWeek.Sunday)
                {
                    day = 20;
                }

                int time_from = day + 1;
                int time_to = day + 2;

                DataGridViewRow Row = this.dgvDoctors.Rows[e.RowIndex];
                int row_Index = dgvDoctors.CurrentRow.Index;

                if (Row.Cells[11].Value.ToString() == "True")
                {
                    if (ds.Tables["tblDoctorDetails"] != null)
                    {
                        ds.Tables["tblDoctorDetails"].Clear();
                    }
                    con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                    cmd.Connection = con;
                    con.Open();
                    da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblDoctorSchedule WHERE doctor_id='" + dgvDoctors.Rows[row_Index].Cells[10].Value.ToString() + "'", con);
                    da.Fill(ds, "tblDoctorDetails");
                    con.Close();

                    if(ds.Tables["tblDoctorDetails"].Rows[0].ItemArray[day].ToString()=="Available")
                    {
                        
                        DateTime currentTime = DateTime.Now;
                        string timeValueFromColumn = ds.Tables["tblDoctorDetails"].Rows[0].ItemArray[time_from].ToString();
                        DateTime tableTime_from = DateTime.ParseExact(timeValueFromColumn, "h:mm:ss tt", CultureInfo.InvariantCulture);
                        string timeValueFromColumn2 = ds.Tables["tblDoctorDetails"].Rows[0].ItemArray[time_to].ToString();
                        DateTime tableTime_to = DateTime.ParseExact(timeValueFromColumn2, "h:mm:ss tt", CultureInfo.InvariantCulture);

                        if (currentTime.TimeOfDay >= tableTime_from.TimeOfDay && currentTime.TimeOfDay <= tableTime_to.TimeOfDay)
                        {
                            tbxAvailability.ForeColor = Color.Green;
                            tbxAvailability.Text = "Available Today !";
                            tbxLocation.ForeColor = Color.Black;
                            tbxLocation.Text = ds.Tables["tblDoctorDetails"].Rows[0].ItemArray[23].ToString();
                        }
                        else if(currentTime.TimeOfDay <= tableTime_from.TimeOfDay)
                        {
                            tbxAvailability.ForeColor = Color.Blue;
                            tbxAvailability.Text = "The doctor hasn't arrived yet !";
                            tbxLocation.ForeColor = Color.Black;
                            tbxLocation.Text = ds.Tables["tblDoctorDetails"].Rows[0].ItemArray[23].ToString();
                        }   
                        else if(currentTime.TimeOfDay >= tableTime_to.TimeOfDay)
                        {
                            tbxAvailability.ForeColor = Color.Brown;
                            tbxAvailability.Text = "Time to see the doctor is over!";
                            tbxLocation.ForeColor = Color.Black;
                            tbxLocation.Text = ds.Tables["tblDoctorDetails"].Rows[0].ItemArray[23].ToString();
                        }
                    }
                    else
                    {
                        tbxAvailability.ForeColor = Color.Red;
                        tbxAvailability.Text = "Not available today !";
                        tbxLocation.Clear();
                    }
                    //tbxPatientNo.Text = ds.Tables["tblDoctorDetails"].Rows[0].ItemArray[0].ToString();
                   

                    ds.Tables["tblDoctorDetails"].Clear();
                }
                else
                {
                    tbxAvailability.ForeColor = Color.Red;
                    tbxLocation.ForeColor = Color.Red;
                    tbxAvailability.Text = "No schedule has been made for the Doctor";
                    tbxLocation.Text = "Not Available";
                }

                string selectedName = Row.Cells[0].Value.ToString();
                string[] nameParts = selectedName.Split(' '); // Split the selected name into first_name and last_name parts

                string firstName = nameParts[0]; // Extract the first_name part
                string lastName = nameParts[1]; // Extract the last_name part
                    
                tbxFirstName.Text = firstName;
                tbxLastName.Text = lastName;
                tbxAddress.Text = Row.Cells[1].Value.ToString();
                cbbxIDType.Text = Row.Cells[2].Value.ToString();
                tbxIDNo.Text = Row.Cells[3].Value.ToString();
                cbbxSpecialization.Text = Row.Cells[4].Value.ToString();
                dtpDOB.Text = Row.Cells[5].Value.ToString();
                if(Row.Cells[6].Value.ToString()=="male")
                {
                    rbtnMale.Checked = true;
                }
                else
                {
                    rbtnFemale.Checked = true;
                }
                if(Row.Cells[7].Value.ToString() != "")
                {
                    tbxEmail.Text = Row.Cells[7].Value.ToString();
                    cbxEmail.Checked = true;
                }
                else
                {
                    cbxEmail.Checked = false;
                }
                if (Row.Cells[8].Value.ToString() != "")
                {
                    tbxMobile.Text = Row.Cells[8].Value.ToString();
                    cbxMobile.Checked = true;
                }
                else
                {
                    cbxMobile.Checked = false;
                }
                if (Row.Cells[9].Value.ToString() != "")
                {
                    tbxHome.Text = Row.Cells[9].Value.ToString();
                    cbxHome.Checked = true;
                }
                else
                {
                    cbxHome.Checked = false;
                }
                tbxDOCID.Text = Row.Cells[10].Value.ToString();
                tbxQualifications.Text = Row.Cells[12].Value.ToString();
                doctor_id = tbxDOCID.Text;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pnlViewDoctors.Enabled == false)
            {
                pnlViewDoctors.Enabled = true;
            }
            else
            {
                pnlViewDoctors.Enabled = false;
            }      
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

        private void btnUpdate_Click(object sender, EventArgs e)
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
                    int id = Convert.ToInt32(tbxDOCID.Text);

                    Doctor Doctor = new Doctor
                    {
                        id = Convert.ToInt32(tbxDOCID.Text),
                        first_name = tbxFirstName.Text,
                        last_name = tbxLastName.Text,
                        address = tbxAddress.Text,
                        id_type = cbbxIDType.Text,
                        id_no = tbxIDNo.Text,
                        spec_id = GetSelectedDoctorId(),
                        dob = dtpDOB.Value.ToShortDateString(),
                        gender = gender,
                        email = tbxEmail.Text,
                        mobile = tbxMobile.Text,
                        home = tbxHome.Text,
                        qualifications = tbxQualifications.Text
                    };

                    manageDoctors manageDoctors = new manageDoctors();
                    manageDoctors.UpdateDoctorById(id, Doctor);

                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();

                    manageDoctors.LoadDoctors(dgvDoctors);

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
                frmDeleteDoctor deleteDoc = new frmDeleteDoctor();
                if (deleteDoc.ShowDialog() == DialogResult.OK)
                {
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();
                    manageDoctors manageDoctors = new manageDoctors();
                    manageDoctors.LoadDoctors(dgvDoctors);

                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void tbxDOCID_TextChanged(object sender, EventArgs e)
        {
            if(tbxDOCID.Text != "" && frmLogin.userType == "Hospital Administrator")
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

        private void cbbxSelectSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbxSelectSpecialization.Text == "All")
            {
                try
                {
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();
                    manageDoctors manageDoctors = new manageDoctors();
                    manageDoctors.LoadDoctors(dgvDoctors);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:" + ex.Message);
                }
            }
            else
            {
                string selectedSpecialization = cbbxSelectSpecialization.Text;                // Get the selected specialization from the ComboBox

                manageDoctors manageDoctors = new manageDoctors();
                manageDoctors.LoadDoctorsBySpecialization(dgvDoctors, selectedSpecialization);
            }
        }

        private void tbxSearchDoctors_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = tbxSearchDoctors.Text;
                manageDoctors manageDoctors = new manageDoctors();
                manageDoctors.SearchDoctors(dgvDoctors, searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private int GetSelectedDoctorId()
        {
            string selectedSpec = cbbxSpecialization.SelectedItem.ToString();
            manageDoctors manageDoctors = new manageDoctors();
            int Spec_Id = manageDoctors.GetSpecializationId(selectedSpec);
            return Spec_Id;
        }

        private void ClearAll()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxAddress.Clear();
            cbbxIDType.Text = "Select ID Type";
            tbxIDNo.Clear();
            dtpDOB.Value = DateTime.Now;
            cbbxSpecialization.Text = "Select Specialization";
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            cbxEmail.Checked = false;
            cbxMobile.Checked = false;
            cbxHome.Checked = false;
            tbxEmail.Clear();
            tbxMobile.Clear();
            tbxHome.Clear();
            tbxDOCID.Clear();
            tbxAvailability.Clear();
            tbxLocation.Clear();
            tbxQualifications.Clear();
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(tbxFirstName.Text) || string.IsNullOrWhiteSpace(tbxLastName.Text) || string.IsNullOrWhiteSpace(tbxAddress.Text) || cbbxIDType.Text == "Select ID Type" ||
             string.IsNullOrWhiteSpace(tbxIDNo.Text)  || cbbxSelectSpecialization.Text == "Select Specialization" ||
             string.IsNullOrWhiteSpace(tbxEmail.Text) || string.IsNullOrWhiteSpace(tbxMobile.Text))
            {
                MessageBox.Show("Please fill all feilds");
                return false;
            }
            else if (dtpDOB.Value.Date == DateTime.Today )
            {
                MessageBox.Show("Please enter a correct birthday !");
                return false;
            }
            return true;
        }

        private void dtpAppointment_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDoctors.Rows.Clear();
                dgvDoctors.Refresh();
                manageDoctors manageDoctors = new manageDoctors();
                manageDoctors.PopulateDoctorsByDay(dgvDoctors, dtpDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void cbbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectByLocation = cbbxLocation.Text;                // Get the selected specialization from the ComboBox

            manageDoctors manageDoctors = new manageDoctors();
            manageDoctors.LoadDoctorsByLocation(dgvDoctors, selectByLocation);
        }
    }
}
