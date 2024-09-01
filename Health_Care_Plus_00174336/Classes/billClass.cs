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
    public class Bill
    {
        // Fields
        public string date_from { get; set; }
        public string date { get; set; }
        public int patient_id { get; set; }
        public string type { get; set; }
        public string amount { get; set; }
        public string status { get; set; }
        public string room_id { get; set; }
        public decimal medi_amount { get; set; }
    }
        
    public class ManageBills
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;Persist Security Info=True;User ID=sa;Password=123";

        //add room bill
        public void addRoomBill(Bill Bill)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblBills (date_from, date, patient_id, type, amount, status, room_id) VALUES (@date_from, @date, @patient_id, @type, @amount, @status, @room_id)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@date_from", Bill.date_from);
                    cmd.Parameters.AddWithValue("@date", Bill.date);
                    cmd.Parameters.AddWithValue("@patient_id", Bill.patient_id);
                    cmd.Parameters.AddWithValue("@type", "room charge");
                    cmd.Parameters.AddWithValue("@amount", 3280);
                    cmd.Parameters.AddWithValue("@status", "pending");
                    cmd.Parameters.AddWithValue("@room_id", Bill.room_id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        //add operation bill
        public void addOperationBill(Bill Bill)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblBills (date_from, date, patient_id, type, amount, status, room_id) VALUES (@date_from, @date, @patient_id, @type, @amount, @status, @room_id)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@date_from", Bill.date_from);
                    cmd.Parameters.AddWithValue("@date", Bill.date);
                    cmd.Parameters.AddWithValue("@patient_id", Bill.patient_id);
                    cmd.Parameters.AddWithValue("@type", "operation charge");
                    cmd.Parameters.AddWithValue("@amount", Bill.amount);
                    cmd.Parameters.AddWithValue("@status", "pending");
                    cmd.Parameters.AddWithValue("@room_id", Bill.room_id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        //add medi bill
        public void addMediBill(Bill Bill)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblBills (date, patient_id, type, amount, status) VALUES (@date, @patient_id, @type, @amount, @status)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@date", DateTime.Today.ToShortDateString());
                    cmd.Parameters.AddWithValue("@patient_id", Bill.patient_id);
                    cmd.Parameters.AddWithValue("@type", "medication");
                    cmd.Parameters.AddWithValue("@amount", Bill.medi_amount);
                    cmd.Parameters.AddWithValue("@status", "pending");

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        //add appointment bill
        public void addAppointmentBill(Bill Bill)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblBills (date, patient_id, type, amount, status) VALUES (@date, @patient_id, @type, @amount, @status)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@date", DateTime.Today.ToShortDateString());
                    cmd.Parameters.AddWithValue("@patient_id", Bill.patient_id);
                    cmd.Parameters.AddWithValue("@type", "appointment");
                    cmd.Parameters.AddWithValue("@amount", 1200);
                    cmd.Parameters.AddWithValue("@status", "pending");

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}

