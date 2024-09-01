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
    public partial class frmBillPrint : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmBillPrint()
        {
            InitializeComponent();

           
        }

        private void dgvMedications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBillPrint_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
            cmd.Connection = con;

            if (ds.Tables["tblBills"] != null)
            {
                ds.Tables["tblBills"].Clear();
            }
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblBills.id,tblBills.date,tblBills.patient_id,tblPatients.first_name,tblPatients.last_name,tblBills.type,tblBills.amount,tblBills.status,tblBills.date_from,tblBills.room_id FROM tblBills INNER JOIN tblPatients ON tblBills.patient_id = tblPatients.id WHERE status = '" + "pending" +"' AND patient_id = '"+frmViewBills.patient_ID+"'", con);
            da.Fill(ds, "tblBills");
            con.Close();
           
            string fname = ds.Tables["tblBills"].Rows[0].ItemArray[3].ToString();
            string lname = ds.Tables["tblBills"].Rows[0].ItemArray[4].ToString();
            string fullname = fname + " " + lname;
            tbxPatientName.Text = fullname;
            tbxID.Text = ds.Tables["tblBills"].Rows[0].ItemArray[2].ToString();
            tbxDate.Text = DateTime.Now.ToString();

            int currentRow = 0;
            int rowcount = ds.Tables["tblBills"].Rows.Count;
            while (currentRow < rowcount)
            {
                if (ds.Tables["tblBills"].Rows[currentRow].ItemArray[5].ToString() == "appointment")
                {
                    tbxDoctorCharges.Text = ds.Tables["tblBills"].Rows[currentRow].ItemArray[6].ToString();
                    tbxDoctorCharge.Text = ds.Tables["tblBills"].Rows[currentRow].ItemArray[6].ToString();
                }
                else if (ds.Tables["tblBills"].Rows[currentRow].ItemArray[5].ToString() == "room charge")
                {
                    string todaySt = ds.Tables["tblBills"].Rows[currentRow].ItemArray[1].ToString();
                    string date_fromSt = ds.Tables["tblBills"].Rows[currentRow].ItemArray[8].ToString();
                    string amountSt = ds.Tables["tblBills"].Rows[currentRow].ItemArray[6].ToString();

                    decimal amount = 0;
                    decimal charge = 0;

                    // Parse the date strings as DateTime objects
                    DateTime today = DateTime.Parse(todaySt);
                    DateTime date_from = DateTime.Parse(date_fromSt);

                    // Calculate the time span (difference) between the two dates
                    TimeSpan difference = today - date_from;

                    int numberOfDays = (int)difference.TotalDays;


                    if (decimal.TryParse(amountSt, out amount))
                    {
                        charge = amount * numberOfDays;

                    }
                    tbxRoomCharges.Text = Convert.ToString(charge);
                    tbxRoomCharge.Text = Convert.ToString(charge);
                    tbxRoomNo.Text = ds.Tables["tblBills"].Rows[currentRow].ItemArray[9].ToString();
                    tbxNoOfDays.Text = Convert.ToString(numberOfDays);
                }
                else if (ds.Tables["tblBills"].Rows[currentRow].ItemArray[5].ToString() == "operation charge")
                {
                    tbxOperationCharges.Text = ds.Tables["tblBills"].Rows[currentRow].ItemArray[6].ToString();
                    tbxOperationCharge.Text = ds.Tables["tblBills"].Rows[currentRow].ItemArray[6].ToString();
                }
                else if (ds.Tables["tblBills"].Rows[currentRow].ItemArray[5].ToString() == "medication")
                {
                    if (ds.Tables["tblBillItems"] != null)
                    {
                        ds.Tables["tblBillItems"].Clear();
                    }
                    con.Open();
                    da = new System.Data.SqlClient.SqlDataAdapter("SELECT tblMedications.name,tblBill_Items.qty,tblBill_Items.amount FROM tblBill_Items INNER JOIN tblMedications ON tblBill_Items.item_id = tblMedications.id WHERE bill_id = '" + ds.Tables["tblBills"].Rows[currentRow].ItemArray[0].ToString() + "'", con);
                    da.Fill(ds, "tblBillItems");
                    con.Close();
                    int currentRow2 = 0;
                    int rowcount2 = ds.Tables["tblBillItems"].Rows.Count;

                    decimal qty = 0;
                    decimal unit = 0;
                    decimal amount = 0;
                    while (currentRow2 < rowcount2)
                    {
                        string date = ds.Tables["tblBills"].Rows[currentRow].ItemArray[1].ToString();
                        string name = ds.Tables["tblBillItems"].Rows[currentRow2].ItemArray[0].ToString();
                        string quantity = ds.Tables["tblBillItems"].Rows[currentRow2].ItemArray[1].ToString();
                        string unit_price = ds.Tables["tblBillItems"].Rows[currentRow2].ItemArray[2].ToString();
                        if (decimal.TryParse(quantity, out qty) && decimal.TryParse(unit_price, out unit))
                        {
                            amount = qty * unit;
                        }
                        dgvMedications.Rows.Add(date, name, quantity, unit_price, amount);
                        currentRow2++;
                    }
                    ds.Tables["tblBillItems"].Clear();

                    int currentRow3 = 0;
                    int rowCount3 = dgvMedications.Rows.Count;
                    decimal rowamount = 0;
                    decimal total = 0;

                    while (currentRow3 < rowCount3)
                    {
                        DataGridViewRow Row = this.dgvMedications.Rows[currentRow3];

                        if (Row.Cells[0].Value != null && Row.Cells[4].Value != null)
                        {
                            string rowamountSt = Row.Cells[4].Value.ToString();

                            if (decimal.TryParse(rowamountSt, out rowamount))
                            {
                                total = total + rowamount;
                            }
                        }
                        currentRow3++;
                    }
                    tbxMedicationCharges.Text = Convert.ToString(total);
                    tbxMedicationCharge.Text = Convert.ToString(total);
                }
                currentRow++;

                decimal doctor_charge = 0;
                decimal room_charge = 0;
                decimal operation_charge = 0;
                decimal medication_charge = 0;

                if (tbxDoctorCharges.Text != "")
                {
                    doctor_charge = Convert.ToDecimal(tbxDoctorCharges.Text);
                }
                if (tbxRoomCharges.Text != "")
                {
                    room_charge = Convert.ToDecimal(tbxRoomCharges.Text);
                }
                if (tbxOperationCharges.Text != "")
                {
                    operation_charge = Convert.ToDecimal(tbxOperationCharges.Text);
                }
                if (tbxMedicationCharges.Text != "")
                {
                    medication_charge = Convert.ToDecimal(tbxMedicationCharges.Text);
                }
                    
                decimal total_charge = doctor_charge + room_charge + operation_charge + medication_charge;
                tbxTotalCharge.Text = Convert.ToString(total_charge);
                tbxTotal.Text = Convert.ToString(total_charge);
            }
            ds.Tables["tblBills"].Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Create a Bitmap to capture the panel contents
            Bitmap panelContentBitmap = new Bitmap(pnlPrint.Width, pnlPrint.Height);

            // Capture the panel contents
            pnlPrint.DrawToBitmap(panelContentBitmap, new Rectangle(0, 0, pnlPrint.Width, pnlPrint.Height));

            // Calculate the scaling factor to fit the captured panel content within the A4 page
            float scaleWidth = e.PageBounds.Width / (float)panelContentBitmap.Width;
            float scaleHeight = e.PageBounds.Height / (float)panelContentBitmap.Height;
            float scaleFactor = Math.Min(scaleWidth, scaleHeight);

            // Calculate the new width and height of the panel content based on the scaling factor
            int newWidth = (int)(panelContentBitmap.Width * scaleFactor);
            int newHeight = (int)(panelContentBitmap.Height * scaleFactor);

            // Center the scaled panel content on the A4 page
            int xPos = (e.PageBounds.Width - newWidth) / 2;
            int yPos = (e.PageBounds.Height - newHeight) / 2;

            // Draw the scaled panel content on the print page
            e.Graphics.DrawImage(panelContentBitmap, new Rectangle(xPos, yPos, newWidth, newHeight));

            // Clean up
            panelContentBitmap.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Display a PrintDialog to allow the user to choose a printer and configure settings
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the printer settings
                    printDocument1.PrinterSettings = printDialog.PrinterSettings;

                    // Start the printing process
                    printDocument1.Print();

                    //bill update as completed
                    con.ConnectionString = "Data Source=MALITH;Initial Catalog=Health_Care_Plus;User ID=sa;Password=123";
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE tblBills SET status='" + "completed" + "', date='" + DateTime.Now.ToShortDateString() + "' WHERE patient_id = '" + frmViewBills.patient_ID + "'";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult = DialogResult.OK;     
                    Close();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message);
            }
        }
    }
}
