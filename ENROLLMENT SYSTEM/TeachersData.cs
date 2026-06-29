using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
namespace ENROLLMENTSYSTEM
{
    class TeachersData
    {
        SqlConnection connect = new SqlConnection(DatabaseConnect._connect);
        public int ID { set; get; }
        public string TeacherID { set; get; }
        public string TeacherName { set; get; }
        public string TeacherGender { set; get; }
        public string TeacherAddress { set; get; }
        public string Status { set; get; }       
        public string TeacherGrade { set; get; }       
        public string TeacherImage { set; get; }
        public string DateInsert { set; get; }
        public List<TeachersData> DisplayTeacherData()
        {
            List<TeachersData> listData = new List<TeachersData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM teachersDATA WHERE date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader DataRead = cmd.ExecuteReader();
                        while (DataRead.Read())
                        {
                            TeachersData addTD = new TeachersData();
                            addTD.ID = (int)DataRead["id"];
                            addTD.TeacherID = DataRead["teacher_id"].ToString();
                            addTD.TeacherName = DataRead["teacher_name"].ToString();
                            addTD.TeacherGender = DataRead["teacher_gender"].ToString();
                            addTD.TeacherAddress = DataRead["teacher_address"].ToString();
                            addTD.Status = DataRead["teacher_status"].ToString();
                            addTD.TeacherGrade = DataRead["teacher_grade"].ToString();
                            addTD.TeacherImage = DataRead["teacher_image"].ToString();
                            addTD.DateInsert = DataRead["date_insert"].ToString();
                            listData.Add(addTD);
                        }
                        DataRead.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                    throw;
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
