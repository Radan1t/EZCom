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
            btnCreateEvent = new Button();
            label1 = new Label();
            txtEventName = new TextBox();
            comboBoxEmails = new ComboBox();
            textBoxEmails = new TextBox();
            dateTimePicker = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Font = new Font("Segoe UI", 15F);
            btnCreateEvent.Location = new Point(312, 293);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(150, 40);
            btnCreateEvent.TabIndex = 0;
            btnCreateEvent.Text = "Create Meet";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(243, 39);
            label1.Name = "label1";
            label1.Size = new Size(294, 38);
            label1.TabIndex = 1;
            label1.Text = "Заплануйте свою зустріч";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(312, 113);
            txtEventName.Multiline = true;
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(150, 29);
            txtEventName.TabIndex = 2;
            txtEventName.Text = "Введіть назву зустрічі";
            txtEventName.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBoxEmails
            // 
            comboBoxEmails.FormattingEnabled = true;
            comboBoxEmails.Location = new Point(301, 159);
            comboBoxEmails.Name = "comboBoxEmails";
            comboBoxEmails.Size = new Size(179, 23);
            comboBoxEmails.TabIndex = 4;
            comboBoxEmails.SelectedIndexChanged += comboBoxEmails_SelectedIndexChanged;
            // 
            // textBoxEmails
            // 
            textBoxEmails.Location = new Point(600, 134);
            textBoxEmails.Multiline = true;
            textBoxEmails.Name = "textBoxEmails";
            textBoxEmails.Size = new Size(158, 100);
            textBoxEmails.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(291, 202);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(643, 250);
            button1.Name = "button1";
            button1.Size = new Size(79, 38);
            button1.TabIndex = 7;
            button1.Text = "Копіювати посилання";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCopyLink_Click;
            // 
            // Meetform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dateTimePicker);
            Controls.Add(textBoxEmails);
            Controls.Add(comboBoxEmails);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(btnCreateEvent);
            Name = "Meetform";
            Text = "Meet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateEvent;
        private Label label1;
        private TextBox txtEventName;
        private ComboBox comboBoxEmails;
        private TextBox textBoxEmails;
        private DateTimePicker dateTimePicker;
        private Button button1;
    }
}