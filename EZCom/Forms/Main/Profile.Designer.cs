namespace EZCom.Forms.Main
{
    partial class Profile
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dtpBirthDate = new DateTimePicker();
            btnSave = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(217, 217, 217);
            txtFirstName.Enabled = false;
            txtFirstName.Location = new Point(154, 49);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(217, 217, 217);
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(154, 97);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(217, 217, 217);
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(154, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(217, 217, 217);
            txtPhone.Enabled = false;
            txtPhone.Location = new Point(154, 190);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CalendarMonthBackground = Color.FromArgb(217, 217, 217);
            dtpBirthDate.Enabled = false;
            dtpBirthDate.Location = new Point(154, 228);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(183, 167, 174);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(378, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(183, 167, 174);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(269, 350);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 6;
            button2.Text = "Редагувати";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnEdit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.EZCom_logo_variant_removebg_preview;
            pictureBox1.Location = new Point(274, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(183, 167, 174);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Location = new Point(104, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 291);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold);
            label4.Location = new Point(47, 188);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 10;
            label4.Text = "Телефон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold);
            label3.Location = new Point(47, 144);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 9;
            label3.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold);
            label2.Location = new Point(47, 95);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 8;
            label2.Text = "Прізвище";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            label1.Location = new Point(47, 47);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 7;
            label1.Text = "Ім'я";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 84, 91);
            ClientSize = new Size(639, 403);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Name = "Profile";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private DateTimePicker dtpBirthDate;
        private Button btnSave;
        private Button button2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}