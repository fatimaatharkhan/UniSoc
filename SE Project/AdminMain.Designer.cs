namespace SE_Project
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
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(224, 54);
            label3.Name = "label3";
            label3.Size = new Size(341, 45);
            label3.TabIndex = 7;
            label3.Text = "Admin Main Page";
            // 
            // AddSocietyBtn
            // 
            AddSocietyBtn.Location = new Point(78, 307);
            AddSocietyBtn.Name = "AddSocietyBtn";
            AddSocietyBtn.Size = new Size(131, 23);
            AddSocietyBtn.TabIndex = 8;
            AddSocietyBtn.Text = "Add Society";
            AddSocietyBtn.UseVisualStyleBackColor = true;
            AddSocietyBtn.Click += AddSocietyBtn_Click;
            // 
            // RemoveSocietyBtn
            // 
            RemoveSocietyBtn.Location = new Point(265, 307);
            RemoveSocietyBtn.Name = "RemoveSocietyBtn";
            RemoveSocietyBtn.Size = new Size(121, 23);
            RemoveSocietyBtn.TabIndex = 9;
            RemoveSocietyBtn.Text = "Remove Society";
            RemoveSocietyBtn.UseVisualStyleBackColor = true;
            RemoveSocietyBtn.Click += RemoveSocietyBtn_Click;
            // 
            // ChangeHeadBtn
            // 
            ChangeHeadBtn.Location = new Point(431, 307);
            ChangeHeadBtn.Name = "ChangeHeadBtn";
            ChangeHeadBtn.Size = new Size(107, 23);
            ChangeHeadBtn.TabIndex = 10;
            ChangeHeadBtn.Text = "Change Head";
            ChangeHeadBtn.UseVisualStyleBackColor = true;
            ChangeHeadBtn.Click += ChangeHeadBtn_Click;
            // 
            // RemoveStudentsBtn
            // 
            RemoveStudentsBtn.Location = new Point(579, 307);
            RemoveStudentsBtn.Name = "RemoveStudentsBtn";
            RemoveStudentsBtn.Size = new Size(120, 23);
            RemoveStudentsBtn.TabIndex = 11;
            RemoveStudentsBtn.Text = "Remove Students";
            RemoveStudentsBtn.UseVisualStyleBackColor = true;
            RemoveStudentsBtn.Click += RemoveStudentsBtn_Click;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveStudentsBtn);
            Controls.Add(ChangeHeadBtn);
            Controls.Add(RemoveSocietyBtn);
            Controls.Add(AddSocietyBtn);
            Controls.Add(label3);
            Name = "AdminMain";
            Text = "AdminMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button AddSocietyBtn;
        private Button RemoveSocietyBtn;
        private Button ChangeHeadBtn;
        private Button RemoveStudentsBtn;
    }
}