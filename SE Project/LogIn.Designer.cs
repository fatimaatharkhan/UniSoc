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
            UsernameTxtbox.Location = new Point(176, 66);
            UsernameTxtbox.Margin = new Padding(3, 4, 3, 4);
            UsernameTxtbox.Name = "UsernameTxtbox";
            UsernameTxtbox.Size = new Size(175, 27);
            UsernameTxtbox.TabIndex = 0;
            UsernameTxtbox.Text = "douglas70";
            // 
            // PasswordTxtbox
            // 
            PasswordTxtbox.Location = new Point(176, 98);
            PasswordTxtbox.Margin = new Padding(3, 4, 3, 4);
            PasswordTxtbox.Name = "PasswordTxtbox";
            PasswordTxtbox.PasswordChar = '*';
            PasswordTxtbox.Size = new Size(175, 27);
            PasswordTxtbox.TabIndex = 1;
            PasswordTxtbox.Text = "456";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(83, 69);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 101);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // LogInBtn
            // 
            LogInBtn.Location = new Point(176, 133);
            LogInBtn.Margin = new Padding(3, 4, 3, 4);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(175, 31);
            LogInBtn.TabIndex = 4;
            LogInBtn.Text = "Log In!";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // LogIn
            // 
            AcceptButton = LogInBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(477, 250);
            Controls.Add(LogInBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTxtbox);
            Controls.Add(UsernameTxtbox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
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