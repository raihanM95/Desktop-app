using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Smart_School
{
    class SchoolInfo
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\School_Data.mdf;Integrated Security=True");

        public void SaveSchoolInfo(string Name, string Establish, string Location)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE School_Info SET Name = '" + Name + "', Establish = '" + Establish + "', Location = '" + Location + "' WHERE Id = " + 1 + "";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
