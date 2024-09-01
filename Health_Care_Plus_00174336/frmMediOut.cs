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
    public partial class frmMediOut : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmMediOut()
        {
            InitializeComponent();
        }

        private void frmMediOut_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            cmd.Connection = con;

            if (ds.Tables["tblMediOut"] != null)
            {
                ds.Tables["tblMediOut"].Clear();
            }
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblMedications", con);
            da.Fill(ds, "tblMediOut");
            con.Close();
            int currentRow = 0;
            int rowcount = ds.Tables["tblMediOut"].Rows.Count;
            while (currentRow < rowcount)
            {
                string id = ds.Tables["tblMediOut"].Rows[currentRow].ItemArray[0].ToString();        
                string name = ds.Tables["tblMediOut"].Rows[currentRow].ItemArray[3].ToString();
                string type = ds.Tables["tblMediOut"].Rows[currentRow].ItemArray[4].ToString();
                string frequency = ds.Tables["tblMediOut"].Rows[currentRow].ItemArray[6].ToString();
                string qty = ds.Tables["tblMediOut"].Rows[currentRow].ItemArray[8].ToString();
                string amount = ds.Tables["tblMediOut"].Rows[currentRow].ItemArray[9].ToString();

                dgvMedications.Rows.Add(id, name, type, frequency, qty, amount);

                currentRow++;
            }
            ds.Tables["tblMediOut"].Clear();

            //patients
            if (ds.Tables["tblPatients"] != null)
            {
                ds.Tables["tblPatients"].Clear();
            }
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblPatients", con);
            da.Fill(ds, "tblPatients");
            con.Close();

            int currentRow1 = 0;
            int rowcount1 = ds.Tables["tblPatients"].Rows.Count;

            while (currentRow1 < rowcount1)
            {
                string fname = ds.Tables["tblPatients"].Rows[currentRow1].ItemArray[1].ToString();
                string lname = ds.Tables["tblPatients"].Rows[currentRow1].ItemArray[2].ToString();
                string fullname = fname + " " + lname;
                lbxPatients.Items.Add(fullname);
                currentRow1++;
            }
        }

        private void dgvMedications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvMedications.Rows[e.RowIndex];

                tbxMediID.Text = Row.Cells[0].Value.ToString();
                tbxMediName.Text = Row.Cells[1].Value.ToString();
                tbxprice.Text = Row.Cells[5].Value.ToString();

                tbxQTY.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbxMediID.Text == "" || tbxMediName.Text == "" )
            {
                MessageBox.Show("Please select a medication before add to list !");
            }
            else if(tbxQTY.Text == "")
            {
                MessageBox.Show("Please add quantity before add to list !");
            }
            else if(tbxPatientID.Text == "")
            {
                MessageBox.Show("Please add patient before add to list !");
            }
            else
            {
                string id = tbxMediID.Text;
                string name = tbxMediName.Text;
                string qty = tbxQTY.Text;
                string amount = tbxprice.Text;

                dgvMediList.Rows.Add(id, name, qty, amount);

                tbxQTY.Enabled = false;
                tbxMediID.Clear();
                tbxMediName.Clear();
                tbxQTY.Clear();
                tbxprice.Clear();
            }
        }

        private void dgvMediList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvMediList.Rows.Clear();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal qty = 0;
            decimal amount = 0;
            int currentRow = 0;
            int rowCount = dgvMediList.Rows.Count;
            if (rowCount == 0)
            {
                MessageBox.Show("Please select add medication list before issue !");
            }
            else
            {
                while (currentRow < rowCount)
                {
                    DataGridViewRow Row = this.dgvMediList.Rows[currentRow];

                    if (Row.Cells[2].Value != null && Row.Cells[3].Value != null)
                    {
                        string qtyStr = Row.Cells[2].Value.ToString();
                        string amountStr = Row.Cells[3].Value.ToString();

                        if (decimal.TryParse(qtyStr, out qty) && decimal.TryParse(amountStr, out amount))
                        {
                            total = total + (qty * amount);
                        }
                    }
                    currentRow++;
                }

                //make a bill
                Bill Bill = new Bill
                {
                    patient_id = Convert.ToInt32(tbxPatientID.Text),
                    medi_amount = Convert.ToDecimal(total)
                };
                ManageBills ManageBills = new ManageBills();
                ManageBills.addMediBill(Bill);

                //get bill id
                if (ds.Tables["tblBillID"] !=null)
                {
                    ds.Tables["tblBillID"].Clear();
                }
                da = new System.Data.SqlClient.SqlDataAdapter("SELECT id FROM tblBills WHERE type = '"+"medication"+"' AND patient_id = '"+tbxPatientID.Text+"' AND date = '"+DateTime.Now.ToShortDateString()+"'", con);
                da.Fill(ds, "tblBillID");
                con.Close();
                string bill_id = ds.Tables["tblBillID"].Rows[0].ItemArray[0].ToString();

                //add bill items
                int currentRow2 = 0;
                int rowCount2 = dgvMediList.Rows.Count;
                while (currentRow2 < rowCount2)
                {
                    DataGridViewRow RowNo = this.dgvMediList.Rows[currentRow2];
                    if (RowNo.Cells[0].Value != null && RowNo.Cells[2].Value != null && RowNo.Cells[3].Value != null)
                    {
                        string medi_id = RowNo.Cells[0].Value.ToString();
                        string quantity = RowNo.Cells[2].Value.ToString();
                        string unit_price = RowNo.Cells[3].Value.ToString();

                        cmd.CommandText = "INSERT INTO tblBill_Items VALUES('" + bill_id + "','" + medi_id + "','" + quantity + "','" + unit_price + "')";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        cmd.CommandText = "UPDATE tblMedications SET qty = qty - '" + quantity + "' WHERE id='" + medi_id + "'";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    currentRow2++;
                }
                ds.Tables["tblBillID"].Clear();

                MessageBox.Show("Medication list has been issued for Bill");

                tbxQTY.Enabled = false;
                tbxMediID.Clear();
                tbxMediName.Clear();
                tbxQTY.Clear();
                tbxprice.Clear();
                tbxPatientID.Clear();
                tbxPatientName.Clear();
                dgvMediList.Rows.Clear();
            }
        }

        private void tbxSearchPatients_TextChanged(object sender, EventArgs e)
        {
            if (ds.Tables["tblPatients"] != null)
            {
                ds.Tables["tblPatients"].Clear();
            }
            lbxPatients.Items.Clear();
            lbxPatients.Refresh();
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblPatients WHERE first_name + ' ' + last_name LIKE '%" + tbxSearchPatients.Text + "%'", con);
            da.Fill(ds, "tblPatients");
            con.Close();

            int currentRow = 0;
            int rowcount = ds.Tables["tblPatients"].Rows.Count;

            while (currentRow < rowcount)
            {
                string fname = ds.Tables["tblPatients"].Rows[currentRow].ItemArray[1].ToString();
                string lname = ds.Tables["tblPatients"].Rows[currentRow].ItemArray[2].ToString();
                string fullname = fname + " " + lname;
                lbxPatients.Items.Add(fullname);
                currentRow++;
            }
        }

        private void lbxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = lbxPatients.SelectedItem.ToString();
            string[] nameParts = selectedName.Split(' '); // Split the selected name into first_name and last_name parts

            string firstName = nameParts[0]; // Extract the first_name part
            string lastName = nameParts[1]; // Extract the last_name part

            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblPatients WHERE first_name = @firstName AND last_name = @lastName", con);
            da.SelectCommand.Parameters.AddWithValue("@firstName", firstName);
            da.SelectCommand.Parameters.AddWithValue("@lastName", lastName);

            DataSet ds = new DataSet();
            da.Fill(ds, "tblPatients");
            con.Close();

            tbxPatientID.Text = ds.Tables["tblPatients"].Rows[0].ItemArray[0].ToString();
            tbxPatientName.Text = firstName + " " + lastName;
        }
    }
}
