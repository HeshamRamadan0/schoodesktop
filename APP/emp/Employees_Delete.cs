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
    public partial class Employees_Delete : UserControl
    {
        public Employees_Delete()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string sqlQuery = "SELECT [Employee_id],[Employee_Name],[Title],[salary],[gander],[birthday],[address],[email],[phone_num],[Evaluation] FROM [School].[dbo].[Employees] WHERE [Employee_id] = @Employee_id";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@Employee_id", txt_empID.Text);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                string deleteQuery = "DELETE FROM [School].[dbo].[Employees] WHERE [Employee_id] = @Employee_id";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                deleteCmd.Parameters.AddWithValue("@Employee_id", txt_empID.Text);
                deleteCmd.ExecuteNonQuery();
                MessageBox.Show("Employee record deleted.");
            }
            else
            {
                MessageBox.Show("Employee ID not found.");
            }
            con.Close();
        }
    }
}
