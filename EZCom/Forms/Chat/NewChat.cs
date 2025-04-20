using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.Common.DTO;
using Application.Interfaces.Services;
using Core.Entities;
using EZCom.UI;
using Microsoft.Extensions.DependencyInjection;

namespace EZCom.Forms.Chat
{
    public partial class NewChat : Form
    {
        private readonly UserDTO _userDTO;
        private readonly IChatService _chatService;

        public NewChat(UserDTO userDTO)
        {
            _userDTO = userDTO;
            _chatService = Program.ServiceProvider.GetRequiredService<IChatService>(); 
            InitializeComponent();
            LoadUsersAsync();
        }



        private async Task LoadUsersAsync()
        {
            if (_userDTO.CompanyID.HasValue)
            {
                var users = await _chatService.GetUsersByCompanyIdAsync(_userDTO.CompanyID.Value);

                var filteredUsers = users.Where(user => user.Id != _userDTO.Id).ToList();

                // Створюємо анонімний об'єкт з повним іменем для кожного користувача
                var userDisplayList = filteredUsers.Select(user => new
                {
                    user.Id,
                    FullName = $"{user.First_name} {user.Last_name}"  // Формуємо повне ім'я
                }).ToList();

                // Налаштовуємо ComboBox для відображення FullName
                comboBoxUsers.DataSource = userDisplayList;
                comboBoxUsers.DisplayMember = "FullName";  // Відображення повного імені
                comboBoxUsers.ValueMember = "Id";  // Використання ID для значення
            }
            else
            {
                MessageBox.Show("Company ID не задано.");
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedItem != null)
            {

                var selectedUser = (dynamic)comboBoxUsers.SelectedItem; 
                int selectedUserId = selectedUser.Id;

 
                var user = await _chatService.GetUsersByCompanyIdAsync(_userDTO.CompanyID.Value);
                var selectedUserDTO = user.FirstOrDefault(u => u.Id == selectedUserId);

                if (selectedUserDTO == null)
                {
                    MessageBox.Show("Користувача не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newChatDTO = new ChatDTO
                {
                    Chat_name = $"{_userDTO.Last_name} & {selectedUserDTO.Last_name}",
                    Create_DateTime = DateTime.Now
                };

                var userChat1 = new UserChat
                {
                    UserID1 = _userDTO.Id,
                    UserID2 = selectedUserId
                };

                var userChat2 = new UserChat
                {
                    UserID1 = selectedUserId,
                    UserID2 = _userDTO.Id
                };

                await _chatService.CreateChatAsync(newChatDTO, userChat1, userChat2);

                MessageBox.Show("Чат успішно створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть користувача для чату.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
