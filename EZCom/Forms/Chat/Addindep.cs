using Application.Common.DTO;
using Application.Interfaces.Services;
using Core.Entities;
using EZCom.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace EZCom.Forms.Chat
{
    public partial class Addindep : Form
    {
        UserDTO _userDTO;
        int _departmentId;
        IChatService _chatService;
        public Addindep(UserDTO userDTO, int departmentId)
        {
            this._userDTO = userDTO;
            _departmentId = departmentId;
            _chatService = Program.ServiceProvider.GetRequiredService<IChatService>();
            InitializeComponent();
            LoadUsersToComboBoxAsync();
        }
        private async Task LoadUsersToComboBoxAsync()
        {
            try
            {
                var users = await _chatService.GetUsersByCompanyIdAsync(_userDTO.CompanyID ?? 0);

                users = users.Where(u => u.Id != _userDTO.Id).ToList();

                var userDisplayList = users.Select(u => new
                {
                    Id = u.Id,
                    FullName = $"{u.First_name} {u.Last_name}"
                }).ToList();

                comboBox1.DataSource = userDisplayList;
                comboBox1.DisplayMember = "FullName";
                comboBox1.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні користувачів: " + ex.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue is int selectedUserId)
                {
                    await _chatService.AddDepartment(_departmentId, selectedUserId);
                    MessageBox.Show("Користувача додано до підрозділу!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Закриваємо форму після додавання (опційно)
                }
                else
                {
                    MessageBox.Show("Будь ласка, виберіть користувача.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при додаванні: " + ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue is int selectedUserId)
                {
                    await _chatService.RemoveFromDepartmentAsync(_departmentId, selectedUserId);
                    MessageBox.Show("Користувача видалено з підрозділу!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Закриваємо форму після видалення (опційно)
                }
                else
                {
                    MessageBox.Show("Будь ласка, виберіть користувача.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні: " + ex.Message);
            }
        }

    }
}
