using Microsoft.Data.SqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace ENROLLMENTSYSTEM
{
    public partial class SchoolForm : UserControl
    {
        SqlDataReader DataRead;
        public SchoolForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(DatabaseConnect._connect);
        private void SchoolForm_Load(object sender, EventArgs e)
        {
            loadRecordsAcademicYear();
        }
        public void loadRecordsAcademicYear()
        {
            try
            {
                dataGridView1.Rows.Clear();
                connect.Open();
                SqlCommand command = new SqlCommand("select * from tblay", connect);
                DataRead = command.ExecuteReader();
                while (DataRead.Read())
                {
                    dataGridView1.Rows.Add(DataRead[0].ToString(), DataRead[1].ToString());
                }
                DataRead.Close();
                connect.Close();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string _column = dataGridView1.Columns[e.ColumnIndex].Name;
                if (_column == "colOpen")
                {
                    if (MessageBox.Show("Do you want to open academic year " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connect.Open();
                        SqlCommand command = new SqlCommand("update tblay set status = 'Close'", connect);
                        DataRead = command.ExecuteReader();
                        connect.Close();
                        connect.Open();
                        SqlCommand command3 = new SqlCommand("update tblay set status = 'Open' where aycode = @aycode", connect);
                        command3.Parameters.AddWithValue("@aycode", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                        command3.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Academic year " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " has been successfully opened!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadRecordsAcademicYear();
                    }

                }
                else if (_column == "colClose")
                {
                    if (MessageBox.Show("Do you want to close academic year " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connect.Open();
                        SqlCommand command = new SqlCommand("update tblay set status = 'Close'", connect);
                        command.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Academic year " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " has been successfully closed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadRecordsAcademicYear();

                    }
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Regex academicYearPattern = new Regex(@"^\d{4}-\d{4}$");
                if (txtAY.Text == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!academicYearPattern.IsMatch(txtAY.Text))
                {
                    MessageBox.Show("Invalid format for academic year. Please use the format YYYY-YYYY.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Do you want to add new academic year?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand("update tblay set status = 'Close'", connect);
                    command.ExecuteNonQuery();
                    connect.Close();
                    connect.Open();
                    SqlCommand command2 = new SqlCommand("insert into tblay(aycode)values(@aycode)", connect);
                    command2.Parameters.AddWithValue("@aycode", txtAY.Text);
                    command2.ExecuteNonQuery();
                    MessageBox.Show("New academic year has been successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAY.Clear();
                    txtAY.Focus();
                    connect.Close();
                    loadRecordsAcademicYear();
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
