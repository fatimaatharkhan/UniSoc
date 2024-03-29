namespace SE_Project
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogInBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // LogInBtn
            // 
            LogInBtn.Location = new Point(517, 328);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(75, 23);
            LogInBtn.TabIndex = 0;
            LogInBtn.Text = "LogIn";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 65);
            label1.Name = "label1";
            label1.Size = new Size(782, 42);
            label1.TabIndex = 2;
            label1.Text = "FAST STUDENT SOCIETY MANAGEMENT SYSTEM";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(LogInBtn);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogInBtn;
        private Label label1;
    }
}