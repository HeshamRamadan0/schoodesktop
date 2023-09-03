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
    public partial class DashBoard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
