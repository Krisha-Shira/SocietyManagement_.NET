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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashboardForm form2 = new DashboardForm();

            // Show Form3
            form2.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Example: Get data from TextBoxes on your form
            int salary = int.Parse(textBox1.Text);
            int eb = int.Parse(textBox2.Text);
            int wb = int.Parse(textBox3.Text);

            // ✅ Connection string — change according to your database
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=society;Integrated Security=True;Connect Timeout=30";

            // ✅ SQL INSERT query
            string query = "INSERT INTO account (salary, eb, wb) VALUES (@salary, @eb, @wb)";

            // ✅ Use SqlConnection and SqlCommand
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@salary", salary);
                        cmd.Parameters.AddWithValue("@eb", eb);
                        cmd.Parameters.AddWithValue("@wb", wb);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfully!");
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
    

