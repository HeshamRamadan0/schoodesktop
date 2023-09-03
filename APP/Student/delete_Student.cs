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
    public partial class delete_Student : UserControl
    {
        public delete_Student()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string sqlQuery = "DELETE FROM [School].[dbo].[Student] WHERE [Student_ID] = @Student_ID";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@Student_ID", Txt_STD_id.Text);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Student record deleted.");
            }
            else
            {
                MessageBox.Show("Student ID not found.");
            }
            con.Close();
        }
    }
}
