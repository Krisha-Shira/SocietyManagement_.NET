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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm form2 = new DashboardForm();

            // Show Form3
            form2.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            // Database connection string (same as before)
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=society;Integrated Security=True;Connect Timeout=30";

            // SQL UPDATE query
            string query = "UPDATE register " +
                           "SET mobileno = @mobileno, password = @password " +
                           "WHERE username = @username AND flatno = @flatno";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Use the same textboxes as in create_Click
                    cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@flatno", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@mobileno", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", textBox4.Text.Trim());

                    try
                    {
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("User details updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given Username and Flat No.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
