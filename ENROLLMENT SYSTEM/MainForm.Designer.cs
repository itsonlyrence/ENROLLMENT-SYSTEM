
namespace ENROLLMENTSYSTEM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel2 = new Panel();
            School_btn = new Button();
            button_logout = new Button();
            Billing_btn = new Button();
            AddTeacher_btn = new Button();
            AddStudent_btn = new Button();
            Dashboard_btn = new Button();
            label1 = new Label();
            panel4 = new Panel();
            OTHERS = new Panel();
            dashboardForm = new DashboardForm();
            billingForm = new FeesForm();
            schoolForm1 = new SchoolForm();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            OTHERS.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(School_btn);
            panel2.Controls.Add(button_logout);
            panel2.Controls.Add(Billing_btn);
            panel2.Controls.Add(AddTeacher_btn);
            panel2.Controls.Add(AddStudent_btn);
            panel2.Controls.Add(Dashboard_btn);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.MinimumSize = new Size(251, 300);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 666);
            panel2.TabIndex = 1;
            // 
            // School_btn
            // 
            School_btn.Cursor = Cursors.Hand;
            School_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            School_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            School_btn.FlatStyle = FlatStyle.Flat;
            School_btn.ForeColor = Color.Black;
            School_btn.ImageAlign = ContentAlignment.MiddleLeft;
            School_btn.Location = new Point(9, 411);
            School_btn.Margin = new Padding(4, 3, 4, 3);
            School_btn.Name = "School_btn";
            School_btn.Size = new Size(233, 46);
            School_btn.TabIndex = 9;
            School_btn.Text = "School";
            School_btn.UseVisualStyleBackColor = true;
            School_btn.Click += School_btn_Click;
            // 
            // button_logout
            // 
            button_logout.Cursor = Cursors.Hand;
            button_logout.FlatAppearance.MouseDownBackColor = Color.Red;
            button_logout.FlatAppearance.MouseOverBackColor = Color.Red;
            button_logout.FlatStyle = FlatStyle.Flat;
            button_logout.ForeColor = Color.Black;
            button_logout.ImageAlign = ContentAlignment.MiddleLeft;
            button_logout.Location = new Point(9, 617);
            button_logout.Margin = new Padding(4, 3, 4, 3);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(233, 46);
            button_logout.TabIndex = 8;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += Logout_Click_1;
            // 
            // Billing_btn
            // 
            Billing_btn.Cursor = Cursors.Hand;
            Billing_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            Billing_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            Billing_btn.FlatStyle = FlatStyle.Flat;
            Billing_btn.ForeColor = Color.Black;
            Billing_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Billing_btn.Location = new Point(9, 359);
            Billing_btn.Margin = new Padding(4, 3, 4, 3);
            Billing_btn.Name = "Billing_btn";
            Billing_btn.Size = new Size(233, 46);
            Billing_btn.TabIndex = 7;
            Billing_btn.Text = "Billing";
            Billing_btn.UseVisualStyleBackColor = true;
            Billing_btn.Click += button1_Click_1;
            // 
            // AddTeacher_btn
            // 
            AddTeacher_btn.Cursor = Cursors.Hand;
            AddTeacher_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            AddTeacher_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            AddTeacher_btn.FlatStyle = FlatStyle.Flat;
            AddTeacher_btn.ForeColor = Color.Black;
            AddTeacher_btn.ImageAlign = ContentAlignment.MiddleLeft;
            AddTeacher_btn.Location = new Point(9, 307);
            AddTeacher_btn.Margin = new Padding(4, 3, 4, 3);
            AddTeacher_btn.Name = "AddTeacher_btn";
            AddTeacher_btn.Size = new Size(233, 46);
            AddTeacher_btn.TabIndex = 4;
            AddTeacher_btn.Text = "Teachers";
            AddTeacher_btn.UseVisualStyleBackColor = true;
            AddTeacher_btn.Click += button4_Click;
            // 
            // AddStudent_btn
            // 
            AddStudent_btn.Cursor = Cursors.Hand;
            AddStudent_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            AddStudent_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            AddStudent_btn.FlatStyle = FlatStyle.Flat;
            AddStudent_btn.ForeColor = Color.Black;
            AddStudent_btn.ImageAlign = ContentAlignment.MiddleLeft;
            AddStudent_btn.Location = new Point(9, 253);
            AddStudent_btn.Margin = new Padding(4, 3, 4, 3);
            AddStudent_btn.Name = "AddStudent_btn";
            AddStudent_btn.Size = new Size(233, 46);
            AddStudent_btn.TabIndex = 3;
            AddStudent_btn.Text = "Students";
            AddStudent_btn.UseVisualStyleBackColor = true;
            AddStudent_btn.Click += AddStudent_btn_Click;
            // 
            // Dashboard_btn
            // 
            Dashboard_btn.Cursor = Cursors.Hand;
            Dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            Dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            Dashboard_btn.FlatStyle = FlatStyle.Flat;
            Dashboard_btn.ForeColor = Color.Black;
            Dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard_btn.Location = new Point(9, 201);
            Dashboard_btn.Margin = new Padding(4, 3, 4, 3);
            Dashboard_btn.Name = "Dashboard_btn";
            Dashboard_btn.Size = new Size(233, 46);
            Dashboard_btn.TabIndex = 2;
            Dashboard_btn.Text = "Dashboard";
            Dashboard_btn.UseVisualStyleBackColor = true;
            Dashboard_btn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(58, 129);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "Welcome, Admin";
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(OTHERS);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.MinimumSize = new Size(12780, 666);
            panel4.Name = "panel4";
            panel4.Size = new Size(12780, 666);
            panel4.TabIndex = 3;
            // 
            // OTHERS
            // 
            OTHERS.Controls.Add(dashboardForm);
            OTHERS.Controls.Add(billingForm);
            OTHERS.Controls.Add(schoolForm1);
            OTHERS.Dock = DockStyle.Left;
            OTHERS.Location = new Point(251, 0);
            OTHERS.Name = "OTHERS";
            OTHERS.Size = new Size(1038, 666);
            OTHERS.TabIndex = 2;
            // 
            // dashboardForm
            // 
            dashboardForm.AutoSize = true;
            dashboardForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashboardForm.Dock = DockStyle.Fill;
            dashboardForm.Location = new Point(0, 0);
            dashboardForm.Margin = new Padding(4, 3, 4, 3);
            dashboardForm.Name = "dashboardForm";
            dashboardForm.Size = new Size(1038, 666);
            dashboardForm.TabIndex = 0;
            // 
            // billingForm
            // 
            billingForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            billingForm.Dock = DockStyle.Fill;
            billingForm.Location = new Point(0, 0);
            billingForm.Margin = new Padding(4, 3, 4, 3);
            billingForm.Name = "billingForm";
            billingForm.Size = new Size(1038, 666);
            billingForm.TabIndex = 1;
            // 
            // schoolForm1
            // 
            schoolForm1.Dock = DockStyle.Fill;
            schoolForm1.Location = new Point(0, 0);
            schoolForm1.Name = "schoolForm1";
            schoolForm1.Size = new Size(1038, 666);
            schoolForm1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1290, 666);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1306, 705);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ENROLLMENT SYSTEM";
            WindowState = FormWindowState.Maximized;
            FormClosed += CLOSE;
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            OTHERS.ResumeLayout(false);
            OTHERS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddTeacher_btn;
        private System.Windows.Forms.Button AddStudent_btn;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Label label1;
        private TeachersForm addTeachersForm1;
        private StudentForm addStudentForm1;
        private System.Windows.Forms.Panel panel4;
        private DashboardForm dashboardForm1;
        private System.Windows.Forms.Button Billing_btn;
        private FeesForm billingForm1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button School_btn;
        private SchoolForm school1;
        private System.Windows.Forms.Panel OTHERS;
        private DashboardForm dashboardForm;
        private TeachersForm teachersForm;
        private StudentForm studentForm;
        private FeesForm billingForm;
        private SchoolForm schoolForm;
        private SchoolForm schoolForm1;
    }
}