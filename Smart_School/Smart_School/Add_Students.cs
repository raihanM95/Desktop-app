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
    public partial class Add_Students : Form
    {
        string imgLocation = "";
        
        public Add_Students()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxAS.ImageLocation = imgLocation;
            }
            else
            {
                imgLocation = pictureBoxAS.ImageLocation;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            s.imageLocation = imgLocation;

            if (txtASName.Text != "" && cmbASGender.Text != "" && cmbASClass.Text != "" && txtASAddress.Text != "")
            {
                Convert.ToInt32(cmbASClass.Text);
                s.AddStudents(txtASName.Text, txtASFName.Text, txtASMName.Text, dateTimePickerASB.Text, cmbASGender.Text, Convert.ToInt32(cmbASClass.Text), txtASRoll.Text, dateTimePickerASA.Text, txtASEmail.Text, txtASAddress.Text);

                txtASName.Text = "";
                txtASFName.Text = "";
                txtASMName.Text = "";
                cmbASGender.Text = "";
                cmbASClass.Text = "";
                txtASRoll.Text = "";
                txtASEmail.Text = "";
                txtASAddress.Text = "";
            }
            else
            {
                MessageBox.Show("Please fillup all information");
            }
        }
    }
}
