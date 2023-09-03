namespace APP.emp
{
    partial class Employees_Delete
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Teacher_ADD_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_empID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Teacher_ADD_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Teacher_ADD_panel
            // 
            this.Teacher_ADD_panel.Controls.Add(this.txt_empID);
            this.Teacher_ADD_panel.Controls.Add(this.label2);
            this.Teacher_ADD_panel.Controls.Add(this.guna2Button2);
            this.Teacher_ADD_panel.Controls.Add(this.guna2Button1);
            this.Teacher_ADD_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Teacher_ADD_panel.Location = new System.Drawing.Point(0, 0);
            this.Teacher_ADD_panel.Name = "Teacher_ADD_panel";
            this.Teacher_ADD_panel.ShadowDecoration.Parent = this.Teacher_ADD_panel;
            this.Teacher_ADD_panel.Size = new System.Drawing.Size(1144, 645);
            this.Teacher_ADD_panel.TabIndex = 4;
            // 
            // txt_empID
            // 
            this.txt_empID.BorderRadius = 18;
            this.txt_empID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_empID.DefaultText = "";
            this.txt_empID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_empID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_empID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_empID.DisabledState.Parent = this.txt_empID;
            this.txt_empID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_empID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_empID.FocusedState.Parent = this.txt_empID;
            this.txt_empID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_empID.HoverState.Parent = this.txt_empID;
            this.txt_empID.Location = new System.Drawing.Point(473, 186);
            this.txt_empID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.PasswordChar = '\0';
            this.txt_empID.PlaceholderText = "";
            this.txt_empID.SelectedText = "";
            this.txt_empID.ShadowDecoration.Parent = this.txt_empID;
            this.txt_empID.Size = new System.Drawing.Size(412, 34);
            this.txt_empID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(186, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee ID :";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(488, 363);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(397, 45);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Clear";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(150, 294);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(420, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Delete";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Employees_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Teacher_ADD_panel);
            this.Name = "Employees_Delete";
            this.Size = new System.Drawing.Size(1144, 645);
            this.Teacher_ADD_panel.ResumeLayout(false);
            this.Teacher_ADD_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Teacher_ADD_panel;
        private Guna.UI2.WinForms.Guna2TextBox txt_empID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
