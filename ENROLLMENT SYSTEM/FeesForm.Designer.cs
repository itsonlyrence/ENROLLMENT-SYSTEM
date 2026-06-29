namespace ENROLLMENTSYSTEM
{
    partial class FeesForm
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
            panel5 = new Panel();
            dataGridView3 = new DataGridView();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDeletefees = new DataGridViewImageColumn();
            txtAmount = new TextBox();
            txtDesc = new TextBox();
            label12 = new Label();
            label11 = new Label();
            button3 = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            txtID = new TextBox();
            label1 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView3);
            panel5.Location = new Point(44, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(924, 534);
            panel5.TabIndex = 8;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column17, Column18, Column19, colEdit, colDeletefees });
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(924, 534);
            dataGridView3.TabIndex = 1;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Column17
            // 
            Column17.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column17.HeaderText = "Id";
            Column17.Name = "Column17";
            Column17.Width = 42;
            // 
            // Column18
            // 
            Column18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column18.HeaderText = "Fees";
            Column18.Name = "Column18";
            // 
            // Column19
            // 
            Column19.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column19.HeaderText = "Amount";
            Column19.Name = "Column19";
            Column19.Width = 76;
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEdit.HeaderText = "";
            colEdit.Name = "colEdit";
            colEdit.ToolTipText = "Open Academic Year";
            colEdit.Width = 5;
            // 
            // colDeletefees
            // 
            colDeletefees.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDeletefees.HeaderText = "";
            colDeletefees.Name = "colDeletefees";
            colDeletefees.Width = 5;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(742, 14);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(240, 23);
            txtAmount.TabIndex = 7;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(439, 15);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(240, 23);
            txtDesc.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(685, 18);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 5;
            label12.Text = "Amount";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(340, 20);
            label11.Name = "label11";
            label11.Size = new Size(93, 15);
            label11.TabIndex = 4;
            label11.Text = "Fees Description";
            // 
            // button3
            // 
            button3.Location = new Point(374, 48);
            button3.Name = "button3";
            button3.Size = new Size(159, 23);
            button3.TabIndex = 3;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(209, 48);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(159, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(44, 48);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 614);
            panel1.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(94, 15);
            txtID.Name = "txtID";
            txtID.Size = new Size(240, 23);
            txtID.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 10;
            label1.Text = "Fees ID";
            // 
            // FeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FeesForm";
            Size = new Size(1003, 614);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView3;
        private Panel panel5;
        private Panel panel1;
        private TextBox txtID;
        private Label label1;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDeletefees;
    }
}
