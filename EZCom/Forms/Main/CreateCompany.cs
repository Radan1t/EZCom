using Application.Common.DTO;
using Application.Interfaces;
using Application.Interfaces.Services;
using EZCom.Forms.Main;
using EZCom.UI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZCom.Forms
{
    public partial class CreateCompany : Form
    {
        private readonly ICompanyService _companyService;
        int UserID;
        private readonly IEntityService _entityService;
        MainNoComp mainNoComp;
        public CreateCompany( int id, MainNoComp mainNoComp ) 
        {
            this.UserID = id;
            this.mainNoComp = mainNoComp;
            InitializeComponent();
            _companyService = Program.ServiceProvider.GetRequiredService<ICompanyService>();
            _entityService = Program.ServiceProvider.GetRequiredService<IEntityService>();
            LoadSubscriptionTypes();
        }

        private async void LoadSubscriptionTypes()
        {
            var subscriptions = await _companyService.GetSubscriptionsAsync();
            List<string> subscriptionTypes = subscriptions.Select(s => s.Version_name).ToList();

            comboBoxSubscription.Items.AddRange(subscriptionTypes.ToArray());
            if (comboBoxSubscription.Items.Count > 0)
            {
                comboBoxSubscription.SelectedIndex = 0;
            }
        }


        private async void buttonSave_Click(object sender, EventArgs e)
        {
            var manager =await _entityService.GetUserByIdAsync(this.UserID);
            if (manager == null)
            {
                MessageBox.Show("Менеджер з таким email не знайдений!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CompanyDTO companyDto = new CompanyDTO
            {
                CompanyName = textBoxCompanyName.Text.Trim(),
                UserCount = 1,
                ContactManagerName = manager.Last_name + manager.First_name,
                ContactManagerPhone = manager.Phone_number,
                ContactManagerEmail = manager.E_mail,
                ProductVersionTypeId = comboBoxSubscription.SelectedIndex + 1, 
                SubscriptionTime = DateTime.Now.AddMonths(1)
            };

            // Викликаємо метод сервісу для створення компанії
            try
            {
                await _companyService.CreateCompanyAsync(companyDto,UserID);
                MessageBox.Show($"Компанія '{companyDto.CompanyName}' успішно створена", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            mainNoComp.Show();
            this.Close();
        }
    }
}