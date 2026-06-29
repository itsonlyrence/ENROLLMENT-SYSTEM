using System;
using System.Windows.Forms;
namespace ENROLLMENTSYSTEM
{
    public partial class MainForm : Form
    {
        private readonly int _accessLevel;
        public MainForm(int accessLevel)
        {
            InitializeComponent();
            _accessLevel = accessLevel;
            SetButtonVisibility();
        }
        private void SetButtonVisibility()
        {
            switch (_accessLevel)
            {
                case 1://admin
                    Dashboard_btn.Visible = true;
                    AddStudent_btn.Visible = true;
                    AddTeacher_btn.Visible = true;
                    Billing_btn.Visible = true;
                    School_btn.Visible = true;
                    label1.Text = "Welcome, " + "admin";
                    break;
                case 2://registrar
                    Dashboard_btn.Visible = true;
                    Dashboard_btn.Location = new Point(9, 201); 
                    AddStudent_btn.Visible = true;
                    AddStudent_btn.Location = new Point(9, 253);
                    AddTeacher_btn.Visible = true;
                    AddTeacher_btn.Location = new Point(9, 307);
                    Billing_btn.Visible = false;
                    School_btn.Visible = false;
                    label1.Text = "Welcome, " + "Registrar";
                    break;
                case 3://cashier
                    Dashboard_btn.Visible = true;
                    Dashboard_btn.Location = new Point(9, 201);
                    AddStudent_btn.Visible = false;
                    AddTeacher_btn.Visible = false;
                    Billing_btn.Visible = true;
                    Billing_btn.Location = new Point(9, 253); 
                    School_btn.Visible = false;
                    label1.Text = "Welcome, " + "Cashier";
                    break;
                case 4:
                    Dashboard_btn.Visible = true;
                    AddTeacher_btn.Visible = false;
                    AddTeacher_btn.Visible = false;
                    Billing_btn.Visible = false;
                    School_btn.Visible = false;
                    label1.Text = "Welcome, " + "";
                    break;
                default:
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)//dashboard button
        {
            DashboardForm dForm = new DashboardForm();
            dForm.loadStudentData();
            dForm.displayTotalGS();
            dForm.displayTotalTT();
            dForm.displayTotalES();
            dashboardForm.Update();
            dashboardForm.Visible = true;
            studentForm.Visible = false;
            teachersForm.Visible = false;
            billingForm.Visible = false;
            schoolForm1.Visible = false;
            MainForm mForm = new MainForm(_accessLevel);
            this.Hide();
            mForm.Show();
        }
        private void AddStudent_btn_Click(object sender, EventArgs e)//add student
        {
            DashboardForm dForm = new DashboardForm();
            dForm.Hide();
            dashboardForm.Visible = false;
            studentForm.Visible = true;
            studentForm.Update();            
            teachersForm.Visible = false;
            billingForm.Visible = false;
            schoolForm1.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)//add teeacher
        {
            dashboardForm.Visible = false;
            studentForm.Visible = false;
            teachersForm.Visible = true;
            teachersForm.Update();
            billingForm.Visible = false;
            schoolForm1.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)//billing
        {
            dashboardForm.Visible = false;
            studentForm.Visible = false;
            teachersForm.Visible = false;
            billingForm.Visible = true;
            billingForm.Update();
            schoolForm1.Visible = false;
        }
        private void School_btn_Click(object sender, EventArgs e)//school
        {
            dashboardForm.Visible = false;
            studentForm.Visible = false;
            teachersForm.Visible = false;
            billingForm.Visible = false;
            schoolForm1.Visible = true;
            schoolForm1.Update();
        }
        private void Logout_Click_1(object sender, EventArgs e)//logout
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }
        }
        private void CLOSE(object sender, FormClosedEventArgs e)//close the app
        {
            Application.Exit();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dashboardForm.Visible = true; 
            studentForm.Visible = false;
            teachersForm.Visible = false;
            billingForm.Visible = false;
            schoolForm1.Visible = false;
            DashboardForm dForm = new DashboardForm();
            dForm.loadStudentData();
            dForm.displayTotalGS();
            dForm.displayTotalTT();
            dForm.displayTotalES();

        }
    }
}
