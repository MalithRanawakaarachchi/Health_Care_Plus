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
    public partial class frmViewAppointment : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        manageAppointments manageAppointments = new manageAppointments();

        public frmViewAppointment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmViewAppointment_Load(object sender, EventArgs e)
        {
            //appointment list
            try
            {
                dgvAppointments.Rows.Clear();
                dgvAppointments.Refresh();
                manageAppointments.getAllAppointments(dgvAppointments);

                if (frmLogin.userType == "Hospital Administrator" || frmLogin.userType == "Operating Officer")
                {
                    btnEdit.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    pnlViewAppointments.Enabled = true;
                }
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

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow Row = this.dgvDoctors.Rows[e.RowIndex];
                    int row_Index = dgvDoctors.CurrentRow.Index;

                    if (Row.Cells[3].Value.ToString() == "")
                    {
                        MessageBox.Show("Select appointment date before select a doctor !");
                    }
                    else
                    {
                        if (ds.Tables["tblDoctorDetails"] != null)
                        {
                            ds.Tables["tblDoctorDetails"].Clear();
                        }
                        con.Open();
                        da = new System.Data.SqlClient.SqlDataAdapter("SELECT room_no FROM tblDoctorSchedule WHERE doctor_id='" + dgvDoctors.Rows[row_Index].Cells[0].Value.ToString() + "'", con);
                        da.Fill(ds, "tblDoctorDetails");
                        con.Close();

                        tbxRoomNo.Text = ds.Tables["tblDoctorDetails"].Rows[0].ItemArray[0].ToString();
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

                        tbxDate.Text = dtpAppointment.Value.ToShortDateString();
                        ds.Tables["tblDoctorDetails"].Clear();
                        ds.Tables["tblAppointments"].Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Select appointment date before select a doctor !");
            }
        }

        private void tbxEdit_Click(object sender, EventArgs e)
        {
            if(pnlEditAppointments.Enabled==false)
            {
                pnlEditAppointments.Enabled = true;
            }
            else
            {
                pnlEditAppointments.Enabled = false;
            }
        }

        private void dtpSelectAppointments_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvAppointments.Rows[e.RowIndex];

                tbxDate.Text = Row.Cells[1].Value.ToString();
                tbxPatientNo.Text = Row.Cells[2].Value.ToString();
                tbxPatientName.Text = Row.Cells[3].Value.ToString();
                tbxDocNo.Text = Row.Cells[4].Value.ToString();
                tbxDoctorName.Text = Row.Cells[5].Value.ToString();
                tbxTimeFrom.Text = Row.Cells[7].Value.ToString();
                tbxTimeTo.Text = Row.Cells[8].Value.ToString();
                tbxRoomNo.Text = Row.Cells[9].Value.ToString();
                tbxChannelingNo.Text = Row.Cells[10].Value.ToString();
            }
        }

        private void tbxUpdate_Click(object sender, EventArgs e)
        {
            if (tbxDate.Text == "")
            {
                MessageBox.Show("Please select a appointment before update !");
            }
            else
            {
                con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                cmd.Connection = con;
                cmd.CommandText = "UPDATE tblAppointments SET doctor_id='" + tbxDocNo.Text + "',date='" + tbxDate.Text +
                   "',channelling_no='" + tbxChannelingNo.Text + "' WHERE id='" + tbxPatientNo.Text + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Appointment has been updated successfully");

                ClearAll();

                //appointment list
                try
                {
                    dgvAppointments.Rows.Clear();
                    dgvAppointments.Refresh();
                    manageAppointments.getAllAppointments(dgvAppointments);
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
        }

        private void tbxDelete_Click(object sender, EventArgs e)
        {
            if (tbxDate.Text == "")
            {
                MessageBox.Show("Please select an appointment before delete !");
            }
            else
            {
                con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "DELETE FROM tblAppointments WHERE patient_id ='" + tbxPatientNo.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Appointment has been removed Successfully");

                ClearAll();

                //appointment list
                try
                {
                    dgvAppointments.Rows.Clear();
                    dgvAppointments.Refresh();
                    manageAppointments.getAllAppointments(dgvAppointments);
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

        private void tbxPatientNo_TextChanged(object sender, EventArgs e)
        {
            if (tbxPatientNo.Text != "")
            {
                if (frmLogin.userType == "Hospital Administrator" || frmLogin.userType == "Operating Officer")
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void ClearAll()
        {
            dgvAppointments.Rows.Clear();
            dgvAppointments.Refresh();
            tbxSearchDoctors.Clear();
            dtpAppointment.Value = DateTime.Now;
            tbxPatientName.Clear();
            tbxPatientNo.Clear();
            tbxDoctorName.Clear();
            tbxDocNo.Clear();
            tbxTimeFrom.Clear();
            tbxTimeTo.Clear();
            tbxRoomNo.Clear();
            tbxChannelingNo.Clear();
            tbxDate.Clear();
            dtpSelectAppointments.Value = DateTime.Now;
            tbxSearchAppointments.Clear();
        }

        private void tbxSearchAppointments_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchAppointment = tbxSearchAppointments.Text;
                manageAppointments.SearchAppointments(dgvAppointments, searchAppointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }
    }
}
