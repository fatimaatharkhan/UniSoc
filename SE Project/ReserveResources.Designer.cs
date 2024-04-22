﻿namespace SE_Project
{
    partial class ReserveResources
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            StartMaskedTextBox1 = new MaskedTextBox();
            EndMaskedTextBox2 = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            ReserveBtn = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(117, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(250, 53);
            label1.Name = "label1";
            label1.Size = new Size(294, 45);
            label1.TabIndex = 1;
            label1.Text = "Reserve Resources";
            // 
            // StartMaskedTextBox1
            // 
            StartMaskedTextBox1.Location = new Point(117, 302);
            StartMaskedTextBox1.Mask = "00:00";
            StartMaskedTextBox1.Name = "StartMaskedTextBox1";
            StartMaskedTextBox1.Size = new Size(100, 23);
            StartMaskedTextBox1.TabIndex = 2;
            StartMaskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // EndMaskedTextBox2
            // 
            EndMaskedTextBox2.Location = new Point(117, 347);
            EndMaskedTextBox2.Mask = "00:00";
            EndMaskedTextBox2.Name = "EndMaskedTextBox2";
            EndMaskedTextBox2.Size = new Size(100, 23);
            EndMaskedTextBox2.TabIndex = 3;
            EndMaskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 195);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 310);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Start Time";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 355);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Stop Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 190);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 7;
            label5.Text = "Resource Type";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Library", "GPU Lab", "CS Lawn", "Auditorium", "LRC" });
            comboBox1.Location = new Point(626, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // ReserveBtn
            // 
            ReserveBtn.Location = new Point(672, 393);
            ReserveBtn.Name = "ReserveBtn";
            ReserveBtn.Size = new Size(75, 23);
            ReserveBtn.TabIndex = 9;
            ReserveBtn.Text = "Reserve";
            ReserveBtn.UseVisualStyleBackColor = true;
            ReserveBtn.Click += ReserveBtn_Click;
            // 
            // ReserveResources
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(ReserveBtn);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(EndMaskedTextBox2);
            Controls.Add(StartMaskedTextBox1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "ReserveResources";
            Text = "ReserveResources";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private MaskedTextBox StartMaskedTextBox1;
        private MaskedTextBox EndMaskedTextBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button ReserveBtn;
    }
}