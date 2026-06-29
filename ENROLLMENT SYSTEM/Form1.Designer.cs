
namespace ENROLLMENTSYSTEM
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            bottom = new Panel();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            right = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            top = new Panel();
            panel7 = new Panel();
            left = new Panel();
            pictureBox1 = new PictureBox();
            bottom.SuspendLayout();
            right.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 278);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(612, 23);
            label1.TabIndex = 0;
            label1.Text = "ENROLLMENT SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bottom
            // 
            bottom.Controls.Add(panel2);
            bottom.Dock = DockStyle.Bottom;
            bottom.Location = new Point(0, 323);
            bottom.Margin = new Padding(4, 3, 4, 3);
            bottom.Name = "bottom";
            bottom.Size = new Size(612, 23);
            bottom.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(12, 23);
            panel2.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // right
            // 
            right.Controls.Add(panel4);
            right.Location = new Point(589, 0);
            right.Margin = new Padding(4, 3, 4, 3);
            right.Name = "right";
            right.Size = new Size(23, 346);
            right.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 1);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(23, 346);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.CornflowerBlue;
            panel5.Location = new Point(0, -1);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(23, 346);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(top);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(612, 23);
            panel6.TabIndex = 4;
            // 
            // top
            // 
            top.BackColor = Color.CornflowerBlue;
            top.Location = new Point(-1, 0);
            top.Margin = new Padding(4, 3, 4, 3);
            top.Name = "top";
            top.Size = new Size(614, 23);
            top.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Red;
            panel7.Location = new Point(1, 0);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(612, 23);
            panel7.TabIndex = 3;
            // 
            // left
            // 
            left.BackColor = Color.Red;
            left.Location = new Point(0, 0);
            left.Margin = new Padding(4, 3, 4, 3);
            left.Name = "left";
            left.Size = new Size(23, 23);
            left.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(612, 346);
            Controls.Add(panel6);
            Controls.Add(left);
            Controls.Add(pictureBox1);
            Controls.Add(right);
            Controls.Add(bottom);
            Controls.Add(label1);
            Cursor = Cursors.WaitCursor;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            bottom.ResumeLayout(false);
            right.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Panel right;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel left;
        private Panel top;
        private PictureBox pictureBox1;
    }
}

