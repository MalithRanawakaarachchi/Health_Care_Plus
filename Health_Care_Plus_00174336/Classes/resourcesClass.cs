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
    public class Resources
    {
        public int id { get; set; }
        public string stock_date { get; set; }
        public string type { get; set; }
        public int value { get; set; }
        public string exp_date { get; set; }
    }

    public class manageResources
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        public void AddResources(Resources Recources)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblResources (stock_date, type, value, exp_date) VALUES (@stock_date, @type, @value, @exp_date)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@stock_date", Recources.stock_date);
                    cmd.Parameters.AddWithValue("@type", Recources.type);
                    cmd.Parameters.AddWithValue("@value", Recources.value);
                    cmd.Parameters.AddWithValue("@exp_date", Recources.exp_date);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Item has been saved successfully");
                }
            }
        }

        // all resources
        public void LoadResources(DataGridView dgvResources)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblResources", con))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tblResources");

                        foreach (DataRow row in ds.Tables["tblResources"].Rows)
                        {
                            Resources resources = new Resources
                            {
                                id = Convert.ToInt32(row["id"]),
                                stock_date = row["stock_date"].ToString(),
                                type = row["type"].ToString(),
                                value = Convert.ToInt32(row["value"].ToString()),
                                exp_date = row["exp_date"].ToString()  
                            };

                            dgvResources.Rows.Add(resources.id, resources.stock_date, resources.type, resources.value, resources.exp_date);
                        }

                        ds.Tables["tblResources"].Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Resource: " + ex.Message);
                }
            }
        }

        // get resources from dgvResources
        public Resources GetResourcesFromdgv(DataGridViewRow selectedRow)
        {
            if (selectedRow == null)
            {
                return null; // No row selected, return null
            }

            Resources resources = new Resources
            {
                id = Convert.ToInt32(selectedRow.Cells[0].Value), // Assuming the first cell contains the resource ID
                stock_date = selectedRow.Cells[1].Value.ToString(),
                type = selectedRow.Cells[2].Value.ToString(),
                value = Convert.ToInt32(selectedRow.Cells[3].Value.ToString()),
                exp_date = selectedRow.Cells[4].Value.ToString()
            };

            return resources;
        }

        //update resources
        public void UpdateResourcesById(int id, Resources updatedRes)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblResources SET stock_date = @stock_date, type = @type, value = @value, exp_date = @exp_date WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@stock_date", updatedRes.stock_date);
                    cmd.Parameters.AddWithValue("@type", updatedRes.type);
                    cmd.Parameters.AddWithValue("@value", updatedRes.value);
                    cmd.Parameters.AddWithValue("@exp_date", updatedRes.exp_date);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Item updated successfully");
                }
            }
        }

        //delete resources
        public void DelteItemt(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE tblResources WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Item has been removed Successfully");
                }
            }
        }
    }
}
