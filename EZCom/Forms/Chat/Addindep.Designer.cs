namespace EZCom.Forms.Chat
{
    partial class Addindep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addindep));
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(225, 213, 217);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 23);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(78, 151);
            button1.Name = "button1";
            button1.Size = new Size(98, 34);
            button1.TabIndex = 1;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.Location = new Point(221, 151);
            button2.Name = "button2";
            button2.Size = new Size(98, 34);
            button2.TabIndex = 2;
            button2.Text = "Видалити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F);
            label1.Location = new Point(78, 54);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 3;
            label1.Text = "Виберіть користувача";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Addindep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(412, 258);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Addindep";
            Text = "Addindep";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}