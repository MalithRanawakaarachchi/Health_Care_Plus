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
    public class Scanners
    {
        public int id { get; set; }
        public string stock_date { get; set; }
        public string name { get; set; }
        public int value { get; set; }
    }

    public class manageScanners
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        public void AddScanners(Scanners Scanners)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblScanners (stock_date, name, value) VALUES (@stock_date, @name, @value)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@stock_date", Scanners.stock_date);
                    cmd.Parameters.AddWithValue("@name", Scanners.name);
                    cmd.Parameters.AddWithValue("@value", Scanners.value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Scanner has been saved successfully");
                }
            }
        }

        // all scanner
        public void LoadScanners(DataGridView dgvScanners)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblScanners", con))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tblScanners");

                        foreach (DataRow row in ds.Tables["tblScanners"].Rows)
                        {
                            Scanners Scanners = new Scanners
                            {
                                id = Convert.ToInt32(row["id"]),
                                stock_date = row["stock_date"].ToString(),
                                name = row["name"].ToString(),
                                value = Convert.ToInt32(row["value"].ToString()),
                            };

                            dgvScanners.Rows.Add(Scanners.id, Scanners.stock_date, Scanners.name, Scanners.value);
                        }

                        ds.Tables["tblScanners"].Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Scanner: " + ex.Message);
                }
            }
        }

        // get scanners from dgvScanners
        public Scanners GetScannersFromdgv(DataGridViewRow selectedRow)
        {
            if (selectedRow == null)
            {
                return null; // No row selected, return null
            }

            Scanners Scanners = new Scanners
            {
                id = Convert.ToInt32(selectedRow.Cells[0].Value), // Assuming the first cell contains the scanner ID
                stock_date = selectedRow.Cells[1].Value.ToString(),
                name = selectedRow.Cells[2].Value.ToString(),
                value = Convert.ToInt32(selectedRow.Cells[3].Value.ToString()),

            };

            return Scanners;
        }

        //update Scanners
        public void UpdateScannersById(int id, Scanners updatedScanners)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblScanners SET stock_date = @stock_date, name = @name, value = @value WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@stock_date", updatedScanners.stock_date);
                    cmd.Parameters.AddWithValue("@name", updatedScanners.name);
                    cmd.Parameters.AddWithValue("@value", updatedScanners.value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Scanner updated successfully");
                }
            }
        }

        //delete Scanners
        public void DelteScanner(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE tblScanners WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Scanner has been removed Successfully");
                }
            }
        }
    }
}
