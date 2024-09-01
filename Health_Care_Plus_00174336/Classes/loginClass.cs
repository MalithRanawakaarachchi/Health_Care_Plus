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
    public class Login
    {
        string x = "no";
        public static string userType = "";
        public static string logingId = "";
        public static string logingName = "";
        public static bool loginSuccess = false;
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        public void LoginData(string Login, TextBox tbxUsername, TextBox tbxPassword)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = con;
                    con.Open();
                    SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblEmployees.email,tblEmployees.password,tblStaffPositions.position,tblEmployees.id,tblEmployees.first_name,tblEmployees.last_name FROM tblEmployees INNER JOIN tblStaffPositions ON tblEmployees.position_id = tblStaffPositions.id", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblLogin");
                    con.Close();
                    int currentRow = 0;
                    int rowcount = ds.Tables["tblLogin"].Rows.Count;

                    if (tbxUsername.Text == "" || tbxPassword.Text == "")
                    {
                        MessageBox.Show("Please type Username and Password");
                    }
                    else
                    {
                        while (currentRow < rowcount)
                        {
                            if (tbxUsername.Text == ds.Tables["tblLogin"].Rows[currentRow].ItemArray[0].ToString() && tbxPassword.Text == ds.Tables["tblLogin"].Rows[currentRow].ItemArray[1].ToString())
                            {
                                logingId = ds.Tables["tblLogin"].Rows[currentRow].ItemArray[3].ToString();
                                string fname = ds.Tables["tblLogin"].Rows[currentRow].ItemArray[4].ToString();
                                string lname = ds.Tables["tblLogin"].Rows[currentRow].ItemArray[5].ToString();
                                logingName = fname + " " + lname;

                                if (ds.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString() == "Hospital Administrator")
                                {
                                    userType = "Hospital Administrator";
                                    x = "yes";
                                    break;
                                }
                                else if (ds.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString() == "Medical Director")
                                {
                                    userType = "Medical Director";
                                    loginSuccess = true;
                                    x = "yes";
                                    break;
                                }
                                else if (ds.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString() == "Nursing Supervisor")
                                {
                                    userType = "Nursing Supervisor";
                                    loginSuccess = true;
                                    x = "yes";
                                    break;
                                }
                                else if (ds.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString() == "Operating Officer")
                                {
                                    userType = "Operating Officer";
                                    loginSuccess = true;
                                    x = "yes";
                                    break;
                                }
                                else if (ds.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString() == "HR Manager")
                                {
                                    userType = "HR Manager";
                                    loginSuccess = true;
                                    x = "yes";
                                    break;
                                }
                            }
                            currentRow++;
                        }

                        if (x == "no")
                        {
                            MessageBox.Show("Please input correct Username & Password !!!");
                        }

                        ds.Tables["tblLogin"].Clear();
                    }
                }
            }
        }
    }
}
