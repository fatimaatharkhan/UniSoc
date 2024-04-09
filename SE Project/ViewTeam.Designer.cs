namespace SE_Project
{
    partial class ViewTeam
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
            dataGridView2 = new DataGridView();
            addTeamBtn = new Button();
            label3 = new Label();
            cmbStudents = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 122);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(776, 181);
            dataGridView2.TabIndex = 19;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // addTeamBtn
            // 
            addTeamBtn.Location = new Point(365, 380);
            addTeamBtn.Margin = new Padding(3, 4, 3, 4);
            addTeamBtn.Name = "addTeamBtn";
            addTeamBtn.Size = new Size(116, 31);
            addTeamBtn.TabIndex = 18;
            addTeamBtn.Text = "Add Member";
            addTeamBtn.UseVisualStyleBackColor = true;
            addTeamBtn.Click += addTeamBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(91, 23);
            label3.Name = "label3";
            label3.Size = new Size(626, 57);
            label3.TabIndex = 17;
            label3.Text = "Event Management Team";
            // 
            // cmbStudents
            // 
            cmbStudents.DisplayMember = "StudentName";
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(365, 345);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(151, 28);
            cmbStudents.TabIndex = 20;
            cmbStudents.ValueMember = "StudentId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 349);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 21;
            label1.Text = "Student Name:";
            label1.Click += label1_Click;
            // 
            // ViewTeam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbStudents);
            Controls.Add(dataGridView2);
            Controls.Add(addTeamBtn);
            Controls.Add(label3);
            Name = "ViewTeam";
            Text = "ViewTeam";
            Shown += ViewTeam_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private Button addTeamBtn;
        private Label label3;
        private ComboBox cmbStudents;
        private Label label1;
    }
}