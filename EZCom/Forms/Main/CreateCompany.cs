using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZCom.Forms
{
    public partial class CreateCompany : Form
    {
        private readonly ICreateCompany _companyService;

        // Конструктор приймає параметр companyService
        public CreateCompany(ICreateCompany companyService)
        {
            InitializeComponent();
            _companyService = companyService ?? throw new ArgumentNullException(nameof(companyService));
            LoadSubscriptionTypes();
        }

        private void LoadSubscriptionTypes()
        {
            // Симуляція отримання типів підписки з бази даних
            List<string> subscriptionTypes = new List<string> { "Basic", "Standard", "Premium" };
            comboBoxSubscription.Items.AddRange(subscriptionTypes.ToArray());
            if (comboBoxSubscription.Items.Count > 0)
            {
                comboBoxSubscription.SelectedIndex = 0;
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            /*string companyName = textBoxCompanyName.Text.Trim();
            string contactManagerName = textBoxContactManagerName.Text.Trim();
            string contactManagerPhone = textBoxContactManagerPhone.Text.Trim();
            string contactManagerEmail = textBoxContactManagerEmail.Text.Trim();
            int userCount = (int)numericUpDownEmployees.Value;
            int productVersionTypeId = comboBoxSubscription.SelectedIndex + 1; // Починається з 1, залежно від типу
            DateTime subscriptionTime = dateTimePickerSubscription.Value; // Виправлено на DateTime

            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Введіть назву компанії", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Викликаємо метод сервісу для створення компанії
            try
            {
                await _companyService.CreateCompanyAsync(companyName, contactManagerName, contactManagerPhone, contactManagerEmail, userCount, productVersionTypeId, subscriptionTime);
                MessageBox.Show($"Компанія '{companyName}' успішно створена", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}