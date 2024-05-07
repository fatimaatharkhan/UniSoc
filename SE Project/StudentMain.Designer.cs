namespace SE_Project
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
            viewSocietyBtn = new Button();
            MySocietiesBtn = new Button();
            MyEventsBtn = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(158, 50);
            label3.Name = "label3";
            label3.Size = new Size(369, 45);
            label3.TabIndex = 8;
            label3.Text = "Student Main Page";
            // 
            // viewTasksBtn
            // 
            viewTasksBtn.Location = new Point(55, 258);
            viewTasksBtn.Margin = new Padding(3, 2, 3, 2);
            viewTasksBtn.Name = "viewTasksBtn";
            viewTasksBtn.Size = new Size(106, 22);
            viewTasksBtn.TabIndex = 9;
            viewTasksBtn.Text = "View Tasks";
            viewTasksBtn.UseVisualStyleBackColor = true;
            viewTasksBtn.Click += viewTasksBtn_Click;
            // 
            // viewSocietyBtn
            // 
            viewSocietyBtn.Location = new Point(190, 257);
            viewSocietyBtn.Name = "viewSocietyBtn";
            viewSocietyBtn.Size = new Size(149, 23);
            viewSocietyBtn.TabIndex = 10;
            viewSocietyBtn.Text = "View Available Societies";
            viewSocietyBtn.UseVisualStyleBackColor = true;
            viewSocietyBtn.Click += viewSocietyBtn_Click;
            // 
            // MySocietiesBtn
            // 
            MySocietiesBtn.Location = new Point(386, 257);
            MySocietiesBtn.Name = "MySocietiesBtn";
            MySocietiesBtn.Size = new Size(108, 23);
            MySocietiesBtn.TabIndex = 11;
            MySocietiesBtn.Text = "My Societies";
            MySocietiesBtn.UseVisualStyleBackColor = true;
            MySocietiesBtn.Click += MySocietiesBtn_Click;
            // 
            // MyEventsBtn
            // 
            MyEventsBtn.Location = new Point(538, 257);
            MyEventsBtn.Name = "MyEventsBtn";
            MyEventsBtn.Size = new Size(85, 23);
            MyEventsBtn.TabIndex = 12;
            MyEventsBtn.Text = "My Events";
            MyEventsBtn.UseVisualStyleBackColor = true;
            MyEventsBtn.Click += MyEventsBtn_Click;
            // 
            // StudentMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(732, 352);
            Controls.Add(MyEventsBtn);
            Controls.Add(MySocietiesBtn);
            Controls.Add(viewSocietyBtn);
            Controls.Add(viewTasksBtn);
            Controls.Add(label3);
            Name = "StudentMain";
            Text = "StudentMain";
            Load += StudentMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button viewTasksBtn;
        private Button viewSocietyBtn;
        private Button MySocietiesBtn;
        private Button MyEventsBtn;
    }
}