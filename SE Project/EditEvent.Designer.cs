namespace SE_Project
{
    partial class EditEvent
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtEventDesc = new TextBox();
            txtEventName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 139);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 175);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(280, 32);
            label4.Name = "label4";
            label4.Size = new Size(266, 57);
            label4.TabIndex = 19;
            label4.Text = "Edit Event";
            label4.Click += label4_Click;
            // 
            // txtEventDesc
            // 
            txtEventDesc.Location = new Point(197, 172);
            txtEventDesc.Multiline = true;
            txtEventDesc.Name = "txtEventDesc";
            txtEventDesc.Size = new Size(315, 69);
            txtEventDesc.TabIndex = 29;
            txtEventDesc.TextChanged += txtEventDesc_TextChanged;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(197, 136);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(151, 27);
            txtEventName.TabIndex = 28;
            txtEventName.TextChanged += txtEventName_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(197, 247);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 30;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtEventDesc);
            Controls.Add(txtEventName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditEvent";
            Text = "EditEvent";
            Activated += EditEvent_Activated;
            Shown += EditEvent_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtEventDesc;
        private TextBox txtEventName;
        private Button button1;
    }
}