using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceMngmt
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSigIn_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "admin" && tbPassword.Text == "adminpass123")
            {
                Dashboard db = new Dashboard();
                MessageBox.Show("Welcome!");
                db.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials entered. Please try again");
            }
        }
    }
}
