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
    public partial class View_Students : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\School_Data.mdf;Integrated Security=True");
        string imgLocation = "";

        public View_Students()
        {
            InitializeComponent();
        }

        private void View_Students_Load(object sender, EventArgs e)
        {
            DisplayInfo();
        }

        private void btnVSSearch_Click(object sender, EventArgs e)
        {
            int i = 0;

            try
            {
                dataGridViewStudents_Info.Columns.Clear();
                dataGridViewStudents_Info.Refresh();

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Students_Info WHERE Name_of_Students LIKE '%" + txtVSSearch.Text + "%' OR Fathers_Name LIKE '%" + txtVSSearch.Text + "%' OR Mothers_Name LIKE '%" + txtVSSearch.Text + "%' OR Date_of_Birth LIKE '%" + txtVSSearch.Text + "%' OR Gender LIKE '%" + txtVSSearch.Text + "%' OR Class LIKE '%" + txtVSSearch.Text + "%' OR Class_Roll LIKE '%" + txtVSSearch.Text + "%' OR Date_of_Admission LIKE '%" + txtVSSearch.Text + "%' OR Email LIKE '%" + txtVSSearch.Text + "%' OR Address LIKE '%" + txtVSSearch.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridViewStudents_Info.DataSource = dt;
                con.Close();

                if(i == 0)
                {
                    MessageBox.Show("Sorry! No informations found \n Please search again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtVSSearch_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;

            try
            {
                dataGridViewStudents_Info.Columns.Clear();
                dataGridViewStudents_Info.Refresh();

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Students_Info WHERE Name_of_Students LIKE '%" + txtVSSearch.Text + "%' OR Fathers_Name LIKE '%" + txtVSSearch.Text + "%' OR Mothers_Name LIKE '%" + txtVSSearch.Text + "%' OR Date_of_Birth LIKE '%" + txtVSSearch.Text + "%' OR Gender LIKE '%" + txtVSSearch.Text + "%' OR Class LIKE '%" + txtVSSearch.Text + "%' OR Class_Roll LIKE '%" + txtVSSearch.Text + "%' OR Date_of_Admission LIKE '%" + txtVSSearch.Text + "%' OR Email LIKE '%" + txtVSSearch.Text + "%' OR Address LIKE '%" + txtVSSearch.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridViewStudents_Info.DataSource = dt;
                con.Close();

                if (i == 0)
                {
                    MessageBox.Show("Sorry! No informations found \n Please search again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewStudents_Info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("If you Update? click Yes \nIf Sent Email? click No", "Update/Sent Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                pnlVSUpdate.Visible = true;

                try
                {
                    int i = Convert.ToInt32(dataGridViewStudents_Info.SelectedCells[0].Value.ToString());
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM Students_Info WHERE Id = " + i + "";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            txtVSUName.Text = dr["Name_of_Students"].ToString();
                            txtVSUFName.Text = dr["Fathers_Name"].ToString();
                            txtVSUMName.Text = dr["Mothers_Name"].ToString();
                            dateTimePickerVSUB.Text = dr["Date_of_Birth"].ToString();
                            cmbVSUGender.Text = dr["Gender"].ToString();
                            cmbVSUClass.Text = dr["Class"].ToString();
                            txtVSURoll.Text = dr["Class_Roll"].ToString();
                            dateTimePickerVSUA.Text = dr["Date_of_Admission"].ToString();
                            txtVSUEmail.Text = dr["Email"].ToString();
                            txtVSUAddress.Text = dr["Address"].ToString();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please click Id no");
                }
            }
            else
            {
                string email = dataGridViewStudents_Info.SelectedCells[9].Value.ToString();
                
                this.Hide();
                Sent_Email sm = new Sent_Email();
                sm.To = email;
                sm.Show();
            }           
        }

        private void btnVSUPBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                txtVSUPic.Text = imgLocation;
            }
            else
            {
                
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewStudents_Info.SelectedCells[0].Value.ToString());
            Students s = new Students();
            s.imageLocation = imgLocation;
            try
            {
                Convert.ToInt32(cmbVSUClass.Text);
                s.UpdateStudentsInfo(txtVSUName.Text, txtVSUFName.Text, txtVSUMName.Text, dateTimePickerVSUB.Text, cmbVSUGender.Text, Convert.ToInt32(cmbVSUClass.Text), txtVSURoll.Text, dateTimePickerVSUA.Text, txtVSUEmail.Text, txtVSUAddress.Text, id);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input class");
            }

            DisplayInfo();
            pnlVSUpdate.Visible = false;
        }

        public void DisplayInfo()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Students_Info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewStudents_Info.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
