namespace EZCom.Forms
{
    partial class CreateCompany
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxCompanyName;
        private NumericUpDown numericUpDownEmployees;
        private ComboBox comboBoxSubscription;
        private TextBox textBoxContactManagerName;
        private TextBox textBoxContactManagerPhone;
        private TextBox textBoxContactManagerEmail;
        private Button buttonSave;
        private Button buttonCancel;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePickerSubscription; // Додано контрол для вибору часу підписки

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
            numericUpDownEmployees = new NumericUpDown();
            comboBoxSubscription = new ComboBox();
            textBoxContactManagerName = new TextBox();
            textBoxContactManagerPhone = new TextBox();
            textBoxContactManagerEmail = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            groupBox1 = new GroupBox();
            dateTimePickerSubscription = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEmployees).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.BackColor = Color.FromArgb(217, 217, 217);
            textBoxCompanyName.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            textBoxCompanyName.Location = new Point(78, 33);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.PlaceholderText = "Company name";
            textBoxCompanyName.Size = new Size(224, 33);
            textBoxCompanyName.TabIndex = 0;
            // 
            // numericUpDownEmployees
            // 
            numericUpDownEmployees.BackColor = Color.FromArgb(217, 217, 217);
            numericUpDownEmployees.Font = new Font("Yu Gothic", 12F);
            numericUpDownEmployees.Location = new Point(78, 92);
            numericUpDownEmployees.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownEmployees.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEmployees.Name = "numericUpDownEmployees";
            numericUpDownEmployees.Size = new Size(100, 33);
            numericUpDownEmployees.TabIndex = 1;
            numericUpDownEmployees.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxSubscription
            // 
            comboBoxSubscription.BackColor = Color.FromArgb(217, 217, 217);
            comboBoxSubscription.Font = new Font("Yu Gothic", 12F);
            comboBoxSubscription.Location = new Point(78, 150);
            comboBoxSubscription.Name = "comboBoxSubscription";
            comboBoxSubscription.Size = new Size(159, 29);
            comboBoxSubscription.TabIndex = 2;
            // 
            // textBoxContactManagerName
            // 
            textBoxContactManagerName.BackColor = Color.FromArgb(217, 217, 217);
            textBoxContactManagerName.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            textBoxContactManagerName.Location = new Point(78, 240);
            textBoxContactManagerName.Name = "textBoxContactManagerName";
            textBoxContactManagerName.PlaceholderText = "Full name";
            textBoxContactManagerName.Size = new Size(250, 27);
            textBoxContactManagerName.TabIndex = 4;
            // 
            // textBoxContactManagerPhone
            // 
            textBoxContactManagerPhone.BackColor = Color.FromArgb(217, 217, 217);
            textBoxContactManagerPhone.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            textBoxContactManagerPhone.Location = new Point(78, 280);
            textBoxContactManagerPhone.Name = "textBoxContactManagerPhone";
            textBoxContactManagerPhone.PlaceholderText = "Phone number";
            textBoxContactManagerPhone.Size = new Size(250, 27);
            textBoxContactManagerPhone.TabIndex = 5;
            // 
            // textBoxContactManagerEmail
            // 
            textBoxContactManagerEmail.BackColor = Color.FromArgb(217, 217, 217);
            textBoxContactManagerEmail.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            textBoxContactManagerEmail.Location = new Point(78, 320);
            textBoxContactManagerEmail.Name = "textBoxContactManagerEmail";
            textBoxContactManagerEmail.PlaceholderText = "E-mail ";
            textBoxContactManagerEmail.Size = new Size(250, 27);
            textBoxContactManagerEmail.TabIndex = 6;
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
            groupBox1.Controls.Add(dateTimePickerSubscription);
            groupBox1.Controls.Add(textBoxContactManagerEmail);
            groupBox1.Controls.Add(textBoxContactManagerPhone);
            groupBox1.Controls.Add(textBoxContactManagerName);
            groupBox1.Controls.Add(comboBoxSubscription);
            groupBox1.Controls.Add(numericUpDownEmployees);
            groupBox1.Controls.Add(textBoxCompanyName);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Location = new Point(159, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 430);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // dateTimePickerSubscription
            // 
            dateTimePickerSubscription.BackColor = Color.FromArgb(217, 217, 217);
            dateTimePickerSubscription.Font = new Font("Yu Gothic", 12F);
            dateTimePickerSubscription.Location = new Point(78, 200);
            dateTimePickerSubscription.Name = "dateTimePickerSubscription";
            dateTimePickerSubscription.Size = new Size(250, 33);
            dateTimePickerSubscription.TabIndex = 9;
            // 
            // CreateCompany
            // 
            BackColor = Color.FromArgb(88, 84, 91);
            ClientSize = new Size(700, 522);
            Controls.Add(groupBox1);
            Name = "CreateCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Створити компанію";
            ((System.ComponentModel.ISupportInitialize)numericUpDownEmployees).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
    }
}
