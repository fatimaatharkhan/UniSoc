namespace SE_Project
{
    partial class HeadMain
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
            assignTasksBtn = new Button();
            label3 = new Label();
            viewMySocietiesBtn = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // assignTasksBtn
            // 
            assignTasksBtn.Location = new Point(297, 417);
            assignTasksBtn.Margin = new Padding(3, 4, 3, 4);
            assignTasksBtn.Name = "assignTasksBtn";
            assignTasksBtn.Size = new Size(138, 31);
            assignTasksBtn.TabIndex = 14;
            assignTasksBtn.Text = "Assign Task";
            assignTasksBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(261, 32);
            label3.Name = "label3";
            label3.Size = new Size(406, 57);
            label3.TabIndex = 12;
            label3.Text = "Head Main Page";
            label3.Click += label3_Click;
            // 
            // viewMySocietiesBtn
            // 
            viewMySocietiesBtn.Location = new Point(481, 417);
            viewMySocietiesBtn.Margin = new Padding(3, 4, 3, 4);
            viewMySocietiesBtn.Name = "viewMySocietiesBtn";
            viewMySocietiesBtn.Size = new Size(138, 31);
            viewMySocietiesBtn.TabIndex = 15;
            viewMySocietiesBtn.Text = "View My Societies";
            viewMySocietiesBtn.UseVisualStyleBackColor = true;
            viewMySocietiesBtn.Click += viewMySocietiesBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 131);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(890, 221);
            dataGridView2.TabIndex = 16;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // HeadMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView2);
            Controls.Add(viewMySocietiesBtn);
            Controls.Add(assignTasksBtn);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HeadMain";
            Text = "TeacherMain";
            Load += HeadMain_Load;
            Shown += HeadMain_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RemoveStudentsBtn;
        private Button ChangeHeadBtn;
        private Button assignTasksBtn;
        private Button AddSocietyBtn;
        private Label label3;
        private Button viewMySocietiesBtn;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}