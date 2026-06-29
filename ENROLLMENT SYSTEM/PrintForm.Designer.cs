namespace ENROLLMENT_SYSTEM
{
    partial class PrintForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            printSurface = new Panel();
            label16 = new Label();
            label15 = new Label();
            teacherdata = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            address = new Label();
            grade = new Label();
            section = new Label();
            lrn = new Label();
            studentname = new Label();
            label11 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            labelTotal = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            feess = new DataGridView();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            print = new Button();
            printDocument = new System.Drawing.Printing.PrintDocument();
            panel1 = new Panel();
            printDialog = new PrintDialog();
            reload = new Button();
            printSurface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacherdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)feess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // printSurface
            // 
            printSurface.Controls.Add(label16);
            printSurface.Controls.Add(label15);
            printSurface.Controls.Add(teacherdata);
            printSurface.Controls.Add(address);
            printSurface.Controls.Add(grade);
            printSurface.Controls.Add(section);
            printSurface.Controls.Add(lrn);
            printSurface.Controls.Add(studentname);
            printSurface.Controls.Add(label11);
            printSurface.Controls.Add(label14);
            printSurface.Controls.Add(label13);
            printSurface.Controls.Add(label12);
            printSurface.Controls.Add(label10);
            printSurface.Controls.Add(pictureBox2);
            printSurface.Controls.Add(label9);
            printSurface.Controls.Add(label8);
            printSurface.Controls.Add(label7);
            printSurface.Controls.Add(label6);
            printSurface.Controls.Add(label5);
            printSurface.Controls.Add(label4);
            printSurface.Controls.Add(labelTotal);
            printSurface.Controls.Add(label3);
            printSurface.Controls.Add(label2);
            printSurface.Controls.Add(label1);
            printSurface.Controls.Add(feess);
            printSurface.Controls.Add(dataGridView1);
            printSurface.Controls.Add(pictureBox1);
            printSurface.Location = new Point(27, 3);
            printSurface.Name = "printSurface";
            printSurface.Size = new Size(510, 675);
            printSurface.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(220, 169);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 27;
            label16.Text = "Teachers";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(220, 397);
            label15.Name = "label15";
            label15.Size = new Size(68, 15);
            label15.TabIndex = 26;
            label15.Text = "FINANCIAL";
            // 
            // teacherdata
            // 
            teacherdata.AllowUserToAddRows = false;
            teacherdata.AllowUserToDeleteRows = false;
            teacherdata.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            teacherdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            teacherdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherdata.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            teacherdata.EnableHeadersVisualStyles = false;
            teacherdata.Location = new Point(3, 186);
            teacherdata.Margin = new Padding(4, 3, 4, 3);
            teacherdata.Name = "teacherdata";
            teacherdata.ReadOnly = true;
            teacherdata.RowHeadersVisible = false;
            teacherdata.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            teacherdata.Size = new Size(501, 208);
            teacherdata.TabIndex = 25;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Gender";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 74;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 70;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(138, 143);
            address.Name = "address";
            address.Size = new Size(44, 15);
            address.TabIndex = 24;
            address.Text = "label19";
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Location = new Point(394, 120);
            grade.Name = "grade";
            grade.Size = new Size(44, 15);
            grade.TabIndex = 23;
            grade.Text = "label18";
            // 
            // section
            // 
            section.AutoSize = true;
            section.Location = new Point(394, 105);
            section.Name = "section";
            section.Size = new Size(44, 15);
            section.TabIndex = 22;
            section.Text = "label17";
            // 
            // lrn
            // 
            lrn.AutoSize = true;
            lrn.Location = new Point(143, 120);
            lrn.Name = "lrn";
            lrn.Size = new Size(44, 15);
            lrn.TabIndex = 21;
            lrn.Text = "label16";
            // 
            // studentname
            // 
            studentname.AutoSize = true;
            studentname.Location = new Point(143, 105);
            studentname.Name = "studentname";
            studentname.Size = new Size(44, 15);
            studentname.TabIndex = 20;
            studentname.Text = "label15";
            // 
            // label11
            // 
            label11.Location = new Point(109, 18);
            label11.Name = "label11";
            label11.Size = new Size(279, 15);
            label11.TabIndex = 16;
            label11.Text = "Department of Education";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(139, 70);
            label14.Name = "label14";
            label14.Size = new Size(226, 20);
            label14.TabIndex = 19;
            label14.Text = "CERTIFICATE OF ENROLLMENT";
            // 
            // label13
            // 
            label13.Location = new Point(109, 48);
            label13.Name = "label13";
            label13.Size = new Size(279, 15);
            label13.TabIndex = 18;
            label13.Text = "Tarlac Province";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Location = new Point(109, 33);
            label12.Name = "label12";
            label12.Size = new Size(279, 15);
            label12.TabIndex = 17;
            label12.Text = "Region III – Central Luzon";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Location = new Point(109, -1);
            label10.Name = "label10";
            label10.Size = new Size(279, 23);
            label10.TabIndex = 15;
            label10.Text = "Republic of the Philippines";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(388, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(314, 120);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 12;
            label9.Text = "Grade Level: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 143);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 11;
            label8.Text = "Student Address: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 120);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 10;
            label7.Text = "LRN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 105);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 105);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 8;
            label5.Text = "Student Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(326, 602);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 7;
            label4.Text = "Total Amount Due:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(440, 602);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(43, 15);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "123456";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 654);
            label3.Name = "label3";
            label3.Size = new Size(380, 15);
            label3.TabIndex = 5;
            label3.Text = "*The school has received the student’s (Full/Half Installment) payment.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 638);
            label2.Name = "label2";
            label2.Size = new Size(461, 15);
            label2.TabIndex = 4;
            label2.Text = "*The above has been paid by the student by (cash/credit/bank Transfer/ Home Credit).";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 615);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 3;
            label1.Text = "Terms and Conditions";
            // 
            // feess
            // 
            feess.AllowUserToAddRows = false;
            feess.AllowUserToDeleteRows = false;
            feess.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            feess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            feess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            feess.Columns.AddRange(new DataGridViewColumn[] { Column17, Column18, Column19 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            feess.DefaultCellStyle = dataGridViewCellStyle3;
            feess.EnableHeadersVisualStyles = false;
            feess.Location = new Point(4, 415);
            feess.Name = "feess";
            feess.ReadOnly = true;
            feess.RowHeadersVisible = false;
            feess.RowTemplate.Height = 25;
            feess.Size = new Size(502, 185);
            feess.TabIndex = 2;
            // 
            // Column17
            // 
            Column17.HeaderText = "Id";
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            Column17.Visible = false;
            // 
            // Column18
            // 
            Column18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column18.HeaderText = "Description";
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            // 
            // Column19
            // 
            Column19.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column19.HeaderText = "Amount";
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            Column19.Width = 76;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 992);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-17, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // print
            // 
            print.Location = new Point(433, 13);
            print.Name = "print";
            print.Size = new Size(75, 23);
            print.TabIndex = 1;
            print.Text = "print";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // panel1
            // 
            panel1.Controls.Add(printSurface);
            panel1.Location = new Point(-17, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 690);
            panel1.TabIndex = 2;
            // 
            // printDialog
            // 
            printDialog.UseEXDialog = true;
            // 
            // reload
            // 
            reload.Location = new Point(352, 12);
            reload.Name = "reload";
            reload.Size = new Size(75, 23);
            reload.TabIndex = 3;
            reload.Text = "reload";
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // PrintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(541, 479);
            Controls.Add(reload);
            Controls.Add(panel1);
            Controls.Add(print);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PrintForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintForm";
            printSurface.ResumeLayout(false);
            printSurface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teacherdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)feess).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel printSurface;
        private DataGridView dataGridView1;
        private Button print;
        private System.Drawing.Printing.PrintDocument printDocument;
        private DataGridView feess;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label labelTotal;
        private Label label12;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label14;
        private Label label13;
        private Label address;
        private Label grade;
        private Label section;
        private Label lrn;
        private Label studentname;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private Panel panel1;
        private PrintDialog printDialog;
        private DataGridView teacherdata;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label15;
        private Label label16;
        private Button reload;
    }
}