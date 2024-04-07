namespace SE_Project
{
    partial class AssignTasks
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            assignBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 161);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(241, 43);
            label3.Name = "label3";
            label3.Size = new Size(326, 57);
            label3.TabIndex = 13;
            label3.Text = "Assign Tasks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 227);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 14;
            label2.Text = "Task Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 287);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 15;
            label4.Text = "Task Description:";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "StudentName";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(241, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            comboBox1.ValueMember = "StudentId";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(241, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 18;
            // 
            // assignBtn
            // 
            assignBtn.Location = new Point(341, 368);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(94, 29);
            assignBtn.TabIndex = 19;
            assignBtn.Text = "Assign";
            assignBtn.UseVisualStyleBackColor = true;
            // 
            // AssignTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(assignBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AssignTasks";
            Text = "AssignTasks";
            Load += AssignTasks_Load;
            Shown += AssignTasks_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button assignBtn;
    }
}