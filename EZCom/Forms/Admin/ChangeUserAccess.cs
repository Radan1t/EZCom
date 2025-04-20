using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.Common.DTO;
using Application.Interfaces;
using Core.Entities;
using EZCom.UI;
using Microsoft.Extensions.DependencyInjection;

namespace EZCom.Forms.Admin
{
    public partial class ChangeUserAccess : Form
    {
        private readonly IAdminService _adminService;
        private readonly UserDTO _userDTO;

        public ChangeUserAccess(UserDTO userDTO)
        {
            _userDTO = userDTO;
            _adminService = Program.ServiceProvider.GetRequiredService<IAdminService>();
            InitializeComponent();
            LoadUsersAndTypes();
        }


        private async Task LoadUsersAndTypes()
        {
            // Перевіряємо, чи CompanyID не null перед викликом методу
            if (_userDTO.CompanyID.HasValue)
            {
                var users = await _adminService.GetUsersByCompanyAsync(_userDTO.CompanyID.Value);
                var userTypes = await _adminService.GetUserTypesAsync();

                // Фільтруємо типи користувачів, щоб не показувати "Owner"
                var filteredUserTypes = userTypes.Where(ut => ut.Type_name != "Owner").ToList();

                // Фільтруємо користувачів, щоб не показувати залогіненого користувача
                var filteredUsers = users.Where(u => u.Id != _userDTO.Id).ToList();

                // Створюємо анонімний тип для об'єднання First_name, Last_name та поточного типу
                var usersWithFullNameAndType = filteredUsers.Select(u => new
                {
                    u.Id,
                    FullName = $"{u.First_name} {u.Last_name}",
                    u.E_mail,
                    u.UserTypeID,
                    // Знаходимо поточний тип користувача по UserTypeID
                    CurrentType = userTypes.FirstOrDefault(ut => ut.Id == u.UserTypeID)?.Type_name ?? "Unknown",
                    // Створюємо комбіновану строку для відображення в listBox
                    FullNameAndType = $"{u.First_name} {u.Last_name} ({userTypes.FirstOrDefault(ut => ut.Id == u.UserTypeID)?.Type_name ?? "Unknown"})"
                }).ToList();

                // Заповнюємо список користувачів
                listBoxUsers.DataSource = usersWithFullNameAndType;

                // Виводимо FullNameAndType як комбінований рядок
                listBoxUsers.DisplayMember = "FullNameAndType";

                // Додаємо інформацію про поточний тип у якості додаткової колонки (не відображати в listBox)
                listBoxUsers.ValueMember = "UserTypeID"; // Якщо потрібен доступ до ID типу користувача

                comboBoxUserTypes.DataSource = filteredUserTypes;
                comboBoxUserTypes.DisplayMember = "Type_name";
            }
            else
            {
                MessageBox.Show("Відсутній ID компанії для цього користувача.");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Отримуємо вибраного користувача з listBox
            if (listBoxUsers.SelectedItem != null && comboBoxUserTypes.SelectedItem != null)
            {
                var selectedUser = (dynamic)listBoxUsers.SelectedItem;  // анонімний тип, що містить FullName
                var selectedUserId = selectedUser.Id;
                var selectedUserTypeId = ((UserType)comboBoxUserTypes.SelectedItem).Id;

                // Викликаємо метод сервісу для зміни типу користувача
                bool result = await  _adminService.ChangeUserTypeAsync(selectedUserId, selectedUserTypeId);

                if (result)
                {
                    MessageBox.Show("Тип користувача успішно змінено.");
                }
                else
                {
                    MessageBox.Show("Не вдалося змінити тип користувача.");
                }
                LoadUsersAndTypes();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть користувача і тип.");
            }
        }
    }
}
