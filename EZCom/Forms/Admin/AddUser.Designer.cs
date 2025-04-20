namespace EZCom.Forms.Admin
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            textBox1 = new TextBox();
            Додати = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(225, 213, 217);
            textBox1.Location = new Point(30, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 0;
            // 
            // Додати
            // 
            Додати.BackColor = Color.FromArgb(225, 213, 217);
            Додати.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
            Додати.Location = new Point(65, 97);
            Додати.Name = "Додати";
            Додати.Size = new Size(75, 26);
            Додати.TabIndex = 1;
            Додати.Text = "Додати";
            Додати.UseVisualStyleBackColor = false;
            Додати.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Додати);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(46, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 143);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(0, 15);
            label1.Name = "label1";
            label1.Size = new Size(207, 21);
            label1.TabIndex = 2;
            label1.Text = "Введіть пошту користувача";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(303, 252);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "AddUser";
            Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button Додати;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
    }
}