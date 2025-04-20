namespace EZCom.Forms.Admin
{
    partial class AddDepartament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartament));
            comboBoxUsers = new ComboBox();
            textBoxDepartmentName = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
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
            comboBoxUsers.Location = new Point(110, 157);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(121, 23);
            comboBoxUsers.TabIndex = 1;
            // 
            // textBoxDepartmentName
            // 
            textBoxDepartmentName.BackColor = Color.FromArgb(225, 213, 217);
            textBoxDepartmentName.Location = new Point(110, 68);
            textBoxDepartmentName.Name = "textBoxDepartmentName";
            textBoxDepartmentName.Size = new Size(121, 23);
            textBoxDepartmentName.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(225, 213, 217);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(127, 198);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 3;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15F);
            label1.Location = new Point(44, 19);
            label1.Name = "label1";
            label1.Size = new Size(238, 28);
            label1.TabIndex = 4;
            label1.Text = "Введіть назву підрозділу";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15F);
            label2.Location = new Point(44, 113);
            label2.Name = "label2";
            label2.Size = new Size(264, 28);
            label2.TabIndex = 5;
            label2.Text = "Виберіть голову підрозділу";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(217, 217, 217);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxDepartmentName);
            groupBox1.Controls.Add(comboBoxUsers);
            groupBox1.Location = new Point(104, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 275);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // AddDepartament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(559, 384);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "AddDepartament";
            Text = "AddDepartament";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBoxUsers;
        private TextBox textBoxDepartmentName;
        private Button button1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}