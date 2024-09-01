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
    public partial class frmViewOperationTheaters : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        manageOperationTheaters manageOperationTheaters = new manageOperationTheaters();

        public frmViewOperationTheaters()
        {
            InitializeComponent();
        }

        private void frmViewOperationTheaters_Load(object sender, EventArgs e)
        {
            //patients
            try
            {
                managePatients managePatients = new managePatients();
                managePatients.LoadPatients(lbxPatients);
                if (frmLogin.userType == "Hospital Administrator")
                {
                    btnChangePatient.Enabled = true;
                }
                else
                {
                    btnChangePatient.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }

            //theaters
            try
            {
                manageOperationTheaters.LoadOperationTheaters(dgvOperationTheaters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void RetrievePatientData(string selectedName)
        {
            managePatients managePatients = new managePatients();
            Patient patient = managePatients.GetPatientByName(selectedName);
            try
            {
                if (patient != null)
                {
                    // Update your form's controls with the retrieved patient data
                    tbxPatientNo.Text = patient.id.ToString();
                    tbxPatientFirstName.Text = patient.first_name;
                    tbxPatientLastName.Text = patient.last_name;
                    // ... (update other controls)
                }
                else
                {
                    // Handle the case where the patient is not found
                    MessageBox.Show("Patient not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void lbxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedName = lbxPatients.SelectedItem.ToString();
                RetrievePatientData(selectedName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void dgvOperationTheaters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow RowIndex = this.dgvOperationTheaters.Rows[e.RowIndex];
                int row_Index = dgvOperationTheaters.CurrentRow.Index;

                if (RowIndex.Cells[2].Value.ToString() == "Available")
                {
                    MessageBox.Show("There is currently no patient in this Theater");
                }
                else
                {
                    if (ds.Tables["tbl_Patients"] != null)
                    {
                        ds.Tables["tbl_Patients"].Clear();
                    }
                    con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                    cmd.Connection = con;
                    con.Open();
                    da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblOperationTheaters.patient_id,tblPatients.first_name,tblPatients.last_name FROM tblOperationTheaters INNER JOIN tblPatients ON tblOperationTheaters.patient_id = tblPatients.id WHERE tblOperationTheaters.number='" + dgvOperationTheaters.Rows[row_Index].Cells[0].Value.ToString() + "'", con);
                    da.Fill(ds, "tbl_Patients");
                    con.Close();

                    tbxTheaterNo.Text = RowIndex.Cells[0].Value.ToString();
                    tbxPatientNo.Text = ds.Tables["tbl_Patients"].Rows[0].ItemArray[0].ToString();
                    tbxPatientFirstName.Text = ds.Tables["tbl_Patients"].Rows[0].ItemArray[1].ToString();
                    tbxPatientLastName.Text = ds.Tables["tbl_Patients"].Rows[0].ItemArray[2].ToString();
                    dtpDateFrom.Text = RowIndex.Cells[1].Value.ToString();
                    tbxProcedures.Text = RowIndex.Cells[3].Value.ToString();
                    tbxType.Text = RowIndex.Cells[4].Value.ToString();

                    ds.Tables["tbl_Patients"].Clear();
                }
            }
        }

        private void tbxChangePatient_Click(object sender, EventArgs e)
        {
            if (lbxPatients.Enabled == false)
            {
                lbxPatients.Enabled = true;
            }
            else
            {
                lbxPatients.Enabled = false;
            }
        }

        private void btnEditDate_Click(object sender, EventArgs e)
        {
            if (dtpDateFrom.Enabled == false)
            {
                dtpDateFrom.Enabled = true;
            }
            else
            {
                dtpDateFrom.Enabled = false;
            }
        }

        private void btnEditProcedures_Click(object sender, EventArgs e)
        {
            if (tbxProcedures.Enabled == false)
            {
                tbxProcedures.Enabled = true;
            }
            else
            {
                tbxProcedures.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    string number = tbxTheaterNo.Text;
                    OperationTheater OperationTheater = new OperationTheater
                    {
                        date_from = dtpDateFrom.Value.ToString(),
                        status = "Available",
                        patient_id = 0,
                        procedures = "",
                    };
                    manageOperationTheaters.ResetOperationTheater(number, OperationTheater);
                    manageOperationTheaters.LoadOperationTheaters(dgvOperationTheaters);
                    ClearAll();

                    //enabled false
                    dtpDateFrom.Enabled = false;
                    tbxProcedures.Enabled = false;
                    lbxPatients.Enabled = false;
                    tbxSearch.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void tbxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    string number = tbxTheaterNo.Text;
                    OperationTheater OperationTheater = new OperationTheater
                    {
                        date_from = dtpDateFrom.Value.ToString(),
                        status = "Not Available",
                        patient_id = Convert.ToInt32(tbxPatientNo.Text),
                        procedures = tbxProcedures.Text,
                    };
                    manageOperationTheaters.addToOperationTheater(number, OperationTheater);
                    MessageBox.Show("Operation theater updated successfully");
                    manageOperationTheaters.LoadOperationTheaters(dgvOperationTheaters);
                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    string number = tbxTheaterNo.Text;
                    OperationTheater OperationTheater = new OperationTheater
                    {
                        date_from = DateTime.Now.ToString(),
                        status = "Available",
                        patient_id = 0,
                        procedures = "",
                    };
                    manageOperationTheaters.DischargeFromOperationTheater(number, OperationTheater);
                    manageOperationTheaters.LoadOperationTheaters(dgvOperationTheaters);

                    //make a bill
                    Bill Bill = new Bill
                    {
                        date_from = dtpDateFrom.Value.ToShortDateString(),
                        date = DateTime.Today.ToShortDateString(),
                        patient_id = Convert.ToInt32(tbxPatientNo.Text),
                        room_id = tbxTheaterNo.Text,
                        amount = tbxCharge.Text
                    };
                    ManageBills ManageBills = new ManageBills();
                    ManageBills.addOperationBill(Bill);

                    //clear all
                    ClearAll();

                    //enabled false
                    dtpDateFrom.Enabled = false;
                    tbxProcedures.Enabled = false;
                    lbxPatients.Enabled = false;
                    tbxSearch.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbxPatients.Items.Clear();
                lbxPatients.Refresh();

                string searchText = tbxSearch.Text;
                managePatients managePatients = new managePatients();
                managePatients.SearchPatients(lbxPatients, searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void ClearAll()
        {
            //clear all
            tbxPatientNo.Clear();
            tbxPatientFirstName.Clear();
            tbxPatientLastName.Clear();
            tbxTheaterNo.Clear();
            tbxType.Clear();
            dtpDateFrom.Value = DateTime.Now;
            tbxProcedures.Clear();
            tbxCharge.Clear();
        }

        private void tbxTheaterNo_TextChanged(object sender, EventArgs e)
        {
            if(tbxTheaterNo.Text != "" && frmLogin.userType == "Hospital Administrator")
            {
                btnReset.Enabled = true;
                btnEditDate.Enabled = true;
                btnEditProcedures.Enabled = true;
                btnUpdate.Enabled = true;
                btnDischarge.Enabled = true;
            }
            else
            {
                btnReset.Enabled = false;
                btnEditDate.Enabled = false;
                btnEditProcedures.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
    }
}
