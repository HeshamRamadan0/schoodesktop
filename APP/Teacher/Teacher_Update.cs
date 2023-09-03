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

namespace APP.Teacher
{
    public partial class Teacher_Update : UserControl
    {
        public Teacher_Update()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)

        {
            decimal teacherEvaluation = decimal.Round((decimal)Teaeva.Value, 2);
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string x = "UPDATE [School].[dbo].[Teacher] SET[Subject] =@Subject,[Salary] = @Salary,[address] =@address,[email] =@email,[Phone_num] =@Phone_num,[Evaluation] =@Evaluation WHERE[Teacher_id]=@Teacher_id";
            SqlCommand cmd = new SqlCommand(x, con);
            cmd.Parameters.AddWithValue("@Teacher_id", Txt_TecherID.Text);
            cmd.Parameters.AddWithValue("@Subject",Txt_Subject.Text);
            cmd.Parameters.AddWithValue("@Salary", Txt_salary.Text);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@Email",Txt_email.Text);
            cmd.Parameters.AddWithValue("@Phone_num", Txt_PhoneNum.Text);
            cmd.Parameters.AddWithValue("@Evaluation", teacherEvaluation);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update successful");

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

           SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
           string sqlQuery = "SELECT [Teacher_id]FROM [School].[dbo].[Teacher] Where [Teacher_id]=@Teacher_ID";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@Teacher_ID", Txt_TecherID.Text);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Teacher_Update_panel.Visible = true;
                Txt_TecherID.Visible = false;
                guna2Button3.Visible = false;
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
