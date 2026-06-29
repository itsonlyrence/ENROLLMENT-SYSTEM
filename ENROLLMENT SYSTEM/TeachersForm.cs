using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace ENROLLMENTSYSTEM
{
    public partial class TeachersForm : UserControl
    {
        SqlConnection connect = new SqlConnection(DatabaseConnect._connect);
        public TeachersForm()
        {
            InitializeComponent();
            displayTeacherData();
        }
        public void displayTeacherData()
        {
            TeachersData addTD = new TeachersData();
            teacher_gridData.AutoGenerateColumns = true;
            teacher_gridData.DataSource = addTD.DisplayTeacherData();
            teacher_gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void clearFields()
        {
            id.Clear();
            teacher_id.Clear();
            teacher_name.Clear();
            teacher_gender.SelectedIndex = -1;
            teacher_address.Clear();
            teacher_status.SelectedIndex = -1;
            teacher_grade.SelectedIndex = -1;
            teacher_image.Image = null;
            imagePath = "";
        }
        private void teacher_addBtn_Click(object sender, EventArgs e)//ADD TEACHR DATA
        {
            string nextId = teacher_id.Text;
            id.Text = nextId.ToString();
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_gender.Text == ""
                || teacher_address.Text == ""
                || teacher_status.Text == ""
                || teacher_grade.Text == ""
                || teacher_image.Image == null
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
                        string sql = "SELECT COUNT(*) FROM teachersDATA WHERE teacher_id = @teacherID";
                        using (SqlCommand command = new SqlCommand(sql, connect))
                        {
                            command.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                            int count = (int)command.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show("Teacher ID: " + teacher_id.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO teachersDATA " +
                                                    "(id, teacher_id, teacher_name, teacher_gender, teacher_address, " +
                                                    "teacher_image, teacher_status, date_insert, teacher_grade) " +
                                                    "VALUES(@id, @teacherID, @teacherName, @teacherGender, @teacherAddress," +
                                                    "@teacherImage, @teacherStatus, @dateInsert, @teachergrade)";
                                string path = Path.Combine(DatabaseConnect.teacherpath, teacher_id.Text.Trim() + ".jpg");
                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(imagePath, path, true);
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@id", id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherGender", teacher_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherAddress", teacher_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherImage", path);
                                    cmd.Parameters.AddWithValue("@teacherStatus", teacher_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teachergrade", teacher_grade.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today);
                                    cmd.ExecuteNonQuery();
                                    displayTeacherData();
                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
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
        private string imagePath;
        private void button1_Click(object sender, EventArgs e)//INSERT IMAGE
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                teacher_image.ImageLocation = imagePath;
            }
        }
        private void teacher_updateBtn_Click(object sender, EventArgs e)//UPDATE DATA TEACHER
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_gender.Text == ""
                || teacher_address.Text == ""
                || teacher_status.Text == ""
                || teacher_image.Image == null
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
                        DialogResult check = MessageBox.Show("Are you sure you want to Update Teacher ID: "
                            + teacher_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;
                            String updateData = "UPDATE teachersDATA SET " +
                                                "teacher_name = @teacherName, teacher_gender = @teacherGender" +
                                                ", teacher_address = @teacherAddress" +
                                                ", teacher_status = @teacherStatus" +
                                                ", teacher_grade = @teachergrade" +
                                                ", date_update = @dateUpdate WHERE teacher_id = @teacherID";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherGender", teacher_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherAddress", teacher_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherStatus", teacher_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@teachergrade", teacher_grade.Text.Trim());
                                cmd.ExecuteNonQuery();
                                displayTeacherData();
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
        private void teacher_deleteBtn_Click(object sender, EventArgs e)//DLETE DATA
        {
            if (teacher_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Teacher ID: "
                        + teacher_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string deleteData = "UPDATE teachersDATA SET date_delete = @dateDelete " +
                                "WHERE teacher_id = @teacherID";
                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                cmd.ExecuteNonQuery();
                                displayTeacherData();
                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error  connecting Database: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        private void teacher_clearBtn_Click(object sender, EventArgs e)//CLEAR DATA
        {
            clearFields();
        }
        private void teacher_gridData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)//click datagrid
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = teacher_gridData.Rows[e.RowIndex];
                teacher_id.Text = row.Cells[1].Value.ToString();
                teacher_name.Text = row.Cells[2].Value.ToString();
                teacher_gender.Text = row.Cells[3].Value.ToString();
                teacher_address.Text = row.Cells[4].Value.ToString();
                teacher_status.Text = row.Cells[5].Value.ToString();
                teacher_grade.Text = row.Cells[6].Value.ToString();
                imagePath = row.Cells[7].Value.ToString();
                string imageData = row.Cells[7].Value.ToString();
                if (imageData != null && imageData.Length > 0)
                {
                    teacher_image.Image = Image.FromFile(imageData);
                }
                else
                {
                    teacher_image.Image = null;
                }
            }
        }
    }
}
