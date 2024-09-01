using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Health_Care_Plus_00174336.Classes
{
    public class OperationTheater
    {
        public int id { get; set; }
        public string number { get; set; }
        public string date_from { get; set; }
        public string status { get; set; }
        public int patient_id { get; set; }
        public string procedures { get; set; }
        public string type { get; set; }
    }

    public class manageOperationTheaters
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        //load theaters
        public void LoadOperationTheaters(DataGridView dgvOperationTheaters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblOperationTheaters", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblOperationTheaters");
                    dgvOperationTheaters.Rows.Clear();
                    dgvOperationTheaters.Refresh();
                    int currentRow = 0;

                    foreach (DataRow row in ds.Tables["tblOperationTheaters"].Rows)
                    {
                        string number = row["number"].ToString();
                        string date_from = row["date_from"].ToString();
                        string status = row["status"].ToString();
                        string procedures = row["procedures"].ToString();
                        string type = row["type"].ToString();

                        if (status == "Not Available")
                        {
                            dgvOperationTheaters.Rows.Add(number, date_from, status, procedures, type);
                            dgvOperationTheaters.Rows[currentRow].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            dgvOperationTheaters.Rows.Add(number, date_from, status, procedures, type);
                        }
                        currentRow++;
                    }

                    ds.Tables["tblOperationTheaters"].Clear();
                }
            }
        }

        //add to operation theater
        public void addToOperationTheater(string number, OperationTheater OperationTheater)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblOperationTheaters SET date_from = @date_from, status = @status, patient_id = @patient_id, procedures = @procedures WHERE number = @number";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@number", number);
                    cmd.Parameters.AddWithValue("@date_from", OperationTheater.date_from);
                    cmd.Parameters.AddWithValue("@status", OperationTheater.status);
                    cmd.Parameters.AddWithValue("@patient_id", OperationTheater.patient_id);
                    cmd.Parameters.AddWithValue("@procedures", OperationTheater.procedures);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        //reset operation theater
        public void ResetOperationTheater(string number, OperationTheater OperationTheater)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblOperationTheaters SET date_from = @date_from, status = @status, patient_id = @patient_id, procedures = @procedures WHERE number = @number";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@number", number);
                    cmd.Parameters.AddWithValue("@date_from", OperationTheater.date_from);
                    cmd.Parameters.AddWithValue("@status", OperationTheater.status);
                    cmd.Parameters.AddWithValue("@patient_id", OperationTheater.patient_id);
                    cmd.Parameters.AddWithValue("@procedures", OperationTheater.procedures);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Operation theater Reset is successful");
                }
            }
        }

        //discharge patient from operation theater
        public void DischargeFromOperationTheater(string number, OperationTheater OperationTheater)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblOperationTheaters SET date_from = @date_from, status = @status, patient_id = @patient_id, procedures = @procedures WHERE number = @number";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@number", number);
                    cmd.Parameters.AddWithValue("@date_from", OperationTheater.date_from);
                    cmd.Parameters.AddWithValue("@status", OperationTheater.status);
                    cmd.Parameters.AddWithValue("@patient_id", OperationTheater.patient_id);
                    cmd.Parameters.AddWithValue("@procedures", OperationTheater.procedures);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Patient discharged successfully");
                }
            }
        }
    }
}
