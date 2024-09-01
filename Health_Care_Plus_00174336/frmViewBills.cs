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
    public partial class frmViewBills : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        public static string patient_ID = "";

        public frmViewBills()
        {
            InitializeComponent();
        }

        private void frmViewBills_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            cmd.Connection = con;

            if (ds.Tables["tblBills"] != null)
            {
                ds.Tables["tblBills"].Clear();
            }
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblBills.id,tblBills.date,tblBills.patient_id,tblPatients.first_name,tblPatients.last_name,tblBills.type,tblBills.amount,tblBills.status,tblBills.room_id FROM tblBills INNER JOIN tblPatients ON tblBills.patient_id = tblPatients.id WHERE status = '" + "pending"+"'", con);
            da.Fill(ds, "tblBills");
            con.Close();
            dgvBills.Rows.Clear();
            dgvBills.Refresh();
            int currentRow = 0;
            int rowcount = ds.Tables["tblBills"].Rows.Count;
            while (currentRow < rowcount)
            {
                string id = ds.Tables["tblBills"].Rows[currentRow].ItemArray[0].ToString();
                string date = ds.Tables["tblBills"].Rows[currentRow].ItemArray[1].ToString();
                string patient_id = ds.Tables["tblBills"].Rows[currentRow].ItemArray[2].ToString();
                string fname = ds.Tables["tblBills"].Rows[currentRow].ItemArray[3].ToString();
                string lname = ds.Tables["tblBills"].Rows[currentRow].ItemArray[4].ToString();
                string type = ds.Tables["tblBills"].Rows[currentRow].ItemArray[5].ToString();
                string amount = ds.Tables["tblBills"].Rows[currentRow].ItemArray[6].ToString();
                string room_id = ds.Tables["tblBills"].Rows[currentRow].ItemArray[8].ToString();

                string fullname = fname + " " + lname;

                dgvBills.Rows.Add(id, date, patient_id, fullname, type, amount, room_id);

                currentRow++;
            }
            ds.Tables["tblBills"].Clear();
        }

        private void dgvBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvBills.Rows[e.RowIndex];

                tbxDate.Text = Row.Cells[1].Value.ToString();
                tbxType.Text = Row.Cells[4].Value.ToString();
                tbxPatientName.Text = Row.Cells[3].Value.ToString();
                tbxPatientID.Text = Row.Cells[2].Value.ToString();
                tbxTotal.Text = Row.Cells[5].Value.ToString();
                if(Row.Cells[6].Value.ToString()!="")
                {
                    lblRoom.Visible = true;
                    tbxRoomNo.Visible = true;
                    tbxRoomNo.Text = Row.Cells[6].Value.ToString();
                }
                else
                {
                    lblRoom.Visible = false;
                    tbxRoomNo.Visible = false;
                }

                patient_ID = Row.Cells[2].Value.ToString();
                lblCaption.Visible = true;
                lblCaption2.Visible = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (tbxDate.Text == "" || tbxTotal.Text == "" || tbxPatientID.Text == "")
            {
                MessageBox.Show("Please select a bill for check all payments of the customer !");
            }
            else
            {
                frmBillPrint billPrint = new frmBillPrint();
                if(billPrint.ShowDialog()==DialogResult.OK)
                {
                    dgvBills.Rows.Clear();
                    dgvBills.Refresh();
                    con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                    cmd.Connection = con;

                    if (ds.Tables["tblBills"] != null)
                    {
                        ds.Tables["tblBills"].Clear();
                    }
                    con.Open();
                    da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblBills.id,tblBills.date,tblBills.patient_id,tblPatients.first_name,tblPatients.last_name,tblBills.type,tblBills.amount,tblBills.status,tblBills.room_id FROM tblBills INNER JOIN tblPatients ON tblBills.patient_id = tblPatients.id WHERE status = '" + "pending" + "'", con);
                    da.Fill(ds, "tblBills");
                    con.Close();
                    int currentRow = 0;
                    int rowcount = ds.Tables["tblBills"].Rows.Count;
                    while (currentRow < rowcount)
                    {
                        string id = ds.Tables["tblBills"].Rows[currentRow].ItemArray[0].ToString();
                        string date = ds.Tables["tblBills"].Rows[currentRow].ItemArray[1].ToString();
                        string patient_id = ds.Tables["tblBills"].Rows[currentRow].ItemArray[2].ToString();
                        string fname = ds.Tables["tblBills"].Rows[currentRow].ItemArray[3].ToString();
                        string lname = ds.Tables["tblBills"].Rows[currentRow].ItemArray[4].ToString();
                        string type = ds.Tables["tblBills"].Rows[currentRow].ItemArray[5].ToString();
                        string amount = ds.Tables["tblBills"].Rows[currentRow].ItemArray[6].ToString();
                        string room_id = ds.Tables["tblBills"].Rows[currentRow].ItemArray[8].ToString();

                        string fullname = fname + " " + lname;

                        dgvBills.Rows.Add(id, date, patient_id, fullname, type, amount, room_id);

                        currentRow++;
                    }
                    ds.Tables["tblBills"].Clear();

                    MessageBox.Show("Payment completed");
                }
            }
        }
    }
}
