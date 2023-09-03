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
using Guna.UI2.WinForms;


namespace APP.Student
{
    public partial class Student_ADD : UserControl
    {
        public Student_ADD()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {






        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void Seach_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {


        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void update_student1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=.");
            string idCheckQuery = "SELECT COUNT(*) FROM [School].[dbo].[Student] WHERE [Student_ID] = @Student_ID";

            SqlCommand idCheckCmd = new SqlCommand(idCheckQuery, con);
            idCheckCmd.Parameters.AddWithValue("@Student_ID", Txt_STD_id.Text);

            con.Open();

            int idCount = (int)idCheckCmd.ExecuteScalar();

            if (idCount > 0)
            {
                con.Close();
                MessageBox.Show("Student ID already exists. Please enter a unique ID.");
            }
            else
            {
                string x = "INSERT INTO [School].[dbo].[Student] ([Student_ID], [Student_Name], [schoo_Year], [grade], [gander], [BirthDay], [Address], [Email], [phone_num], [parent_num]) VALUES ('" + Txt_STD_id.Text + "', '" + Txt_Std_name.Text + "', '" + Txt_School_year.Text + "', '" + Comb_Grade.Text + "', '" + Comb_Gander.Text + "', '" + Txt_Birt_day.Text + "', '" + Txt_address.Text + "', '" + Txt_emil.Text + "', '" + Txt_phone.Text + "', '" + Txt_parNum.Text + "')";

                SqlCommand cmd = new SqlCommand(x, con);
                
                cmd.ExecuteNonQuery();
                con.Close();
                string message = "Student added successfully";
                string title = "Success";

                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Txt_STD_id.Clear();
            Txt_Std_name.Clear();
            Txt_address.Clear();
            Txt_parNum.Clear();
            Txt_phone.Clear();
            Txt_School_year.Clear();
            Txt_emil.Clear();
           

        }
    }
}


