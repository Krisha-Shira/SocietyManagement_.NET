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
    public partial class Form6 : Form
    {
        public Form6()
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

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string flatn = textBox2.Text.Trim();
            string mobilen = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(flatn) || string.IsNullOrEmpty(mobilen))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            bool success = AddMembersToDatabase(name, flatn, mobilen);

            if (success)
            {
                MessageBox.Show("Member added successfully!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add member.");
            }
        }

        private bool AddMembersToDatabase(string name, string flatn, string mobilen)
        {
            // Replace with your actual SQL Server details
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=society;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO members ([name], [flatn], [mobilen]) VALUES (@Name, @Flatn, @Mobilen)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Convert name to bytes for VARBINARY
                        byte[] nameBytes = Encoding.UTF8.GetBytes(name);
                        cmd.Parameters.AddWithValue("@Name", nameBytes);

                        // Pad flat and mobile to 10 characters (NCHAR(10))
                        cmd.Parameters.AddWithValue("@Flatn", flatn.PadRight(10));
                        cmd.Parameters.AddWithValue("@Mobilen", mobilen.PadRight(10));

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

        private void update_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim(); // TextBox where user enters name

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the name to delete.");
                return;
            }

            bool success = DeleteMemberByName(name);

            if (success)
            {
                MessageBox.Show("Member deleted successfully!");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete member. Name may not exist.");
            }
        }

        private bool DeleteMemberByName(string name)
        {
            // Replace with your actual SQL Server info
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=society;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM members WHERE [name] = @Name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Convert name to bytes for VARBINARY
                        byte[] nameBytes = Encoding.UTF8.GetBytes(name);
                        cmd.Parameters.AddWithValue("@Name", nameBytes);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // true if any row deleted
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }
    }
}
//using System;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace societymanagement
//{
//    public partial class Form6 : Form
//    {
//        public Form6()
//        {
//            InitializeComponent();
//        }

//        // Navigate to Dashboard
//        private void button1_Click(object sender, EventArgs e)
//        {
//            DashboardForm form2 = new DashboardForm();
//            form2.Show();
//            this.Hide();
//        }

//        // Add Member
//        private void button2_Click(object sender, EventArgs e)
//        {
//            string name = textBox1.Text.Trim();
//            string flat = textBox2.Text.Trim();
//            string mobile = textBox3.Text.Trim();

//            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(flat) || string.IsNullOrEmpty(mobile))
//            {
//                MessageBox.Show("Please fill all the fields.");
//                return;
//            }

//            bool success = AddMemberToDatabase(name, flat, mobile);

//            if (success)
//            {
//                MessageBox.Show("Member added successfully!");
//                textBox1.Clear();
//                textBox2.Clear();
//                textBox3.Clear();
//            }
//            else
//            {
//                MessageBox.Show("Failed to add member.");
//            }
//        }

//        private bool AddMemberToDatabase(string name, string flatn, string mobilen)
//        {
//            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=society;Integrated Security=True;Connect Timeout=30";

//            try
//            {
//                using (SqlConnection conn = new SqlConnection(connectionString))
//                {
//                    conn.Open();
//                    string query = "INSERT INTO members ([name], [flat], [mobile]) VALUES (@Name, @Flatn, @Mobilen)";
//                    using (SqlCommand cmd = new SqlCommand(query, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@Name", name);
//                        cmd.Parameters.AddWithValue("@Flatn", flatn);
//                        cmd.Parameters.AddWithValue("@Mobilen", mobilen);

//                        cmd.ExecuteNonQuery();
//                    }
//                }
//                return true;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Database Error: " + ex.Message);
//                return false;
//            }
//        }

//        // Delete Member
//        private void update_Click(object sender, EventArgs e)
//        {
//            string name = textBox1.Text.Trim(); // Delete based on Name

//            if (string.IsNullOrEmpty(name))
//            {
//                MessageBox.Show("Please enter the name to delete.");
//                return;
//            }

//            bool success = DeleteMemberByName(name);

//            if (success)
//            {
//                MessageBox.Show("Member deleted successfully!");
//                textBox1.Clear();
//                textBox2.Clear();
//                textBox3.Clear();
//            }
//            else
//            {
//                MessageBox.Show("Failed to delete member. Name may not exist.");
//            }
//        }

//        private bool DeleteMemberByName(string name)
//        {
//            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=society;Integrated Security=True;Connect Timeout=30";

//            try
//            {
//                using (SqlConnection conn = new SqlConnection(connectionString))
//                {
//                    conn.Open();
//                    string query = "DELETE FROM members WHERE [name] = @Name";
//                    using (SqlCommand cmd = new SqlCommand(query, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@Name", name);
//                        int rowsAffected = cmd.ExecuteNonQuery();
//                        return rowsAffected > 0;
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Database Error: " + ex.Message);
//                return false;
//            }
//        }
//    }
//}


