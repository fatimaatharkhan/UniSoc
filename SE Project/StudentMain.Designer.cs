﻿namespace SE_Project
{
    partial class StudentMain
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
            viewTasksBtn = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(181, 66);
            label3.Name = "label3";
            label3.Size = new Size(472, 57);
            label3.TabIndex = 8;
            label3.Text = "Student Main Page";
            // 
            // viewTasksBtn
            // 
            viewTasksBtn.Location = new Point(349, 253);
            viewTasksBtn.Name = "viewTasksBtn";
            viewTasksBtn.Size = new Size(121, 29);
            viewTasksBtn.TabIndex = 9;
            viewTasksBtn.Text = "View Tasks";
            viewTasksBtn.UseVisualStyleBackColor = true;
            viewTasksBtn.Click += viewTasksBtn_Click;
            // 
            // StudentMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(836, 469);
            Controls.Add(viewTasksBtn);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentMain";
            Text = "StudentMain";
            Load += StudentMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button viewTasksBtn;
    }
}