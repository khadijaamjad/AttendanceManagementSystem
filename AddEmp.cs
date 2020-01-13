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
    public partial class AddEmp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=AttendanceMngmt;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;
        public AddEmp()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            string qu = "Insert into Employees (Emp_Fname,Emp_Lname,Emp_Dept,Emp_Designation) values ('" + tbFname.Text + "','" + tbLname.Text + "','" + ddDept.selectedValue.ToString() + "','" + ddDesignation.selectedValue.ToString() + "')";
            cmd = new SqlCommand(qu, con);
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
               MessageBox.Show("Error occured, try again."); 
            }
            else
            { MessageBox.Show("Employee Added!"); }
            con.Close();
        }
    }
}
