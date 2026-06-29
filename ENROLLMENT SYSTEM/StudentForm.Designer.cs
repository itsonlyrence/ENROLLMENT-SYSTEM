
namespace ENROLLMENTSYSTEM
{
    partial class StudentForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            Print = new Button();
            gg = new Label();
            student_status = new ComboBox();
            label8 = new Label();
            student_deleteBtn = new Button();
            student_clearBtn = new Button();
            student_updateBtn = new Button();
            student_addBtn = new Button();
            student_importBtn = new Button();
            panel3 = new Panel();
            student_image = new PictureBox();
            student_section = new ComboBox();
            label7 = new Label();
            student_grade = new ComboBox();
            label6 = new Label();
            student_address = new TextBox();
            label5 = new Label();
            student_gender = new ComboBox();
            label4 = new Label();
            student_name = new TextBox();
            label3 = new Label();
            student_id = new TextBox();
            label2 = new Label();
            id = new TextBox();
            panel1 = new Panel();
            student_studentData = new DataGridView();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_image).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_studentData).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Print);
            panel2.Controls.Add(gg);
            panel2.Controls.Add(student_status);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(student_deleteBtn);
            panel2.Controls.Add(student_clearBtn);
            panel2.Controls.Add(student_updateBtn);
            panel2.Controls.Add(student_addBtn);
            panel2.Controls.Add(student_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(student_section);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(student_grade);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(student_address);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(student_gender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(student_name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(student_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(4, 343);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 255);
            panel2.TabIndex = 3;
            // 
            // Print
            // 
            Print.BackColor = Color.FromArgb(0, 0, 192);
            Print.FlatAppearance.BorderSize = 0;
            Print.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            Print.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            Print.FlatStyle = FlatStyle.Flat;
            Print.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Print.ForeColor = Color.White;
            Print.Location = new Point(756, 203);
            Print.Margin = new Padding(4, 3, 4, 3);
            Print.Name = "Print";
            Print.Size = new Size(119, 40);
            Print.TabIndex = 21;
            Print.Text = "Print";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click;
            // 
            // gg
            // 
            gg.AutoSize = true;
            gg.Location = new Point(872, 7);
            gg.Name = "gg";
            gg.Size = new Size(38, 15);
            gg.TabIndex = 20;
            gg.Text = "label9";
            gg.Visible = false;
            // 
            // student_status
            // 
            student_status.FormattingEnabled = true;
            student_status.Items.AddRange(new object[] { "Enrolled", "Pending", "Graduated" });
            student_status.Location = new Point(617, 69);
            student_status.Margin = new Padding(4, 3, 4, 3);
            student_status.Name = "student_status";
            student_status.Size = new Size(167, 23);
            student_status.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(564, 73);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 18;
            label8.Text = "Status:";
            // 
            // student_deleteBtn
            // 
            student_deleteBtn.BackColor = Color.FromArgb(0, 0, 192);
            student_deleteBtn.FlatAppearance.BorderSize = 0;
            student_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            student_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            student_deleteBtn.FlatStyle = FlatStyle.Flat;
            student_deleteBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            student_deleteBtn.ForeColor = Color.White;
            student_deleteBtn.Location = new Point(616, 203);
            student_deleteBtn.Margin = new Padding(4, 3, 4, 3);
            student_deleteBtn.Name = "student_deleteBtn";
            student_deleteBtn.Size = new Size(119, 40);
            student_deleteBtn.TabIndex = 17;
            student_deleteBtn.Text = "Delete";
            student_deleteBtn.UseVisualStyleBackColor = false;
            student_deleteBtn.Click += student_deleteBtn_Click;
            // 
            // student_clearBtn
            // 
            student_clearBtn.BackColor = Color.FromArgb(0, 0, 192);
            student_clearBtn.FlatAppearance.BorderSize = 0;
            student_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            student_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            student_clearBtn.FlatStyle = FlatStyle.Flat;
            student_clearBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            student_clearBtn.ForeColor = Color.White;
            student_clearBtn.Location = new Point(469, 203);
            student_clearBtn.Margin = new Padding(4, 3, 4, 3);
            student_clearBtn.Name = "student_clearBtn";
            student_clearBtn.Size = new Size(119, 40);
            student_clearBtn.TabIndex = 16;
            student_clearBtn.Text = "Clear";
            student_clearBtn.UseVisualStyleBackColor = false;
            student_clearBtn.Click += student_clearBtn_Click;
            // 
            // student_updateBtn
            // 
            student_updateBtn.BackColor = Color.FromArgb(0, 0, 192);
            student_updateBtn.FlatAppearance.BorderSize = 0;
            student_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            student_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            student_updateBtn.FlatStyle = FlatStyle.Flat;
            student_updateBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            student_updateBtn.ForeColor = Color.White;
            student_updateBtn.Location = new Point(309, 203);
            student_updateBtn.Margin = new Padding(4, 3, 4, 3);
            student_updateBtn.Name = "student_updateBtn";
            student_updateBtn.Size = new Size(119, 40);
            student_updateBtn.TabIndex = 15;
            student_updateBtn.Text = "Update";
            student_updateBtn.UseVisualStyleBackColor = false;
            student_updateBtn.Click += student_updateBtn_Click;
            // 
            // student_addBtn
            // 
            student_addBtn.BackColor = Color.FromArgb(0, 0, 192);
            student_addBtn.FlatAppearance.BorderSize = 0;
            student_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            student_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            student_addBtn.FlatStyle = FlatStyle.Flat;
            student_addBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            student_addBtn.ForeColor = Color.White;
            student_addBtn.Location = new Point(142, 203);
            student_addBtn.Margin = new Padding(4, 3, 4, 3);
            student_addBtn.Name = "student_addBtn";
            student_addBtn.Size = new Size(119, 40);
            student_addBtn.TabIndex = 14;
            student_addBtn.Text = "Add";
            student_addBtn.UseVisualStyleBackColor = false;
            student_addBtn.Click += button2_Click;
            // 
            // student_importBtn
            // 
            student_importBtn.BackColor = Color.FromArgb(0, 0, 192);
            student_importBtn.FlatAppearance.BorderSize = 0;
            student_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            student_importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            student_importBtn.FlatStyle = FlatStyle.Flat;
            student_importBtn.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            student_importBtn.ForeColor = Color.White;
            student_importBtn.Location = new Point(875, 123);
            student_importBtn.Margin = new Padding(4, 3, 4, 3);
            student_importBtn.Name = "student_importBtn";
            student_importBtn.Size = new Size(93, 27);
            student_importBtn.TabIndex = 13;
            student_importBtn.Text = "Import";
            student_importBtn.UseVisualStyleBackColor = false;
            student_importBtn.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(student_image);
            panel3.Location = new Point(875, 28);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(93, 99);
            panel3.TabIndex = 12;
            // 
            // student_image
            // 
            student_image.Location = new Point(0, 0);
            student_image.Margin = new Padding(4, 3, 4, 3);
            student_image.Name = "student_image";
            student_image.Size = new Size(93, 99);
            student_image.SizeMode = PictureBoxSizeMode.StretchImage;
            student_image.TabIndex = 1;
            student_image.TabStop = false;
            // 
            // student_section
            // 
            student_section.FormattingEnabled = true;
            student_section.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            student_section.Location = new Point(617, 24);
            student_section.Margin = new Padding(4, 3, 4, 3);
            student_section.Name = "student_section";
            student_section.Size = new Size(167, 23);
            student_section.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(556, 28);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 10;
            label7.Text = "Section:";
            // 
            // student_grade
            // 
            student_grade.FormattingEnabled = true;
            student_grade.Items.AddRange(new object[] { "Grade 11", "Grade 12" });
            student_grade.Location = new Point(364, 114);
            student_grade.Margin = new Padding(4, 3, 4, 3);
            student_grade.Name = "student_grade";
            student_grade.Size = new Size(167, 23);
            student_grade.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 118);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 8;
            label6.Text = "Grade:";
            // 
            // student_address
            // 
            student_address.Location = new Point(364, 24);
            student_address.Margin = new Padding(4, 3, 4, 3);
            student_address.Multiline = true;
            student_address.Name = "student_address";
            student_address.Size = new Size(167, 76);
            student_address.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 31);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 6;
            label5.Text = "Address:";
            // 
            // student_gender
            // 
            student_gender.FormattingEnabled = true;
            student_gender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            student_gender.Location = new Point(94, 120);
            student_gender.Margin = new Padding(4, 3, 4, 3);
            student_gender.Name = "student_gender";
            student_gender.Size = new Size(167, 23);
            student_gender.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 123);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "Gender:";
            // 
            // student_name
            // 
            student_name.Location = new Point(93, 72);
            student_name.Margin = new Padding(4, 3, 4, 3);
            student_name.Multiline = true;
            student_name.Name = "student_name";
            student_name.Size = new Size(167, 28);
            student_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 78);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // student_id
            // 
            student_id.Location = new Point(93, 24);
            student_id.Margin = new Padding(4, 3, 4, 3);
            student_id.Multiline = true;
            student_id.Name = "student_id";
            student_id.Size = new Size(118, 28);
            student_id.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 0;
            label2.Text = "LRN:";
            // 
            // id
            // 
            id.Location = new Point(-15, 288);
            id.Margin = new Padding(4, 3, 4, 3);
            id.Multiline = true;
            id.Name = "id";
            id.Size = new Size(139, 28);
            id.TabIndex = 20;
            id.Visible = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(student_studentData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(id);
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.MinimumSize = new Size(990, 321);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 321);
            panel1.TabIndex = 2;
            // 
            // student_studentData
            // 
            student_studentData.AllowUserToAddRows = false;
            student_studentData.AllowUserToDeleteRows = false;
            student_studentData.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            student_studentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            student_studentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_studentData.EnableHeadersVisualStyles = false;
            student_studentData.Location = new Point(23, 54);
            student_studentData.Margin = new Padding(4, 3, 4, 3);
            student_studentData.Name = "student_studentData";
            student_studentData.ReadOnly = true;
            student_studentData.RowHeadersVisible = false;
            student_studentData.Size = new Size(945, 258);
            student_studentData.TabIndex = 1;
            student_studentData.CellClick += student_studentData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 0;
            label1.Text = "Student's Data";
            // 
            // StudentForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "StudentForm";
            Size = new Size(1006, 602);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)student_image).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)student_studentData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button student_deleteBtn;
        private System.Windows.Forms.Button student_clearBtn;
        private System.Windows.Forms.Button student_updateBtn;
        private System.Windows.Forms.Button student_addBtn;
        private System.Windows.Forms.Button student_importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox student_section;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox student_grade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox student_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView student_studentData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox student_image;
        private System.Windows.Forms.ComboBox student_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id;
        private Label gg;
        private Button Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
