using ENROLLMENTSYSTEM;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ENROLLMENT_SYSTEM
{
    public partial class PrintForm : Form
    {
        SqlConnection connect = new SqlConnection(DatabaseConnect._connect);
        private string _studentId;
        private string _studentName;
        private string _studentAddress;
        private string _studentGrade;
        private string _studentSection;
        public PrintForm(string studentId, string studentName, string studentAddress, string studentGrade, string studentSection)
        {
            InitializeComponent();
            loadRecordsfeeslist();
            loadTeacherlist();
            lrn.Text = studentId;
            studentname.Text = studentName;
            address.Text = studentAddress;
            grade.Text = studentGrade;
            section.Text = studentSection;
        }
        private void print_Click(object sender, EventArgs e)
        {
            printDocument.DefaultPageSettings.Landscape = true;
            printDocument.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int letterWidthPx = 794; // 8.5 inches * 96 dpi
            int letterHeightPx = 1123; // 11 inches * 96 dpi
            int marginPx = (int)(5 * 96 / 25.4); // 5 mm * 96 dpi / 25.4 mm/inch
            int availableWidthPx = letterWidthPx - 2 * marginPx;
            int availableHeightPx = letterHeightPx - 2 * marginPx;
            int surfaceWidth = printSurface.Width;
            int surfaceHeight = printSurface.Height;
            float scaleFactorWidth = availableWidthPx / (float)surfaceWidth;
            float scaleFactorHeight = availableHeightPx / (float)surfaceHeight;
            float scaleFactor = Math.Min(scaleFactorWidth, scaleFactorHeight);
            Matrix matrix = new Matrix();
            matrix.Scale(scaleFactor, scaleFactor);
            matrix.Translate(marginPx, marginPx);
            e.Graphics.Transform = matrix;
            using (Bitmap bitmap = new Bitmap(surfaceWidth, surfaceHeight))
            {
                printSurface.DrawToBitmap(bitmap, new Rectangle(0, 0, surfaceWidth, surfaceHeight));
                e.Graphics.DrawImage(bitmap, new Point(0, 0));
            }
            e.HasMorePages = false;
        }
        public void loadTeacherlist()
        {
            try
            {
                teacherdata.Rows.Clear();
                string sql = "SELECT teacher_name, teacher_gender, teacher_status FROM teachersDATA WHERE teacher_grade = @grade AND date_delete IS NULL AND teacher_status = 'Active';";
                using (SqlCommand command = new SqlCommand(sql, connect))
                {
                    command.Parameters.AddWithValue("@grade", grade.Text);
                    if (grade.Text == "Grade 11" || grade.Text == "Grade 12")
                    {
                        connect.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            teacherdata.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                        }
                        reader.Close();
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ENROLLMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //load fees
        public void loadRecordsfeeslist()
        {
            try
            {
                feess.Rows.Clear();
                decimal total = 0;
                using (SqlCommand command = new SqlCommand("select * from tblfees", connect))
                {
                    SqlDataReader dr;
                    connect.Open();
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        feess.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                        total += Convert.ToDecimal(dr[2]);
                    }
                    dr.Close();
                    connect.Close();
                    labelTotal.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ENROLLMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void reload_Click(object sender, EventArgs e)
        {
            loadRecordsfeeslist();
            loadTeacherlist();
        }


    }
}
