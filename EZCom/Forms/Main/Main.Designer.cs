namespace EZCom.Forms.Main
{
    partial class Main
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
            SuspendLayout();
            // 
            // buttonEditProfile
            // 
            buttonEditProfile.BackColor = Color.FromArgb(183, 167, 174);
            buttonEditProfile.FlatStyle = FlatStyle.Popup;
            buttonEditProfile.Font = new Font("Yu Gothic", 8.25F);
            buttonEditProfile.Location = new Point(543, 23);
            buttonEditProfile.Name = "buttonEditProfile";
            buttonEditProfile.Size = new Size(136, 38);
            buttonEditProfile.TabIndex = 0;
            buttonEditProfile.Text = "Log Out";
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
            buttonCreateCompany.Text = "Create company";
            buttonCreateCompany.UseVisualStyleBackColor = false;
            buttonCreateCompany.Click += buttonCreateCompany_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 84, 91);
            ClientSize = new Size(700, 422);
            Controls.Add(buttonEditProfile);
            Controls.Add(buttonCreateCompany);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головне меню";
            ResumeLayout(false);
        }
    }
}
