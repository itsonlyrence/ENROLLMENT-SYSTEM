using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace ENROLLMENTSYSTEM
{
    public partial class DashboardForm : UserControl
    {
        SqlConnection connect = new SqlConnection(DatabaseConnect._connect);
        public DashboardForm()
        {
            InitializeComponent();
            displayTotalES();
            displayTotalTT();
            displayTotalGS();
            loadStudentData(); 
        }
        public void loadStudentData()
        {
            try
            {
                dataGridView3.Rows.Clear();
                using (SqlCommand command = new SqlCommand("SELECT student_id, student_name, student_grade, student_status, date_insert FROM studentsDATA WHERE date_delete IS NULL", connect))
                {
                    connect.Open();
                    SqlDataReader DataRead = command.ExecuteReader();
                    while (DataRead.Read())
                    {
                        dataGridView3.Rows.Add(DataRead[0].ToString(), DataRead[1].ToString(), DataRead[2].ToString(), DataRead[3].ToString(), DataRead[4].ToString());
                    }
                    DataRead.Close();
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ENROLLMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void displayTotalES()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(*) FROM studentsDATA WHERE student_status = 'Enrolled' AND date_delete IS NULL";

                    using (SqlCommand command = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        int tempES = 0;
                        if (reader.Read())
                        {
                            tempES = Convert.ToInt32(reader[0]);
                            total_ES.Text = tempES.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to connect Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }
        public void displayTotalTT()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(*) FROM teachersDATA WHERE teacher_status = 'Active' AND date_delete IS NULL";
                    using (SqlCommand command = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        int tempTT = 0;
                        if (reader.Read())
                        {
                            tempTT = Convert.ToInt32(reader[0]);
                            total_TT.Text = tempTT.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to connect Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        public void displayTotalGS()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT COUNT(*) FROM studentsDATA WHERE student_status = 'Graduated' AND date_delete IS NULL";

                    using (SqlCommand command = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        int tempGS = 0;
                        if (reader.Read())
                        {
                            tempGS = Convert.ToInt32(reader[0]);
                            total_GS.Text = tempGS.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error to connect Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
