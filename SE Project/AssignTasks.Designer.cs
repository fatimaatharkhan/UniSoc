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
            cmbStudents = new ComboBox();
            txtTaskDesc = new TextBox();
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
            label2.Location = new Point(78, 192);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 14;
            label2.Text = "Task Description";
            // 
            // cmbStudents
            // 
            cmbStudents.DisplayMember = "StudentName";
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(241, 158);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(151, 28);
            cmbStudents.TabIndex = 16;
            cmbStudents.ValueMember = "StudentId";
            cmbStudents.SelectedIndexChanged += cmbStudents_SelectedIndexChanged;
            // 
            // txtTaskDesc
            // 
            txtTaskDesc.Location = new Point(241, 192);
            txtTaskDesc.Name = "txtTaskDesc";
            txtTaskDesc.Size = new Size(151, 27);
            txtTaskDesc.TabIndex = 17;
            // 
            // assignBtn
            // 
            assignBtn.Location = new Point(241, 235);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(94, 29);
            assignBtn.TabIndex = 19;
            assignBtn.Text = "Assign";
            assignBtn.UseVisualStyleBackColor = true;
            assignBtn.Click += assignBtn_Click;
            // 
            // AssignTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(assignBtn);
            Controls.Add(txtTaskDesc);
            Controls.Add(cmbStudents);
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
        private ComboBox cmbStudents;
        private TextBox txtTaskDesc;
        private Button assignBtn;
    }
}