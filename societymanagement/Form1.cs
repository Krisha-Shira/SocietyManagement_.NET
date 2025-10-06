using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace societymanagement
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=society;Integrated Security=True;Connect Timeout=30";


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void login_Click(object sender, EventArgs e)
        //{
        //    // Create object of the next form
        //    DashboardForm dashboard = new DashboardForm();

        //    // Show the next form
        //    dashboard.Show();

        //    // Hide the current login form (optional)
        //    this.Hide();
        //}
        // ✅ Login button click event
        private void login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text; // Your username textbox
            string password = textBox2.Text; // Your password textbox

            // SQL query to check username and password
            string query = "SELECT COUNT(*) FROM register WHERE Username=@username AND Password=@password";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    con.Open();
                    int result = (int)cmd.ExecuteScalar(); // returns count of matching users

                    if (result > 0)
                    {
                        // Login successful, open Dashboard
                        DashboardForm dashboard = new DashboardForm();
                        dashboard.FormClosed += (s, args) => this.Close();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form0 form7 = new Form0();

            // Show Form3
            form7.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
