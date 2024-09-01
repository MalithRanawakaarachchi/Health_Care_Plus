using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Health_Care_Plus_00174336.Classes
{
    public class Appointment
    {
        public int id { get; set; }
        public int patient_id { get; set; }
        public int doctor_id { get; set; }
        public string date { get; set; }
        public string channelling_no { get; set; }
    }
    public class manageAppointments
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        // all doctors
        public void LoadDoctors(DataGridView dgvDoctors)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT tblDoctors.id,tblDoctors.first_name,tblDoctors.last_name,tblSpecialization.specialization,tblDoctors.schedule FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id", con))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tblDoctors");

                        foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                        {
                            if (row["schedule"].ToString() == "True")
                            {
                                Doctor Doctor = new Doctor
                                {
                                    id = Convert.ToInt32(row["id"].ToString()),
                                    first_name = row["first_name"].ToString(),
                                    last_name = row["last_name"].ToString(),
                                    spec = row["specialization"].ToString(),
                                };

                                string fullName = Doctor.first_name + " " + Doctor.last_name;
                                dgvDoctors.Rows.Add(Doctor.id, fullName, Doctor.spec);
                            }
                        }

                        ds.Tables["tblDoctors"].Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Resource: " + ex.Message);
                }
            }
        }

        //search doctors
        public void SearchDoctors(DataGridView dgvDoctors, string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT tblDoctors.id,tblDoctors.first_name,tblDoctors.last_name,tblSpecialization.specialization,tblDoctors.schedule FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id WHERE tblDoctors.first_name + ' ' + tblDoctors.last_name LIKE @SearchText", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblDoctors");

                    // Clear the list box before adding search results
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();

                    foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                    {
                        if (row["schedule"].ToString() == "True")
                        {
                            Doctor Doctor = new Doctor
                            {
                                first_name = row["first_name"].ToString(),
                                last_name = row["last_name"].ToString(),
                                spec = row["specialization"].ToString(),
                                schedule = row["schedule"].ToString(),
                            };

                            string fullName = Doctor.first_name + " " + Doctor.last_name;
                            dgvDoctors.Rows.Add(Doctor.id, fullName, Doctor.spec);
                        }
                    }

                    ds.Tables["tblDoctors"].Clear();
                }
            }
        }

        //search appointments
        public void SearchAppointments(DataGridView dgvAppointments, string searchAppointment)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                dgvAppointments.Rows.Clear();
                dgvAppointments.Refresh();
                DataSet ds = new DataSet();
                if (ds.Tables["tblAppointmentsList"] != null)
                {
                    ds.Tables["tblAppointmentsList"].Clear();
                }
                    con.Open();
                    SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblAppointments.id,tblAppointments.date,tblAppointments.patient_id,tblPatients.first_name,tblPatients.last_name,tblAppointments.doctor_id,tblDoctors.first_name,tblDoctors.last_name,tblAppointments.channelling_no FROM tblAppointments INNER JOIN tblPatients ON tblAppointments.patient_id=tblPatients.id INNER JOIN tblDoctors ON tblAppointments.doctor_id = tblDoctors.id WHERE tblAppointments.patient_id LIKE @searchAppointment", con);
                    da.SelectCommand.Parameters.AddWithValue("@searchAppointment", "%" + searchAppointment + "%");
                    da.Fill(ds, "tblAppointmentsList");
                    con.Close();
                    int currentRow = 0;
                    int rowcount = ds.Tables["tblAppointmentsList"].Rows.Count;
                    int day = 0;

                    while (currentRow < rowcount)
                    {
                        day = GetDayOfWeekOffset(Convert.ToDateTime(ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[1].ToString()));

                        if (ds.Tables["tblDoctorBySchedule"] != null)
                        {
                            ds.Tables["tblDoctorBySchedule"].Clear();
                        }
                        con.Open();
                        da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblDoctorSchedule WHERE doctor_id = '" + ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[5].ToString() + "'", con);
                        da.Fill(ds, "tblDoctorBySchedule");
                        con.Close();

                        //doctor specialization
                        if (ds.Tables["tblDoctorsSpec"] != null)
                        {
                            ds.Tables["tblDoctorsSpec"].Clear();
                        }
                        con.Open();
                        da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblSpecialization.specialization FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id WHERE tblDoctors.id = '" + ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[5].ToString() + "'", con);
                        da.Fill(ds, "tblDoctorsSpec");
                        con.Close();


                        string id = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[0].ToString();
                        string date = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[1].ToString();
                        string patient_id = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[2].ToString();
                        string patient_fname = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[3].ToString();
                        string patient_lname = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[4].ToString();
                        string doctor_id = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[5].ToString();
                        string doctor_fname = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[6].ToString();
                        string doctor_lname = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[7].ToString();
                        string specialization = ds.Tables["tblDoctorsSpec"].Rows[0].ItemArray[0].ToString();
                        string timefrom = ds.Tables["tblDoctorBySchedule"].Rows[0].ItemArray[day + 1].ToString();
                        string timeto = ds.Tables["tblDoctorBySchedule"].Rows[0].ItemArray[day + 2].ToString();
                        string room_no = ds.Tables["tblDoctorBySchedule"].Rows[0].ItemArray[23].ToString();
                        string channelling_no = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[8].ToString();

                        string patient_fullname = patient_fname + " " + patient_lname;
                        string doctor_fullname = doctor_fname + " " + doctor_lname;

                        dgvAppointments.Rows.Add(id, date, patient_id, patient_fullname, doctor_id, doctor_fullname, specialization, timefrom, timeto, room_no, channelling_no);

                        ds.Tables["tblDoctorBySchedule"].Clear();
                        ds.Tables["tblDoctorsSpec"].Clear();
                        currentRow++;
                    }
                    ds.Tables["tblAppointmentsList"].Clear();
                
            }
        }

        //search doctor by specialization
        public void LoadDoctorsBySpecialization(DataGridView dgvDoctors, string specialization)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT tblDoctors.id, tblDoctors.first_name, tblDoctors.last_name, tblSpecialization.specialization, tblDoctors.schedule FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id = tblSpecialization.id WHERE tblSpecialization.specialization = @specialization", con);
                    da.SelectCommand.Parameters.AddWithValue("@specialization", specialization);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblDoctors");

                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();

                    foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                    {
                        if (row["schedule"].ToString() == "True")
                        {
                            Doctor Doctor = new Doctor
                            {
                                first_name = row["first_name"].ToString(),
                                last_name = row["last_name"].ToString(),
                                spec = row["specialization"].ToString(),
                                id = Convert.ToInt32(row["id"].ToString()),
                            };

                            string fullName = Doctor.first_name + " " + Doctor.last_name;
                            dgvDoctors.Rows.Add(Doctor.id_no, fullName, Doctor.spec);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //get doctor by today
        public void LoadDoctorsByDay(DataGridView dgvDoctors, ComboBox cbbxSelectSpecialization)
        {
            dgvDoctors.Rows.Clear();
            dgvDoctors.Refresh();

            int day = 0;

            DateTime today = DateTime.Today;

            if (today.DayOfWeek == DayOfWeek.Monday)
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

            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblDoctorSchedule", con))
                {
                    da.Fill(ds, "tblDoctorByDay");
                }
                con.Close();
            }

            int rowCount = ds.Tables["tblDoctorByDay"].Rows.Count;
            int currentRow = 0;

            while (currentRow < rowCount)
            {
                if (ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[day].ToString() == "Available")
                {

                    if (ds.Tables["tblDoctors"] != null)
                    {
                        ds.Tables["tblDoctors"].Clear();
                    }
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter("SELECT tblDoctors.id, tblDoctors.first_name, tblDoctors.last_name, tblSpecialization.specialization, tblDoctors.schedule FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id WHERE tblDoctors.id = '" + ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[1].ToString() + "'", con))
                        {
                            da.Fill(ds, "tblDoctors");
                        }
                        con.Close();
                    }

                    if (ds.Tables["tblDoctors"].Rows[0].ItemArray[3].ToString()== cbbxSelectSpecialization.Text)
                    {
                        string id = ds.Tables["tblDoctors"].Rows[0].ItemArray[0].ToString();
                        string fname = ds.Tables["tblDoctors"].Rows[0].ItemArray[1].ToString();
                        string lname = ds.Tables["tblDoctors"].Rows[0].ItemArray[2].ToString();
                        string specialization = ds.Tables["tblDoctors"].Rows[0].ItemArray[3].ToString();
                        string from = ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[time_from].ToString();
                        string to = ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[time_to].ToString();
                        string room = ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[23].ToString();

                        string fullname = fname + " " + lname;

                        dgvDoctors.Rows.Add(id, fullname, specialization, from, to, room);
                    }
                    ds.Tables["tblDoctors"].Clear();
                    dgvDoctors.Enabled = true;
                }
                currentRow++;
            }
            ds.Tables["tblDoctorByDay"].Clear();
        }

        //get doctor by date
        public void PopulateDoctorsByDay(DataGridView dgvDoctors, DateTimePicker dtpDate, ComboBox cbbxSpecialization)
        {
            dgvDoctors.Rows.Clear();
            dgvDoctors.Refresh();

            int day = GetDayOfWeekOffset(dtpDate.Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                DataSet ds = new DataSet();

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblDoctorSchedule", con))
                {
                    da.Fill(ds, "tblDoctorByDay");
                }

                int rowCount = ds.Tables["tblDoctorByDay"].Rows.Count;
                int currentRow = 0;

                while (currentRow < rowCount)
                {
                    if (ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[day].ToString() == "Available")
                    {
                        string doctorId = ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[1].ToString();
                        string from = ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[day + 1].ToString();
                        string to = ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[day + 2].ToString();
                        string room = ds.Tables["tblDoctorByDay"].Rows[currentRow].ItemArray[23].ToString();

                        SqlDataAdapter daa = new SqlDataAdapter($"SELECT tblDoctors.id, tblDoctors.first_name, tblDoctors.last_name, tblSpecialization.specialization FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id = tblSpecialization.id INNER JOIN tblDoctorSchedule ON tblDoctors.id = tblDoctorSchedule.doctor_id WHERE tblDoctors.id = '" + doctorId + "'", con);

                        DataSet dss = new DataSet();
                        daa.Fill(dss, "tblDoctors");

                        foreach (DataRow row in dss.Tables["tblDoctors"].Rows)
                        {
                            if (dss.Tables["tblDoctors"].Rows[0].ItemArray[3].ToString() == cbbxSpecialization.Text)
                            {
                                Doctor Doctor = new Doctor
                                {
                                    id = Convert.ToInt32(row["id"].ToString()),
                                    first_name = row["first_name"].ToString(),
                                    last_name = row["last_name"].ToString(),
                                    spec = row["specialization"].ToString(),
                                };

                                string fullName = Doctor.first_name + " " + Doctor.last_name;
                                dgvDoctors.Rows.Add(Doctor.id, fullName, Doctor.spec, from, to, room);
                            }
                        }
                        dss.Tables["tblDoctors"].Clear();
                    }
                    currentRow++;
                }
                ds.Tables["tblDoctorByDay"].Clear();
            }
        }

        public void AddAppointment(Appointment Appointment)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblAppointments (patient_id, doctor_id, date, channelling_no) VALUES (@patient_id, @doctor_id, @date, @channelling_no)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@patient_id", Appointment.patient_id);
                    cmd.Parameters.AddWithValue("@doctor_id", Appointment.doctor_id);
                    cmd.Parameters.AddWithValue("@date", Appointment.date);
                    cmd.Parameters.AddWithValue("@channelling_no", Appointment.channelling_no);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Appointment has been saved successfully");
                }
            }
        }

        //load DGV of Appointments
        public void getAllAppointments(DataGridView dgvAppointments)
        {

            dgvAppointments.Rows.Clear();
            dgvAppointments.Refresh();
            DataSet ds = new DataSet();
            if (ds.Tables["tblAppointmentsList"] != null)
            {
                ds.Tables["tblAppointmentsList"].Clear();
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblAppointments.id,tblAppointments.date,tblAppointments.patient_id,tblPatients.first_name,tblPatients.last_name,tblAppointments.doctor_id,tblDoctors.first_name,tblDoctors.last_name,tblAppointments.channelling_no FROM tblAppointments INNER JOIN tblPatients ON tblAppointments.patient_id=tblPatients.id INNER JOIN tblDoctors ON tblAppointments.doctor_id = tblDoctors.id", con);
                da.Fill(ds, "tblAppointmentsList");
                con.Close();
                int currentRow = 0;
                int rowcount = ds.Tables["tblAppointmentsList"].Rows.Count;
                int day = 0;

                while (currentRow < rowcount)
                {
                    day = GetDayOfWeekOffset(Convert.ToDateTime(ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[1].ToString()));

                    if (ds.Tables["tblDoctorBySchedule"] != null)
                    {
                        ds.Tables["tblDoctorBySchedule"].Clear();
                    }
                    con.Open();
                    da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblDoctorSchedule WHERE doctor_id = '" + ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[5].ToString() + "'", con);
                    da.Fill(ds, "tblDoctorBySchedule");
                    con.Close();

                    //doctor specialization
                    if (ds.Tables["tblDoctorsSpec"] != null)
                    {
                        ds.Tables["tblDoctorsSpec"].Clear();
                    }
                    con.Open();
                    da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblSpecialization.specialization FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id WHERE tblDoctors.id = '" + ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[5].ToString() + "'", con);
                    da.Fill(ds, "tblDoctorsSpec");
                    con.Close();


                    string id = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[0].ToString();
                    string date = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[1].ToString();
                    string patient_id = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[2].ToString();
                    string patient_fname = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[3].ToString();
                    string patient_lname = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[4].ToString();
                    string doctor_id = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[5].ToString();
                    string doctor_fname = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[6].ToString();
                    string doctor_lname = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[7].ToString();
                    string specialization = ds.Tables["tblDoctorsSpec"].Rows[0].ItemArray[0].ToString();
                    string timefrom = ds.Tables["tblDoctorBySchedule"].Rows[0].ItemArray[day+1].ToString();
                    string timeto = ds.Tables["tblDoctorBySchedule"].Rows[0].ItemArray[day+2].ToString();
                    string room_no = ds.Tables["tblDoctorBySchedule"].Rows[0].ItemArray[23].ToString();
                    string channelling_no = ds.Tables["tblAppointmentsList"].Rows[currentRow].ItemArray[8].ToString();

                    string patient_fullname = patient_fname + " " + patient_lname;
                    string doctor_fullname = doctor_fname + " " + doctor_lname;

                    dgvAppointments.Rows.Add(id, date, patient_id, patient_fullname, doctor_id, doctor_fullname, specialization, timefrom, timeto, room_no, channelling_no);

                    ds.Tables["tblDoctorBySchedule"].Clear();
                    ds.Tables["tblDoctorsSpec"].Clear();
                    currentRow++;
                }
                ds.Tables["tblAppointmentsList"].Clear();
            }
        }

private int GetDayOfWeekOffset(DateTime selectedDate)
        {
            DayOfWeek dayOfWeek = selectedDate.DayOfWeek;
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return 2;
                case DayOfWeek.Tuesday:
                    return 5;
                case DayOfWeek.Wednesday:
                    return 8;
                case DayOfWeek.Thursday:
                    return 11;
                case DayOfWeek.Friday:
                    return 14;
                case DayOfWeek.Saturday:
                    return 17;
                case DayOfWeek.Sunday:
                    return 20;
                default:
                    return 0;
            }
        }
    }
}
