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
            Task = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(195, 76);
            label3.Name = "label3";
            label3.Size = new Size(534, 57);
            label3.TabIndex = 8;
            label3.Text = "Remove Society Page";
            // 
            // SocietyNameTxtbox
            // 
            SocietyNameTxtbox.Location = new Point(437, 493);
            SocietyNameTxtbox.Margin = new Padding(3, 4, 3, 4);
            SocietyNameTxtbox.Name = "SocietyNameTxtbox";
            SocietyNameTxtbox.Size = new Size(203, 27);
            SocietyNameTxtbox.TabIndex = 13;
            SocietyNameTxtbox.Enter += SocietyNameTxtbox_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 504);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 12;
            label1.Text = "Society Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Task });
            dataGridView1.Location = new Point(37, 155);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 277);
            dataGridView1.TabIndex = 14;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(751, 553);
            RemoveBtn.Margin = new Padding(3, 4, 3, 4);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(86, 31);
            RemoveBtn.TabIndex = 15;
            RemoveBtn.Text = "Remove!";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // Task
            // 
            Task.HeaderText = "Assign Task";
            Task.MinimumWidth = 6;
            Task.Name = "Task";
            Task.Width = 125;
            // 
            // RemoveSociety
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(914, 600);
            Controls.Add(RemoveBtn);
            Controls.Add(dataGridView1);
            Controls.Add(SocietyNameTxtbox);
            Controls.Add(label1);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
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
        private DataGridViewButtonColumn Task;
    }
}