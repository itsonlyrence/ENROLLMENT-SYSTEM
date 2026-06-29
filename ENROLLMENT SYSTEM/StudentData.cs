using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
namespace ENROLLMENTSYSTEM
{
    class StudentData
    {
        SqlConnection connect = new SqlConnection(DatabaseConnect._connect);
        public int ID { set; get; }
        public string StudentID { set; get; }
        public string StudentName { set; get; }
        public string StudentGender { set; get; }
        public string StudentAddress { set; get; }
        public string StudentGrade { set; get; }
        public string StudentSection { set; get; }
        public string Status { set; get; }
        public string StudentImage { set; get; }
        public string DateInsert { set; get; }
        public List<StudentData> studentData()
        {
            List<StudentData> listData = new List<StudentData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM studentsDATA WHERE date_delete IS NULL";
                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        SqlDataReader DataRead = command.ExecuteReader();
                        while (DataRead.Read())
                        {
                            StudentData addSD = new StudentData();
                            addSD.ID = (int)DataRead["id"];
                            addSD.StudentID = DataRead["student_id"].ToString();
                            addSD.StudentName = DataRead["student_name"].ToString();
                            addSD.StudentGender = DataRead["student_gender"].ToString();
                            addSD.StudentAddress = DataRead["student_address"].ToString();
                            addSD.StudentGrade = DataRead["student_grade"].ToString();
                            addSD.StudentSection = DataRead["student_section"].ToString();      
                            addSD.Status = DataRead["student_status"].ToString();
                            addSD.StudentImage = DataRead["student_image"].ToString();
                            addSD.DateInsert = DataRead["date_insert"].ToString();
                            listData.Add(addSD);
                        }
                        DataRead.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
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
