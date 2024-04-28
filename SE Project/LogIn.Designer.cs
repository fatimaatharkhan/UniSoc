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
            SuspendLayout();
            // 
            // UsernameTxtbox
            // 
            UsernameTxtbox.Location = new Point(154, 50);
            UsernameTxtbox.Name = "UsernameTxtbox";
            UsernameTxtbox.Size = new Size(154, 23);
            UsernameTxtbox.TabIndex = 0;
            // 
            // PasswordTxtbox
            // 
            PasswordTxtbox.Location = new Point(154, 74);
            PasswordTxtbox.Name = "PasswordTxtbox";
            PasswordTxtbox.PasswordChar = '*';
            PasswordTxtbox.Size = new Size(154, 23);
            PasswordTxtbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(73, 52);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 76);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // LogInBtn
            // 
            LogInBtn.Location = new Point(154, 100);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(153, 23);
            LogInBtn.TabIndex = 4;
            LogInBtn.Text = "Log In!";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // LogIn
            // 
            AcceptButton = LogInBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(417, 188);
            Controls.Add(LogInBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTxtbox);
            Controls.Add(UsernameTxtbox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label3;
    }
}