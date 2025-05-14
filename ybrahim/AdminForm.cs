using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ybrahim
{
    public partial class AdminForm : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;database=dbyb;username=root;password=;"); //Change database name
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Call the private function showall student
            showallstudent();
            label1.Text = "Welcome";

        }
        private void showallstudent()
        {
            try
            {
                // Open the database connection
                conn.Open();

                // SQL query to select all records from the 'tblstudentinfo' table, ordered by ID in ascending order
                string showallrecordquery = "SELECT * FROM tblstudentinfo ORDER BY ID ASC";

                // Create a MySqlCommand to execute the query
                MySqlCommand command = new MySqlCommand(showallrecordquery, conn);

                // Create a data adapter to fetch the data using the command
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to hold the fetched data
                DataTable dt = new DataTable();

                // Fill the DataTable with data from the database
                adapter.Fill(dt);

                // Display the data in the DataGridView control on the form
                dataGridView1.DataSource = dt;

                // Set user-friendly column headers for the DataGridView
                dataGridView1.Columns["id"].HeaderText = "No.";
                dataGridView1.Columns["studentno"].HeaderText = "Student No.";
                dataGridView1.Columns["lastname"].HeaderText = "Lastname";
                dataGridView1.Columns["firstname"].HeaderText = "Firstname";
                dataGridView1.Columns["middlename"].HeaderText = "Middlename";
                dataGridView1.Columns["birthdate"].HeaderText = "Birthdate";
                dataGridView1.Columns["course"].HeaderText = "Course";
                dataGridView1.Columns["section"].HeaderText = "Section";
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Always close the connection if it is open
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the text entered in the search box
                string search = textBox2.Text;

                // Open the database connection
                conn.Open();

                // SQL query to find records where student number, last name, or first name matches the search term
                string showallrecordquery = "SELECT * FROM tblstudentinfo WHERE studentno LIKE @search OR lastname LIKE @search OR firstname LIKE @search";

                // Create a command to run the SQL query
                MySqlCommand command = new MySqlCommand(showallrecordquery, conn);

                // Add the search term to the query using a parameter with wildcards for partial matches
                command.Parameters.AddWithValue("@search", "%" + search + "%");

                // Use a data adapter to get the results of the query
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Create a DataTable to store the results
                DataTable dt = new DataTable();

                // Fill the DataTable with data from the query
                adapter.Fill(dt);

                // Display the data in the DataGridView on the form
                dataGridView1.DataSource = dt;

                // Set readable column headers for the displayed data
                dataGridView1.Columns["id"].HeaderText = "No.";
                dataGridView1.Columns["studentno"].HeaderText = "Student No.";
                dataGridView1.Columns["lastname"].HeaderText = "Lastname";
                dataGridView1.Columns["firstname"].HeaderText = "Firstname";
                dataGridView1.Columns["middlename"].HeaderText = "Middlename";
                dataGridView1.Columns["birthdate"].HeaderText = "Birthdate";
                dataGridView1.Columns["course"].HeaderText = "Course";
                dataGridView1.Columns["section"].HeaderText = "Section";
            }
            catch (Exception ex)
            {
                // Show a message if an error occurs
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection if it's still open

                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtId.Text = row.Cells["id"].Value.ToString();
                txtStudentNo.Text = row.Cells["studentno"].Value.ToString();
                txtLastname.Text = row.Cells["lastname"].Value.ToString();
                txtFirstname.Text = row.Cells["firstname"].Value.ToString();
                txtMiddlename.Text = row.Cells["middlename"].Value.ToString();
                cmbCourse.Text = row.Cells["course"].Value.ToString();
                cmbSection.Text = row.Cells["section"].Value.ToString();

                // Parse the birthdate
                if (DateTime.TryParse(row.Cells["birthdate"].Value.ToString(), out DateTime datebirthdate))
                {
                    birthdate.Value = datebirthdate;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before updating the record
            DialogResult confirm = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Validate if student number is filled
                if (string.IsNullOrWhiteSpace(txtStudentNo.Text))
                {
                    MessageBox.Show("Please select a student record to update.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Open the database connection
                    conn.Open();

                    // Get the values from the form
                    string StudentNo = txtStudentNo.Text;
                    string Firstname = txtFirstname.Text;
                    string Lastname = txtLastname.Text;
                    string MiddleName = txtMiddlename.Text;

                    // Ensure the correct date format MONTH DAY YEAR
                    string Birthdate = birthdate.Value.ToString("MM dd, yyyy");

                    string Course = cmbCourse.Text;
                    string Section = cmbSection.Text;

                    // Update query for tblstudentinfo
                    string updatestudentinfo = @"UPDATE tblstudentinfo 
                          SET firstname = @Firstname, lastname = @Lastname, middlename = @MiddleName,
                              birthdate = @Birthdate, course = @Course, section = @Section
                          WHERE studentno = @StudentNo";
                    MySqlCommand cmd1 = new MySqlCommand(updatestudentinfo, conn);
                    cmd1.Parameters.AddWithValue("@Firstname", Firstname);
                    cmd1.Parameters.AddWithValue("@Lastname", Lastname);
                    cmd1.Parameters.AddWithValue("@MiddleName", MiddleName);
                    cmd1.Parameters.AddWithValue("@Birthdate", Birthdate);
                    cmd1.Parameters.AddWithValue("@Course", Course);
                    cmd1.Parameters.AddWithValue("@Section", Section);
                    cmd1.Parameters.AddWithValue("@StudentNo", StudentNo);
                    cmd1.ExecuteNonQuery(); // Execute the update

                    // Update the name in the users table
                    string Name = Firstname + " " + Lastname;

                    string updateuser = @"UPDATE tblusers
                  SET name = @Name
                  WHERE username = @StudentNo";
                    MySqlCommand cmd2 = new MySqlCommand(updateuser, conn);
                    cmd2.Parameters.AddWithValue("@Name", Name);
                    cmd2.Parameters.AddWithValue("@StudentNo", StudentNo); // Ensure the parameter is added for username
                    int result = cmd2.ExecuteNonQuery(); // Execute the update and get affected rows

                    // Check if records were updated
                    if (result > 0)
                    {
                        // Show success message
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Clear all fields
                    txtFirstname.Clear();
                    txtId.Clear();
                    txtLastname.Clear();
                    txtMiddlename.Clear();
                    txtpassword.Clear();
                    txtStudentNo.Clear();
                    textBox2.Clear();
                    cmbCourse.SelectedIndex = -1;  // Clear the course selection
                    cmbSection.SelectedIndex = -1; // Clear the section selection
                    birthdate.Value = DateTime.Today; // Reset the birthdate picker

                    // Refresh DataGridView or call showallstudent function to update displayed data
                    conn.Close();
                    showallstudent();
                }
                catch (Exception ex)
                {
                    // Show error message if something goes wrong
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before deleting the record
            DialogResult close = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms "Yes"
            if (close == DialogResult.Yes)
            {
                // Check if Student Number textbox is empty
                if (string.IsNullOrWhiteSpace(txtStudentNo.Text))
                {
                    MessageBox.Show("Please Select Student Record to delete", "Select Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop the deletion process if no student number is provided
                }

                try
                {
                    // Open the database connection
                    conn.Open();

                    // Get the student number from the textbox
                    string StudentNo = txtStudentNo.Text;

                    // Prepare the SQL query to delete the student from tblstudentinfo
                    string deletestudentinfo = "DELETE FROM tblstudentinfo WHERE studentno = @StudentNo";
                    MySqlCommand studentinfocmd = new MySqlCommand(deletestudentinfo, conn);
                    studentinfocmd.Parameters.AddWithValue("@StudentNo", StudentNo); // Set the parameter value
                    studentinfocmd.ExecuteNonQuery(); // Execute the DELETE command

                    // Prepare the SQL query to delete the user from users table
                    string deleteuser = "DELETE FROM tblusers WHERE username = @StudentNo";
                    MySqlCommand usercmd = new MySqlCommand(deleteuser, conn);
                    usercmd.Parameters.AddWithValue("@StudentNo", StudentNo); // Set the parameter value
                    int result = usercmd.ExecuteNonQuery(); // Execute and get number of affected rows

                    // Check if any record was deleted from users table
                    if (result > 0)
                    {
                        // Show success message
                        MessageBox.Show("Deleted Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear all input fields
                        txtFirstname.Clear();
                        txtId.Clear();
                        txtLastname.Clear();
                        txtMiddlename.Clear();
                        txtpassword.Clear();
                        txtStudentNo.Clear();
                        textBox2.Clear();

                        // Close the connection
                        conn.Close();

                        // Refresh the student list in DataGridView
                        showallstudent();
                    }
                    else
                    {
                        // If no matching record found in users table
                        MessageBox.Show("No Record Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    // Show error if something went wrong during deletion
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Make sure the connection is closed even if an error occurs
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
    }
}
