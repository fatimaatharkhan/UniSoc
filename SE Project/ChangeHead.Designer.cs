namespace SE_Project
{
    partial class ChangeHead
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
            dataGridView1 = new DataGridView();
            ChangeHeadBtn = new Button();
            SocietyNameTxtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            unTxtbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(209, 31);
            label3.Name = "label3";
            label3.Size = new Size(368, 45);
            label3.TabIndex = 9;
            label3.Text = "Change Head Page";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 241);
            dataGridView1.TabIndex = 10;
            // 
            // ChangeHeadBtn
            // 
            ChangeHeadBtn.Location = new Point(661, 406);
            ChangeHeadBtn.Name = "ChangeHeadBtn";
            ChangeHeadBtn.Size = new Size(114, 23);
            ChangeHeadBtn.TabIndex = 18;
            ChangeHeadBtn.Text = "Change Head!";
            ChangeHeadBtn.UseVisualStyleBackColor = true;
            ChangeHeadBtn.Click += ChangeHeadBtn_Click;
            // 
            // SocietyNameTxtbox
            // 
            SocietyNameTxtbox.Location = new Point(399, 366);
            SocietyNameTxtbox.Name = "SocietyNameTxtbox";
            SocietyNameTxtbox.Size = new Size(178, 23);
            SocietyNameTxtbox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 374);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 16;
            label1.Text = "Society Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 414);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 19;
            label2.Text = "Head  Username";
            // 
            // unTxtbox
            // 
            unTxtbox.Location = new Point(399, 411);
            unTxtbox.Name = "unTxtbox";
            unTxtbox.Size = new Size(178, 23);
            unTxtbox.TabIndex = 20;
            // 
            // ChangeHead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(unTxtbox);
            Controls.Add(label2);
            Controls.Add(ChangeHeadBtn);
            Controls.Add(SocietyNameTxtbox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Name = "ChangeHead";
            Text = "ChangeHead";
            FormClosing += ChangeHead_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dataGridView1;
        private Button ChangeHeadBtn;
        private TextBox SocietyNameTxtbox;
        private Label label1;
        private Label label2;
        private TextBox unTxtbox;
    }
}