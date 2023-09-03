using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.DashBoard
{
    public partial class dashView : Form
    {
        public dashView()
        {
            InitializeComponent();
        }

        private void dashView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StudentDASh.Visible = true;
            TeaDash.Visible = false;
            EmplDash.Visible = false;
        } 

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TeaDash.Visible = true;
            StudentDASh.Visible = false;
            EmplDash.Visible = false;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            EmplDash.Visible = true;
            StudentDASh.Visible = false;
            TeaDash.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Main_Menu n1 = new Main_Menu();
            n1.Show();
            this.Hide();

        }
    }
}
