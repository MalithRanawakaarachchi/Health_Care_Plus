using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using Health_Care_Plus_00174336;

namespace Health_Care_Plus_00174336.Classes
{
    public class Employee
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string id_type { get; set; }
        public string id_no { get; set; }
        public int position_id { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string home { get; set; }
        public string password { get; set; }
        public string position { get; set; }
    }

    public class manageEmployees
    {
        private string connectionString = "Data Source=MALITH;Initial Catalog = Health_Care_Plus; Persist Security Info=True;User ID = sa; Password=123";

        public int GetPositionIdByName(string selectedPosition)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT id FROM tblStaffPositions WHERE position = @position";
                    cmd.Parameters.AddWithValue("@position", selectedPosition);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions here
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            // Return a default value (e.g., -1) or throw an exception if the position is not found.
            return -1; // You can choose an appropriate default value.
        }

        public void AddEmployee(Employee Employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tblEmployees (first_name, last_name, address, id_type, id_no, position_id, dob, gender, email, mobile, home, password) VALUES (@first_name, @last_name, @address, @id_type, @id_no, @position_id, @dob, @gender, @email, @mobile, @home, @password)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@first_name", Employee.first_name);
                    cmd.Parameters.AddWithValue("@last_name", Employee.last_name);
                    cmd.Parameters.AddWithValue("@address", Employee.address);
                    cmd.Parameters.AddWithValue("@id_type", Employee.id_type);
                    cmd.Parameters.AddWithValue("@id_no", Employee.id_no);
                    cmd.Parameters.AddWithValue("@position_id", Employee.position_id);
                    cmd.Parameters.AddWithValue("@dob", Employee.dob);
                    cmd.Parameters.AddWithValue("@gender", Employee.gender);
                    cmd.Parameters.AddWithValue("@email", Employee.email);
                    cmd.Parameters.AddWithValue("@mobile", Employee.mobile);
                    cmd.Parameters.AddWithValue("@home", Employee.home);
                    cmd.Parameters.AddWithValue("@password", Employee.password);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Employee has been saved successfully");
                }
            }
        }

        // all employees
        public void LoadEmployees(ListBox listBox)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblEmployees", con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblEmployees");

                    foreach (DataRow row in ds.Tables["tblEmployees"].Rows)
                    {
                        string fname = row["first_name"].ToString();
                        string lname = row["last_name"].ToString();
                        string fullname = fname + " " + lname;
                        listBox.Items.Add(fullname);
                    }

                    ds.Tables["tblEmployees"].Clear();
                }

            }
        }

        //search employees
        public void SearchEmployes(ListBox listBox, string searchText)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblEmployees WHERE first_name + ' ' + last_name LIKE @SearchText", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblEmployees");

                    // Clear the list box before adding search results
                    listBox.Items.Clear();

                    foreach (DataRow row in ds.Tables["tblEmployees"].Rows)
                    {
                        string fname = row["first_name"].ToString();
                        string lname = row["last_name"].ToString();
                        string fullname = fname + " " + lname;
                        listBox.Items.Add(fullname);
                    }

                    ds.Tables["tblEmployees"].Clear();
                }
            }
        }

        // get employees by listbox name
        public Employee GetEmployeeByName(string selectedName)
        {
            
            string[] nameParts = selectedName.Split(' '); // Split the selected name into first_name and last_name parts

            string firstName = nameParts[0]; // Extract the first_name part
            string lastName = nameParts[1]; // Extract the last_name part

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT tblEmployees.id,tblEmployees.first_name,tblEmployees.last_name,tblEmployees.address,tblEmployees.id_type,tblEmployees.id_no, tblStaffPositions.position, tblEmployees.dob,tblEmployees.gender,tblEmployees.email,tblEmployees.mobile,tblEmployees.home,tblEmployees.password FROM tblEmployees INNER JOIN tblStaffPositions ON tblEmployees.position_id = tblStaffPositions.id WHERE first_name = @firstName AND last_name = @lastName", con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@firstName", firstName);
                    da.SelectCommand.Parameters.AddWithValue("@lastName", lastName);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblEmployees");



                    if (ds.Tables["tblEmployees"].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables["tblEmployees"].Rows[0];
                        Employee employee = new Employee
                        {
                           
                            id = Convert.ToInt32(row["id"]),
                            first_name = row["first_name"].ToString(),
                            last_name = row["last_name"].ToString(),
                            address = row["address"].ToString(),
                            id_type = row["id_type"].ToString(),
                            id_no = row["id_no"].ToString(),
                            position = row["position"].ToString(),
                            dob = row["dob"].ToString(),
                            gender = row["gender"].ToString(),
                            email = row["email"].ToString(),
                            mobile = row["mobile"].ToString(),
                            home = row["home"].ToString(),
                        };

                        return employee;
                    }
                    ds.Tables["tblEmployees"].Clear();
                }
            }

            return null; // Employee not found
        }

        //update employees
        public void UpdateEmployeeById(int id, Employee updatedEmployee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (string.IsNullOrWhiteSpace(updatedEmployee.password))
                {
                    string query = "UPDATE tblEmployees SET first_name = @first_name, last_name = @last_name, address = @address, id_type = @id_type, id_no = @id_no, position_id = @position_id, dob = @dob, gender = @gender, email = @email, mobile = @mobile , home = @home WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@first_name", updatedEmployee.first_name);
                        cmd.Parameters.AddWithValue("@last_name", updatedEmployee.last_name);
                        cmd.Parameters.AddWithValue("@address", updatedEmployee.address);
                        cmd.Parameters.AddWithValue("@id_type", updatedEmployee.id_type);
                        cmd.Parameters.AddWithValue("@id_no", updatedEmployee.id_no);
                        cmd.Parameters.AddWithValue("@position_id", updatedEmployee.position_id);
                        cmd.Parameters.AddWithValue("@dob", updatedEmployee.dob);
                        cmd.Parameters.AddWithValue("@gender", updatedEmployee.gender);
                        cmd.Parameters.AddWithValue("@email", updatedEmployee.email);
                        cmd.Parameters.AddWithValue("@mobile", updatedEmployee.mobile);
                        cmd.Parameters.AddWithValue("@home", updatedEmployee.home);
                        

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Employees's Details updated successfully");
                    }
                }
                else
                {
                    string query = "UPDATE tblEmployees SET first_name = @first_name, last_name = @last_name, address = @address, id_type = @id_type, id_no = @id_no, position_id = @position_id, dob = @dob, gender = @gender, email = @email, mobile = @mobile, password = @password WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@first_name", updatedEmployee.first_name);
                        cmd.Parameters.AddWithValue("@last_name", updatedEmployee.last_name);
                        cmd.Parameters.AddWithValue("@address", updatedEmployee.address);
                        cmd.Parameters.AddWithValue("@id_type", updatedEmployee.id_type);
                        cmd.Parameters.AddWithValue("@id_no", updatedEmployee.id_no);
                        cmd.Parameters.AddWithValue("@position_id", updatedEmployee.position_id);
                        cmd.Parameters.AddWithValue("@dob", updatedEmployee.dob);
                        cmd.Parameters.AddWithValue("@gender", updatedEmployee.gender);
                        cmd.Parameters.AddWithValue("@email", updatedEmployee.email);
                        cmd.Parameters.AddWithValue("@mobile", updatedEmployee.mobile);
                        cmd.Parameters.AddWithValue("@home", updatedEmployee.home);
                        cmd.Parameters.AddWithValue("@password", updatedEmployee.password);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Employees's Details updated successfully");
                    }
                }
            }
        }

        //delete employees
        public void DelteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE tblEmployees WHERE id = @EmployeeId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Employee has been removed Successfully");
                }
            }
        }
    }
}

