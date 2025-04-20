namespace EZCom.Forms.Admin
{
    partial class Adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminform));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(225, 213, 217);
            button1.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
            button1.Location = new Point(49, 71);
            button1.Name = "button1";
            button1.Size = new Size(89, 47);
            button1.TabIndex = 0;
            button1.Text = "Додати користувача";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(225, 213, 217);
            button2.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
            button2.Location = new Point(241, 71);
            button2.Name = "button2";
            button2.Size = new Size(89, 47);
            button2.TabIndex = 1;
            button2.Text = "Змінити";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(225, 213, 217);
            button3.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
            button3.Location = new Point(447, 71);
            button3.Name = "button3";
            button3.Size = new Size(90, 47);
            button3.TabIndex = 2;
            button3.Text = "Створити";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 3;
            label1.Text = "Додати користувача";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(185, 12);
            label2.Name = "label2";
            label2.Size = new Size(200, 21);
            label2.TabIndex = 4;
            label2.Text = "Змінити тип користувача";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(406, 12);
            label3.Name = "label3";
            label3.Size = new Size(158, 21);
            label3.TabIndex = 5;
            label3.Text = "Створити підрозділ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-25, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(17, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 152);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // Adminform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(599, 261);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Adminform";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
    }
}