using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace ENROLLMENTSYSTEM
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(DatabaseConnect._connect);
        public LoginForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)//exit application
        {
            Application.Exit();
        }
        private bool once = false;
        private void label6_Click(object sender, EventArgs e)//minimize
        {
            WindowState = once ? FormWindowState.Minimized : FormWindowState.Minimized;
            once = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)//key press
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();
                    String sql = "SELECT password, acess_level FROM users WHERE username = @username";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        using (SqlDataReader DataRead = cmd.ExecuteReader())
                        {
                            if (DataRead.Read())
                            {
                                string dbPassword = DataRead["password"].ToString();
                                if (password.Text.Trim() == dbPassword)
                                {
                                    int accessLevel = Convert.ToInt32(DataRead["acess_level"]);
                                    MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MainForm mForm = new MainForm(accessLevel);
                                    mForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    password.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                username.Clear();
                                password.Clear();
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
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showPass.Checked ? '\0' : '*';
        }

    }
}