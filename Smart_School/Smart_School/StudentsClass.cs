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
    class Students
    {
        public string imageLocation;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\School_Data.mdf;Integrated Security=True");
        
        public void AddStudents(string Name, string FatherName, string MotherName, string BirthDate, string Gender, int Class, string ClassRoll, string AdmissionDate, string Email, string Address)
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
                    cmd.CommandText = "INSERT INTO Students_Info VALUES('" + Name + "','" + FatherName + "','" + MotherName + "','" + BirthDate + "','" + Gender + "'," + Class + ",'" + ClassRoll + "','" + AdmissionDate + "','" + Email + "','" + Address + "', @images)";
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Student data save successfully");
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
                    cmd.CommandText = "INSERT INTO Students_Info (Name_of_Students, Fathers_Name, Mothers_Name, Date_of_Birth, Gender, Class, Class_Roll, Date_of_Admission, Email, Address) VALUES ('" + Name + "','" + FatherName + "','" + MotherName + "','" + BirthDate + "','" + Gender + "'," + Class + ",'" + ClassRoll + "','" + AdmissionDate + "','" + Email + "','" + Address + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Student data save successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void UpdateStudentsInfo(string Name, string FatherName, string MotherName, string BirthDate, string Gender, int Class, string ClassRoll, string AdmissionDate, string Email, string Address, int Id)
        {
            if(imageLocation != "")
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
                    cmd.CommandText = "UPDATE Students_Info SET Name_of_Students = '" + Name + "', Fathers_Name = '" + FatherName + "', Mothers_Name = '" + MotherName + "', Date_of_Birth = '" + BirthDate + "', Gender = '" + Gender + "', Class = " + Class + ", Class_Roll = '" + ClassRoll + "', Date_of_Admission = '" + AdmissionDate + "', Email = '" + Email + "', Address = '" + Address + "', Image = @images WHERE Id = " + Id + "";
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Student data update successfully");
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
                    cmd.CommandText = "UPDATE Students_Info SET Name_of_Students = '" + Name + "', Fathers_Name = '" + FatherName + "', Mothers_Name = '" + MotherName + "', Date_of_Birth = '" + BirthDate + "', Gender = '" + Gender + "', Class = " + Class + ", Class_Roll = '" + ClassRoll + "', Date_of_Admission = '" + AdmissionDate + "', Email = '" + Email + "', Address = '" + Address + "' WHERE Id = " + Id + "";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Student data update successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
