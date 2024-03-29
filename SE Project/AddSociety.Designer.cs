namespace SE_Project
{
    partial class AddSociety
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
            label1 = new Label();
            label2 = new Label();
            SocietyNameTxtbox = new TextBox();
            CapacityTxtbox = new TextBox();
            AddSocietyBtn = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(207, 54);
            label3.Name = "label3";
            label3.Size = new Size(339, 45);
            label3.TabIndex = 8;
            label3.Text = "Add Society Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 174);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 9;
            label1.Text = "Society Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 225);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 10;
            label2.Text = "Capacity";
            // 
            // SocietyNameTxtbox
            // 
            SocietyNameTxtbox.Location = new Point(368, 166);
            SocietyNameTxtbox.Name = "SocietyNameTxtbox";
            SocietyNameTxtbox.Size = new Size(178, 23);
            SocietyNameTxtbox.TabIndex = 11;
            // 
            // CapacityTxtbox
            // 
            CapacityTxtbox.Location = new Point(368, 217);
            CapacityTxtbox.Name = "CapacityTxtbox";
            CapacityTxtbox.Size = new Size(178, 23);
            CapacityTxtbox.TabIndex = 12;
            // 
            // AddSocietyBtn
            // 
            AddSocietyBtn.Location = new Point(498, 342);
            AddSocietyBtn.Name = "AddSocietyBtn";
            AddSocietyBtn.Size = new Size(104, 23);
            AddSocietyBtn.TabIndex = 13;
            AddSocietyBtn.Text = "Add Society";
            AddSocietyBtn.UseVisualStyleBackColor = true;
            AddSocietyBtn.Click += AddSocietyBtn_Click;
            // 
            // AddSociety
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(AddSocietyBtn);
            Controls.Add(CapacityTxtbox);
            Controls.Add(SocietyNameTxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "AddSociety";
            Text = "AddSociety";
            FormClosing += AddSociety_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox SocietyNameTxtbox;
        private TextBox CapacityTxtbox;
        private Button AddSocietyBtn;
    }
}