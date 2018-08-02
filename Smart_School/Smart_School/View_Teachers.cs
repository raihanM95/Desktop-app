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
using System.IO;

namespace Smart_School
{
    public partial class View_Teachers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\School_Data.mdf;Integrated Security=True");

        public View_Teachers()
        {
            InitializeComponent();
        }

        private void View_Teachers_Load(object sender, EventArgs e)
        {
            DisplayHeadTeacherInfo();

            DisplayAssistantTeachersInfo();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Teachers at = new Add_Teachers();
            at.UMessage = "Update";
            at.UTMessage = "HeadTeacher";
            at.Show();
        }

        private void dataGridViewATeachers_Info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = Convert.ToInt32(dataGridViewATeachers_Info.SelectedCells[0].Value.ToString());

            this.Hide();
            Add_Teachers at = new Add_Teachers();
            at.UMessage = "Update";
            at.UTMessage = "AssistantTeacher";
            at.Id = i;
            at.Show();
        }

        public void DisplayHeadTeacherInfo()
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
                
                SqlDataReader dre = cmd.ExecuteReader();
                dre.Read();
                if (dre.HasRows)
                {
                    byte[] images = ((byte[])dre[7]);
                    if (images != null)
                    {
                        MemoryStream mrys = new MemoryStream(images);
                        pictureBoxVHTeacher.Image = Image.FromStream(mrys);                    
                    }
                    else
                    {
                        pictureBoxVHTeacher.Image = null;
                    }
                }
                else
                {
                    //MessageBox.Show("false");
                }
                
                foreach (DataRow dr in dt.Rows)
                {
                    lblVHTName.Text = dr["Name"].ToString();
                    lblVHTQualification.Text = dr["Qualification"].ToString();
                    lblVHTJoinDate.Text = dr["Date_of_Join"].ToString();
                    lblVHTPhone.Text = dr["Phone"].ToString();
                    lblVHTEmail.Text = dr["Email"].ToString();
                    lblVHTAddress.Text = dr["Address"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayAssistantTeachersInfo()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM AssistantTeachers_Info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewATeachers_Info.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
