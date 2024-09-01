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
    public partial class frmAddDoctorSchedule : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmAddDoctorSchedule()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mon = "";
            string tue = "";
            string wed = "";
            string thu = "";
            string fri = "";
            string sat = "";
            string sun = "";

            string mon_time_from = "";
            string mon_time_to = "";
            string tue_time_from = "";
            string tue_time_to = "";
            string wed_time_from = "";
            string wed_time_to = "";
            string thu_time_from = "";
            string thu_time_to = "";
            string fri_time_from = "";
            string fri_time_to = "";
            string sat_time_from = "";
            string sat_time_to = "";
            string sun_time_from = "";
            string sun_time_to = "";

            Boolean schedule = true;

            if (tbxFullName.Text == "")
            {
                MessageBox.Show("Please select a Doctor for make a schedule !");
            }
            else if(cbxMon.Checked==false && cbxTue.Checked == false && cbxWed.Checked == false && cbxThu.Checked == false && cbxFri.Checked == false &&
                cbxSat.Checked == false && cbxSun.Checked == false)
            {
                MessageBox.Show("No schedule is made for any day !!");
            }
            else if(cbbxLocation.Text== "Select a Channeling Room")
            {
                MessageBox.Show("Select a Location for the Doctor !!!");
            }
            else
            {
                //monday
                if (cbxMon.Checked == true)
                {
                    mon = "Available";
                    mon_time_from = dtpMon_from.Text;
                    mon_time_to = dtpMon_to.Text;
                }
                else
                {
                    mon = "Not Available";
                    mon_time_from = "";
                    mon_time_to = "";
                }

                //tuesday
                if (cbxTue.Checked == true)
                {
                    tue = "Available";
                    tue_time_from = dtpTue_from.Text;
                    tue_time_to = dtpTue_to.Text;
                }
                else
                {
                    tue = "Not Available";
                    tue_time_from = "";
                    tue_time_to = "";
                }

                //wednesday
                if (cbxWed.Checked == true)
                {
                    wed = "Available";
                    wed_time_from = dtpWed_from.Text;
                    wed_time_to = dtpWed_to.Text;
                }
                else
                {
                    wed = "Not Available";
                    wed_time_from = "";
                    wed_time_to = "";
                }

                //thursday
                if (cbxThu.Checked == true)
                {
                    thu = "Available";
                    thu_time_from = dtpThu_from.Text;
                    thu_time_to = dtpThu_to.Text;
                }
                else
                {
                    thu = "Not Available";
                    thu_time_from = "";
                    thu_time_to = "";
                }

                //friday
                if (cbxFri.Checked == true)
                {
                    fri = "Available";
                    fri_time_from = dtpFri_from.Text;
                    fri_time_to = dtpFri_to.Text;
                }
                else
                {
                    fri = "Not Available";
                    fri_time_from = "";
                    fri_time_to = "";
                }

                //saturday
                if (cbxSat.Checked == true)
                {
                    sat = "Available";
                    sat_time_from = dtpSat_from.Text;
                    sat_time_to = dtpSat_to.Text;
                }
                else
                {
                    sat = "Not Available";
                    sat_time_from = "";
                    sat_time_to = "";
                }

                //sunday
                if (cbxSun.Checked == true)
                {
                    sun = "Available";
                    sun_time_from = dtpSun_from.Text;
                    sun_time_to = dtpSun_to.Text;
                }
                else
                {
                    sun = "Not Available";
                    sun_time_from = "";
                    sun_time_to = "";
                }

                con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO tblDoctorSchedule VALUES('" + tbxDOCID.Text + "','" + mon + "','" + mon_time_from +"','"+mon_time_to+"','" + tue +
                    "','" + tue_time_from +"','"+tue_time_to+"','" + wed + "','" + wed_time_from +"','"+wed_time_to+"','" + thu + "','" + thu_time_from +
                    "','"+thu_time_to+"','" + fri + "','" + fri_time_from + "','"+fri_time_to+"','"+sat+"','"+sat_time_from+"','"+sat_time_to+"','"+sun+
                    "','"+sun_time_from+"','"+sun_time_to+"','"+cbbxLocation.Text+"')";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Doctor Schedule has been saved successfully");

                //update doctor table
                cmd.CommandText = "UPDATE tblDoctors SET schedule='" + schedule + "' WHERE id='" + tbxDOCID.Text + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //doctors data grid view load
                dgvDoctors.Rows.Clear();
                dgvDoctors.Refresh();

                if (ds.Tables["tblDoctors"] != null)
                {
                    ds.Tables["tblDoctors"].Clear();
                }
                con.Open();
                da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblDoctors.id,tblDoctors.first_name,tblDoctors.last_name,tblSpecialization.specialization,tblDoctors.schedule FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id", con);
                da.Fill(ds, "tblDoctors");
                con.Close();
                int currentRow = 0;
                int rowcount = ds.Tables["tblDoctors"].Rows.Count;
                while (currentRow < rowcount)
                {
                    if (ds.Tables["tblDoctors"].Rows[currentRow].ItemArray[4].ToString() == "False")
                    {
                        string id = ds.Tables["tblDoctors"].Rows[currentRow].ItemArray[0].ToString();
                        string fname = ds.Tables["tblDoctors"].Rows[currentRow].ItemArray[1].ToString();
                        string lname = ds.Tables["tblDoctors"].Rows[currentRow].ItemArray[2].ToString();
                        string specialization1 = ds.Tables["tblDoctors"].Rows[currentRow].ItemArray[3].ToString();

                        string fullname = fname + " " + lname;

                        dgvDoctors.Rows.Add(fullname, specialization1, id);
                    }
                    currentRow++;
                }
                ds.Tables["tblDoctors"].Clear();

                //location combobox
                cbbxLocation.Items.Clear();

                // Populate ComboBox with all room numbers
                string[] roomNumbers = new string[]
                {
                "G01", "G02", "G03", "G04", "G05", "G06","G07", "G08", "G09", "G10", "G11", "G12","G13", "G14", "G15",
                "A01", "A02", "A03", "A04", "A05", "A06","A07", "A08", "A09", "A10", "A11", "A12","A13", "A14", "A15",
                "B01", "B02", "B03", "B04", "B05", "B06","B07", "B08", "B09", "B10", "B11", "B12","B13", "B14", "B15",
                };

                cbbxLocation.Items.AddRange(roomNumbers);

                int comboCount = cbbxLocation.Items.Count;
                int currentCombo = 0;

                if (ds.Tables["tblDoctorSchedule"] != null)
                {
                    ds.Tables["tblDoctorSchedule"].Clear();
                }
                con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                con.Open();
                da = new System.Data.SqlClient.SqlDataAdapter("SELECT DISTINCT room_no FROM tblDoctorSchedule", con);
                da.Fill(ds, "tblDoctorSchedule");
                con.Close();

                int currentRow1 = 0;
                int rowcount1 = ds.Tables["tblDoctorSchedule"].Rows.Count;

                while (currentRow1 < rowcount1)
                {
                    while (currentCombo < comboCount)
                    {
                        if (cbbxLocation.Items[currentCombo].ToString() == ds.Tables["tblDoctorSchedule"].Rows[currentRow1].ItemArray[0].ToString())
                        {
                            cbbxLocation.Items.RemoveAt(currentCombo);
                            break;
                        }
                        currentCombo++;
                    }
                    currentRow1++;
                }
                ds.Tables["tblDoctorSchedule"].Clear();

                //reset tools
                tbxFullName.Clear();
                tbxDOCID.Clear();

                cbxMon.Checked = false;
                cbxTue.Checked = false;
                cbxWed.Checked = false;
                cbxThu.Checked = false;
                cbxFri.Checked = false;
                cbxSat.Checked = false;
                cbxSun.Checked = false;

                dtpMon_from.Value = DateTime.Now;
                dtpMon_to.Value = DateTime.Now;
                dtpTue_from.Value = DateTime.Now;
                dtpTue_to.Value = DateTime.Now;
                dtpWed_from.Value = DateTime.Now;
                dtpWed_to.Value = DateTime.Now;
                dtpThu_from.Value = DateTime.Now;
                dtpThu_to.Value = DateTime.Now;
                dtpFri_from.Value = DateTime.Now;
                dtpFri_to.Value = DateTime.Now;
                dtpSat_from.Value = DateTime.Now;
                dtpSat_to.Value = DateTime.Now;
                dtpSun_from.Value = DateTime.Now;
                dtpSun_to.Value = DateTime.Now;
                cbbxLocation.Text = "Select a Channeling Room";
            }
        }

        private void frmDoctorAvailabilityAndLocation_Load(object sender, EventArgs e)
        {
            //doctors data grid view load
            try
            {
                dgvDoctors.Rows.Clear();
                dgvDoctors.Refresh();
                manageDoctors manageDoctors = new manageDoctors();
                manageDoctors.LoadDoctors4Schedule(dgvDoctors);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }

            //location combobox
            cbbxLocation.Items.Clear();

            // Populate ComboBox with all room numbers
            string[] roomNumbers = new string[]
            {
                "G01", "G02", "G03", "G04", "G05", "G06","G07", "G08", "G09", "G10", "G11", "G12","G13", "G14", "G15",
                "A01", "A02", "A03", "A04", "A05", "A06","A07", "A08", "A09", "A10", "A11", "A12","A13", "A14", "A15",
                "B01", "B02", "B03", "B04", "B05", "B06","B07", "B08", "B09", "B10", "B11", "B12","B13", "B14", "B15",
            };

            cbbxLocation.Items.AddRange(roomNumbers);

            int comboCount = cbbxLocation.Items.Count;
            int currentCombo = 0;

            if (ds.Tables["tblDoctorSchedule"] != null)
            {
                ds.Tables["tblDoctorSchedule"].Clear();
            }
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT DISTINCT room_no FROM tblDoctorSchedule", con);
            da.Fill(ds, "tblDoctorSchedule");
            con.Close();

            int currentRow1 = 0;
            int rowcount1 = ds.Tables["tblDoctorSchedule"].Rows.Count;

            while (currentRow1 < rowcount1)
            {
                while (currentCombo < comboCount)
                {
                    if (cbbxLocation.Items[currentCombo].ToString() == ds.Tables["tblDoctorSchedule"].Rows[currentRow1].ItemArray[0].ToString())
                    {
                        cbbxLocation.Items.RemoveAt(currentCombo);
                        break;
                    }
                    currentCombo++;
                }
                currentRow1++;
            }
            ds.Tables["tblDoctorSchedule"].Clear();
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvDoctors.Rows[e.RowIndex];

                tbxFullName.Text = Row.Cells[0].Value.ToString();
                tbxDOCID.Text = Row.Cells[2].Value.ToString();
            }
    }

        private void cbxMon_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxMon.Checked==true)
            {
                dtpMon_from.Enabled = true;
                dtpMon_to.Enabled = true;
            }
            else
            {
                dtpMon_from.Enabled = false;
                dtpMon_from.Value = DateTime.Now;
                dtpMon_to.Enabled = false;
                dtpMon_to.Value = DateTime.Now;
            }
        }

        private void cbxTue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTue.Checked == true)
            {
                dtpTue_from.Enabled = true;
                dtpTue_to.Enabled = true;
            }
            else
            {
                dtpTue_from.Enabled = false;
                dtpTue_from.Value = DateTime.Now;
                dtpTue_to.Enabled = false;
                dtpTue_to.Value = DateTime.Now;
            }
        }

        private void cbxWed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxWed.Checked == true)
            {
                dtpWed_from.Enabled = true;
                dtpWed_to.Enabled = true;
            }
            else
            {
                dtpWed_from.Enabled = false;
                dtpWed_from.Value = DateTime.Now;
                dtpWed_to.Enabled = false;
                dtpWed_to.Value = DateTime.Now;
            }
        }

        private void cbxThu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxThu.Checked == true)
            {
                dtpThu_from.Enabled = true;
                dtpThu_to.Enabled = true;
            }
            else
            {
                dtpThu_from.Enabled = false;
                dtpThu_from.Value = DateTime.Now;
                dtpThu_to.Enabled = false;
                dtpThu_to.Value = DateTime.Now;
            }
        }

        private void cbxFri_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFri.Checked == true)
            {
                dtpFri_from.Enabled = true;
                dtpFri_to.Enabled = true;
            }
            else
            {
                dtpFri_from.Enabled = false;
                dtpFri_from.Value = DateTime.Now;
                dtpFri_to.Enabled = false;
                dtpFri_to.Value = DateTime.Now;
            }
        }

        private void cbxSat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSat.Checked == true)
            {
                dtpSat_from.Enabled = true;
                dtpSat_to.Enabled = true;
            }
            else
            {
                dtpSat_from.Enabled = false;
                dtpSat_from.Value = DateTime.Now;
                dtpSat_to.Enabled = false;
                dtpSat_to.Value = DateTime.Now;
            }
        }

        private void cbxSun_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSun.Checked == true)
            {
                dtpSun_from.Enabled = true;
                dtpSun_to.Enabled = true;
            }
            else
            {
                dtpSun_from.Enabled = false;
                dtpSun_from.Value = DateTime.Now;
                dtpSun_to.Enabled = false;
                dtpSun_to.Value = DateTime.Now;
            }
        }

        private void cbbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(pnlAddDocSchedule.Enabled==false)
            {
                pnlAddDocSchedule.Enabled = true;
            }
            else
            {
                pnlAddDocSchedule.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset tools
            tbxFullName.Clear();
            tbxDOCID.Clear();

            cbxMon.Checked = false;
            cbxTue.Checked = false;
            cbxWed.Checked = false;
            cbxThu.Checked = false;
            cbxFri.Checked = false;
            cbxSat.Checked = false;
            cbxSun.Checked = false;

            dtpMon_from.Value = DateTime.Now;
            dtpMon_to.Value = DateTime.Now;
            dtpTue_from.Value = DateTime.Now;
            dtpTue_to.Value = DateTime.Now;
            dtpWed_from.Value = DateTime.Now;
            dtpWed_to.Value = DateTime.Now;
            dtpThu_from.Value = DateTime.Now;
            dtpThu_to.Value = DateTime.Now;
            dtpFri_from.Value = DateTime.Now;
            dtpFri_to.Value = DateTime.Now;
            dtpSat_from.Value = DateTime.Now;
            dtpSat_to.Value = DateTime.Now;
            dtpSun_from.Value = DateTime.Now;
            dtpSun_to.Value = DateTime.Now;
            cbbxLocation.Text = "Select a Channeling Room";
        }

        private void cbbxSelectSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbxSelectSpecialization.Text == "All")
                {
                
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();
                    manageDoctors manageDoctors = new manageDoctors();
                    manageDoctors.LoadDoctors4Schedule(dgvDoctors); 
                }
                else
                {
                    string selectedSpecialization = cbbxSelectSpecialization.Text;                // Get the selected specialization from the ComboBox

                    manageDoctors manageDoctors = new manageDoctors();
                    manageDoctors.DoctorsBySpec4schedule(dgvDoctors, selectedSpecialization);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void tbxSearchDoctors_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = tbxSearchDoctors.Text;
                manageDoctors manageDoctors = new manageDoctors();
                manageDoctors.SearchDoctors4Schedule(dgvDoctors, searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }
    }
}
