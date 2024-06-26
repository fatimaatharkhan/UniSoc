﻿namespace SE_Project
{
    partial class AdminMain
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
            AddSocietyBtn = new Button();
            RemoveSocietyBtn = new Button();
            ChangeHeadBtn = new Button();
            RemoveStudentsBtn = new Button();
            viewEventsBtn = new Button();
            addEventsBtn = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(214, 46);
            label3.Name = "label3";
            label3.Size = new Size(435, 57);
            label3.TabIndex = 7;
            label3.Text = "Admin Main Page";
            // 
            // AddSocietyBtn
            // 
            AddSocietyBtn.Location = new Point(109, 205);
            AddSocietyBtn.Margin = new Padding(3, 4, 3, 4);
            AddSocietyBtn.Name = "AddSocietyBtn";
            AddSocietyBtn.Size = new Size(138, 31);
            AddSocietyBtn.TabIndex = 8;
            AddSocietyBtn.Text = "Add Society";
            AddSocietyBtn.UseVisualStyleBackColor = true;
            AddSocietyBtn.Click += AddSocietyBtn_Click;
            // 
            // RemoveSocietyBtn
            // 
            RemoveSocietyBtn.Location = new Point(275, 205);
            RemoveSocietyBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveSocietyBtn.Name = "RemoveSocietyBtn";
            RemoveSocietyBtn.Size = new Size(138, 31);
            RemoveSocietyBtn.TabIndex = 9;
            RemoveSocietyBtn.Text = "Remove Society";
            RemoveSocietyBtn.UseVisualStyleBackColor = true;
            RemoveSocietyBtn.Click += RemoveSocietyBtn_Click;
            // 
            // ChangeHeadBtn
            // 
            ChangeHeadBtn.Location = new Point(606, 205);
            ChangeHeadBtn.Margin = new Padding(3, 4, 3, 4);
            ChangeHeadBtn.Name = "ChangeHeadBtn";
            ChangeHeadBtn.Size = new Size(138, 31);
            ChangeHeadBtn.TabIndex = 10;
            ChangeHeadBtn.Text = "Change Head";
            ChangeHeadBtn.UseVisualStyleBackColor = true;
            ChangeHeadBtn.Click += ChangeHeadBtn_Click;
            // 
            // RemoveStudentsBtn
            // 
            RemoveStudentsBtn.Location = new Point(439, 205);
            RemoveStudentsBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveStudentsBtn.Name = "RemoveStudentsBtn";
            RemoveStudentsBtn.Size = new Size(138, 31);
            RemoveStudentsBtn.TabIndex = 11;
            RemoveStudentsBtn.Text = "Remove Students";
            RemoveStudentsBtn.UseVisualStyleBackColor = true;
            RemoveStudentsBtn.Click += RemoveStudentsBtn_Click;
            // 
            // viewEventsBtn
            // 
            viewEventsBtn.Location = new Point(275, 266);
            viewEventsBtn.Margin = new Padding(3, 4, 3, 4);
            viewEventsBtn.Name = "viewEventsBtn";
            viewEventsBtn.Size = new Size(138, 31);
            viewEventsBtn.TabIndex = 12;
            viewEventsBtn.Text = "View Events";
            viewEventsBtn.UseVisualStyleBackColor = true;
            viewEventsBtn.Click += viewEventsBtn_Click;
            // 
            // addEventsBtn
            // 
            addEventsBtn.Location = new Point(439, 266);
            addEventsBtn.Margin = new Padding(3, 4, 3, 4);
            addEventsBtn.Name = "addEventsBtn";
            addEventsBtn.Size = new Size(138, 31);
            addEventsBtn.TabIndex = 13;
            addEventsBtn.Text = "Add Events";
            addEventsBtn.UseVisualStyleBackColor = true;
            addEventsBtn.Click += addEventsBtn_Click;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(846, 453);
            Controls.Add(addEventsBtn);
            Controls.Add(viewEventsBtn);
            Controls.Add(RemoveStudentsBtn);
            Controls.Add(ChangeHeadBtn);
            Controls.Add(RemoveSocietyBtn);
            Controls.Add(AddSocietyBtn);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminMain";
            Text = "AdminMain";
            Load += AdminMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button AddSocietyBtn;
        private Button RemoveSocietyBtn;
        private Button ChangeHeadBtn;
        private Button RemoveStudentsBtn;
        private Button viewEventsBtn;
        private Button addEventsBtn;
    }
}