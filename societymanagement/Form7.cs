//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace societymanagement
//{
//    public partial class Form0 : Form
//    {
//        public Form0()
//        {
//            InitializeComponent();
//        }

//        private void create_Click(object sender, EventArgs e)
//        {
//            // Your existing code for create button
//        }

//        private void btnLogin_Click(object sender, EventArgs e)
//        {
//            // Optionally validate Username & Password here before proceeding

//            Form1 login = new Form1(); // create Form2 object
//            login.Show();              // show Form2
//            this.Hide();                   // hide the login form (Form7)
//        }

//        private void login_Click(object sender, EventArgs e)
//        {
//            Form1 form1 = new Form1();

//            // Show Form3
//            form1.Show();

//            // Hide the current form (optional)
//            this.Hide();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;  // Add this for database operations
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace societymanagement
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=society;Integrated Security=True;Connect Timeout=30";

            string query = "INSERT INTO register (username, flatno, mobileno, password) " +
                           "VALUES (@username, @flatno, @mobileno, @password)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@flatno", textBox2.Text);
                    cmd.Parameters.AddWithValue("@mobileno", textBox3.Text);
                    cmd.Parameters.AddWithValue("@password", textBox4.Text);

                    try
                    {
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("User created successfully!");
                        else
                            MessageBox.Show("Creation failed.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

