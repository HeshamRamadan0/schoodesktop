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
    public partial class Update_student : UserControl
    {
        public Update_student()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string x = "UPDATE [School].[dbo].[Student] SET [schoo_Year] = @school_Year, [grade] = @grade, [Address] = @Address, [Email] = @Email, [phone_num] = @Phone_num, [Parent_num] = @Parent_num WHERE [Student_ID] = @ID;";
            SqlCommand cmd = new SqlCommand(x, con);
            cmd.Parameters.AddWithValue("@ID", Txt_STD_id.Text);
            cmd.Parameters.AddWithValue("@school_Year", txt_School_Year.Text);
            cmd.Parameters.AddWithValue("@grade", Txt_Grade.Text);
            cmd.Parameters.AddWithValue("@Address", Txt_Address.Text);
            cmd.Parameters.AddWithValue("@Email", txt_email.Text);
            cmd.Parameters.AddWithValue("@Phone_num", txt_Student_PH.Text);
            cmd.Parameters.AddWithValue("@Parent_num", Txt_parent_pn.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update successful");


        }

        private void Update_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
    string sqlQuery = "SELECT [Student_ID] FROM [School].[dbo].[Student] WHERE [Student_ID] = @Student_ID";
    SqlCommand cmd = new SqlCommand(sqlQuery, con);
    cmd.Parameters.AddWithValue("@Student_ID", Txt_STD_id.Text);
    con.Open();
    SqlDataReader reader = cmd.ExecuteReader();
    if (reader.HasRows)
    {
        Update_panel.Visible = true;
        Txt_STD_id.Visible = false;
        guna2Button1.Visible = false;
    }
    else
    {
        MessageBox.Show("Student ID not found.");
    }
    reader.Close();
    con.Close();
}

        private void Txt_STD_id_TextChanged(object sender, EventArgs e)
        {

        }

        }

       
    }

