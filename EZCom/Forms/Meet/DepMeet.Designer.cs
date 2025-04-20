namespace EZCom.Forms.Meet
{
    partial class DepMeet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepMeet));
            button1 = new Button();
            dateTimePicker = new DateTimePicker();
            comboBoxDepartments = new ComboBox();
            txtEventName = new TextBox();
            label1 = new Label();
            btnCreateEvent = new Button();
            textBoxEmails = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(461, 280);
            button1.Name = "button1";
            button1.Size = new Size(106, 49);
            button1.TabIndex = 14;
            button1.Text = "Копіювати посилання";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCopyLink_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(118, 228);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 13;
            // 
            // comboBoxDepartments
            // 
            comboBoxDepartments.BackColor = Color.FromArgb(225, 213, 217);
            comboBoxDepartments.FormattingEnabled = true;
            comboBoxDepartments.Location = new Point(118, 185);
            comboBoxDepartments.Name = "comboBoxDepartments";
            comboBoxDepartments.Size = new Size(200, 23);
            comboBoxDepartments.TabIndex = 11;
            comboBoxDepartments.SelectedIndexChanged += comboBoxDepartments_SelectedIndexChanged;
            // 
            // txtEventName
            // 
            txtEventName.BackColor = Color.FromArgb(225, 213, 217);
            txtEventName.Font = new Font("Segoe UI Light", 11.25F);
            txtEventName.Location = new Point(118, 139);
            txtEventName.Multiline = true;
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(200, 29);
            txtEventName.TabIndex = 10;
            txtEventName.Text = "Введіть назву зустрічі";
            txtEventName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 18F);
            label1.Location = new Point(90, 88);
            label1.Name = "label1";
            label1.Size = new Size(294, 38);
            label1.TabIndex = 9;
            label1.Text = "Заплануйте свою зустріч";
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCreateEvent.Location = new Point(139, 280);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(150, 40);
            btnCreateEvent.TabIndex = 8;
            btnCreateEvent.Text = "Створити";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // textBoxEmails
            // 
            textBoxEmails.BackColor = Color.FromArgb(225, 213, 217);
            textBoxEmails.Location = new Point(450, 158);
            textBoxEmails.Multiline = true;
            textBoxEmails.Name = "textBoxEmails";
            textBoxEmails.Size = new Size(132, 93);
            textBoxEmails.TabIndex = 15;
            textBoxEmails.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // DepMeet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(645, 387);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxEmails);
            Controls.Add(button1);
            Controls.Add(dateTimePicker);
            Controls.Add(comboBoxDepartments);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(btnCreateEvent);
            Name = "DepMeet";
            Text = "DepMeet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxDepartments;
        private TextBox txtEventName;
        private Label label1;
        private Button btnCreateEvent;
        private TextBox textBoxEmails;
        private PictureBox pictureBox1;
    }
}