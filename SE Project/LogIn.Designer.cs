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
            UsernameTxtbox.Location = new Point(440, 224);
            UsernameTxtbox.Margin = new Padding(3, 4, 3, 4);
            UsernameTxtbox.Name = "UsernameTxtbox";
            UsernameTxtbox.Size = new Size(175, 27);
            UsernameTxtbox.TabIndex = 0;
            // 
            // PasswordTxtbox
            // 
            PasswordTxtbox.Location = new Point(440, 329);
            PasswordTxtbox.Margin = new Padding(3, 4, 3, 4);
            PasswordTxtbox.Name = "PasswordTxtbox";
            PasswordTxtbox.PasswordChar = '*';
            PasswordTxtbox.Size = new Size(175, 27);
            PasswordTxtbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(277, 224);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 333);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // LogInBtn
            // 
            LogInBtn.Location = new Point(640, 459);
            LogInBtn.Margin = new Padding(3, 4, 3, 4);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(86, 31);
            LogInBtn.TabIndex = 4;
            LogInBtn.Text = "Log In!";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // BackToMainBtn
            // 
            BackToMainBtn.Location = new Point(214, 459);
            BackToMainBtn.Margin = new Padding(3, 4, 3, 4);
            BackToMainBtn.Name = "BackToMainBtn";
            BackToMainBtn.Size = new Size(113, 31);
            BackToMainBtn.TabIndex = 5;
            BackToMainBtn.Text = "Back To Main";
            BackToMainBtn.UseVisualStyleBackColor = true;
            BackToMainBtn.Click += BackToMainBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(352, 59);
            label3.Name = "label3";
            label3.Size = new Size(295, 57);
            label3.TabIndex = 6;
            label3.Text = "LogIn Page";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(BackToMainBtn);
            Controls.Add(LogInBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTxtbox);
            Controls.Add(UsernameTxtbox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
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