namespace EZCom.Forms.Admin
{
    partial class ChangeUserAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserAccess));
            listBoxUsers = new ListBox();
            comboBoxUserTypes = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.BackColor = Color.FromArgb(225, 213, 217);
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(32, 133);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(344, 79);
            listBoxUsers.TabIndex = 0;
            // 
            // comboBoxUserTypes
            // 
            comboBoxUserTypes.BackColor = Color.FromArgb(225, 213, 217);
            comboBoxUserTypes.FormattingEnabled = true;
            comboBoxUserTypes.Location = new Point(433, 160);
            comboBoxUserTypes.Name = "comboBoxUserTypes";
            comboBoxUserTypes.Size = new Size(139, 23);
            comboBoxUserTypes.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(225, 213, 217);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(269, 263);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 2;
            button1.Text = "Внести зміни";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14F);
            label1.Location = new Point(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 14;
            label1.Text = "Оберіть користувача";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14F);
            label2.Location = new Point(433, 100);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 15;
            label2.Text = "Права доступу";
            // 
            // ChangeUserAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(644, 351);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(comboBoxUserTypes);
            Controls.Add(listBoxUsers);
            Name = "ChangeUserAccess";
            Text = "ChangeUserAccess";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxUsers;
        private ComboBox comboBoxUserTypes;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}