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
    public partial class frmDeleteEmployee : Form
    {
        public frmDeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(frmViewEmployees.emp_id);
                manageEmployees manageEmployees = new manageEmployees();
                manageEmployees.DelteEmployee(id);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }
    }
}
