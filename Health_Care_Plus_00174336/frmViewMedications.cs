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
    public partial class frmViewMedications : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        manageMedications manageMedications = new manageMedications();

        public frmViewMedications()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxDosage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    int id = Convert.ToInt32(tbxMediID.Text);

                    Medication Medication = new Medication
                    {
                        id = Convert.ToInt32(tbxMediID.Text),
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

                    manageMedications.UpdateMedicationsById(id, Medication);
                    manageMedications.LoadMedicationrs(dgvMedications);
                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void frmViewMedications_Load(object sender, EventArgs e)
        {
            //Medications
            try
            {
                manageMedications.LoadMedicationrs(dgvMedications);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void dgvMedications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dgvMedications.Rows[e.RowIndex];            

                tbxMediID.Text = Row.Cells[0].Value.ToString();
                dtpStock.Text = Row.Cells[1].Value.ToString();
                dtpExp.Text = Row.Cells[2].Value.ToString();
                tbxMedicationName.Text = Row.Cells[3].Value.ToString();
                cbbxType.Text = Row.Cells[4].Value.ToString(); 
                tbxDosage.Text = Row.Cells[5].Value.ToString();
                cbbxFrequency.Text = Row.Cells[6].Value.ToString();
                tbxAllergies.Text = Row.Cells[7].Value.ToString();
                tbxQuantity.Text = Row.Cells[8].Value.ToString();
                tbxPrice.Text = Row.Cells[9].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbxMediID.Text);
                manageMedications.DelteIMedication(id);
                manageMedications.LoadMedicationrs(dgvMedications);
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void ClearAll()
        {
            tbxMediID.Clear();
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
               string.IsNullOrWhiteSpace(tbxMedicationName.Text)|| string.IsNullOrWhiteSpace(tbxDosage.Text) || string.IsNullOrWhiteSpace(tbxAllergies.Text) ||
               string.IsNullOrWhiteSpace(tbxQuantity.Text))
            {
                MessageBox.Show("Please fill all feilds");
                return false;
            }
            return true;
        }
    }
}
