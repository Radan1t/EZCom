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
            dateTimePicker = new DateTimePicker();
            txtEmails = new TextBox();
            SuspendLayout();
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Font = new Font("Segoe UI", 15F);
            btnCreateEvent.Location = new Point(337, 263);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(150, 40);
            btnCreateEvent.TabIndex = 0;
            btnCreateEvent.Text = "Create Meet";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateEvent_Click_1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(265, 19);
            label1.Name = "label1";
            label1.Size = new Size(294, 38);
            label1.TabIndex = 1;
            label1.Text = "Заплануйте свою зустріч";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(337, 113);
            txtEventName.Multiline = true;
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(150, 29);
            txtEventName.TabIndex = 2;
            txtEventName.Text = "Введіть назву зустрічі";
            txtEventName.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(307, 211);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 3;
            // 
            // txtEmails
            // 
            txtEmails.Location = new Point(326, 157);
            txtEmails.Multiline = true;
            txtEmails.Name = "txtEmails";
            txtEmails.Size = new Size(171, 38);
            txtEmails.TabIndex = 4;
            txtEmails.Text = "введіть пошту людей яких хочите додати";
            // 
            // Meetform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmails);
            Controls.Add(dateTimePicker);
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
        private DateTimePicker dateTimePicker;
        private TextBox txtEmails;
    }
}