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
    public partial class Teacher_ADD : UserControl
    {
        public Teacher_ADD()
        {
            InitializeComponent();
        }

        private void ADD_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string idCheckQuery = "SELECT COUNT(*) FROM [School].[dbo].[Teacher] WHERE [Teacher_id] = @Teacher_id";

            SqlCommand idCheckCmd = new SqlCommand(idCheckQuery, con);
            idCheckCmd.Parameters.AddWithValue("@Teacher_id", Txt_TeaID.Text);

            con.Open();

            int idCount = (int)idCheckCmd.ExecuteScalar();

            if (idCount > 0)
            {
                con.Close();
                MessageBox.Show("Teatcher ID already exists. Please enter a unique ID.");
            }
            else
            {
                decimal teacherEvaluation = decimal.Round((decimal)teaeva.Value, 2);

                string x = "INSERT INTO [School].[dbo].[Teacher]([Teacher_id],[Teacher_name],[Subject],[Salary],[Gander],[BirthDay],[address],[email],[Phone_num],[Evaluation])VALUES ('" + Txt_TeaID.Text + "', '" + Txt_TeaName.Text + "', '" + Txt_TeaSub.Text + "', '" + Txt_teaSalary.Text + "', '" + Comb_Gander.SelectedValue + "', '" + dt_TeaBDate.Text + "', '" + Txt_teaAddress.Text + "', '" + Txt_teaMail.Text + "', '" + Txt_pn.Text + "', '" + teacherEvaluation + "')";


                SqlCommand cmd = new SqlCommand(x, con);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Teacher added successfully...");
            }
        }
    }
}

