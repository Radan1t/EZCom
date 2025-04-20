namespace EZCom.Forms
{
    partial class CreateCompany
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxCompanyName;
        private ComboBox comboBoxSubscription;
        private Button buttonSave;
        private Button buttonCancel;
        private GroupBox groupBox1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCompany));
            textBoxCompanyName = new TextBox();
            comboBoxSubscription = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.BackColor = Color.FromArgb(225, 213, 217);
            textBoxCompanyName.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            textBoxCompanyName.ForeColor = SystemColors.MenuText;
            textBoxCompanyName.Location = new Point(80, 78);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.PlaceholderText = "Company name";
            textBoxCompanyName.Size = new Size(224, 33);
            textBoxCompanyName.TabIndex = 0;
            // 
            // comboBoxSubscription
            // 
            comboBoxSubscription.BackColor = Color.FromArgb(225, 213, 217);
            comboBoxSubscription.Font = new Font("Yu Gothic", 12F);
            comboBoxSubscription.Location = new Point(80, 189);
            comboBoxSubscription.Name = "comboBoxSubscription";
            comboBoxSubscription.Size = new Size(224, 29);
            comboBoxSubscription.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(225, 213, 217);
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            buttonSave.ForeColor = Color.FromArgb(31, 31, 31);
            buttonSave.Location = new Point(63, 246);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(225, 213, 217);
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.FromArgb(31, 31, 31);
            buttonCancel.Location = new Point(241, 246);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 30);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Відмінити";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxSubscription);
            groupBox1.Controls.Add(textBoxCompanyName);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Location = new Point(110, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 315);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F);
            label2.Location = new Point(68, 136);
            label2.Name = "label2";
            label2.Size = new Size(261, 32);
            label2.TabIndex = 12;
            label2.Text = "Виберіть тип підписки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F);
            label1.Location = new Point(63, 20);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 11;
            label1.Text = "Введіть назву компанії";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-14, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CreateCompany
            // 
            BackColor = Color.FromArgb(183, 167, 174);
            ClientSize = new Size(570, 362);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "CreateCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Створити компанію";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
