using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_School
{
    public partial class Register_LogIn : Form
    {
        public Register_LogIn()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            LogIns liclass = new LogIns();
            liclass.Registration(txtRName.Text, txtREmail.Text, txtRUser.Text, txtRPass.Text, txtRRPass.Text);

            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void btnRCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }
    }
}
