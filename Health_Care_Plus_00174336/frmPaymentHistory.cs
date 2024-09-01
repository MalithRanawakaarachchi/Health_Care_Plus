using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_00174336
{
    public partial class frmPaymentHistory : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmPaymentHistory()
        {
            InitializeComponent();
        }

        private void frmPaymentHistory_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            cmd.Connection = con;

            if (ds.Tables["tblBillHistory"] != null)
            {
                ds.Tables["tblBillHistory"].Clear();
            }
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblBills.id,tblBills.date,tblBills.patient_id,tblPatients.first_name,tblPatients.last_name,tblBills.type,tblBills.amount,tblBills.status,tblBills.room_id FROM tblBills INNER JOIN tblPatients ON tblBills.patient_id = tblPatients.id WHERE status = '" + "completed"+ "'", con);
            da.Fill(ds, "tblBillHistory");
            con.Close();

            decimal total = 0;
            decimal amount = 0;
            int currentRow = 0;
            int rowcount = ds.Tables["tblBillHistory"].Rows.Count;
            while (currentRow < rowcount)
            {
                string id = ds.Tables["tblBillHistory"].Rows[currentRow].ItemArray[0].ToString();
                string date = ds.Tables["tblBillHistory"].Rows[currentRow].ItemArray[1].ToString();
                string patient_ID = ds.Tables["tblBillHistory"].Rows[currentRow].ItemArray[2].ToString();
                string fname = ds.Tables["tblBillHistory"].Rows[currentRow].ItemArray[3].ToString();
                string lname = ds.Tables["tblBillHistory"].Rows[currentRow].ItemArray[4].ToString();
                string type = ds.Tables["tblBillHistory"].Rows[currentRow].ItemArray[5].ToString();
                string amountSt = ds.Tables["tblBillHistory"].Rows[currentRow].ItemArray[6].ToString();
                string status = ds.Tables["tblBillHistory"].Rows[currentRow].ItemArray[7].ToString();
                string room = ds.Tables["tblBillHistory"].Rows[currentRow].ItemArray[8].ToString();
                string fullname = fname + " " + lname;

                if (decimal.TryParse(amountSt, out amount))
                {
                    total = total + amount;
                }

                    dgvPaymentHistory.Rows.Add(id, date, fullname, patient_ID, type, room, status, amountSt);

                currentRow++;
            }

            tbxTotal.Text = Convert.ToString(total);

            ds.Tables["tblBillHistory"].Clear();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar.Visible = true;

                int totalSteps = 10; // Adjust to your total number of steps
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;

                for (int i = 0; i <= totalSteps; i++)
                {
                    int progress = i * 10;

                    // Update the progress bar
                    progressBar.Value = progress;

                    // Sleep for a short duration to slow down the update and make it smoother
                    System.Threading.Thread.Sleep(50); // Adjust the sleep duration as needed
                }


                if (dgvPaymentHistory.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);

                    progressBar.Maximum = dgvPaymentHistory.Rows.Count; // Set the progress bar maximum to the total rows

                    for (int i = 1; i < dgvPaymentHistory.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = dgvPaymentHistory.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvPaymentHistory.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvPaymentHistory.Columns.Count; j++)
                        {
                            if (dgvPaymentHistory.Rows[i].Cells[j].Value != null)
                            {
                                MExcel.Cells[i + 2, j + 1] = dgvPaymentHistory.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                MExcel.Cells[i + 2, j + 1] = string.Empty; // Or handle null values as needed
                            }
                        }
                    }
                    MExcel.Rows.AutoFit();
                    MExcel.Columns.Font.Size = 12;
                    MExcel.Visible = true;
                }
                else
                {
                    MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }
    }
}
