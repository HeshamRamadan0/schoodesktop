using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Add_btn.Hide();
            Update_btn.Hide();
            Search_btn.Hide();
            Delete_btn.Hide();
            Teacher_ADD_BTN.Hide();
            Teacher_Delete_BTN.Hide();
            Teacher_Search_btn.Hide();
            Teacher_Update_btn.Hide();
            emp_ADD.Show();
            Emp_Delete.Show();
            Emp_Search.Show();
            Emp_Update.Show();

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adD_order3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Add_btn.Hide();
            Update_btn.Hide();
            Search_btn.Hide();
            Delete_btn.Hide();
            Teacher_ADD_BTN.Show();
            Teacher_Delete_BTN.Show();
            Teacher_Search_btn.Show();
            Teacher_Update_btn.Show();

            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
          

        }

        private void add_Student1_Load(object sender, EventArgs e)
        {

        }

        private void student_ADD1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Add_btn.Show();
            Update_btn.Show();
            Search_btn.Show();
            Delete_btn.Show();
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = true;
            delete_Student1.Visible = false;
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            student_Search1.Visible = true;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            student_Search1.Visible = false;
            update_student1.Visible = true;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            delete_Student1.Visible = true;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
        }

        private void Teacher_ADD_BTN_Click(object sender, EventArgs e)
        {
            teacher_ADD1.Visible = true;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
               

        }

        private void Teacher_Update_btn_Click(object sender, EventArgs e)
        {

            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = true;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
        }

        private void Teacher_Search_btn_Click(object sender, EventArgs e)
        {
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = true;
            teacher_Update1.Visible = false;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
        }

        private void Teacher_Delete_BTN_Click(object sender, EventArgs e)
        {
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = true;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;

            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
        }

        private void emp_ADD_Click(object sender, EventArgs e)
        {
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;
            employees_ADD1.Visible = true;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
        }

        private void Emp_Update_Click(object sender, EventArgs e)
        {
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;
            employees_ADD1.Visible = false;
            employee_Update1.Visible = true;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = false;
           

        }

        private void Emp_Search_Click(object sender, EventArgs e)
        {

            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;
            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = true;
            employees_Delete1.Visible = false;
        }

        private void Emp_Delete_Click(object sender, EventArgs e)
        {
            teacher_ADD1.Visible = false;
            teacher_Delete1.Visible = false;
            teacher_Search1.Visible = false;
            teacher_Update1.Visible = false;
            student_Search1.Visible = false;
            update_student1.Visible = false;
            student_ADD1.Visible = false;
            delete_Student1.Visible = false;
            employees_ADD1.Visible = false;
            employee_Update1.Visible = false;
            employee_Search1.Visible = false;
            employees_Delete1.Visible = true;

        }

        private void employees_Delete1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DashBoard.dashView dv = new DashBoard.dashView();
            dv.Show();
            this.Hide();

       
        }
    }
}
