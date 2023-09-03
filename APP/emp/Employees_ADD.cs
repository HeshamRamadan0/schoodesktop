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
    public partial class Employees_ADD : UserControl
    {
        public Employees_ADD()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string idCheckQuery = "SELECT COUNT(*) FROM [School].[dbo].[Employees] WHERE [Employee_id] = @Employee_id";

            SqlCommand idCheckCmd = new SqlCommand(idCheckQuery, con);
            idCheckCmd.Parameters.AddWithValue("Employee_id", Txt_empID.Text);

            con.Open();

            int idCount = (int)idCheckCmd.ExecuteScalar();

            if (idCount > 0)
            {
                con.Close();
                MessageBox.Show("Teatcher ID already exists. Please enter a unique ID.");
            }
            else
            {
            decimal EMployeeEvaluation = decimal.Round((decimal)EMPRatingStar.Value, 2);
            string x = "INSERT INTO [School].[dbo].[Employees]([Employee_id],[Employee_Name],[Title],[salary],[gander],[birthday],[address],[email],[phone_num] ,[Evaluation])VALUES('" + Txt_empID.Text+ "', '" + Txt_empName.Text + "', '" + Txt_empTitle.Text + "', '" + Txt_empSalary.Text + "', '" + Comb_Gander.SelectedValue+ "', '" + dt_empBD.Text + "', '" + Txt_empAddress.Text + "', '" + Txt_empMail.Text + "', '" + Txt_empPN.Text+ "', '" + EMployeeEvaluation + "')";


            SqlCommand cmd = new SqlCommand(x, con);
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Employee added successfully...");
        }
    }
}
    }
