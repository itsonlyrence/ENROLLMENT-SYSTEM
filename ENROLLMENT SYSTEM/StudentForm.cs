using ENROLLMENT_SYSTEM;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ENROLLMENTSYSTEM
{
    public partial class StudentForm : UserControl
    {
        SqlConnection connect = new SqlConnection(DatabaseConnect._connect);
        public StudentForm()
        {
            InitializeComponent();
            displayStudentData();
            setay();
        }
        public void displayStudentData()
        {
            StudentData adData = new StudentData();
            student_studentData.DataSource = adData.studentData();
            student_studentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void setay()
        {
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("SELECT aycode FROM tblay WHERE status = 'Open'", connect);
                SqlDataReader DataRead = command.ExecuteReader();
                if (DataRead.Read())
                {
                    gg.Text = DataRead["aycode"].ToString();
                }
                else
                {
                    MessageBox.Show("No aycode with status 'Open' found.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                connect.Close();
            }
        }
        private void student_studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = student_studentData.Rows[e.RowIndex];
                student_id.Text = row.Cells[1].Value.ToString();
                student_name.Text = row.Cells[2].Value.ToString();
                student_gender.Text = row.Cells[3].Value.ToString();
                student_address.Text = row.Cells[4].Value.ToString();
                student_grade.Text = row.Cells[5].Value.ToString();
                student_section.Text = row.Cells[6].Value.ToString();
                student_status.Text = row.Cells[7].Value.ToString();
                imagePath = row.Cells[8].Value.ToString();
                string imageData = row.Cells[8].Value.ToString();
                if (imageData != null && imageData.Length > 0)
                {
                    student_image.Image = Image.FromFile(imageData);
                }
                else
                {
                    student_image.Image = null;
                }
            }
        }
        public void clearFields()//clear all fields
        {
            id.Text = "";
            student_id.Text = "";
            student_name.Text = "";
            student_gender.SelectedIndex = -1;
            student_address.Text = "";
            student_grade.SelectedIndex = -1;
            student_section.SelectedIndex = -1;
            student_status.SelectedIndex = -1;
            student_image.Image = null;
            imagePath = "";
        }
        private void button2_Click(object sender, EventArgs e)//add new data
        {
            string nextId = student_id.Text;
            id.Text = nextId.ToString();
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_gender.Text == ""
                || student_address.Text == ""
                || student_grade.Text == ""
                || student_section.Text == ""
                || student_status.Text == ""
                || student_image.Image == null
                || imagePath == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string checkStudentID = "SELECT COUNT(*) FROM studentsDATA WHERE student_id = @studentID";
                        using (SqlCommand checkSID = new SqlCommand(checkStudentID, connect))
                        {
                            checkSID.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show("Student ID: " + student_id.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO studentsDATA (id,student_id, student_name" +
                                                    ", student_gender, student_address, student_grade, student_section" +
                                                    ", student_image, student_status,aycode, date_insert) " +
                                                    "VALUES(@id, @studentID, @studentName, @studentGender, @studentAddress" +
                                                    ", @studentGrade, @studentSection, @studentImage, @studentStatus" +
                                                       ",@aycode, @dateInsert)";
                                string path = Path.Combine(DatabaseConnect.studentpath, student_id.Text.Trim() + ".jpg");
                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(imagePath, path, true);
                                using (SqlCommand command = new SqlCommand(insertData, connect))
                                {
                                    command.Parameters.AddWithValue("@id", id.Text.Trim());
                                    command.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                    command.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                    command.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                                    command.Parameters.AddWithValue("@studentAddress", student_address.Text.Trim());
                                    command.Parameters.AddWithValue("@studentGrade", student_grade.Text.Trim());
                                    command.Parameters.AddWithValue("@studentSection", student_section.Text.Trim());
                                    command.Parameters.AddWithValue("@studentImage", path);
                                    command.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                    command.Parameters.AddWithValue("@aycode", gg.Text.Trim());
                                    command.Parameters.AddWithValue("@dateInsert", today);
                                    command.ExecuteNonQuery();
                                    displayStudentData();
                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        public string imagePath;
        private void button1_Click(object sender, EventArgs e)//photo inset
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                student_image.ImageLocation = imagePath;
            }
        }
        private void student_updateBtn_Click(object sender, EventArgs e)//update exiisting data
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_gender.Text == ""
                || student_address.Text == ""
                || student_grade.Text == ""
                || student_section.Text == ""
                || student_status.Text == ""
                || student_image.Image == null
                || imagePath == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        DialogResult check = MessageBox.Show("Are you sure you want to Update Student ID: "
                            + student_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;
                            String updateData = "UPDATE studentsDATA SET student_name = @studentName, " +
                                                "student_gender = @studentGender, student_address = @studentAddress, " +
                                                "student_grade = @studentGrade, student_section = @studentSection, " +
                                                "student_status = @studentStatus, date_update = @dateUpdate " +
                                                "WHERE student_id = @studentID";
                            using (SqlCommand command = new SqlCommand(updateData, connect))
                            {
                                command.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                command.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                                command.Parameters.AddWithValue("@studentAddress", student_address.Text.Trim());
                                command.Parameters.AddWithValue("@studentGrade", student_grade.Text.Trim());
                                command.Parameters.AddWithValue("@studentSection", student_section.Text.Trim());
                                command.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                command.Parameters.AddWithValue("@dateUpdate", today);
                                command.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                command.ExecuteNonQuery();
                                displayStudentData();
                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        private void student_deleteBtn_Click(object sender, EventArgs e)//delete student data
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Student ID: " + student_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string deleteData = "UPDATE studentsDATA SET date_delete = @dateDelete " + "WHERE student_id = @studentID";
                            using (SqlCommand command = new SqlCommand(deleteData, connect))
                            {
                                command.Parameters.AddWithValue("@dateDelete", today);
                                command.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                command.ExecuteNonQuery();
                                displayStudentData();
                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting Database: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        private void student_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void Print_Click(object sender, EventArgs e)
        {
            string studentId = student_id.Text;
            string studentName = student_name.Text;
            string studentAddress = student_address.Text;
            string studentGrade = student_grade.Text;
            string studentSection = student_section.Text;
            PrintForm pf1 = new PrintForm(studentId, studentName, studentAddress, studentGrade, studentSection);
            pf1.ShowDialog();
        }
    }
}
