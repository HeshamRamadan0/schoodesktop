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
    public partial class Employee_Update : UserControl
    {
        public Employee_Update()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string sqlQuery = "SELECT [Employee_id] FROM [School].[dbo].[Employees]Where[Employee_id] =@Employee_id";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@Employee_id", Txt_empID.Text);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
               EmpUpdate_panel.Visible = true;
               Txt_empID.Visible = false;
                guna2Button3.Visible = false;
                label2.Visible = false;
            }
            else
            {
                MessageBox.Show("Teacher ID not found.");
            }
            reader.Close();
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            decimal EMployeeEvaluation = decimal.Round((decimal)EMPRatingStar.Value, 2);
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string x = "UPDATE [School].[dbo].[Employees]SET [Title] = @Title,[salary] =@salary,[address] =@address,[email] = @email,[phone_num] =@phone_num,[Evaluation] =@Evaluation WHERE [Employee_id]=@Employee_id";
            SqlCommand cmd = new SqlCommand(x, con);
            cmd.Parameters.AddWithValue("@Employee_id", Txt_empID.Text);
            cmd.Parameters.AddWithValue("@Title", txt_Title.Text);
            cmd.Parameters.AddWithValue("@Salary", Txt_salary.Text);
            cmd.Parameters.AddWithValue("@Address", txt_empAddress.Text);
            cmd.Parameters.AddWithValue("@Email", Txt_empMail.Text);
            cmd.Parameters.AddWithValue("@Phone_num",Txt_empPnum.Text);
            cmd.Parameters.AddWithValue("@Evaluation", EMployeeEvaluation);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update successful");
        }
    }
}
