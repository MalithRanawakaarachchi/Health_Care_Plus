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
    public class Doctor
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string id_type { get; set; }
        public string id_no { get; set; }
        public int spec_id { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string home { get; set; }
        public string schedule { get; set; }
        public string spec { get; set; }
        public string qualifications { get; set; }
    }

    public class manageDoctors
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        public int GetSpecializationId(string selectedSpecialization)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT id FROM tblSpecialization WHERE specialization = @specialization";
                    cmd.Parameters.AddWithValue("@specialization", selectedSpecialization);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions here
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            // Return a default value (e.g., -1) or throw an exception if the position is not found.
            return -1; // You can choose an appropriate default value.
        }

        public void AddDoctor(Doctor Doctor)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblDoctors (first_name, last_name, address, id_type, id_no, specialization_id, dob, gender, email, mobile, home, schedule, qualifications) VALUES (@first_name, @last_name, @address, @id_type, @id_no, @specialization_id, @dob, @gender, @email, @mobile, @home, @schedule, @qualifications)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@first_name", Doctor.first_name);
                    cmd.Parameters.AddWithValue("@last_name", Doctor.last_name);
                    cmd.Parameters.AddWithValue("@address", Doctor.address);
                    cmd.Parameters.AddWithValue("@id_type", Doctor.id_type);
                    cmd.Parameters.AddWithValue("@id_no", Doctor.id_no);
                    cmd.Parameters.AddWithValue("@specialization_id", Doctor.spec_id);
                    cmd.Parameters.AddWithValue("@dob", Doctor.dob);
                    cmd.Parameters.AddWithValue("@gender", Doctor.gender);
                    cmd.Parameters.AddWithValue("@email", Doctor.email);
                    cmd.Parameters.AddWithValue("@mobile", Doctor.mobile);
                    cmd.Parameters.AddWithValue("@home", Doctor.home);
                    cmd.Parameters.AddWithValue("@schedule", Doctor.schedule);
                    cmd.Parameters.AddWithValue("@qualifications", Doctor.qualifications);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Doctor has been saved successfully");
                }
            }
        }

        // all doctors
        public void LoadDoctors(DataGridView dgvDoctors)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT tblDoctors.id,tblDoctors.first_name,tblDoctors.last_name,tblDoctors.address,tblDoctors.id_type,tblDoctors.id_no,tblDoctors.dob,tblDoctors.gender,tblDoctors.email,tblDoctors.mobile,tblDoctors.home,tblSpecialization.specialization,tblDoctors.schedule,tblDoctors.qualifications FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id", con))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tblDoctors");

                        foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                        {
                            Doctor Doctor = new Doctor
                            {
                                first_name = row["first_name"].ToString(),
                                last_name = row["last_name"].ToString(),
                                address = row["address"].ToString(),
                                id_type = row["id_type"].ToString(),
                                id_no = row["id_no"].ToString(),
                                spec = row["specialization"].ToString(),
                                dob = row["dob"].ToString(),
                                gender = row["gender"].ToString(),
                                email = row["email"].ToString(),
                                mobile = row["mobile"].ToString(),
                                home = row["home"].ToString(),
                                id = Convert.ToInt32(row["id"].ToString()),
                                schedule = row["schedule"].ToString(),
                                qualifications = row["qualifications"].ToString()
                            };

                            string fullName = Doctor.first_name + " " + Doctor.last_name;
                            dgvDoctors.Rows.Add(fullName, Doctor.address, Doctor.id_type, Doctor.id_no, Doctor.spec, Doctor.dob, Doctor.gender, Doctor.email, Doctor.mobile, Doctor.home, Doctor.id, Doctor.schedule, Doctor.qualifications);
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
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT tblDoctors.id,tblDoctors.first_name,tblDoctors.last_name,tblDoctors.address,tblDoctors.id_type,tblDoctors.id_no,tblDoctors.dob,tblDoctors.gender,tblDoctors.email,tblDoctors.mobile,tblDoctors.home,tblSpecialization.specialization,tblDoctors.schedule,tblDoctors.qualifications FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id WHERE tblDoctors.first_name + ' ' + tblDoctors.last_name LIKE @SearchText", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblDoctors");

                    // Clear the list box before adding search results
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();

                    foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                    {
                        Doctor Doctor = new Doctor
                        {
                            first_name = row["first_name"].ToString(),
                            last_name = row["last_name"].ToString(),
                            address = row["address"].ToString(),
                            id_type = row["id_type"].ToString(),
                            id_no = row["id_no"].ToString(),
                            spec = row["specialization"].ToString(),
                            dob = row["dob"].ToString(),
                            gender = row["gender"].ToString(),
                            email = row["email"].ToString(),
                            mobile = row["mobile"].ToString(),
                            home = row["home"].ToString(),
                            id = Convert.ToInt32(row["id"].ToString()),
                            schedule = row["schedule"].ToString(),
                            qualifications = row["qualifications"].ToString()
                        };

                        string fullName = Doctor.first_name + " " + Doctor.last_name;
                        dgvDoctors.Rows.Add(fullName, Doctor.address, Doctor.id_type, Doctor.id_no, Doctor.spec, Doctor.dob, Doctor.gender, Doctor.email, Doctor.mobile, Doctor.home, Doctor.id, Doctor.schedule, Doctor.qualifications);
                    }

                    ds.Tables["tblDoctors"].Clear();
                }
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
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT tblDoctors.id, tblDoctors.first_name, tblDoctors.last_name, tblDoctors.address, tblDoctors.id_type, tblDoctors.id_no, tblDoctors.dob, tblDoctors.gender, tblDoctors.email, tblDoctors.mobile, tblDoctors.home, tblSpecialization.specialization,tblDoctors.schedule,tblDoctors.qualifications FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id = tblSpecialization.id WHERE tblSpecialization.specialization = @specialization", con);
                    da.SelectCommand.Parameters.AddWithValue("@specialization", specialization);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblDoctors");

                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();

                    foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                    {
                        Doctor Doctor = new Doctor
                        {
                            first_name = row["first_name"].ToString(),
                            last_name = row["last_name"].ToString(),
                            address = row["address"].ToString(),
                            id_type = row["id_type"].ToString(),
                            id_no = row["id_no"].ToString(),
                            spec = row["specialization"].ToString(),
                            dob = row["dob"].ToString(),
                            gender = row["gender"].ToString(),
                            email = row["email"].ToString(),
                            mobile = row["mobile"].ToString(),
                            home = row["home"].ToString(),
                            id = Convert.ToInt32(row["id"].ToString()),
                            schedule = row["schedule"].ToString(),
                            qualifications = row["qualifications"].ToString()
                        };

                        string fullName = Doctor.first_name + " " + Doctor.last_name;
                        dgvDoctors.Rows.Add(fullName, Doctor.address, Doctor.id_type, Doctor.id_no, Doctor.spec, Doctor.dob, Doctor.gender, Doctor.email, Doctor.mobile, Doctor.home, Doctor.id, Doctor.schedule, Doctor.qualifications);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //search doctor by location
        public void LoadDoctorsByLocation(DataGridView dgvDoctors, string location)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT tblDoctors.id, tblDoctors.first_name, tblDoctors.last_name, tblDoctors.address, tblDoctors.id_type, tblDoctors.id_no, tblDoctors.dob, tblDoctors.gender, tblDoctors.email, tblDoctors.mobile, tblDoctors.home, tblSpecialization.specialization,tblDoctors.schedule,tblDoctors.qualifications FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id = tblSpecialization.id INNER JOIN tblDoctorSchedule ON tblDoctors.id = tblDoctorSchedule.doctor_id WHERE tblDoctorSchedule.room_no = @room_no", con);
                    da.SelectCommand.Parameters.AddWithValue("@room_no", location);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblDoctors");

                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();

                    foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                    {
                        Doctor Doctor = new Doctor
                        {
                            first_name = row["first_name"].ToString(),
                            last_name = row["last_name"].ToString(),
                            address = row["address"].ToString(),
                            id_type = row["id_type"].ToString(),
                            id_no = row["id_no"].ToString(),
                            spec = row["specialization"].ToString(),
                            dob = row["dob"].ToString(),
                            gender = row["gender"].ToString(),
                            email = row["email"].ToString(),
                            mobile = row["mobile"].ToString(),
                            home = row["home"].ToString(),
                            id = Convert.ToInt32(row["id"].ToString()),
                            schedule = row["schedule"].ToString(),
                            qualifications = row["qualifications"].ToString()
                        };

                        string fullName = Doctor.first_name + " " + Doctor.last_name;
                        dgvDoctors.Rows.Add(fullName, Doctor.address, Doctor.id_type, Doctor.id_no, Doctor.spec, Doctor.dob, Doctor.gender, Doctor.email, Doctor.mobile, Doctor.home, Doctor.id, Doctor.schedule, Doctor.qualifications);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //update doctors
        public void UpdateDoctorById(int id, Doctor updatedDoctor)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblDoctors SET first_name = @first_name, last_name = @last_name, address = @address, id_type = @id_type, id_no = @id_no, specialization_id = @specialization_id, dob = @dob, gender = @gender, email = @email, mobile = @mobile , home = @home, qualifications = @qualifications WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@first_name", updatedDoctor.first_name);
                    cmd.Parameters.AddWithValue("@last_name", updatedDoctor.last_name);
                    cmd.Parameters.AddWithValue("@address", updatedDoctor.address);
                    cmd.Parameters.AddWithValue("@id_type", updatedDoctor.id_type);
                    cmd.Parameters.AddWithValue("@id_no", updatedDoctor.id_no);
                    cmd.Parameters.AddWithValue("@specialization_id", updatedDoctor.spec_id);
                    cmd.Parameters.AddWithValue("@dob", updatedDoctor.dob);
                    cmd.Parameters.AddWithValue("@gender", updatedDoctor.gender);
                    cmd.Parameters.AddWithValue("@email", updatedDoctor.email);
                    cmd.Parameters.AddWithValue("@mobile", updatedDoctor.mobile);
                    cmd.Parameters.AddWithValue("@home", updatedDoctor.home);
                    cmd.Parameters.AddWithValue("@qualifications", updatedDoctor.qualifications);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Doctors's Details updated successfully");
                }
            }
        }

        //delete doctors
        public void DelteDoctor(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE tblDoctors WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Doctor has been removed Successfully");
                }
            }
        }

        //get doctor by date
        public void PopulateDoctorsByDay(DataGridView dgvDoctors, DateTimePicker dtpDate)
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

                        SqlDataAdapter daa = new SqlDataAdapter($"SELECT tblDoctors.id, tblDoctors.first_name, tblDoctors.last_name, tblDoctors.address, tblDoctors.id_type, tblDoctors.id_no, tblDoctors.dob, tblDoctors.gender, tblDoctors.email, tblDoctors.mobile, tblDoctors.home, tblSpecialization.specialization,tblDoctors.schedule,tblDoctors.qualifications FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id = tblSpecialization.id INNER JOIN tblDoctorSchedule ON tblDoctors.id = tblDoctorSchedule.doctor_id WHERE tblDoctors.id = '" + doctorId + "'", con);

                        DataSet dss = new DataSet();
                        daa.Fill(dss, "tblDoctors");

                        foreach (DataRow row in dss.Tables["tblDoctors"].Rows)
                        {
                            Doctor Doctor = new Doctor
                            {
                                first_name = row["first_name"].ToString(),
                                last_name = row["last_name"].ToString(),
                                address = row["address"].ToString(),
                                id_type = row["id_type"].ToString(),
                                id_no = row["id_no"].ToString(),
                                spec = row["specialization"].ToString(),
                                dob = row["dob"].ToString(),
                                gender = row["gender"].ToString(),
                                email = row["email"].ToString(),
                                mobile = row["mobile"].ToString(),
                                home = row["home"].ToString(),
                                id = Convert.ToInt32(row["id"].ToString()),
                                schedule = row["schedule"].ToString(),
                                qualifications = row["qualifications"].ToString()
                            };

                            string fullName = Doctor.first_name + " " + Doctor.last_name;
                            dgvDoctors.Rows.Add(fullName, Doctor.address, Doctor.id_type, Doctor.id_no, Doctor.spec, Doctor.dob, Doctor.gender, Doctor.email, Doctor.mobile, Doctor.home, Doctor.id, Doctor.schedule, Doctor.qualifications);
                        }
                        dss.Tables["tblDoctors"].Clear();
                    }
                    currentRow++;
                }
                ds.Tables["tblDoctorByDay"].Clear();
            }
        }

        // all doctors for schedule
        public void LoadDoctors4Schedule(DataGridView dgvDoctors)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT tblDoctors.id,tblDoctors.first_name,tblDoctors.last_name,tblSpecialization.specialization FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id WHERE tblDoctors.schedule='"+"False"+"'", con))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tblDoctors");

                        foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                        {
                            Doctor Doctor = new Doctor
                            {
                                first_name = row["first_name"].ToString(),
                                last_name = row["last_name"].ToString(),
                                spec = row["specialization"].ToString(),
                                id = Convert.ToInt32(row["id"].ToString()),
                            };

                            string fullName = Doctor.first_name + " " + Doctor.last_name;
                            dgvDoctors.Rows.Add(fullName, Doctor.spec, Doctor.id);
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

        //search doctors for make schedules
        public void SearchDoctors4Schedule(DataGridView dgvDoctors, string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT tblDoctors.id,tblDoctors.first_name,tblDoctors.last_name,tblSpecialization.specialization FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id=tblSpecialization.id WHERE tblDoctors.first_name + ' ' + tblDoctors.last_name LIKE @SearchText AND schedule = '"+"False"+"'", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblDoctors");

                    // Clear the list box before adding search results
                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();

                    foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                    {
                        Doctor Doctor = new Doctor
                        {
                            first_name = row["first_name"].ToString(),
                            last_name = row["last_name"].ToString(),
                            spec = row["specialization"].ToString(),
                            id = Convert.ToInt32(row["id"].ToString()),
                        };

                        string fullName = Doctor.first_name + " " + Doctor.last_name;
                        dgvDoctors.Rows.Add(fullName, Doctor.spec, Doctor.id);
                    }

                    ds.Tables["tblDoctors"].Clear();
                }
            }
        }

        //search doctor by specialization for make schedule
        public void DoctorsBySpec4schedule(DataGridView dgvDoctors, string specialization)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT tblDoctors.id, tblDoctors.first_name, tblDoctors.last_name, tblSpecialization.specialization FROM tblDoctors INNER JOIN tblSpecialization ON tblDoctors.specialization_id = tblSpecialization.id WHERE tblSpecialization.specialization = @specialization AND tblDoctors.schedule = '"+"False"+"'", con);
                    da.SelectCommand.Parameters.AddWithValue("@specialization", specialization);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblDoctors");

                    dgvDoctors.Rows.Clear();
                    dgvDoctors.Refresh();

                    foreach (DataRow row in ds.Tables["tblDoctors"].Rows)
                    {
                        Doctor Doctor = new Doctor
                        {
                            first_name = row["first_name"].ToString(),
                            last_name = row["last_name"].ToString(),
                            spec = row["specialization"].ToString(),
                            id = Convert.ToInt32(row["id"].ToString()),  
                        };

                        string fullName = Doctor.first_name + " " + Doctor.last_name;
                        dgvDoctors.Rows.Add(fullName, Doctor.spec, Doctor.id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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
