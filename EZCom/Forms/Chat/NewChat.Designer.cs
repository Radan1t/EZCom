namespace EZCom.Forms.Chat
{
    partial class NewChat
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
            comboBoxUsers = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(327, 157);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(121, 23);
            comboBoxUsers.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(345, 273);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBoxUsers);
            Name = "NewChat";
            Text = "NewChat";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxUsers;
        private Button button1;
    }
}