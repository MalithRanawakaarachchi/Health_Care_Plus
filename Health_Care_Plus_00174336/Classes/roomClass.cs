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
    public class Room
    {
        public int id { get; set; }
        public int room_no { get; set; }
        public string date_from { get; set; }
        public string status { get; set; }
        public int patient_id { get; set; }
        public string procedures { get; set; }
    }

    public class manageRooms
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        //load Rooms
        public void LoadRooms(DataGridView dgvRooms)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblRooms", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblRooms");
                    dgvRooms.Rows.Clear();
                    dgvRooms.Refresh();
                    int currentRow = 0;

                    foreach (DataRow row in ds.Tables["tblRooms"].Rows)
                    {
                        int room_no = Convert.ToInt32(row["room_no"]);
                        string status = row["status"].ToString();

                        if (status == "Not Available")
                        {
                            dgvRooms.Rows.Add(room_no, status);
                            dgvRooms.Rows[currentRow].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            dgvRooms.Rows.Add(room_no, status);
                        }
                        currentRow++;
                    }

                    ds.Tables["tblRooms"].Clear();
                }
            }
        }

        //Load rooms for edit
        public void LoadRoomsFroEdit(DataGridView dgvRooms)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblRooms", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblRooms");
                    dgvRooms.Rows.Clear();
                    dgvRooms.Refresh();
                    int currentRow = 0;

                    foreach (DataRow row in ds.Tables["tblRooms"].Rows)
                    {
                        int room_no = Convert.ToInt32(row["room_no"]);
                        string date_from = row["date_from"].ToString();
                        string status = row["status"].ToString();
                        string procedures = row["procedures"].ToString();

                        if (status == "Not Available")
                        {
                            dgvRooms.Rows.Add(room_no, date_from, status, procedures);
                            dgvRooms.Rows[currentRow].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            dgvRooms.Rows.Add(room_no, date_from, status, procedures);
                        }
                        currentRow++;
                    }

                    ds.Tables["tblRooms"].Clear();
                }
            }
        }

        //add to room
        public void addToRoom(int room_no, Room Room)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblRooms SET date_from = @date_from, status = @status, patient_id = @patient_id, procedures = @procedures WHERE room_no = @room_no";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@room_no", room_no);
                    cmd.Parameters.AddWithValue("@date_from", Room.date_from);
                    cmd.Parameters.AddWithValue("@status", Room.status);
                    cmd.Parameters.AddWithValue("@patient_id", Room.patient_id);
                    cmd.Parameters.AddWithValue("@procedures", Room.procedures);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        //reset to room
        public void ResetRoom(int room_no, Room Room)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblRooms SET date_from = @date_from, status = @status, patient_id = @patient_id, procedures = @procedures WHERE room_no = @room_no";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@room_no", room_no);
                    cmd.Parameters.AddWithValue("@date_from", Room.date_from);
                    cmd.Parameters.AddWithValue("@status", Room.status);
                    cmd.Parameters.AddWithValue("@patient_id", Room.patient_id);
                    cmd.Parameters.AddWithValue("@procedures", Room.procedures);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Room Reset is successful");
                }
            }
        }

        //discharge patient from room
        public void DischargeFromRoom(int room_no, Room Room)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblRooms SET date_from = @date_from, status = @status, patient_id = @patient_id, procedures = @procedures WHERE room_no = @room_no";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@room_no", room_no);
                    cmd.Parameters.AddWithValue("@date_from", Room.date_from);
                    cmd.Parameters.AddWithValue("@status", Room.status);
                    cmd.Parameters.AddWithValue("@patient_id", Room.patient_id);
                    cmd.Parameters.AddWithValue("@procedures", Room.procedures);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Patient discharged successfully");
                }
            }
        }
    }
}
