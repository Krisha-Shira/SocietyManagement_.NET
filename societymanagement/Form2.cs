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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();

            // Show Form3
            form6.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void notice_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            // Show Form3
            form3.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void main_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            // Show Form3
            form4.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void account_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            // Show Form3
            form5.Show();

            // Hide the current form (optional)
            this.Hide();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();

            // Show Form3
            form8.Show();

            // Hide the current form (optional)
            this.Hide();
        }
    }
}
