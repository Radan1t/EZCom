namespace EZCom.Forms.Chat
{
    partial class NewChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewChat));
            comboBoxUsers = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.BackColor = Color.FromArgb(225, 213, 217);
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(73, 70);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(121, 23);
            comboBoxUsers.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(225, 213, 217);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(89, 118);
            button1.Name = "button1";
            button1.Size = new Size(87, 35);
            button1.TabIndex = 1;
            button1.Text = "Написати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F);
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 2;
            label1.Text = "Оберіть користувача";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBoxUsers);
            groupBox1.Location = new Point(60, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 197);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // NewChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(395, 336);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "NewChat";
            Text = "NewChat";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxUsers;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}