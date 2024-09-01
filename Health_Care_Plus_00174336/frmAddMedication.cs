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
    public partial class frmAddMedication : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        manageMedications manageMedications = new manageMedications();

        public frmAddMedication()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pnlMEdication.Enabled == false)
            {
                pnlMEdication.Enabled = true;
            }
            else
            {
                pnlMEdication.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpStock.Value = DateTime.Now;
            dtpExp.Value = DateTime.Now;
            tbxMedicationName.Clear();
            cbbxType.Text = "Select Medication Type";
            cbbxFrequency.Text = "Select Frequency";
            tbxDosage.Clear();
            tbxAllergies.Clear();
            tbxQuantity.Clear();
            tbxPrice.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    Medication Medication = new Medication
                    {
                        stock_from = dtpStock.Value.ToString(),
                        exp = dtpExp.Value.ToString(),
                        name = tbxMedicationName.Text,
                        type = cbbxType.Text,
                        dosage = tbxDosage.Text,
                        frequency = cbbxFrequency.Text,
                        allegies = tbxAllergies.Text,
                        qty = Convert.ToInt32(tbxQuantity.Text),
                        price = Convert.ToInt32(tbxPrice.Text)
                    };
                    manageMedications.AddMedication(Medication);

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
            dtpStock.Value = DateTime.Now;
            dtpExp.Value = DateTime.Now;
            tbxMedicationName.Clear();
            cbbxType.Text = "Select Medication Type";
            cbbxFrequency.Text = "Select Frequency";
            tbxDosage.Clear();
            tbxAllergies.Clear();
            tbxQuantity.Clear();
            tbxPrice.Clear();
        }

        private bool Validate()
        {
            if (dtpExp.Value.Date == DateTime.Today || cbbxType.Text == "Select Medication Type" || cbbxFrequency.Text == "Select Frequency" ||
                string.IsNullOrWhiteSpace(tbxMedicationName.Text) || string.IsNullOrWhiteSpace(tbxDosage.Text) || string.IsNullOrWhiteSpace(tbxAllergies.Text) ||
                string.IsNullOrWhiteSpace(tbxQuantity.Text) || string.IsNullOrWhiteSpace(tbxPrice.Text))
            {
                MessageBox.Show("Please fill all feilds");
                return false;
            }
            return true;
        }
    }
}
