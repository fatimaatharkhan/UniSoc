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
            label3.Location = new Point(239, 41);
            label3.Name = "label3";
            label3.Size = new Size(469, 57);
            label3.TabIndex = 9;
            label3.Text = "Change Head Page";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 117);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(887, 321);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ChangeHeadBtn
            // 
            ChangeHeadBtn.Location = new Point(755, 541);
            ChangeHeadBtn.Margin = new Padding(3, 4, 3, 4);
            ChangeHeadBtn.Name = "ChangeHeadBtn";
            ChangeHeadBtn.Size = new Size(130, 31);
            ChangeHeadBtn.TabIndex = 18;
            ChangeHeadBtn.Text = "Change Head!";
            ChangeHeadBtn.UseVisualStyleBackColor = true;
            ChangeHeadBtn.Click += ChangeHeadBtn_Click;
            // 
            // SocietyNameTxtbox
            // 
            SocietyNameTxtbox.Location = new Point(456, 488);
            SocietyNameTxtbox.Margin = new Padding(3, 4, 3, 4);
            SocietyNameTxtbox.Name = "SocietyNameTxtbox";
            SocietyNameTxtbox.Size = new Size(203, 27);
            SocietyNameTxtbox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 499);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 16;
            label1.Text = "Society Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 552);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 19;
            label2.Text = "Head  Username";
            // 
            // unTxtbox
            // 
            unTxtbox.Location = new Point(456, 548);
            unTxtbox.Margin = new Padding(3, 4, 3, 4);
            unTxtbox.Name = "unTxtbox";
            unTxtbox.Size = new Size(203, 27);
            unTxtbox.TabIndex = 20;
            // 
            // ChangeHead
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(914, 600);
            Controls.Add(unTxtbox);
            Controls.Add(label2);
            Controls.Add(ChangeHeadBtn);
            Controls.Add(SocietyNameTxtbox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
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