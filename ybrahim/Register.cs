using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Transactions;
// Import necessary namespaces for MySQL and Windows Forms functionality
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ybrahim
{
    public partial class Register : Form
    {
        // Define MySQL connection using XAMPP's phpMyAdmin database
        private MySqlConnection conn = new MySqlConnection("server=localhost;database=dbyb;username=root;password=;");
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void chShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowpass.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //Validate if all input are filled
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text) ||
                cmbCourse.SelectedIndex == -1 ||
                cmbSection.SelectedIndex == -1
                )
            {
                MessageBox.Show("All fields must be filled out", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM tblstudentinfo WHERE studentno = @StudentNo";
                MySqlCommand checkcmd = new MySqlCommand(checkQuery, conn);
                checkcmd.Parameters.AddWithValue("@StudentNo", txtusername.Text);
                int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Student No. already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtusername.Clear();
                    return;
                }
                //Insert student information into the database
                string registerquery = "INSERT INTO tblstudentinfo (studentno, lastname, firstname, middlename, birthdate, course, section)" +
                    "VALUES (@StudentNo, @Lastname, @Firstname, @Middlename, @Birthdate, @Course, @Section)";
                MySqlCommand cmd = new MySqlCommand(registerquery, conn);
                cmd.Parameters.AddWithValue("@StudentNo", txtusername.Text);
                cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text);
                cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@Middlename", txtMiddlename.Text);
                cmd.Parameters.AddWithValue("@Birthdate", birthday.Value);
                cmd.Parameters.AddWithValue("@Course", cmbCourse.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Section", cmbSection.SelectedItem.ToString());
                cmd.ExecuteNonQuery(); // Execute insert query

                string name = txtFirstname.Text + " " + txtLastname.Text;

                //Insert user credentials in the tblusers table
                string registeruser = "INSERT INTO tblusers (name, username, password, role) " +
                    "VALUES (@name, @username, @password, 'Student')";
                MySqlCommand cmd2 = new MySqlCommand(registeruser, conn);
                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.Parameters.AddWithValue("@username", txtusername.Text);
                cmd2.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd2.ExecuteNonQuery(); // Execute insert query

                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clear All inputs
                txtusername.Clear();
                txtLastname.Clear();
                txtFirstname.Clear();
                txtMiddlename.Clear();
                txtpassword.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.Items.Clear();


            }
            catch (Exception ex)
            {
                // Display error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close(); // Ensure database connection is closed after operation
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSection.Items.Clear();
            if (cmbCourse.SelectedIndex == 0)
            {
                cmbSection.Items.Add("ACT 1A");
                cmbSection.Items.Add("ACT 1B");
                cmbSection.Items.Add("ACT 1E");
            }
            else if (cmbCourse.SelectedIndex == 1)
            {
                cmbSection.Items.Add("HM 1A");
                cmbSection.Items.Add("HM 1B");
                cmbSection.Items.Add("HM 1E");
            }
            else if (cmbCourse.SelectedIndex == 2)
            {
                cmbSection.Items.Add("BSOA 1A");
                cmbSection.Items.Add("BSOA 1B");
                cmbSection.Items.Add("BSOA 1E");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Do you want to close the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void cmbCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // prevent user from typing in the combobox
        }

        private void cmbSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // prevent user from typing in the combobox
        }
    }
}
