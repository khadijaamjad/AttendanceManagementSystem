using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AttendanceMngmt
{
    public partial class MarkAttendance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=AttendanceMngmt;Integrated Security=True");
        SqlCommand cmd;
        public MarkAttendance()
        {
            InitializeComponent();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            lblAns.Text="";
            string q = "SELECT * FROM Employees where EmpID="+Convert.ToInt32(tbID.Text);
            cmd = new SqlCommand(q, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            lblfn.Text=dt.Tables[0].Rows[0]["Emp_Fname"].ToString();
            lblLname.Text=dt.Tables[0].Rows[0]["Emp_Lname"].ToString();
            lblDept.Text=dt.Tables[0].Rows[0]["Emp_Dept"].ToString();
            lblDesignation.Text=dt.Tables[0].Rows[0]["Emp_Designation"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM Attendance where EmpID=" + Convert.ToInt32(tbID.Text)+" AND AttendanceDate=Convert(Date,GetDate())";
            cmd = new SqlCommand(q, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            if (dt.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Employee's attendance has been marked for today.");
            }
            else
            {
                string status = "Absent";
                if (rbAbsent.Checked == true)
                {
                    status = "Absent";
                }
                if (rbPresent.Checked == true)
                {
                    status = "Present";
                }
                if (rbHalf.Checked == true)
                {
                    status = "HalfDay";
                }
                con.Open();
                string str = "Insert into Attendance values(" + tbID.Text + ",'" + status + "', GetDate())";
                cmd = new SqlCommand(str, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblAns.Text = " " + lblfn.Text + "'s attendance not marked due to some error";
                }
                else
                {
                    lblAns.Text = " " + lblfn.Text + "'s attendance marked ";
                }
                con.Close();
            }

            
        }

        private void MarkAttendance_Load(object sender, EventArgs e)
        {
            rbAbsent.Checked=true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

