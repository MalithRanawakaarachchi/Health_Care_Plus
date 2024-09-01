using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_00174336
{
    public partial class frmManageDoctorSchedules : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmManageDoctorSchedules()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pnlManageDocSchedule.Enabled == false)
            {
                pnlManageDocSchedule.Enabled = true;
            }
            else
            {
                pnlManageDocSchedule.Enabled = false;
            }
        }

        private void cbxMon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMon.Checked == true)
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

        private void btnUpdate_Click(object sender, EventArgs e)
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

            if (tbxFullName.Text == "")
            {
                MessageBox.Show("Please select a Doctor for update schedule !");
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
                cmd.CommandText = "UPDATE tblDoctorSchedule SET mon='" + mon + "',time_mon_from='" + mon_time_from + "',time_mon_to='"+mon_time_to+
                    "',tue='" + tue + "',time_tue_from='" + tue_time_from +"',time_tue_to='"+tue_time_to+"',wed='" + wed + "',time_wed_from='" + wed_time_from +
                    "',time_wed_to='"+wed_time_to+"',thu='" + thu + "',time_thu_from='" + thu_time_from + "',time_thu_to='"+thu_time_to+"',fri='" + fri +
                    "',time_fri_from='" + fri_time_from +"',time_fri_to='"+fri_time_to+"',sat='" + sat + "',time_sat_from='" + sat_time_from +
                    "',time_sat_to='"+sat_time_to+"',sun='" + sun +"',time_sun_from='" + sun_time_from + "',time_sun_to='"+sun_time_to+
                    "',room_no='" + cbbxLocation.Text +"' WHERE doctor_id='"+tbxDOCID.Text+"'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Doctor Schedule has been updated successfully");

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

        private void frmManageDoctorSchedules_Load(object sender, EventArgs e)
        {
            //doctors data grid view load
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            cmd.Connection = con;

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
                if (ds.Tables["tblDoctors"].Rows[currentRow].ItemArray[4].ToString() == "True")
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
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow RowIndex = this.dgvDoctors.Rows[e.RowIndex];
                int row_Index = dgvDoctors.CurrentRow.Index;

                if (ds.Tables["tblDoctorSchedule1"] != null)
                {
                    ds.Tables["tblDoctorSchedule1"].Clear();
                }
                con.Open();
                da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblDoctorSchedule WHERE doctor_id='" + dgvDoctors.Rows[row_Index].Cells[2].Value.ToString() + "'", con);
                da.Fill(ds, "tblDoctorSchedule1");
                con.Close();

                tbxFullName.Text = RowIndex.Cells[0].Value.ToString();
                tbxDOCID.Text = RowIndex.Cells[2].Value.ToString();
                if(ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[2].ToString()=="Available")
                {
                    cbxMon.Checked = true;
                    dtpMon_from.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[3].ToString();
                    dtpMon_to.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[4].ToString();
                }
                else
                {
                    cbxMon.Checked = false;
                }
                if (ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[5].ToString() == "Available")
                {
                    cbxTue.Checked = true;
                    dtpTue_from.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[6].ToString();
                    dtpTue_to.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[7].ToString();
                }
                else
                {
                    cbxTue.Checked = false;
                }
                if (ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[8].ToString() == "Available")
                {
                    cbxWed.Checked = true;
                    dtpWed_from.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[9].ToString();
                    dtpWed_to.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[10].ToString();
                }
                else
                {
                    cbxWed.Checked = false;
                }
                if (ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[11].ToString() == "Available")
                {
                    cbxThu.Checked = true;
                    dtpThu_from.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[12].ToString();
                    dtpThu_to.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[13].ToString();
                }
                else
                {
                    cbxThu.Checked = false;
                }
                if (ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[14].ToString() == "Available")
                {
                    cbxFri.Checked = true;
                    dtpFri_from.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[15].ToString();
                    dtpFri_to.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[16].ToString();
                }
                else
                {
                    cbxFri.Checked = false;
                }
                if (ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[17].ToString() == "Available")
                {
                    cbxSat.Checked = true;
                    dtpSat_from.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[18].ToString();
                    dtpSat_to.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[19].ToString();
                }
                else
                {
                    cbxSat.Checked = false;
                }
                if (ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[20].ToString() == "Available")
                {
                    cbxSun.Checked = true;
                    dtpSun_from.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[21].ToString();
                    dtpSun_to.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[22].ToString();
                }
                else
                {
                    cbxSun.Checked = false;
                }

                cbbxLocation.Text = ds.Tables["tblDoctorSchedule1"].Rows[0].ItemArray[23].ToString();

                ds.Tables["tblDoctorSchedule1"].Clear(); 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Boolean schedule = false;

            if (tbxFullName.Text == "")
            {
                MessageBox.Show("Please select a Doctor for delete schedule !");
            }
            else
            { 
                con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "DELETE FROM tblDoctorSchedule WHERE doctor_id ='" + tbxDOCID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Schedule has been removed Successfully");

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
                    if (ds.Tables["tblDoctors"].Rows[currentRow].ItemArray[4].ToString() == "True")
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
    }
}
