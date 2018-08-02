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
    public partial class School_Info : Form
    {       
        public School_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SchoolInfo si = new SchoolInfo();
            si.SaveSchoolInfo(txtSIName.Text, txtSIEstablish.Text, txtSILocation.Text);
            this.Hide();

            MDI_Main mm = new MDI_Main();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
