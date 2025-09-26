using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // Your existing code for create button
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Optionally validate Username & Password here before proceeding

            Form1 login = new Form1(); // create Form2 object
            login.Show();              // show Form2
            this.Hide();                   // hide the login form (Form7)
        }

        private void login_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Show Form3
            form1.Show();

            // Hide the current form (optional)
            this.Hide();
        }
    }
}
