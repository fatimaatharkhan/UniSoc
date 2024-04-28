namespace SE_Project
{
    partial class AddEvent
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
            components = new System.ComponentModel.Container();
            addBtn = new Button();
            txtEventName = new TextBox();
            cmbSocieties = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtEventDesc = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(243, 298);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 25;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(243, 191);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(151, 27);
            txtEventName.TabIndex = 24;
            // 
            // cmbSocieties
            // 
            cmbSocieties.DisplayMember = "Name";
            cmbSocieties.FormattingEnabled = true;
            cmbSocieties.Location = new Point(243, 152);
            cmbSocieties.Name = "cmbSocieties";
            cmbSocieties.Size = new Size(151, 28);
            cmbSocieties.TabIndex = 23;
            cmbSocieties.ValueMember = "ID";
            cmbSocieties.SelectedIndexChanged += cmbSocieties_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 194);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 22;
            label2.Text = "Event Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(243, 38);
            label3.Name = "label3";
            label3.Size = new Size(265, 57);
            label3.TabIndex = 21;
            label3.Text = "Add Event";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 156);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 20;
            label1.Text = "Society Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 230);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 26;
            label4.Text = "Event Description:";
            // 
            // txtEventDesc
            // 
            txtEventDesc.Location = new Point(243, 227);
            txtEventDesc.Multiline = true;
            txtEventDesc.Name = "txtEventDesc";
            txtEventDesc.Size = new Size(315, 56);
            txtEventDesc.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEventDesc);
            Controls.Add(label4);
            Controls.Add(addBtn);
            Controls.Add(txtEventName);
            Controls.Add(cmbSocieties);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AddEvent";
            Text = "AddEvent";
            Shown += AddEvent_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private TextBox txtEventName;
        private ComboBox cmbSocieties;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox txtEventDesc;
        private ContextMenuStrip contextMenuStrip1;
    }
}