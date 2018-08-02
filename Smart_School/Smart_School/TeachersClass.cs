using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Smart_School
{
    class Teachers
    {
        public string imageLocation;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\School_Data.mdf;Integrated Security=True");

        public void JoinHeadTeacher(string Name, string Qualification, string JoinDate, string Phone, string Email, string Address)
        {
            if (imageLocation != "")
            {
                try
                {
                    byte[] images = null;
                    FileStream strm = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(strm);
                    images = br.ReadBytes((int)strm.Length);

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE HeadTeacher_Info SET Name = '" + Name + "', Qualification = '" + Qualification + "', Date_of_Join = '" + JoinDate + "', Phone = '" + Phone + "', Email = '" + Email + "', Address = '" + Address + "', Image = @images WHERE Id = " + 1 + "";
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data save successfully");
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
                    cmd.CommandText = "UPDATE HeadTeacher_Info SET Name = '" + Name + "', Qualification = '" + Qualification + "', Date_of_Join = '" + JoinDate + "', Phone = '" + Phone + "', Email = '" + Email + "', Address = '" + Address + "' WHERE Id = " + 1 + "";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data save successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void UpdateHeadTeacher(string Name, string Qualification, string JoinDate, string Phone, string Email, string Address)
        {
            if (imageLocation != "")
            {
                try
                {
                    byte[] images = null;
                    FileStream strm = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(strm);
                    images = br.ReadBytes((int)strm.Length);

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE HeadTeacher_Info SET Name = '" + Name + "', Qualification = '" + Qualification + "', Date_of_Join = '" + JoinDate + "', Phone = '" + Phone + "', Email = '" + Email + "', Address = '" + Address + "', Image = @images WHERE Id = " + 1 + "";
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data save successfully");
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
                    cmd.CommandText = "UPDATE HeadTeacher_Info SET Name = '" + Name + "', Qualification = '" + Qualification + "', Date_of_Join = '" + JoinDate + "', Phone = '" + Phone + "', Email = '" + Email + "', Address = '" + Address + "' WHERE Id = " + 1 + "";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data save successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void JoinAssistantTeachers(string Name, string Position, string Qualification, string BirthDate, string JoinDate, string Gender, string Phone, string Email, string Address)
        {
            if (imageLocation != "")
            {
                try
                {
                    byte[] images = null;
                    FileStream strm = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(strm);
                    images = br.ReadBytes((int)strm.Length);

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO AssistantTeachers_Info VALUES('" + Name + "','" + Position + "','" + Qualification + "','" + BirthDate + "','" + JoinDate + "','" + Gender + "','" + Phone + "','" + Email + "','" + Address + "', @images)";
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data save successfully");
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
                    cmd.CommandText = "INSERT INTO AssistantTeachers_Info (Name, Position, Qualification, Date_of_Birth, Date_of_Join, Gender, Phone, Email, Address) VALUES ('" + Name + "','" + Position + "','" + Qualification + "','" + BirthDate + "','" + JoinDate + "','" + Gender + "','" + Phone + "','" + Email + "','" + Address + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data save successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void UpdateAssistantTeachers(string Name, string Position, string Qualification, string BirthDate, string JoinDate, string Gender, string Phone, string Email, string Address, int Id)
        {
            if (imageLocation != "")
            {
                try
                {
                    byte[] images = null;
                    FileStream strm = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(strm);
                    images = br.ReadBytes((int)strm.Length);

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE AssistantTeachers_Info SET Name = '" + Name + "', Position = '" + Position + "', Qualification = '" + Qualification + "', Date_of_Birth = '" + BirthDate + "', Date_of_Join = '" + JoinDate + "', Gender = '" + Gender + "', Phone = '" + Phone + "', Email = '" + Email + "', Address = '" + Address + "', Image = @images WHERE Id = " + Id + "";
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data save successfully");
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
                    cmd.CommandText = "UPDATE AssistantTeachers_Info SET Name = '" + Name + "', Position = '" + Position + "', Qualification = '" + Qualification + "', Date_of_Birth = '" + BirthDate + "', Date_of_Join = '" + JoinDate + "', Gender = '" + Gender + "', Phone = '" + Phone + "', Email = '" + Email + "', Address = '" + Address + "' WHERE Id = " + Id + "";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data save successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
