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
    public partial class frmAddPatientToOperationTheater : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        manageOperationTheaters manageOperationTheaters = new manageOperationTheaters();

        public frmAddPatientToOperationTheater()
        {
            InitializeComponent();
        }

        private void frmAddPatientToOperationTheater_Load(object sender, EventArgs e)
        {
            //patients
            try
            {
                managePatients managePatients = new managePatients();
                managePatients.LoadPatients(lbxPatients);
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

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvOperationTheaters.Rows[e.RowIndex];

                if (Row.Cells[1].Value.ToString() == "Not Available")
                {
                    MessageBox.Show("The Operation Theater already using !");
                }
                else
                {
                    tbxTheaterNo.Text = Row.Cells[0].Value.ToString();
                    tbxType.Text = Row.Cells[4].Value.ToString();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Patient has been admitted to the operation theater successfully");
                    manageOperationTheaters.LoadOperationTheaters(dgvOperationTheaters);
                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void ClearAll()
        {
            tbxPatientNo.Clear();
            tbxPatientFirstName.Clear();
            tbxPatientLastName.Clear();
            tbxTheaterNo.Clear();
            dtpDateFrom.Value = DateTime.Now;
            tbxProcedures.Clear();
            tbxType.Clear();
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

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(tbxPatientNo.Text) || string.IsNullOrWhiteSpace(tbxPatientFirstName.Text) || string.IsNullOrWhiteSpace(tbxPatientLastName.Text) ||
                string.IsNullOrWhiteSpace(tbxTheaterNo.Text) || string.IsNullOrWhiteSpace(tbxType.Text) || string.IsNullOrWhiteSpace(tbxProcedures.Text))
            {
                MessageBox.Show("Please fill all feilds");
                return false;
            }
            return true;
        }
    }
}
