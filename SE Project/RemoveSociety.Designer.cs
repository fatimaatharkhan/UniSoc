namespace SE_Project
{
    partial class RemoveSociety
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
            SocietyNameTxtbox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            RemoveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(171, 57);
            label3.Name = "label3";
            label3.Size = new Size(418, 45);
            label3.TabIndex = 8;
            label3.Text = "Remove Society Page";
            // 
            // SocietyNameTxtbox
            // 
            SocietyNameTxtbox.Location = new Point(382, 370);
            SocietyNameTxtbox.Name = "SocietyNameTxtbox";
            SocietyNameTxtbox.Size = new Size(178, 23);
            SocietyNameTxtbox.TabIndex = 13;
            SocietyNameTxtbox.Enter += SocietyNameTxtbox_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 378);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 12;
            label1.Text = "Society Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(700, 208);
            dataGridView1.TabIndex = 14;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(657, 415);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(75, 23);
            RemoveBtn.TabIndex = 15;
            RemoveBtn.Text = "Remove!";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // RemoveSociety
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveBtn);
            Controls.Add(dataGridView1);
            Controls.Add(SocietyNameTxtbox);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "RemoveSociety";
            Text = "RemoveSociety";
            FormClosing += RemoveSociety_FormClosing;
            Load += RemoveSocietyForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox SocietyNameTxtbox;
        private Label label1;
        private DataGridView dataGridView1;
        private Button RemoveBtn;
    }
}