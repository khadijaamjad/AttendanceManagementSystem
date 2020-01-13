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
using System.Data.Sql;

namespace AttendanceMngmt
{
    public partial class ViewAttendance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=AttendanceMngmt;Integrated Security=True");
        SqlCommand cmd;
        public ViewAttendance()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ddDept_onItemSelected(object sender, EventArgs e)
        {
            
            }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
        
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            int option = ddOption.selectedIndex;
            string str;
            if (option == 0)
            {
                str = "SELECT * FROM Attendance WHERE EmpID ='" + tbVal.Text + "'";
                cmd = new SqlCommand(str, con);
            }
            if (option == 1)
            {
                str = "SELECT * FROM Attendance WHERE EmpID IN (Select EmpID from Employees WHERE Emp_Dept='" + tbVal.Text + "')";
                cmd = new SqlCommand(str, con);
            }
            if (option == 2)
            {
                str = "SELECT * FROM Attendance WHERE EmpID IN (Select EmpID from Employees WHERE Emp_Designation='" + tbVal.Text + "')";
                cmd = new SqlCommand(str, con);
            }
            if (option == 3)
            {
                tbVal.Hide();
                str = "SELECT * FROM Attendance Order by AttendanceDate";
                cmd = new SqlCommand(str, con);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAttendance.DataSource = dt;
            dgvAttendance.Columns[0].HeaderText = "EmployeeID";
            dgvAttendance.Columns[1].HeaderText = "Status";
            dgvAttendance.Columns[2].HeaderText = "Date";
        }
        }
    }

