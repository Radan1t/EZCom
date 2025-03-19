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
        Login _login;
        private readonly ICompanyService _companyService;
        int UserID;
        MainNoComp mainNoComp;
        public CreateCompany( int id, MainNoComp mainNoComp,Login login ) 
        {
            _login = login;
            this.UserID = id;
            this.mainNoComp = mainNoComp;
            InitializeComponent();
            _companyService = Program.ServiceProvider.GetRequiredService<ICompanyService>();
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
            var manager =await _companyService.GetUserByIdAsync(this.UserID);
            if (manager == null)
            {
                MessageBox.Show("Менеджер з таким email не знайдений!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CompanyDTO companyDto = new CompanyDTO
            {
                Company_name = textBoxCompanyName.Text.Trim(),
                User_count = 1,
                Contact_manager_name = manager.Last_name + manager.First_name,
                Contact_manager_phone = manager.Phone_number,
                Contact_manager_email = manager.E_mail,
                ProductVersionTypeID = comboBoxSubscription.SelectedIndex + 1,
                Subscription_time = DateTime.Now.AddMonths(1)
            };

            // Викликаємо метод сервісу для створення компанії
            try
            {
                await _companyService.CreateCompanyAsync(companyDto, UserID);
                MessageBox.Show($"Компанія '{companyDto.Company_name}' успішно створена", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm main = new MainForm(UserID,_login);
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