namespace EZCom
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EZCom = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnGoogleLogin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // EZCom
            // 
            EZCom.AutoSize = true;
            EZCom.Font = new Font("Lucida Bright", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EZCom.ForeColor = SystemColors.ButtonFace;
            EZCom.Location = new Point(105, 9);
            EZCom.Name = "EZCom";
            EZCom.Size = new Size(190, 55);
            EZCom.TabIndex = 0;
            EZCom.Text = "EZCom";
            EZCom.Click += EZCom_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(183, 167, 174);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(75, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 243);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(77, 204);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(68, 126);
            label2.Name = "label2";
            label2.Size = new Size(116, 27);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(68, 33);
            label1.Name = "label1";
            label1.Size = new Size(121, 27);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(55, 169);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(144, 29);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(217, 217, 217);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(55, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 29);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(183, 167, 174);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(143, 331);
            button1.Name = "button1";
            button1.Size = new Size(114, 32);
            button1.TabIndex = 0;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(183, 167, 174);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(143, 383);
            button2.Name = "button2";
            button2.Size = new Size(114, 32);
            button2.TabIndex = 2;
            button2.Text = "Registration";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnGoogleLogin
            // 
            btnGoogleLogin.Location = new Point(117, 439);
            btnGoogleLogin.Name = "btnGoogleLogin";
            btnGoogleLogin.Size = new Size(161, 23);
            btnGoogleLogin.TabIndex = 3;
            btnGoogleLogin.Text = "Log in by Google";
            btnGoogleLogin.UseVisualStyleBackColor = true;
            btnGoogleLogin.Click += btnGoogleLogin_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(88, 84, 91);
            ClientSize = new Size(402, 485);
            Controls.Add(btnGoogleLogin);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(EZCom);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EZCom;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private CheckBox checkBox1;
        private Button btnGoogleLogin;
    }
}
