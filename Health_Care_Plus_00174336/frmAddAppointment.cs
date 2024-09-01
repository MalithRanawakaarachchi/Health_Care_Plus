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
    public partial class frmAddAppointment : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        manageAppointments manageAppointments = new manageAppointments();

        public frmAddAppointment()
        {
            InitializeComponent();
        }

        private void frmAddAppointment_Load(object sender, EventArgs e)
        {
            //patients
            try
            {
                lbxPatient.Items.Clear();
                lbxPatient.Refresh();
                managePatients managePatients = new managePatients();
                managePatients.LoadPatients(lbxPatient);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }

            //doctors
            try
            {
                dgvDoctors.Rows.Clear();
                dgvDoctors.Refresh();
                manageAppointments.LoadDoctors(dgvDoctors);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void cbbxSelectSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbxSelectSpecialization.Text == "All" || cbbxSelectSpecialization.Text == "Specialization")
            { 
                try
                {
                    pnlDate.Enabled = false;
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();
                    manageAppointments manageAppointments = new manageAppointments();
                    manageAppointments.LoadDoctors(dgvDoctors);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:" + ex.Message);
                }
            }
            else
            {
                try
                {
                    pnlDate.Enabled = true;
                    string selectedSpecialization = cbbxSelectSpecialization.Text;
                    manageAppointments manageAppointments = new manageAppointments();
                    manageAppointments.LoadDoctorsBySpecialization(dgvDoctors, selectedSpecialization);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:" + ex.Message);
                }
            }
        }

        private void tbxSearchDoctors_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = tbxSearchDoctors.Text;
                manageAppointments.SearchDoctors(dgvDoctors, searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void tbxSearcgPatients_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = tbxSearchDoctors.Text;
                managePatients managePatients = new managePatients();
                managePatients.SearchPatients(lbxPatient, searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void RetrievPatientData(string selectedName)
        {
            managePatients managePatients = new managePatients();
            Patient Patient = managePatients.GetPatientByName(selectedName);
            try
            {
                if (Patient != null)
                {
                    // Update form's controls with the retrieved patient data
                    tbxPatientNo.Text = Patient.id.ToString();
                    string fname = Patient.first_name.ToString();
                    string lname = Patient.last_name.ToString();
                    string fullName = fname + " " + lname;
                    tbxPatientName.Text = fullName;
                }
                else
                {
                    // Handle the case where the patient is not found
                    MessageBox.Show("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void lbxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedName = lbxPatient.SelectedItem.ToString();
                RetrievPatientData(selectedName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow Row = this.dgvDoctors.Rows[e.RowIndex];
                    int row_Index = dgvDoctors.CurrentRow.Index;

                    if (string.IsNullOrWhiteSpace(Row.Cells[3].Value.ToString()))
                    {
                        MessageBox.Show("Select appointment date before select a doctor !");
                    }
                    else
                    {
                        tbxRoomNo.Text = Row.Cells[5].Value.ToString();
                        tbxDocNo.Text = Row.Cells[0].Value.ToString();
                        tbxDoctorName.Text = Row.Cells[1].Value.ToString();
                        tbxTimeFrom.Text = Row.Cells[3].Value.ToString();
                        tbxTimeTo.Text = Row.Cells[4].Value.ToString();

                        if (ds.Tables["tblAppointments"] != null)
                        {
                            ds.Tables["tblAppointments"].Clear();
                        }

                        string date = "";
                        if (cbxTodayAvailable.Checked == true)
                        {
                            date = DateTime.Now.ToShortDateString();
                        }
                        else
                        {
                            date = dtpAppointment.Value.ToShortDateString();
                        }

                        con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                        con.Open();
                        da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblAppointments.channelling_no, tblAppointments.date FROM tblAppointments WHERE doctor_id='" + dgvDoctors.Rows[row_Index].Cells[0].Value.ToString() + "' AND date = '" + date + "'", con);
                        da.Fill(ds, "tblAppointments");
                        con.Close();

                        int rowCount = 0;
                        if (ds.Tables["tblAppointments"] != null)
                        {
                            rowCount = ds.Tables["tblAppointments"].Rows.Count;
                        }

                        int current_no = rowCount + 1;
                        string channelling_no = tbxRoomNo.Text + "-0" + current_no;
                        tbxChannelingNo.Text = channelling_no;
                        ds.Tables["tblAppointments"].Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select appointment date before select a doctor !");
            }
        }

        private void dtpAppointment_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpAppointment.Value.Date != DateTime.Now.Date)
                {
                    cbxTodayAvailable.Checked = false;
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();

                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();
                    manageAppointments manageAppointments = new manageAppointments();
                    manageAppointments.PopulateDoctorsByDay(dgvDoctors, dtpAppointment, cbbxSelectSpecialization);
                }
                else
                {
                    cbxTodayAvailable.Checked = true;
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }

        }

        private void cbxTodayAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTodayAvailable.Checked == true)
            {
                if (cbbxSelectSpecialization.Text != "Specialization")
                {
                    dtpAppointment.Value = DateTime.Now;
                    // Instantiate the DoctorScheduler class
                    manageAppointments manageAppointments = new manageAppointments();
                    manageAppointments.LoadDoctorsByDay(dgvDoctors, cbbxSelectSpecialization);
                }
                else
                {
                    MessageBox.Show("Please select Specialization first !");
                }
            }
            else
            {
                ClearAllofDoctor();

                try
                {
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();
                    manageAppointments.LoadDoctors(dgvDoctors);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:" + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(dgvDoctors.Enabled==false)
            {
                dgvDoctors.Enabled = true;
            }
            else
            {
                dgvDoctors.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string date = "";
            if(cbxTodayAvailable.Checked==true)
            {
                date = DateTime.Now.ToShortDateString();
            }
            else
            {
                date = dtpAppointment.Value.ToShortDateString();
            }

            if (tbxDocNo.Text == "")
            {
                MessageBox.Show("Please select a doctor before make an appointment !");
            }
            else if (tbxPatientNo.Text == "")
            {
                MessageBox.Show("Please select a patient before make an appointment !");
            }
            else
            {
                try
                {
                    if (Validate())
                    {
                        Appointment Appointment = new Appointment
                        {
                            patient_id = Convert.ToInt32(tbxPatientNo.Text),
                            doctor_id = Convert.ToInt32(tbxDocNo.Text),
                            date = date,
                            channelling_no = tbxChannelingNo.Text
                        };
                        manageAppointments.AddAppointment(Appointment);

                        //add a bill
                        Bill Bill = new Bill
                        {
                            patient_id = Convert.ToInt32(tbxPatientNo.Text),
                        };
                        ManageBills ManageBills = new ManageBills();
                        ManageBills.addAppointmentBill(Bill);

                        ClearAllofDoctor();
                        ClearButton();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:" + ex.Message);
                }

                //reload list of doctors
                try
                {
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();
                    manageAppointments.LoadDoctors(dgvDoctors);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:" + ex.Message);
                }
            }
        }

        private void ClearAllofDoctor()
        {
            dgvDoctors.Rows.Clear();
            dgvDoctors.Refresh();
            tbxDoctorName.Clear();
            tbxDocNo.Clear();
            tbxTimeFrom.Clear();
            tbxTimeTo.Clear();
            tbxRoomNo.Clear();
            tbxChannelingNo.Clear();
        }

        private void ClearButton()
        {
            tbxSearchDoctors.Clear();
            cbbxSelectSpecialization.Text = "Specialization";
            dtpAppointment.Value = DateTime.Now;
            cbxTodayAvailable.Checked = false;
            tbxPatientName.Clear();
            tbxPatientNo.Clear();
            tbxDoctorName.Clear();
            tbxDocNo.Clear();
            tbxTimeFrom.Clear();
            tbxTimeTo.Clear();
            tbxRoomNo.Clear();
            tbxChannelingNo.Clear();
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(tbxDocNo.Text))
            {
                MessageBox.Show("Please select a doctor before make an appointment !");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxPatientNo.Text))
            {
                MessageBox.Show("Please select a patient before make an appointment !");
                return false;
            }
            return true;
        }
    }
}
