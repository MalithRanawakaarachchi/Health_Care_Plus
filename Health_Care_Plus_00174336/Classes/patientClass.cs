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
    
    public class Patient
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string id_type { get; set; }
        public string id_no { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string home { get; set; }
        public string office { get; set; }
    }

    public class managePatients
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        public void AddPatient(Patient Patient)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblPatients (first_name, last_name, address, id_type, id_no, dob, gender, email, mobile, home, office) VALUES (@first_name, @last_name, @address, @id_type, @id_no, @dob, @gender, @email, @mobile, @home, @office)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@first_name", Patient.first_name);
                    cmd.Parameters.AddWithValue("@last_name", Patient.last_name);
                    cmd.Parameters.AddWithValue("@address", Patient.address);
                    cmd.Parameters.AddWithValue("@id_type", Patient.id_type);
                    cmd.Parameters.AddWithValue("@id_no", Patient.id_no);
                    cmd.Parameters.AddWithValue("@dob", Patient.dob);
                    cmd.Parameters.AddWithValue("@gender", Patient.gender);
                    cmd.Parameters.AddWithValue("@email", Patient.email);
                    cmd.Parameters.AddWithValue("@mobile", Patient.mobile);
                    cmd.Parameters.AddWithValue("@home", Patient.home);
                    cmd.Parameters.AddWithValue("@office", Patient.office);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Patient has been saved successfully");
                }
            }
        }

        // all patients
        public void LoadPatients(ListBox listBox)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblPatients", con))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tblPatients");

                        foreach (DataRow row in ds.Tables["tblPatients"].Rows)
                        {
                            string fname = row["first_name"].ToString();
                            string lname = row["last_name"].ToString();
                            string fullname = fname + " " + lname;
                            listBox.Items.Add(fullname);
                        }

                        ds.Tables["tblPatients"].Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patients: " + ex.Message);
                }
            }
        }

        //search patient
        public void SearchPatients(ListBox listBox, string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblPatients WHERE first_name + ' ' + last_name LIKE @SearchText", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblPatients");

                    // Clear the list box before adding search results
                    listBox.Items.Clear();

                    foreach (DataRow row in ds.Tables["tblPatients"].Rows)
                    {
                        string fname = row["first_name"].ToString();
                        string lname = row["last_name"].ToString();
                        string fullname = fname + " " + lname;
                        listBox.Items.Add(fullname);
                    }

                    ds.Tables["tblPatients"].Clear();
                }
            }
        }

        // get patients by listbox name
        public Patient GetPatientByName(string selectedName)
        {
            string[] nameParts = selectedName.Split(' '); // Split the selected name into first_name and last_name parts

            string firstName = nameParts[0]; // Extract the first_name part
            string lastName = nameParts[1]; // Extract the last_name part

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblPatients WHERE first_name = @firstName AND last_name = @lastName", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@firstName", firstName);
                    da.SelectCommand.Parameters.AddWithValue("@lastName", lastName);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblPatients");

                    if (ds.Tables["tblPatients"].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables["tblPatients"].Rows[0];
                        Patient patient = new Patient
                        {
                            id = Convert.ToInt32(row["id"]),
                            first_name = row["first_name"].ToString(),
                            last_name = row["last_name"].ToString(),
                            address = row["address"].ToString(),
                            id_type = row["id_type"].ToString(),
                            id_no = row["id_no"].ToString(),
                            dob = row["dob"].ToString(),
                            gender = row["gender"].ToString(),
                            email = row["email"].ToString(),
                            mobile = row["mobile"].ToString(),
                            home = row["home"].ToString(),
                            office = row["office"].ToString()
                        };

                        return patient;
                    }
                    ds.Tables["tblPatients"].Clear();
                }
            }

            return null; // Patient not found
        }

        //update patients
        public void UpdatePatientById(int id, Patient updatedPatient)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblPatients SET first_name = @first_name, last_name = @last_name, address = @address, id_type = @id_type, id_no = @id_no, dob = @dob, gender = @gender, email = @email, mobile = @mobile , home = @home, office = @office WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@first_name", updatedPatient.first_name);
                    cmd.Parameters.AddWithValue("@last_name", updatedPatient.last_name);
                    cmd.Parameters.AddWithValue("@address", updatedPatient.address);
                    cmd.Parameters.AddWithValue("@id_type", updatedPatient.id_type);
                    cmd.Parameters.AddWithValue("@id_no", updatedPatient.id_no);
                    cmd.Parameters.AddWithValue("@dob", updatedPatient.dob);
                    cmd.Parameters.AddWithValue("@gender", updatedPatient.gender);
                    cmd.Parameters.AddWithValue("@email", updatedPatient.email);
                    cmd.Parameters.AddWithValue("@mobile", updatedPatient.mobile);
                    cmd.Parameters.AddWithValue("@home", updatedPatient.home);
                    cmd.Parameters.AddWithValue("@office", updatedPatient.office);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Patients's Details updated successfully");
                }
            }
        }

        //delete patient
        public void DeltePatient(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE tblPatients WHERE id = @PatientId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PatientId", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Patient has been removed Successfully");
                }
            }
        }
    }
}
