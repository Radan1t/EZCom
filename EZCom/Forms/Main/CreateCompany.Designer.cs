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
            textBoxCompanyName = new TextBox();
            comboBoxSubscription = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.BackColor = Color.FromArgb(217, 217, 217);
            textBoxCompanyName.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            textBoxCompanyName.Location = new Point(104, 99);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.PlaceholderText = "Company name";
            textBoxCompanyName.Size = new Size(224, 33);
            textBoxCompanyName.TabIndex = 0;
            // 
            // comboBoxSubscription
            // 
            comboBoxSubscription.BackColor = Color.FromArgb(217, 217, 217);
            comboBoxSubscription.Font = new Font("Yu Gothic", 12F);
            comboBoxSubscription.Location = new Point(127, 195);
            comboBoxSubscription.Name = "comboBoxSubscription";
            comboBoxSubscription.Size = new Size(159, 29);
            comboBoxSubscription.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(183, 167, 174);
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Location = new Point(78, 370);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(183, 167, 174);
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Location = new Point(228, 370);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 30);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxSubscription);
            groupBox1.Controls.Add(textBoxCompanyName);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Location = new Point(159, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 430);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // CreateCompany
            // 
            BackColor = Color.FromArgb(88, 84, 91);
            ClientSize = new Size(700, 522);
            Controls.Add(groupBox1);
            Name = "CreateCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Створити компанію";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
    }
}
