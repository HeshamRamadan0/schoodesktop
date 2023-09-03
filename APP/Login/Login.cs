using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APP.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
             Txt_ID.Clear();
            Txt_Pass.Clear();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
{
    
    string id = Txt_ID.Text;
    string password = Txt_Pass.Text;

   
    string x = "SELECT COUNT(*) FROM Login WHERE ID=@id AND Password=@password";

   
    using (SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=School;Data Source=."))
    {
        
        con.Open();

        
        using (SqlCommand cmd = new SqlCommand(x, con))
        {
            
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", password);

            
            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {

                Main_Menu m = new Main_Menu();
                m.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Invalid ID or Password!");
            }
        }
    }
}




        }

        private void Txt_ID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Txt_Pass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
