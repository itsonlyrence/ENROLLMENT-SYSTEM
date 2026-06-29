using System;
using System.Windows.Forms;
namespace ENROLLMENTSYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            if (panel2.Width >= 612)
            {
                label1.Text = DatabaseConnect._title;
                panel5.Height -= 10;
            }
            if (panel5.Height <= 0)
            {
                label1.Text = DatabaseConnect._title2;
                top.Width -= 10;
            }
            if (top.Width <= 0)
            {
                label1.Text = DatabaseConnect._title3;
                left.Height += 10;
            }
            if(left.Height >= 346)
            {
                timer1.Stop();
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }
        }
    }
}
