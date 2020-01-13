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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddemp_Click(object sender, EventArgs e)
        {
            AddEmp ae = new AddEmp();
            ae.Show();
        }

        private void btnMarkAtt_Click(object sender, EventArgs e)
        {
            MarkAttendance ma = new MarkAttendance();
            ma.Show();
        }

        private void btnViewAtt_Click(object sender, EventArgs e)
        {
            ViewAttendance av = new ViewAttendance();
            av.Show();
        }
    }
}
