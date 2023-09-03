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


namespace APP.Student
{
    public partial class student_Search : UserControl
    {
        public student_Search()
        {
            InitializeComponent();
        }

        private void DataShow_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string sqlQuery = "SELECT [Student_ID],[Student_Name],[schoo_Year],[grade],[gander],[BirthDay],[Address],[Email],[phone_num],[parent_num]FROM [School].[dbo].[Student] Where[Student_ID]=@Student_id";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@Student_ID", Txt_STD_id.Text);
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
                Txt_STD_id.Visible = false;
                guna2Button6.Visible = false;

            }
            else
            {
                MessageBox.Show("Student ID not found.");
            }
            reader.Close();
            con.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
