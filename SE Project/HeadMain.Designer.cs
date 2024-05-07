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
            viewAssignTasksBtn = new Button();
            label3 = new Label();
            viewSocietiesBtn = new Button();
            dataGridView2 = new DataGridView();
            ReserverResourcesBtn = new Button();
            GenerateReportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // viewAssignTasksBtn
            // 
            viewAssignTasksBtn.Location = new Point(23, 284);
            viewAssignTasksBtn.Name = "viewAssignTasksBtn";
            viewAssignTasksBtn.Size = new Size(121, 23);
            viewAssignTasksBtn.TabIndex = 14;
            viewAssignTasksBtn.Text = "View Tasks";
            viewAssignTasksBtn.UseVisualStyleBackColor = true;
            viewAssignTasksBtn.Click += viewAssignTasksBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 22);
            label3.Name = "label3";
            label3.Size = new Size(318, 45);
            label3.TabIndex = 12;
            label3.Text = "Head Main Page";
            label3.Click += label3_Click;
            // 
            // viewSocietiesBtn
            // 
            viewSocietiesBtn.Location = new Point(205, 284);
            viewSocietiesBtn.Name = "viewSocietiesBtn";
            viewSocietiesBtn.Size = new Size(121, 23);
            viewSocietiesBtn.TabIndex = 15;
            viewSocietiesBtn.Text = "View Societies";
            viewSocietiesBtn.UseVisualStyleBackColor = true;
            viewSocietiesBtn.Click += viewSocietiesBtn_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(10, 87);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(705, 166);
            dataGridView2.TabIndex = 16;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // ReserverResourcesBtn
            // 
            ReserverResourcesBtn.Location = new Point(392, 284);
            ReserverResourcesBtn.Name = "ReserverResourcesBtn";
            ReserverResourcesBtn.Size = new Size(129, 23);
            ReserverResourcesBtn.TabIndex = 17;
            ReserverResourcesBtn.Text = "Reserve Resources";
            ReserverResourcesBtn.UseVisualStyleBackColor = true;
            ReserverResourcesBtn.Click += ReserverResourcesBtn_Click;
            // 
            // GenerateReportBtn
            // 
            GenerateReportBtn.Location = new Point(560, 284);
            GenerateReportBtn.Name = "GenerateReportBtn";
            GenerateReportBtn.Size = new Size(120, 23);
            GenerateReportBtn.TabIndex = 18;
            GenerateReportBtn.Text = "Generate Report";
            GenerateReportBtn.UseVisualStyleBackColor = true;
            GenerateReportBtn.Click += GenerateReportBtn_Click;
            // 
            // HeadMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(726, 367);
            Controls.Add(GenerateReportBtn);
            Controls.Add(ReserverResourcesBtn);
            Controls.Add(dataGridView2);
            Controls.Add(viewSocietiesBtn);
            Controls.Add(viewAssignTasksBtn);
            Controls.Add(label3);
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
        private Button viewAssignTasksBtn;
        private Button AddSocietyBtn;
        private Label label3;
        private Button viewSocietiesBtn;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button ReserverResourcesBtn;
        private Button GenerateReportBtn;
    }
}