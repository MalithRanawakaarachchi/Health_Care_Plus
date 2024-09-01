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
    public partial class frmMain : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuitmLogin_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            if (log.ShowDialog() == DialogResult.OK)
            {
                if (frmLogin.userType == "Hospital Administrator")
                {
                    mnuitmDoctors.Enabled = true;
                    mnuitmPatients.Enabled = true;
                    mnuitmMedicalRecords.Enabled = true;
                    mnuitmAppointments.Enabled = true;
                    mnuitmStaff.Enabled = true;
                    mnuitmRooms.Enabled = true;
                    mnuitmResources.Enabled = true;
                    mnuitmLogin.Enabled = false;
                    mnuitmLogout.Enabled = true;
                    pnlMain.Visible = false;
                    pbxMonthIncome.Visible = true;
                    lblMonthIncome.Visible = true;
                    tbxMonthlyIncome.Visible = true;
                    mnuitmAddDoctor.Enabled = true;
                    mnuitmAddDoctorSchedules.Enabled = true;
                    mnuitmManageDoctorSchedules.Enabled = true;
                    mnuitmAddPatients.Enabled = true;
                    mnuitmAddPatientToRoom.Enabled = true;
                    mnuitmOperationTheater.Enabled = true;
                    mnuitmBillingAndInvoicing.Enabled = true;
                    mnuitmManageResources.Enabled = true;
                    mnuitmMedication.Enabled = true;
                    mnuitmAddEMR.Enabled = true;
                    mnuitmAddAppointment.Enabled = true;
                    mnuitmAddEmployee.Enabled = true;
                    mnuitmViewEMR.Enabled = true;
                }
                else if (frmLogin.userType == "Medical Director")
                {
                    mnuitmLogin.Enabled = false;
                    mnuitmLogout.Enabled = true;
                    mnuitmDoctors.Enabled = true;
                    mnuitmPatients.Enabled = true;
                    mnuitmMedicalRecords.Enabled = true;
                    mnuitmAppointments.Enabled = true;
                    mnuitmStaff.Enabled = true;
                    mnuitmRooms.Enabled = true;
                    mnuitmResources.Enabled = true;
                    mnuitmMedication.Enabled = true;
                    mnuitmViewEMR.Enabled = true;
                    pnlMain.Visible = false;
                }
                else if (frmLogin.userType == "Nursing Supervisor")
                {
                    mnuitmLogin.Enabled = false;
                    mnuitmLogout.Enabled = true;
                    pnlMain.Visible = false;
                    mnuitmDoctors.Enabled = true;
                    mnuitmPatients.Enabled = true;
                    mnuitmMedicalRecords.Enabled = true;
                    mnuitmViewEMR.Enabled = true;
                    mnuitmAppointments.Enabled = true;
                    mnuitmStaff.Enabled = true;
                    mnuitmRooms.Enabled = true;
                    mnuitmResources.Enabled = true;
                    mnuitmAddEMR.Enabled = true;
                }
                else if (frmLogin.userType == "Operating Officer")
                {
                    mnuitmLogin.Enabled = false;
                    mnuitmLogout.Enabled = true;
                    pnlMain.Visible = false;
                    mnuitmDoctors.Enabled = true;
                    mnuitmPatients.Enabled = true;
                    mnuitmMedicalRecords.Enabled = true;
                    mnuitmAppointments.Enabled = true;
                    mnuitmStaff.Enabled = true;
                    mnuitmRooms.Enabled = true;
                    mnuitmResources.Enabled = true;
                    mnuitmAddAppointment.Enabled = true;
                    mnuitmViewEMR.Enabled = true;
                }
                else if (frmLogin.userType == "HR Manager")
                {
                    mnuitmLogin.Enabled = false;
                    mnuitmLogout.Enabled = true;
                    pnlMain.Visible = false;
                    mnuitmDoctors.Enabled = true;
                    mnuitmPatients.Enabled = true;
                    mnuitmMedicalRecords.Enabled = true;
                    mnuitmAppointments.Enabled = true;
                    mnuitmStaff.Enabled = true;
                    mnuitmRooms.Enabled = true;
                    mnuitmResources.Enabled = true;
                    mnuitmAddEmployee.Enabled = true;
                    mnuitmViewEMR.Enabled = true;
                }
                else
                {
                    mnuitmDoctors.Enabled = false;
                    mnuitmPatients.Enabled = false;
                    mnuitmMedicalRecords.Enabled = false;
                    mnuitmAppointments.Enabled = false;
                    mnuitmStaff.Enabled = false;
                    mnuitmRooms.Enabled = false;
                    mnuitmResources.Enabled = false;
                    mnuitmLogin.Enabled = true;
                    mnuitmLogout.Enabled = false;
                    pnlMain.Visible = true;
                    mnuitmAddDoctor.Enabled = false;
                    mnuitmAddDoctorSchedules.Enabled = false;
                    mnuitmManageDoctorSchedules.Enabled = false;
                    mnuitmAddPatients.Enabled = false;
                    mnuitmAddPatientToRoom.Enabled = false;
                    mnuitmOperationTheater.Enabled = false;
                    mnuitmBillingAndInvoicing.Enabled = false;
                    mnuitmManageResources.Enabled = false;
                    mnuitmMedication.Enabled = false;
                    mnuitmAddEMR.Enabled = false;
                    mnuitmAddAppointment.Enabled = false;
                    mnuitmAddEmployee.Enabled = false;
                    mnuMain.Enabled = false;
                    tbxMonthlyIncome.Visible = false;
                    pbxMonthIncome.Visible = false;
                    lblMonthIncome.Visible = false;
                    mnuitmViewEMR.Enabled = false;
                }
            }
        }

        private void mnuitmLogout_Click(object sender, EventArgs e)
        {
            mnuitmDoctors.Enabled = false;
            mnuitmPatients.Enabled = false;
            mnuitmMedicalRecords.Enabled = false;
            mnuitmAppointments.Enabled = false;
            mnuitmStaff.Enabled = false;
            mnuitmRooms.Enabled = false;
            mnuitmResources.Enabled = false;
            mnuitmLogin.Enabled = true;
            mnuitmLogout.Enabled = false;
            pnlMain.Visible = true;
            mnuitmAddDoctor.Enabled = false;
            mnuitmAddDoctorSchedules.Enabled = false;
            mnuitmManageDoctorSchedules.Enabled = false;
            mnuitmAddPatients.Enabled = false;
            mnuitmAddPatientToRoom.Enabled = false;
            mnuitmOperationTheater.Enabled = false;
            mnuitmBillingAndInvoicing.Enabled = false;
            mnuitmManageResources.Enabled = false;
            mnuitmMedication.Enabled = false;
            mnuitmAddEMR.Enabled = false;
            mnuitmAddAppointment.Enabled = false;
            mnuitmAddEmployee.Enabled = false;
            tbxMonthlyIncome.Visible = false;
            pbxMonthIncome.Visible = false;
            lblMonthIncome.Visible = false;
        }

        private void mnuitmAddDoctor_Click(object sender, EventArgs e)
        {
            frmAddDoctor addDoctor = new frmAddDoctor();
            addDoctor.ShowDialog();
        }

        private void mnuitmViewDoctor_Click(object sender, EventArgs e)
        {
            frmViewDoctors viewDoctors = new frmViewDoctors();
            viewDoctors.ShowDialog();
        }

        private void mnuitmAddPatients_Click(object sender, EventArgs e)
        {
            frmAddPatients addPatients = new frmAddPatients();
            addPatients.ShowDialog();
        }

        private void mnuitmViewPatients_Click(object sender, EventArgs e)
        {
            frmViewPatients viewPatients = new frmViewPatients();
            viewPatients.ShowDialog();
        }

        private void mnuitmAddEMR_Click(object sender, EventArgs e)
        {
            frmAddEMR addEMR = new frmAddEMR();
            addEMR.ShowDialog();
        }

        private void mnuitmViewEMR_Click(object sender, EventArgs e)
        {
            frmViewEMR viewEMR = new frmViewEMR();
            viewEMR.ShowDialog();
        }

        private void mnuitmAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee addEmployee = new frmAddEmployee();
            addEmployee.ShowDialog();
        }

        private void mnuitmViewEmployee_Click(object sender, EventArgs e)
        {
            frmViewEmployees viewEmployees = new frmViewEmployees();
            viewEmployees.ShowDialog();
        }

        private void mnuitmAddAppointment_Click(object sender, EventArgs e)
        {
            frmAddAppointment addAppointment = new frmAddAppointment();
            addAppointment.ShowDialog();
        }

        private void mnuitmViewAppointment_Click(object sender, EventArgs e)
        {
            frmViewAppointment viewAppointment = new frmViewAppointment();
            viewAppointment.ShowDialog();
        }

        private void mnuitmAddMedication_Click(object sender, EventArgs e)
        {
            frmAddMedication addMedication = new frmAddMedication();
            addMedication.Show();
        }

        private void mnuitmManageMedication_Click(object sender, EventArgs e)
        {
            frmViewMedications viewMedications = new frmViewMedications();
            viewMedications.ShowDialog();
        }

        private void mnuitmRoomDetails_Click(object sender, EventArgs e)
        {
            frmViewRooms rooms = new frmViewRooms();
            rooms.ShowDialog();
        }

        private void mnuitmAddPatientToRoom_Click(object sender, EventArgs e)
        {
            frmAddPatientToRoom addToRoom = new frmAddPatientToRoom();
            addToRoom.ShowDialog();
        }

        private void mnuitmAddDoctorSchedules_Click(object sender, EventArgs e)
        {
            frmAddDoctorSchedule addDocSchedule = new frmAddDoctorSchedule();
            addDocSchedule.ShowDialog();
        }

        private void mnuitmManageDoctorSchedules_Click(object sender, EventArgs e)
        {
            frmManageDoctorSchedules manageDocSchedules = new frmManageDoctorSchedules();
            manageDocSchedules.ShowDialog();
        }

        private void issueMedicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMediOut mediOut = new frmMediOut();
            mediOut.ShowDialog();
        }

        private void viewBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewBills bills = new frmViewBills();
            bills.ShowDialog();
        }

        private void mnuitmOperationTheater_Click(object sender, EventArgs e)
        {
            frmAddPatientToOperationTheater addtotheater = new frmAddPatientToOperationTheater();
            addtotheater.ShowDialog();
        }

        private void mnultmOperationTheaterDetails_Click(object sender, EventArgs e)
        {
            frmViewOperationTheaters viewtheaters = new frmViewOperationTheaters();
            viewtheaters.ShowDialog();
        }

        private void mnuitmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //patients
            if (ds.Tables["tblPatients"] != null)
            {
                ds.Tables["tblPatients"].Clear();
            }
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT id FROM tblPatients", con);
            da.Fill(ds, "tblPatients");
            con.Close();

            int rowcount = ds.Tables["tblPatients"].Rows.Count;

            tbxPatients.Text = Convert.ToString(rowcount);

            ds.Tables["tblPatients"].Clear();

            //appointments
            if (ds.Tables["tblAppointments"] != null)
            {
                ds.Tables["tblAppointments"].Clear();
            }
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT id FROM tblAppointments", con);
            da.Fill(ds, "tblAppointments");
            con.Close();

            int rowcount2 = ds.Tables["tblAppointments"].Rows.Count;

            tbxAppointments.Text = Convert.ToString(rowcount2);

            ds.Tables["tblAppointments"].Clear();

            //medications
            if (ds.Tables["tblMedications"] != null)
            {
                ds.Tables["tblMedications"].Clear();
            }
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT id FROM tblMedications", con);
            da.Fill(ds, "tblMedications");
            con.Close();

            int rowcount3 = ds.Tables["tblMedications"].Rows.Count;

            tbxMedications.Text = Convert.ToString(rowcount3);

            ds.Tables["tblMedications"].Clear();

            //rooms
            if (ds.Tables["tblRooms"] != null)
            {
                ds.Tables["tblRooms"].Clear();
            }
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT id FROM tblRooms WHERE status='"+"Available"+"'", con);
            da.Fill(ds, "tblRooms");
            con.Close();

            int rowcount4 = ds.Tables["tblRooms"].Rows.Count;

            tbxAvailableRooms.Text = Convert.ToString(rowcount4);

            ds.Tables["tblRooms"].Clear();

            //doctors
            if (ds.Tables["tblDoctors"] != null)
            {
                ds.Tables["tblDoctors"].Clear();
            }
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT id FROM tblDoctors", con);
            da.Fill(ds, "tblDoctors");
            con.Close();

            int rowcount5 = ds.Tables["tblDoctors"].Rows.Count;

            tbxDoctors.Text = Convert.ToString(rowcount5);

            ds.Tables["tblDoctors"].Clear();

            //revenue
            if (ds.Tables["tblBills"] != null)
            {
                ds.Tables["tblBills"].Clear();
            }
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT amount FROM tblBills WHERE status = '"+"completed"+"'", con);
            da.Fill(ds, "tblBills");
            con.Close();

            int currentRow = 0;
            int rowcount6 = ds.Tables["tblBills"].Rows.Count;
            decimal total = 0;
            decimal amount = 0;
            while(currentRow < rowcount6)
            {
                string amountStr = ds.Tables["tblBills"].Rows[currentRow].ItemArray[0].ToString();

                if (decimal.TryParse(amountStr, out amount))
                {
                    total = total + amount;
                }
                currentRow++;
            }
            tbxMonthlyIncome.Text = Convert.ToString(total);

            ds.Tables["tblBills"].Clear();
        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentHistory history = new frmPaymentHistory();
            history.ShowDialog();
        }

        private void mnuitmManageResources_Click(object sender, EventArgs e)
        {
            frmManageResources resource = new frmManageResources();
            resource.ShowDialog();
        }

        private void mnuitmManageScanners_Click(object sender, EventArgs e)
        {
            frmManageScanners scanners = new frmManageScanners();
            scanners.ShowDialog();
        }
    }
}
