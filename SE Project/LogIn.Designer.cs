namespace SE_Project
{
    partial class LogIn
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
            UsernameTxtbox = new TextBox();
            PasswordTxtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LogInBtn = new Button();
            BackToMainBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // UsernameTxtbox
            // 
            UsernameTxtbox.Location = new Point(385, 168);
            UsernameTxtbox.Name = "UsernameTxtbox";
            UsernameTxtbox.Size = new Size(154, 23);
            UsernameTxtbox.TabIndex = 0;
            // 
            // PasswordTxtbox
            // 
            PasswordTxtbox.Location = new Point(385, 247);
            PasswordTxtbox.Name = "PasswordTxtbox";
            PasswordTxtbox.PasswordChar = '*';
            PasswordTxtbox.Size = new Size(154, 23);
            PasswordTxtbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(242, 168);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 250);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // LogInBtn
            // 
            LogInBtn.Location = new Point(560, 344);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(75, 23);
            LogInBtn.TabIndex = 4;
            LogInBtn.Text = "Log In!";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // BackToMainBtn
            // 
            BackToMainBtn.Location = new Point(187, 344);
            BackToMainBtn.Name = "BackToMainBtn";
            BackToMainBtn.Size = new Size(99, 23);
            BackToMainBtn.TabIndex = 5;
            BackToMainBtn.Text = "Back To Main";
            BackToMainBtn.UseVisualStyleBackColor = true;
            BackToMainBtn.Click += BackToMainBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(308, 44);
            label3.Name = "label3";
            label3.Size = new Size(231, 45);
            label3.TabIndex = 6;
            label3.Text = "LogIn Page";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(BackToMainBtn);
            Controls.Add(LogInBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTxtbox);
            Controls.Add(UsernameTxtbox);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTxtbox;
        private TextBox PasswordTxtbox;
        private Label label1;
        private Label label2;
        private Button LogInBtn;
        private Button BackToMainBtn;
        private Label label3;
    }
}