namespace EZCom.Forms.Meet
{
    partial class Meetform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meetform));
            btnCreateEvent = new Button();
            label1 = new Label();
            txtEventName = new TextBox();
            comboBoxEmails = new ComboBox();
            textBoxEmails = new TextBox();
            dateTimePicker = new DateTimePicker();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.BackColor = Color.FromArgb(225, 213, 217);
            btnCreateEvent.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCreateEvent.Location = new Point(62, 185);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(178, 40);
            btnCreateEvent.TabIndex = 0;
            btnCreateEvent.Text = "Створити зустріч";
            btnCreateEvent.UseVisualStyleBackColor = false;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 21);
            label1.Name = "label1";
            label1.Size = new Size(294, 38);
            label1.TabIndex = 1;
            label1.Text = "Заплануйте свою зустріч";
            // 
            // txtEventName
            // 
            txtEventName.BackColor = Color.FromArgb(225, 213, 217);
            txtEventName.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtEventName.Location = new Point(62, 52);
            txtEventName.Multiline = true;
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(179, 29);
            txtEventName.TabIndex = 2;
            txtEventName.Text = "Введіть назву зустрічі";
            txtEventName.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBoxEmails
            // 
            comboBoxEmails.BackColor = Color.FromArgb(225, 213, 217);
            comboBoxEmails.FormattingEnabled = true;
            comboBoxEmails.Location = new Point(62, 97);
            comboBoxEmails.Name = "comboBoxEmails";
            comboBoxEmails.Size = new Size(179, 23);
            comboBoxEmails.TabIndex = 4;
            comboBoxEmails.SelectedIndexChanged += comboBoxEmails_SelectedIndexChanged;
            // 
            // textBoxEmails
            // 
            textBoxEmails.BackColor = Color.FromArgb(225, 213, 217);
            textBoxEmails.Location = new Point(349, 56);
            textBoxEmails.Multiline = true;
            textBoxEmails.Name = "textBoxEmails";
            textBoxEmails.Size = new Size(158, 100);
            textBoxEmails.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker.Location = new Point(62, 133);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(179, 23);
            dateTimePicker.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(225, 213, 217);
            button1.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold);
            button1.Location = new Point(385, 185);
            button1.Name = "button1";
            button1.Size = new Size(96, 44);
            button1.TabIndex = 7;
            button1.Text = "Копіювати посилання";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCopyLink_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(btnCreateEvent);
            groupBox1.Controls.Add(txtEventName);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(textBoxEmails);
            groupBox1.Controls.Add(comboBoxEmails);
            groupBox1.Location = new Point(102, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 285);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // Meetform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(731, 408);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Meetform";
            Text = "Meet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateEvent;
        private Label label1;
        private TextBox txtEventName;
        private ComboBox comboBoxEmails;
        private TextBox textBoxEmails;
        private DateTimePicker dateTimePicker;
        private Button button1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
    }
}