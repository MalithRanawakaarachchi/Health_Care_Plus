using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Health_Care_Plus_00174336.Classes;

namespace Health_Care_Plus_00174336
{
    public partial class frmLogin : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        string x = "no";
        public static string userType = "";
        public static string logingId = "";
        public static string logingName = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '\0')
            {
                // If the password is currently visible, hide it
                tbxPassword.PasswordChar = '•'; // You can use any character to mask the password
            }
            else
            {
                // If the password is currently hidden, show it
                tbxPassword.PasswordChar = '\0'; // Use '\0' to display the actual characters
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            cmd.Connection = con;
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblEmployees.email,tblEmployees.password,tblStaffPositions.position,tblEmployees.id,tblEmployees.first_name,tblEmployees.last_name FROM tblEmployees INNER JOIN tblStaffPositions ON tblEmployees.position_id = tblStaffPositions.id", con);
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
                            DialogResult = DialogResult.OK;
                            x = "yes";
                            break;
                        }
                        else if (ds.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString() == "Medical Director")
                        {
                            userType = "Medical Director";
                            DialogResult = DialogResult.OK;
                            x = "yes";
                            break;
                        }
                        else if (ds.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString() == "Nursing Supervisor")
                        {
                            userType = "Nursing Supervisor";
                            DialogResult = DialogResult.OK;
                            x = "yes";
                            break;
                        }
                        else if (ds.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString() == "Operating Officer")
                        {
                            userType = "Operating Officer";
                            DialogResult = DialogResult.OK;
                            x = "yes";
                            break;
                        }
                        else if (ds.Tables["tblLogin"].Rows[currentRow].ItemArray[2].ToString() == "HR Manager")
                        {
                            userType = "HR Manager";
                            DialogResult = DialogResult.OK;
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
