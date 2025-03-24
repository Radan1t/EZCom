namespace EZCom.Forms.Admin
{
    partial class ChangeUserAccess
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
            listBoxUsers = new ListBox();
            comboBoxUserTypes = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(217, 57);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(344, 94);
            listBoxUsers.TabIndex = 0;
            // 
            // comboBoxUserTypes
            // 
            comboBoxUserTypes.FormattingEnabled = true;
            comboBoxUserTypes.Location = new Point(310, 207);
            comboBoxUserTypes.Name = "comboBoxUserTypes";
            comboBoxUserTypes.Size = new Size(121, 23);
            comboBoxUserTypes.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(300, 273);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ChangeUserAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBoxUserTypes);
            Controls.Add(listBoxUsers);
            Name = "ChangeUserAccess";
            Text = "ChangeUserAccess";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUsers;
        private ComboBox comboBoxUserTypes;
        private Button button1;
    }
}