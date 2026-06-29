
namespace ENROLLMENTSYSTEM
{
    partial class TeachersForm
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
            teacher_grade = new ComboBox();
            label6 = new Label();
            teacher_deleteBtn = new Button();
            teacher_clearBtn = new Button();
            teacher_updateBtn = new Button();
            teacher_addBtn = new Button();
            button1 = new Button();
            panel3 = new Panel();
            teacher_image = new PictureBox();
            teacher_status = new ComboBox();
            label7 = new Label();
            teacher_address = new TextBox();
            label5 = new Label();
            teacher_gender = new ComboBox();
            label4 = new Label();
            teacher_name = new TextBox();
            label3 = new Label();
            teacher_id = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            teacher_gridData = new DataGridView();
            label1 = new Label();
            id = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_image).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_gridData).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(teacher_grade);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(teacher_deleteBtn);
            panel2.Controls.Add(teacher_clearBtn);
            panel2.Controls.Add(teacher_updateBtn);
            panel2.Controls.Add(teacher_addBtn);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(teacher_status);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(teacher_address);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(teacher_gender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(teacher_name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(teacher_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(14, 372);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(992, 264);
            panel2.TabIndex = 5;
            // 
            // teacher_grade
            // 
            teacher_grade.FormattingEnabled = true;
            teacher_grade.Items.AddRange(new object[] { "Grade 11", "Grade 12" });
            teacher_grade.Location = new Point(627, 72);
            teacher_grade.Margin = new Padding(4, 3, 4, 3);
            teacher_grade.Name = "teacher_grade";
            teacher_grade.Size = new Size(167, 23);
            teacher_grade.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 75);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 18;
            label6.Text = "Level Teacher:";
            // 
            // teacher_deleteBtn
            // 
            teacher_deleteBtn.BackColor = Color.FromArgb(0, 0, 192);
            teacher_deleteBtn.FlatAppearance.BorderSize = 0;
            teacher_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            teacher_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            teacher_deleteBtn.FlatStyle = FlatStyle.Flat;
            teacher_deleteBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            teacher_deleteBtn.ForeColor = Color.White;
            teacher_deleteBtn.Location = new Point(671, 201);
            teacher_deleteBtn.Margin = new Padding(4, 3, 4, 3);
            teacher_deleteBtn.Name = "teacher_deleteBtn";
            teacher_deleteBtn.Size = new Size(119, 40);
            teacher_deleteBtn.TabIndex = 17;
            teacher_deleteBtn.Text = "Delete";
            teacher_deleteBtn.UseVisualStyleBackColor = false;
            teacher_deleteBtn.Click += teacher_deleteBtn_Click;
            // 
            // teacher_clearBtn
            // 
            teacher_clearBtn.BackColor = Color.FromArgb(0, 0, 192);
            teacher_clearBtn.FlatAppearance.BorderSize = 0;
            teacher_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            teacher_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            teacher_clearBtn.FlatStyle = FlatStyle.Flat;
            teacher_clearBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            teacher_clearBtn.ForeColor = Color.White;
            teacher_clearBtn.Location = new Point(524, 201);
            teacher_clearBtn.Margin = new Padding(4, 3, 4, 3);
            teacher_clearBtn.Name = "teacher_clearBtn";
            teacher_clearBtn.Size = new Size(119, 40);
            teacher_clearBtn.TabIndex = 16;
            teacher_clearBtn.Text = "Clear";
            teacher_clearBtn.UseVisualStyleBackColor = false;
            teacher_clearBtn.Click += teacher_clearBtn_Click;
            // 
            // teacher_updateBtn
            // 
            teacher_updateBtn.BackColor = Color.FromArgb(0, 0, 192);
            teacher_updateBtn.FlatAppearance.BorderSize = 0;
            teacher_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            teacher_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            teacher_updateBtn.FlatStyle = FlatStyle.Flat;
            teacher_updateBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            teacher_updateBtn.ForeColor = Color.White;
            teacher_updateBtn.Location = new Point(364, 201);
            teacher_updateBtn.Margin = new Padding(4, 3, 4, 3);
            teacher_updateBtn.Name = "teacher_updateBtn";
            teacher_updateBtn.Size = new Size(119, 40);
            teacher_updateBtn.TabIndex = 15;
            teacher_updateBtn.Text = "Update";
            teacher_updateBtn.UseVisualStyleBackColor = false;
            teacher_updateBtn.Click += teacher_updateBtn_Click;
            // 
            // teacher_addBtn
            // 
            teacher_addBtn.BackColor = Color.FromArgb(0, 0, 192);
            teacher_addBtn.FlatAppearance.BorderSize = 0;
            teacher_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            teacher_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            teacher_addBtn.FlatStyle = FlatStyle.Flat;
            teacher_addBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            teacher_addBtn.ForeColor = Color.White;
            teacher_addBtn.Location = new Point(217, 201);
            teacher_addBtn.Margin = new Padding(4, 3, 4, 3);
            teacher_addBtn.Name = "teacher_addBtn";
            teacher_addBtn.Size = new Size(119, 40);
            teacher_addBtn.TabIndex = 14;
            teacher_addBtn.Text = "Add";
            teacher_addBtn.UseVisualStyleBackColor = true;
            teacher_addBtn.Click += teacher_addBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(875, 123);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(93, 27);
            button1.TabIndex = 13;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(teacher_image);
            panel3.Location = new Point(875, 28);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(93, 99);
            panel3.TabIndex = 12;
            // 
            // teacher_image
            // 
            teacher_image.Location = new Point(0, 0);
            teacher_image.Margin = new Padding(4, 3, 4, 3);
            teacher_image.Name = "teacher_image";
            teacher_image.Size = new Size(93, 99);
            teacher_image.SizeMode = PictureBoxSizeMode.StretchImage;
            teacher_image.TabIndex = 0;
            teacher_image.TabStop = false;
            // 
            // teacher_status
            // 
            teacher_status.FormattingEnabled = true;
            teacher_status.Items.AddRange(new object[] { "Active", "Inactive" });
            teacher_status.Location = new Point(627, 28);
            teacher_status.Margin = new Padding(4, 3, 4, 3);
            teacher_status.Name = "teacher_status";
            teacher_status.Size = new Size(167, 23);
            teacher_status.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(577, 31);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 10;
            label7.Text = "Status:";
            // 
            // teacher_address
            // 
            teacher_address.Location = new Point(364, 24);
            teacher_address.Margin = new Padding(4, 3, 4, 3);
            teacher_address.Multiline = true;
            teacher_address.Name = "teacher_address";
            teacher_address.Size = new Size(167, 76);
            teacher_address.TabIndex = 7;
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
            // teacher_gender
            // 
            teacher_gender.FormattingEnabled = true;
            teacher_gender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            teacher_gender.Location = new Point(94, 120);
            teacher_gender.Margin = new Padding(4, 3, 4, 3);
            teacher_gender.Name = "teacher_gender";
            teacher_gender.Size = new Size(167, 23);
            teacher_gender.TabIndex = 5;
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
            // teacher_name
            // 
            teacher_name.Location = new Point(93, 72);
            teacher_name.Margin = new Padding(4, 3, 4, 3);
            teacher_name.Multiline = true;
            teacher_name.Name = "teacher_name";
            teacher_name.Size = new Size(167, 28);
            teacher_name.TabIndex = 3;
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
            // teacher_id
            // 
            teacher_id.Location = new Point(93, 24);
            teacher_id.Margin = new Padding(4, 3, 4, 3);
            teacher_id.Multiline = true;
            teacher_id.Name = "teacher_id";
            teacher_id.Size = new Size(118, 28);
            teacher_id.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 0;
            label2.Text = "Teacher ID:";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(teacher_gridData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(id);
            panel1.Location = new Point(14, 17);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 333);
            panel1.TabIndex = 4;
            // 
            // teacher_gridData
            // 
            teacher_gridData.AllowUserToAddRows = false;
            teacher_gridData.AllowUserToDeleteRows = false;
            teacher_gridData.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            teacher_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            teacher_gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacher_gridData.EnableHeadersVisualStyles = false;
            teacher_gridData.Location = new Point(23, 54);
            teacher_gridData.Margin = new Padding(4, 3, 4, 3);
            teacher_gridData.Name = "teacher_gridData";
            teacher_gridData.ReadOnly = true;
            teacher_gridData.RowHeadersVisible = false;
            teacher_gridData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            teacher_gridData.Size = new Size(945, 258);
            teacher_gridData.TabIndex = 3;
            teacher_gridData.CellContentClick += teacher_gridData_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 0;
            label1.Text = "Teacher's Data";
            // 
            // id
            // 
            id.Location = new Point(-21, 299);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 2;
            id.Visible = false;
            // 
            // TeachersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TeachersForm";
            Size = new Size(1010, 639);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teacher_image).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_gridData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button teacher_deleteBtn;
        private System.Windows.Forms.Button teacher_clearBtn;
        private System.Windows.Forms.Button teacher_updateBtn;
        private System.Windows.Forms.Button teacher_addBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox teacher_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox teacher_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacher_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox teacher_image;
        private System.Windows.Forms.TextBox id;
        private DataGridView teacher_gridData;
        private ComboBox teacher_grade;
        private Label label6;
    }
}
