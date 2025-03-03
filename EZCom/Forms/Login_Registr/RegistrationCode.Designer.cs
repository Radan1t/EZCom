namespace EZCom.Forms
{
    partial class RegistrationCode
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(88, 84, 91);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(183, 167, 174);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(27, 42, 55);
            button2.Location = new Point(343, 208);
            button2.Name = "button2";
            button2.Size = new Size(108, 53);
            button2.TabIndex = 3;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(183, 167, 174);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(27, 42, 55);
            button1.Location = new Point(134, 208);
            button1.Name = "button1";
            button1.Size = new Size(108, 53);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 25F);
            label1.ForeColor = Color.FromArgb(246, 242, 246);
            label1.Location = new Point(226, 10);
            label1.Name = "label1";
            label1.Size = new Size(133, 39);
            label1.TabIndex = 1;
            label1.Text = "EZCom";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(183, 167, 174);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(27, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 150);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 12F, FontStyle.Bold);
            label3.Location = new Point(147, 45);
            label3.Name = "label3";
            label3.Size = new Size(99, 18);
            label3.TabIndex = 3;
            label3.Text = "Your Email:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(225, 213, 217);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(27, 42, 55);
            button3.Location = new Point(427, 79);
            button3.Name = "button3";
            button3.Size = new Size(76, 42);
            button3.TabIndex = 2;
            button3.Text = "Resend";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(225, 213, 217);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Lucida Bright", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(211, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 42);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(28, 37, 44);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(517, 36);
            label2.TabIndex = 0;
            label2.Text = "A message with a notification code has been sent to your email.\n Please enter that code below.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrationCode
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(613, 291);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "RegistrationCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationCode";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}