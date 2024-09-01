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
    public class EMR
    {
        public int id { get; set; }
        public int patient_id { get; set; }
        public string weight { get; set; }
        public string height { get; set; }
        public string blood_category { get; set; }
        public string blood_sugar { get; set; }
        public string blood_pressure { get; set; }
        public string heart_rate { get; set; }
        public string temperature { get; set; }
        public string BMI { get; set; }
        public string diagnosis { get; set; }
        public string prescription { get; set; }
        public string blood_tests { get; set; }
        public string radiology_reports { get; set; }
        public string pathology_reports { get; set; }
        public string surgery_and_operation_reports { get; set; }
        public string date { get; set; }
    }

    public class manageEMRs
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        public void AddEMRs(EMR emr)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblEMRs (patient_id, weight, height, blood_category, blood_sugar, blood_pressure, heart_rate, temperature, BMI, diagnosis, prescription, blood_tests, radiology_reports, pathology_reports, surgery_and_operation_reports, date) VALUES (@patient_id, @weight, @height, @blood_category, @blood_sugar, @blood_pressure, @heart_rate, @temperature, @BMI, @diagnosis, @prescription, @blood_tests, @radiology_reports, @pathology_reports, @surgery_and_operation_reports, @date)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@patient_id", emr.patient_id);
                    cmd.Parameters.AddWithValue("@weight", emr.weight);
                    cmd.Parameters.AddWithValue("@height", emr.height);
                    cmd.Parameters.AddWithValue("@blood_category", emr.blood_category);
                    cmd.Parameters.AddWithValue("@blood_sugar", emr.blood_sugar);
                    cmd.Parameters.AddWithValue("@blood_pressure", emr.blood_pressure);
                    cmd.Parameters.AddWithValue("@heart_rate", emr.heart_rate);
                    cmd.Parameters.AddWithValue("@temperature", emr.temperature);
                    cmd.Parameters.AddWithValue("@BMI", emr.BMI);
                    cmd.Parameters.AddWithValue("@diagnosis", emr.diagnosis);
                    cmd.Parameters.AddWithValue("@prescription", emr.prescription);
                    cmd.Parameters.AddWithValue("@blood_tests", emr.blood_tests);
                    cmd.Parameters.AddWithValue("@radiology_reports", emr.radiology_reports);
                    cmd.Parameters.AddWithValue("@pathology_reports", emr.pathology_reports);
                    cmd.Parameters.AddWithValue("@surgery_and_operation_reports", emr.surgery_and_operation_reports);
                    cmd.Parameters.AddWithValue("@date", emr.date);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("EMR has been saved successfully");
                }
            }
        }

        // get emrs by listbox name
        public EMR GetEMRsByName(DataGridView dgvEMRs, string selectedName )
        {
            string[] nameParts = selectedName.Split(' '); // Split the selected name into first_name and last_name parts

            string firstName = nameParts[0]; // Extract the first_name part
            string lastName = nameParts[1]; // Extract the last_name part

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT tblEMRs.id,tblEMRs.patient_id,tblEMRs.weight,tblEMRs.height,tblEMRs.blood_category,tblEMRs.blood_sugar,tblEMRs.blood_pressure,tblEMRs.heart_rate,tblEMRs.temperature,tblEMRs.BMI,tblEMRs.diagnosis,tblEMRs.prescription,tblEMRs.blood_tests,tblEMRs.radiology_reports,tblEMRs.pathology_reports,tblEMRs.surgery_and_operation_reports,tblEMRs.date FROM tblEMRs INNER JOIN tblPatients ON tblEMRs.patient_id = tblPatients.id  WHERE tblPatients.first_name = @firstName AND tblPatients.last_name = @lastName", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@firstName", firstName);
                    da.SelectCommand.Parameters.AddWithValue("@lastName", lastName);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblEMRs");
                    dgvEMRs.Rows.Clear();
                    dgvEMRs.Refresh();

                    if (ds.Tables["tblEMRs"].Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables["tblEMRs"].Rows)
                        {
                            EMR emr = new EMR
                            {
                                id = Convert.ToInt32(row["id"]),
                                date = row["date"].ToString(),
                                patient_id = Convert.ToInt32(row["patient_id"]),
                                weight = row["weight"].ToString(),
                                height = row["height"].ToString(),
                                blood_category = row["blood_category"].ToString(),
                                blood_sugar = row["blood_sugar"].ToString(),
                                blood_pressure = row["blood_pressure"].ToString(),
                                heart_rate = row["heart_rate"].ToString(),
                                temperature = row["temperature"].ToString(),
                                BMI = row["BMI"].ToString(),
                                diagnosis = row["diagnosis"].ToString(),
                                prescription = row["prescription"].ToString(),
                                blood_tests = row["blood_tests"].ToString(),
                                radiology_reports = row["radiology_reports"].ToString(),
                                pathology_reports = row["pathology_reports"].ToString(),
                                surgery_and_operation_reports = row["surgery_and_operation_reports"].ToString()

                            };

                            dgvEMRs.Rows.Add(emr.id, emr.date, emr.patient_id, emr.weight, emr.height, emr.blood_category, emr.blood_sugar, emr.blood_pressure,
                                emr.heart_rate, emr.temperature, emr.BMI, emr.diagnosis, emr.prescription, emr.blood_tests,
                                emr.radiology_reports, emr.pathology_reports, emr.surgery_and_operation_reports);
                        }
                    }
                    ds.Tables["tblEMRs"].Clear();
                }
            }

            return null; // Employee not found
        }

        //update EMRs
        public void UpdateEMRById(int id, EMR emr)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblEMRs SET weight = @weight, height = @height, blood_category = @blood_category, blood_sugar = @blood_sugar, blood_pressure = @blood_pressure, heart_rate = @heart_rate, temperature = @temperature, BMI = @BMI, diagnosis = @diagnosis , prescription = @prescription, blood_tests = @blood_tests, radiology_reports = @radiology_reports, pathology_reports = @pathology_reports, surgery_and_operation_reports = @surgery_and_operation_reports WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@weight", emr.weight);
                    cmd.Parameters.AddWithValue("@height", emr.height);
                    cmd.Parameters.AddWithValue("@blood_category", emr.blood_category);
                    cmd.Parameters.AddWithValue("@blood_sugar", emr.blood_sugar);
                    cmd.Parameters.AddWithValue("@blood_pressure", emr.blood_pressure);
                    cmd.Parameters.AddWithValue("@heart_rate", emr.heart_rate);
                    cmd.Parameters.AddWithValue("@temperature", emr.temperature);
                    cmd.Parameters.AddWithValue("@BMI", emr.BMI);
                    cmd.Parameters.AddWithValue("@diagnosis", emr.diagnosis);
                    cmd.Parameters.AddWithValue("@prescription", emr.prescription);
                    cmd.Parameters.AddWithValue("@blood_tests", emr.blood_tests);
                    cmd.Parameters.AddWithValue("@radiology_reports", emr.radiology_reports);
                    cmd.Parameters.AddWithValue("@pathology_reports", emr.pathology_reports);
                    cmd.Parameters.AddWithValue("@surgery_and_operation_reports", emr.surgery_and_operation_reports);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("EMRs's Details updated successfully");
                }
            }
        }

        //delete EMRs
        public void DelteEMR(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE tblEMRs WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("EMR has been removed Successfully");
                }
            }
        }
    }
}
