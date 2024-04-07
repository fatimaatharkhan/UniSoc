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
            label3.Location = new Point(237, 72);
            label3.Name = "label3";
            label3.Size = new Size(435, 57);
            label3.TabIndex = 8;
            label3.Text = "Add Society Page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 232);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 9;
            label1.Text = "Society Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 300);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 10;
            label2.Text = "Capacity";
            // 
            // SocietyNameTxtbox
            // 
            SocietyNameTxtbox.Location = new Point(421, 221);
            SocietyNameTxtbox.Margin = new Padding(3, 4, 3, 4);
            SocietyNameTxtbox.Name = "SocietyNameTxtbox";
            SocietyNameTxtbox.Size = new Size(203, 27);
            SocietyNameTxtbox.TabIndex = 11;
            // 
            // CapacityTxtbox
            // 
            CapacityTxtbox.Location = new Point(421, 289);
            CapacityTxtbox.Margin = new Padding(3, 4, 3, 4);
            CapacityTxtbox.Name = "CapacityTxtbox";
            CapacityTxtbox.Size = new Size(203, 27);
            CapacityTxtbox.TabIndex = 12;
            // 
            // AddSocietyBtn
            // 
            AddSocietyBtn.Location = new Point(569, 456);
            AddSocietyBtn.Margin = new Padding(3, 4, 3, 4);
            AddSocietyBtn.Name = "AddSocietyBtn";
            AddSocietyBtn.Size = new Size(119, 31);
            AddSocietyBtn.TabIndex = 13;
            AddSocietyBtn.Text = "Add Society";
            AddSocietyBtn.UseVisualStyleBackColor = true;
            AddSocietyBtn.Click += AddSocietyBtn_Click;
            // 
            // AddSociety
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(914, 600);
            Controls.Add(AddSocietyBtn);
            Controls.Add(CapacityTxtbox);
            Controls.Add(SocietyNameTxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddSociety";
            Text = "AddSociety";
            FormClosing += AddSociety_FormClosing;
            Load += AddSociety_Load;
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