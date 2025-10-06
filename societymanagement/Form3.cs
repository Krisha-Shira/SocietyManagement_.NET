using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace societymanagement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm form2 = new DashboardForm();

            // Show Form3
            form2.Show();

            // Hide the current form (optional)
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            // Show Form3
            form3.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            // Show Form3
            form4.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            // Show Form3
            form5.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();

            // Show Form3
            form6.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DashboardForm form2 = new DashboardForm();

            // Show Form3
            form2.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DashboardForm form2 = new DashboardForm();

            // Show Form3
            form2.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void send_Click(object sender, EventArgs e)
        {
          
                string notice = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(notice))
                {
                    bool success = SaveNoticeToDatabase(notice);

                    if (success)
                    {
                        MessageBox.Show("Notice sent successfully!");
                        textBox1.Clear(); // Clear textbox after sending
                    }
                    else
                    {
                        MessageBox.Show("Failed to send notice.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a notice.");
                }
            }

        // Function to save notice to database
        private bool SaveNoticeToDatabase(string notice)
        {
            // Replace these with your actual server name and database name
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=society;Integrated Security=True;Connect Timeout=30";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO notice (notice) VALUES (@notice)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@notice", notice);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }
    }

}
    

