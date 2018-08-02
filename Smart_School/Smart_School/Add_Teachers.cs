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

namespace Smart_School
{
    public partial class Add_Teachers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\School_Data.mdf;Integrated Security=True");
        public string UMessage;
        public string UTMessage;
        public int Id;
        string imgLocation = "";

        public Add_Teachers()
        {
            InitializeComponent();
        }

        private void Add_Teachers_Load(object sender, EventArgs e)
        {
            lblUMessage.Text = UMessage;
            lblUTMessage.Text = UTMessage;

            if (lblUTMessage.Text == "HeadTeacher")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM HeadTeacher_Info WHERE Id = " + 1 + "";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        txtATName.Text = dr["Name"].ToString();
                        txtATQualification.Text = dr["Qualification"].ToString();
                        dateTimePickerATJ.Text = dr["Date_of_Join"].ToString();
                        txtATPhone.Text = dr["Phone"].ToString();
                        txtATEmail.Text = dr["Email"].ToString();
                        txtATAddress.Text = dr["Address"].ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM AssistantTeachers_Info WHERE Id = " + Id + "";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        txtATName.Text = dr["Name"].ToString();
                        cmbATPosition.Text = dr["Position"].ToString();
                        txtATQualification.Text = dr["Qualification"].ToString();
                        dateTimePickerATB.Text = dr["Date_of_Birth"].ToString();
                        dateTimePickerATJ.Text = dr["Date_of_Join"].ToString();
                        cmbATGender.Text = dr["Gender"].ToString();
                        txtATPhone.Text = dr["Phone"].ToString();
                        txtATEmail.Text = dr["Email"].ToString();
                        txtATAddress.Text = dr["Address"].ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxAT.ImageLocation = imgLocation;
            }
            else
            {
                imgLocation = pictureBoxAT.ImageLocation;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            t.imageLocation = imgLocation;

            if(lblUMessage.Text != "Update")
            {
                if (txtATName.Text != "" && cmbATPosition.Text == "Head Teacher" && cmbATGender.Text != "" && txtATPhone.Text != "")
                {
                    t.JoinHeadTeacher(txtATName.Text, txtATQualification.Text, dateTimePickerATJ.Text, txtATPhone.Text, txtATEmail.Text, txtATAddress.Text);

                    txtATName.Text = "";
                    txtATQualification.Text = "";
                    txtATPhone.Text = "";
                    txtATEmail.Text = "";
                    txtATAddress.Text = "";
                }
                else if(txtATName.Text != "" && cmbATPosition.Text != "" && cmbATGender.Text != "" && txtATPhone.Text != "")
                {
                    t.JoinAssistantTeachers(txtATName.Text, cmbATPosition.Text, txtATQualification.Text, dateTimePickerATB.Text, dateTimePickerATJ.Text, cmbATGender.Text, txtATPhone.Text, txtATEmail.Text, txtATAddress.Text);

                    txtATName.Text = "";
                    cmbATPosition.Text = "";
                    txtATQualification.Text = "";
                    cmbATGender.Text = "";
                    txtATPhone.Text = "";
                    txtATEmail.Text = "";
                    txtATAddress.Text = "";
                }
                else
                {
                    MessageBox.Show("Please fillup all information");
                }
            }
            else
            {
                if (lblUTMessage.Text == "HeadTeacher" && cmbATPosition.Text == "Head Teacher")
                {
                    t.UpdateHeadTeacher(txtATName.Text, txtATQualification.Text, dateTimePickerATJ.Text, txtATPhone.Text, txtATEmail.Text, txtATAddress.Text);
                    this.Hide();
                    View_Teachers vt = new View_Teachers();
                    vt.Show();
                }
                else if (lblUTMessage.Text == "AssistantTeacher" && cmbATPosition.Text == "Assistant Teacher")
                {
                    t.UpdateAssistantTeachers(txtATName.Text, cmbATPosition.Text, txtATQualification.Text, dateTimePickerATB.Text, dateTimePickerATJ.Text, cmbATGender.Text, txtATPhone.Text, txtATEmail.Text, txtATAddress.Text, Id);
                    this.Hide();
                    View_Teachers vt = new View_Teachers();
                    vt.Show();
                }
                else
                {
                    MessageBox.Show("You input wrong position");
                }
            }   
        }
    }
}
