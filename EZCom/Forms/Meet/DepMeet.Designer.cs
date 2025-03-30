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
            button1 = new Button();
            dateTimePicker = new DateTimePicker();
            comboBoxDepartments = new ComboBox();
            txtEventName = new TextBox();
            label1 = new Label();
            btnCreateEvent = new Button();
            textBoxEmails = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(332, 311);
            button1.Name = "button1";
            button1.Size = new Size(79, 38);
            button1.TabIndex = 14;
            button1.Text = "Копіювати посилання";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCopyLink_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(275, 213);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 13;
            // 
            // comboBoxDepartments
            // 
            comboBoxDepartments.FormattingEnabled = true;
            comboBoxDepartments.Location = new Point(285, 170);
            comboBoxDepartments.Name = "comboBoxDepartments";
            comboBoxDepartments.Size = new Size(179, 23);
            comboBoxDepartments.TabIndex = 11;
            comboBoxDepartments.SelectedIndexChanged += comboBoxDepartments_SelectedIndexChanged;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(296, 124);
            txtEventName.Multiline = true;
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(150, 29);
            txtEventName.TabIndex = 10;
            txtEventName.Text = "Введіть назву зустрічі";
            txtEventName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(227, 50);
            label1.Name = "label1";
            label1.Size = new Size(294, 38);
            label1.TabIndex = 9;
            label1.Text = "Заплануйте свою зустріч";
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Font = new Font("Segoe UI", 15F);
            btnCreateEvent.Location = new Point(296, 265);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(150, 40);
            btnCreateEvent.TabIndex = 8;
            btnCreateEvent.Text = "Create Meet";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // textBoxEmails
            // 
            textBoxEmails.Location = new Point(607, 156);
            textBoxEmails.Multiline = true;
            textBoxEmails.Name = "textBoxEmails";
            textBoxEmails.Size = new Size(129, 93);
            textBoxEmails.TabIndex = 15;
            textBoxEmails.Visible = false;
            // 
            // DepMeet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEmails);
            Controls.Add(button1);
            Controls.Add(dateTimePicker);
            Controls.Add(comboBoxDepartments);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(btnCreateEvent);
            Name = "DepMeet";
            Text = "DepMeet";
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
    }
}