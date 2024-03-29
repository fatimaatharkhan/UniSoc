namespace SE_Project
{
    partial class RemoveStudent
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
            label3 = new Label();
            RemoveStudentBtn = new Button();
            unTxtbox = new TextBox();
            SocietyNameTxtbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DataGridView1 = new DataGridView();
            SearchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(183, 44);
            label3.Name = "label3";
            label3.Size = new Size(429, 45);
            label3.TabIndex = 8;
            label3.Text = "Remove Student Page";
            // 
            // RemoveStudentBtn
            // 
            RemoveStudentBtn.Location = new Point(680, 418);
            RemoveStudentBtn.Name = "RemoveStudentBtn";
            RemoveStudentBtn.Size = new Size(108, 23);
            RemoveStudentBtn.TabIndex = 18;
            RemoveStudentBtn.Text = "Remove Student";
            RemoveStudentBtn.UseVisualStyleBackColor = true;
            RemoveStudentBtn.Click += RemoveStudentBtn_Click;
            // 
            // unTxtbox
            // 
            unTxtbox.Location = new Point(302, 414);
            unTxtbox.Name = "unTxtbox";
            unTxtbox.Size = new Size(178, 23);
            unTxtbox.TabIndex = 17;
            // 
            // SocietyNameTxtbox
            // 
            SocietyNameTxtbox.Location = new Point(302, 363);
            SocietyNameTxtbox.Name = "SocietyNameTxtbox";
            SocietyNameTxtbox.Size = new Size(178, 23);
            SocietyNameTxtbox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 418);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 15;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 371);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 14;
            label1.Text = "Society Name";
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(27, 92);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowTemplate.Height = 25;
            DataGridView1.Size = new Size(740, 253);
            DataGridView1.TabIndex = 19;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(680, 367);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 20;
            SearchBtn.Text = "Search!";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // RemoveStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBtn);
            Controls.Add(DataGridView1);
            Controls.Add(RemoveStudentBtn);
            Controls.Add(unTxtbox);
            Controls.Add(SocietyNameTxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "RemoveStudent";
            Text = "RemoveStudent";
            FormClosing += RemoveStudent_FormClosing;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button RemoveStudentBtn;
        private TextBox unTxtbox;
        private TextBox SocietyNameTxtbox;
        private Label label2;
        private Label label1;
        private DataGridView DataGridView1;
        private Button SearchBtn;
    }
}