using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Health_Care_Plus_00174336.Classes;

namespace Health_Care_Plus_00174336
{
    public partial class frmViewEmployees : Form
    {
        public manageEmployees manageEmployees = new manageEmployees();
        int position = 0;
        public static string emp_id = "";

        public frmViewEmployees()
        {
            InitializeComponent();
        }

        private void frmViewEmployees_Load(object sender, EventArgs e)
        {
            try
            {
                manageEmployees manageEmployees = new manageEmployees();
                manageEmployees.LoadEmployees(lbxEmployees);

                if(frmLogin.userType == "Hospital Administrator" || frmLogin.userType == "HR Manager")
                {
                    btnEdit.Enabled = true;
                    cbxGeneratePasword.Visible = true;
                    tbxPassword.Visible = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    cbxGeneratePasword.Visible = false;
                    tbxPassword.Visible = false;
                    pnlViewEmployees.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (pnlViewEmployees.Enabled == false)
            {
                pnlViewEmployees.Enabled = true;
            }
            else
            {
                pnlViewEmployees.Enabled = false;
            }
        }

        private void cbxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxGeneratePasword.Checked == true)
            {
                tbxPassword.Enabled = true;
            }
            else
            {
                tbxPassword.Enabled = false;
            }
        }

        private void cbxMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMobile.Checked == true)
            {
                tbxMobile.Enabled = true;
            }
            else
            {
                tbxMobile.Enabled = false;
            }
        }

        private void cbxHome_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHome.Checked == true)
            {
                tbxHome.Enabled = true;
            }
            else
            {
                tbxHome.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbtnMale.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }

            try
            {
                if (Validate())
                {
                    int id = Convert.ToInt32(tbxEMPID.Text);

                    // Encrypt the password
                    string password = tbxPassword.Text;
                    string setPassword = "";
                    string encryptedPassword = PasswordEncryptor.EncryptPassword(password);

                    if(string.IsNullOrWhiteSpace(tbxPassword.Text))
                    {
                        setPassword = "";
                    }
                    else
                    {
                        setPassword = encryptedPassword;
                    }

                    Employee Employee = new Employee
                    {
                        id = Convert.ToInt32(tbxEMPID.Text),
                        first_name = tbxFirstName.Text,
                        last_name = tbxLastName.Text,
                        address = tbxAddress.Text,
                        id_type = cbbxIDType.Text,
                        id_no = tbxIDno.Text,
                        position_id = GetSelectedPositionId(),
                        dob = dtpDOB.Value.ToShortDateString(),
                        gender = gender,
                        email = tbxEmail.Text,
                        mobile = tbxMobile.Text,
                        home = tbxHome.Text,
                        password = setPassword
                    };

                    manageEmployees manageEmployees = new manageEmployees();
                    manageEmployees.UpdateEmployeeById(id, Employee);

                    lbxEmployees.Items.Clear();
                    lbxEmployees.Refresh();

                    manageEmployees.LoadEmployees(lbxEmployees);

                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        public class PasswordEncryptor
        {
            public static readonly string EncryptionKey = "MySecretEncryptionKey";
            public static readonly string IV = "MyRandomIVValue";

            public static string EncryptPassword(string password)
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32)); // Ensure key is 32 bytes
                byte[] ivBytes = Encoding.UTF8.GetBytes(IV.PadRight(16)); // Ensure IV is 16 bytes

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = keyBytes;
                    aesAlg.IV = ivBytes;

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(password);
                            }
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }

            public static string DecryptPassword(string encryptedPassword)
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32)); // Ensure key is 32 bytes
                byte[] ivBytes = Encoding.UTF8.GetBytes(IV.PadRight(16)); // Ensure IV is 16 bytes

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = keyBytes;
                    aesAlg.IV = ivBytes;

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedPassword)))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }

        private void RetrieveEmployeeData(string selectedName)
        {
            Employee employee = manageEmployees.GetEmployeeByName(selectedName);
            try
            {
                if (employee != null)
                {
                    tbxEMPID.Text = employee.id.ToString();
                    tbxFirstName.Text = employee.first_name;
                    tbxLastName.Text = employee.last_name;
                    tbxAddress.Text = employee.address;
                    cbbxIDType.Text = employee.id_type;
                    tbxIDno.Text = employee.id_no;
                    cbbxPosition.Text = employee.position;
                    dtpDOB.Text = employee.dob;
                    if (employee.gender == "male")
                    {
                        rbtnMale.Checked = true;
                    }
                    else
                    {
                        rbtnFemale.Checked = true;
                    }
                    tbxEmail.Text = employee.email;
                    tbxMobile.Text = employee.mobile;
                    tbxHome.Text = employee.home;

                    emp_id = tbxEMPID.Text;
                }
                else
                {
                    // Handle the case where the patient is not found
                    MessageBox.Show("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void lbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedName = lbxEmployees.SelectedItem.ToString();
                RetrieveEmployeeData(selectedName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeleteEmployee deleteEmp = new frmDeleteEmployee();
                if (deleteEmp.ShowDialog() == DialogResult.OK)
                {
                    lbxEmployees.Items.Clear();
                    lbxEmployees.Refresh();
                    manageEmployees manageEmployees = new manageEmployees();
                    manageEmployees.LoadEmployees(lbxEmployees);

                    ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private void tbxEMPID_TextChanged(object sender, EventArgs e)
        {
            if (tbxEMPID.Text != "")
            {
                if(frmLogin.userType == "Hospital Administrator" || frmLogin.userType == "HR Manager")
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void tbxFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbxEmployees.Items.Clear();
                lbxEmployees.Refresh();

                string searchText = tbxSearch.Text;
                manageEmployees manageEmployees = new manageEmployees();
                manageEmployees.SearchEmployes(lbxEmployees, searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }

        private int GetSelectedPositionId()
        {
            string selectedPosition = cbbxPosition.SelectedItem.ToString();
            manageEmployees manageEmployees = new manageEmployees();
            int positionId = manageEmployees.GetPositionIdByName(selectedPosition);
            return positionId;
        }

        private void ClearAll()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxAddress.Clear();
            cbbxIDType.Text = "Select ID Type";
            tbxIDno.Clear();
            dtpDOB.Value = DateTime.Now;
            cbbxPosition.Text = "Select Position";
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            cbxEmail.Checked = false;
            cbxMobile.Checked = false;
            cbxHome.Checked = false;
            tbxEmail.Clear();
            tbxMobile.Clear();
            tbxHome.Clear();
            tbxPassword.Clear();
            tbxEMPID.Clear();
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(tbxFirstName.Text) || string.IsNullOrWhiteSpace(tbxLastName.Text) ||
                string.IsNullOrWhiteSpace(tbxAddress.Text)  || cbbxIDType.Text == "Select ID Type" ||
              string.IsNullOrWhiteSpace(tbxIDno.Text) || cbbxPosition.Text == "Select Position" || 
              string.IsNullOrWhiteSpace(tbxEmail.Text) || string.IsNullOrWhiteSpace(tbxMobile.Text))
            {
                MessageBox.Show("Please fill all feilds");
                return false;
            }
            else if(dtpDOB.Value.Date == DateTime.Today)
            {
                MessageBox.Show("Please select a valid birthday");
                return false;
            }
            return true;
        }
    }
}
