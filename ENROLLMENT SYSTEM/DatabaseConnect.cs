using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENROLLMENTSYSTEM
{
    internal class DatabaseConnect
    {
        //connection string
        //public static string _connect = "Data Source = AMOU;Initial Catalog =schoolsystem;Integrated Security=true;TrustServerCertificate=True";//pc
          public static string _connect = "Data Source = CHILLPLS;Initial Catalog =schoolsystem;Integrated Security=true;TrustServerCertificate=True";//laptop
        //path
        //public static string teacherpath = @"F:\C#\ENROLLMENT SYSTEM\Teacher";//pc
        //public static string studentpath = @"F:\C#\ENROLLMENT SYSTEM\Student";//pc

        //public static string teacherpath = @"C:\Users\laure\OneDrive\Desktop\ENROLLMENT SYSTEM\Teacher";//pc
        //public static string studentpath = @"C:\Users\laure\OneDrive\Desktop\ENROLLMENT SYSTEM\Student";//pc

          public static string teacherpath = @"C:\Users\ASUS\Desktop\ENROLLMENT SYSTEM\Teacher";//pc
          public static string studentpath = @"C:\Users\ASUS\Desktop\ENROLLMENT SYSTEM\Student";//pc
        //for form1 label
          public static string _title = "ENROLLMENT SYSTEM";
          public static string _title2 = "HORIZON AVIADOR";
          public static string _title3 = "AVIATION SCHOOL";

        //NuGet\Install-Package Microsoft.Data.SqlClient -Version 5.2.0
    }

}

