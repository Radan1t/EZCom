namespace EZCom.Forms.Main
{
    partial class MainNoComp
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonEditProfile;
        private Button buttonCreateCompany;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonEditProfile = new Button();
            buttonCreateCompany = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonEditProfile
            // 
            buttonEditProfile.BackColor = Color.FromArgb(183, 167, 174);
            buttonEditProfile.FlatStyle = FlatStyle.Popup;
            buttonEditProfile.Font = new Font("Yu Gothic", 8.25F);
            buttonEditProfile.Location = new Point(552, 12);
            buttonEditProfile.Name = "buttonEditProfile";
            buttonEditProfile.Size = new Size(136, 38);
            buttonEditProfile.TabIndex = 0;
            buttonEditProfile.Text = "Вийти";
            buttonEditProfile.UseVisualStyleBackColor = false;
            buttonEditProfile.Click += buttonEditProfile_Click;
            // 
            // buttonCreateCompany
            // 
            buttonCreateCompany.BackColor = Color.FromArgb(183, 167, 174);
            buttonCreateCompany.FlatStyle = FlatStyle.Popup;
            buttonCreateCompany.Font = new Font("Yu Gothic", 8.25F);
            buttonCreateCompany.Location = new Point(12, 359);
            buttonCreateCompany.Name = "buttonCreateCompany";
            buttonCreateCompany.Size = new Size(136, 37);
            buttonCreateCompany.TabIndex = 1;
            buttonCreateCompany.Text = "Створити компанію";
            buttonCreateCompany.UseVisualStyleBackColor = false;
            buttonCreateCompany.Click += buttonCreateCompany_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 18F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(71, 143);
            label1.Name = "label1";
            label1.Size = new Size(546, 84);
            label1.TabIndex = 2;
            label1.Text = "На жаль, наразі ви не є учасником жодної компанії.\r\nЗв'яжіться зі своїм менеджером, щоб вас додали.\r\nАбо ви можете створити власну компанію.\r\n";
            // 
            // MainNoComp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 84, 91);
            ClientSize = new Size(700, 422);
            Controls.Add(label1);
            Controls.Add(buttonEditProfile);
            Controls.Add(buttonCreateCompany);
            Name = "MainNoComp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головне меню";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
