namespace EZCom.Forms
{
    partial class Registration
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
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Password2 = new TextBox();
            Password = new TextBox();
            Login = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            DateOfBirth = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            LastName = new TextBox();
            FirstName = new TextBox();
            label9 = new Label();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            label10 = new Label();
            label12 = new Label();
            Phone = new TextBox();
            Email = new TextBox();
            label13 = new Label();
            groupBox7 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(88, 84, 91);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(183, 167, 174);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Password2);
            groupBox2.Controls.Add(Password);
            groupBox2.Controls.Add(Login);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(15, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 140);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Lucida Bright", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(9, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(142, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 11F);
            label5.ForeColor = Color.FromArgb(28, 37, 44);
            label5.Location = new Point(41, 30);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 6;
            label5.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 11F);
            label4.ForeColor = Color.FromArgb(28, 37, 44);
            label4.Location = new Point(170, 81);
            label4.Name = "label4";
            label4.Size = new Size(144, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 11F);
            label3.ForeColor = Color.FromArgb(28, 37, 44);
            label3.Location = new Point(202, 30);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // Password2
            // 
            Password2.BackColor = Color.FromArgb(217, 217, 217);
            Password2.BorderStyle = BorderStyle.FixedSingle;
            Password2.Location = new Point(170, 101);
            Password2.Name = "Password2";
            Password2.PasswordChar = '*';
            Password2.Size = new Size(142, 23);
            Password2.TabIndex = 3;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(217, 217, 217);
            Password.BorderStyle = BorderStyle.FixedSingle;
            Password.Location = new Point(170, 50);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(142, 23);
            Password.TabIndex = 2;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(217, 217, 217);
            Login.BorderStyle = BorderStyle.FixedSingle;
            Login.Location = new Point(6, 50);
            Login.Name = "Login";
            Login.Size = new Size(145, 23);
            Login.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 15F);
            label2.ForeColor = Color.FromArgb(28, 37, 44);
            label2.Location = new Point(67, 1);
            label2.Name = "label2";
            label2.Size = new Size(190, 23);
            label2.TabIndex = 0;
            label2.Text = "Login Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 25F);
            label1.ForeColor = Color.FromArgb(246, 242, 246);
            label1.Location = new Point(104, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 39);
            label1.TabIndex = 0;
            label1.Text = "EZCom";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(88, 84, 91);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(27, 223);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 171);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(183, 167, 174);
            groupBox4.Controls.Add(DateOfBirth);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(LastName);
            groupBox4.Controls.Add(FirstName);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(15, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(320, 144);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // DateOfBirth
            // 
            DateOfBirth.CalendarMonthBackground = Color.FromArgb(217, 217, 217);
            DateOfBirth.Location = new Point(67, 101);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(200, 23);
            DateOfBirth.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Bright", 11F);
            label6.ForeColor = Color.FromArgb(28, 37, 44);
            label6.Location = new Point(34, 30);
            label6.Name = "label6";
            label6.Size = new Size(88, 17);
            label6.TabIndex = 6;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Bright", 11F);
            label7.ForeColor = Color.FromArgb(28, 37, 44);
            label7.Location = new Point(99, 81);
            label7.Name = "label7";
            label7.Size = new Size(130, 17);
            label7.TabIndex = 5;
            label7.Text = "Date of birthday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Bright", 11F);
            label8.ForeColor = Color.FromArgb(28, 37, 44);
            label8.Location = new Point(202, 30);
            label8.Name = "label8";
            label8.Size = new Size(85, 17);
            label8.TabIndex = 4;
            label8.Text = "Last Name";
            // 
            // LastName
            // 
            LastName.BackColor = Color.FromArgb(217, 217, 217);
            LastName.BorderStyle = BorderStyle.FixedSingle;
            LastName.Location = new Point(170, 50);
            LastName.Name = "LastName";
            LastName.Size = new Size(142, 23);
            LastName.TabIndex = 2;
            // 
            // FirstName
            // 
            FirstName.BackColor = Color.FromArgb(217, 217, 217);
            FirstName.BorderStyle = BorderStyle.FixedSingle;
            FirstName.Location = new Point(6, 50);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(145, 23);
            FirstName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Bright", 15F);
            label9.ForeColor = Color.FromArgb(28, 37, 44);
            label9.Location = new Point(51, 3);
            label9.Name = "label9";
            label9.Size = new Size(220, 23);
            label9.TabIndex = 0;
            label9.Text = "Personal Information";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(88, 84, 91);
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Location = new Point(27, 400);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(350, 171);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(183, 167, 174);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(Phone);
            groupBox6.Controls.Add(Email);
            groupBox6.Controls.Add(label13);
            groupBox6.Location = new Point(15, 16);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(320, 144);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Bright", 11F);
            label10.ForeColor = Color.FromArgb(28, 37, 44);
            label10.Location = new Point(131, 30);
            label10.Name = "label10";
            label10.Size = new Size(53, 17);
            label10.TabIndex = 6;
            label10.Text = "E-Mail";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Bright", 11F);
            label12.ForeColor = Color.FromArgb(28, 37, 44);
            label12.Location = new Point(99, 77);
            label12.Name = "label12";
            label12.Size = new Size(115, 17);
            label12.TabIndex = 4;
            label12.Text = "Phone number";
            // 
            // Phone
            // 
            Phone.BackColor = Color.FromArgb(217, 217, 217);
            Phone.BorderStyle = BorderStyle.FixedSingle;
            Phone.Location = new Point(51, 97);
            Phone.Name = "Phone";
            Phone.Size = new Size(215, 23);
            Phone.TabIndex = 2;
            // 
            // Email
            // 
            Email.BackColor = Color.FromArgb(217, 217, 217);
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Location = new Point(51, 51);
            Email.Name = "Email";
            Email.Size = new Size(215, 23);
            Email.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Bright", 15F);
            label13.ForeColor = Color.FromArgb(28, 37, 44);
            label13.Location = new Point(99, 3);
            label13.Name = "label13";
            label13.Size = new Size(123, 23);
            label13.TabIndex = 0;
            label13.Text = "Contac info";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.FromArgb(88, 84, 91);
            groupBox7.Controls.Add(button1);
            groupBox7.Location = new Point(109, 586);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(176, 46);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(183, 167, 174);
            button1.FlatAppearance.BorderColor = Color.FromArgb(183, 167, 174);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Lucida Bright", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(27, 42, 55);
            button1.Location = new Point(33, 9);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 0;
            button1.Text = "Registration";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Registration
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(402, 644);
            Controls.Add(groupBox7);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Registration_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox Password2;
        private TextBox Password;
        private TextBox Login;
        private CheckBox checkBox1;
        private Label label5;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox LastName;
        private TextBox FirstName;
        private Label label9;
        private DateTimePicker DateOfBirth;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label10;
        private Label label12;
        private TextBox Phone;
        private TextBox Email;
        private Label label13;
        private GroupBox groupBox7;
        private Button button1;
    }
}