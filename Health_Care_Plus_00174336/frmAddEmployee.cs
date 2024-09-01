using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using Health_Care_Plus_00174336.Classes;

namespace Health_Care_Plus_00174336
{
    public partial class frmAddEmployee : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void cbxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEmail.Checked == true)
            {
                tbxEmail.Enabled = true;
            }
            else
            {
                tbxEmail.Enabled = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAddEmployee.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
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
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                    string password = tbxPassword.Text;

                    // Encrypt the password
                    string encryptedPassword = PasswordEncryptor.EncryptPassword(password);

                    Employee Employee = new Employee
                    {
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
                        password = encryptedPassword
                    };
                    manageEmployees manageEmployees = new manageEmployees();
                    manageEmployees.AddEmployee(Employee);
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

        private int GetSelectedPositionId()
        {
            string selectedPosition = cbbxPosition.SelectedItem.ToString();
            manageEmployees manageEmployees = new manageEmployees();
            int positionId = manageEmployees.GetPositionIdByName(selectedPosition);
            return positionId;
        }

        private void cbbxIDType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(tbxFirstName.Text) || string.IsNullOrWhiteSpace(tbxLastName.Text) ||
                string.IsNullOrWhiteSpace(tbxAddress.Text) || cbbxIDType.Text == "Select ID Type" ||
                cbbxPosition.Text == "Select Position" || string.IsNullOrWhiteSpace(tbxIDno.Text) ||  string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                MessageBox.Show("Please fill all feilds");
                return false;
            }
            else if (rbtnMale.Checked == false && rbtnFemale.Checked == false)
            {
                MessageBox.Show("Please select a gender");
                return false;
            }
            else if(dtpDOB.Value.Date == DateTime.Today)
            {
                MessageBox.Show("Please select a correct birthday");
                return false;
            }
            return true;
        }

        private void ClearAll()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxAddress.Clear();
            cbbxIDType.Text = "Select ID Type";
            tbxIDno.Clear();
            cbbxPosition.Text = "Select Position";
            dtpDOB.Value = DateTime.Now;
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            cbxEmail.Checked = false;
            cbxMobile.Checked = false;
            cbxHome.Checked = false;
            tbxEmail.Clear();
            tbxMobile.Clear();
            tbxHome.Clear();
            tbxPassword.Clear();
        }
    }
}
