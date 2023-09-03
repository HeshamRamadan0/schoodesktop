using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APP.emp
{
    public partial class Employee_Search : UserControl
    {
        public Employee_Search()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string sqlQuery = "SELECT [Employee_id],[Employee_Name],[Title],[salary],[gander],[birthday],[address],[email],[phone_num],[Evaluation]FROM [School].[dbo].[Employees]Where [Employee_id]=@Employee_id";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@Employee_id", txt_empID.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.ColumnHeadersVisible = true;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataShow_panel.Visible = true;
                txt_empID.Visible = false;
                guna2Button1.Visible = false;

            }
            else
            {
                MessageBox.Show("Student ID not found.");
            }
            reader.Close();
            con.Close();
        }
    }
}
