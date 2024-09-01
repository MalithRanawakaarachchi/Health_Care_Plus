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
    public class Medication
    {
        public int id { get; set; }
        public string stock_from { get; set; }
        public string exp { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string dosage { get; set; }
        public string frequency { get; set; }
        public string allegies { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
    }

    public class manageMedications
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        public void AddMedication(Medication Medication)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblMedications (stock_from, exp, name, type, dosage, frequency, allegies, qty, price) VALUES (@stock_from, @exp, @name, @type, @dosage, @frequency, @allegies, @qty, @price)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@stock_from", Medication.stock_from);
                    cmd.Parameters.AddWithValue("@exp", Medication.exp);
                    cmd.Parameters.AddWithValue("@name", Medication.name);
                    cmd.Parameters.AddWithValue("@type", Medication.type);
                    cmd.Parameters.AddWithValue("@dosage", Medication.dosage);
                    cmd.Parameters.AddWithValue("@frequency", Medication.frequency);
                    cmd.Parameters.AddWithValue("@allegies", Medication.allegies);
                    cmd.Parameters.AddWithValue("@qty", Medication.qty);
                    cmd.Parameters.AddWithValue("@price", Medication.price);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Medication has been saved successfully");
                }
            }
        }

        public void LoadMedicationrs(DataGridView dgvMedications)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblMedications", con))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tblMedications");
                        dgvMedications.Rows.Clear();
                        dgvMedications.Refresh();

                        foreach (DataRow row in ds.Tables["tblMedications"].Rows)
                        {
                            Medication Medication = new Medication
                            {
                                id = Convert.ToInt32(row["id"]),
                                stock_from = row["stock_from"].ToString(),
                                exp = row["exp"].ToString(),
                                name = row["name"].ToString(),
                                type = row["type"].ToString(),
                                dosage = row["dosage"].ToString(),
                                frequency = row["frequency"].ToString(),
                                allegies = row["allegies"].ToString(),
                                qty = Convert.ToInt32(row["qty"]),
                                price = Convert.ToInt32(row["price"]),
                            };

                            dgvMedications.Rows.Add(Medication.id, Medication.stock_from, Medication.exp, Medication.name, Medication.type, Medication.dosage, Medication.frequency, Medication.allegies, Medication.qty, Medication.price);
                        }

                        ds.Tables["tblMedications"].Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Resource: " + ex.Message);
                }
            }
        }

        //search Medications
        public void SearchMedications(DataGridView dgvMedications, string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblMedications WHERE tblMedications.name LIKE @SearchText", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblMedications");

                    // Clear the list box before adding search results
                    dgvMedications.Rows.Clear();
                    dgvMedications.Refresh();

                    foreach (DataRow row in ds.Tables["tblMedications"].Rows)
                    {
                        Medication Medication = new Medication
                        {
                            id = Convert.ToInt32(row["id"]),
                            stock_from = row["stock_from"].ToString(),
                            exp = row["exp"].ToString(),
                            name = row["name"].ToString(),
                            type = row["type"].ToString(),
                            dosage = row["dosage"].ToString(),
                            frequency = row["frequency"].ToString(),
                            allegies = row["allegies"].ToString(),
                            qty = Convert.ToInt32(row["qty"]),
                            price = Convert.ToInt32(row["price"]),
                        };

                        dgvMedications.Rows.Add(Medication.id, Medication.stock_from, Medication.exp, Medication.name, Medication.type, Medication.dosage, Medication.frequency, Medication.allegies, Medication.qty, Medication.price);
                    }

                    ds.Tables["tblMedications"].Clear();
                }
            }
        }

        //update Medications
        public void UpdateMedicationsById(int id, Medication updatedMedications)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblMedications SET stock_from = @stock_from, exp = @exp, name = @name, type = @type, dosage = @dosage, frequency = @frequency, allegies = @allegies, qty = @qty, price = @price WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@stock_from", updatedMedications.stock_from);
                    cmd.Parameters.AddWithValue("@exp", updatedMedications.exp);
                    cmd.Parameters.AddWithValue("@name", updatedMedications.name);
                    cmd.Parameters.AddWithValue("@type", updatedMedications.type);
                    cmd.Parameters.AddWithValue("@dosage", updatedMedications.dosage);
                    cmd.Parameters.AddWithValue("@frequency", updatedMedications.frequency);
                    cmd.Parameters.AddWithValue("@allegies", updatedMedications.allegies);
                    cmd.Parameters.AddWithValue("@qty", updatedMedications.qty);
                    cmd.Parameters.AddWithValue("@price", updatedMedications.price);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Medication updated successfully");
                }
            }
        }

        //delete Medications
        public void DelteIMedication(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE tblMedications WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Medication has been removed Successfully");
                }
            }
        }
    }
}
