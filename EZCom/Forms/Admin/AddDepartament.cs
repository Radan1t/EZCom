﻿using Application.Interfaces;
using Application.Common.DTO;
using System;
using System.Windows.Forms;
using Application.Interfaces.Services;
using EZCom.UI;
using Microsoft.Extensions.DependencyInjection;

namespace EZCom.Forms.Admin
{
    public partial class AddDepartament : Form
    {
        private readonly IAdminService _adminService;
        private readonly UserDTO _userDTO;
        public class UserWithFullName
        {
            public int Id { get; set; }
            public string FullName { get; set; }
        }

        public AddDepartament(UserDTO userDTO)
        {
            _userDTO = userDTO;
            InitializeComponent();
            _adminService = Program.ServiceProvider.GetRequiredService<IAdminService>();
            LoadUsers();  
        }

        private async void LoadUsers()
        {
            if (_userDTO.CompanyID.HasValue)
            {
                var users = await _adminService.GetUsersByCompanyAsync(_userDTO.CompanyID.Value);

                var usersWithFullName = users.Select(user => new UserWithFullName
                {
                    Id = user.Id,
                    FullName = $"{user.First_name} {user.Last_name}"
                }).ToList();

                comboBoxUsers.DataSource = usersWithFullName;
                comboBoxUsers.DisplayMember = "FullName";
                comboBoxUsers.ValueMember = "Id";

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string departmentName = textBoxDepartmentName.Text.Trim();

            if (string.IsNullOrEmpty(departmentName))
            {
                MessageBox.Show("Будь ласка, введіть назву підрозділу.");
                return;
            }

            if (comboBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть користувача.");
                return;
            }

            // Get the selected user from combo box (which is UserWithFullName)
            var selectedUser = (UserWithFullName)comboBoxUsers.SelectedItem;

            // Use the selected user's Id to get the full user details
            var userDTO = await _adminService.GetUserByIdAsync(selectedUser.Id);

            if (userDTO == null)
            {
                MessageBox.Show("Не вдалося знайти користувача.");
                return;
            }

            // Proceed to add department
            bool result = await _adminService.AddDepartmentAsync(departmentName, _userDTO.CompanyID.Value, selectedUser.Id);

            if (result)
            {
                MessageBox.Show("Підрозділ успішно створений.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Не вдалося створити підрозділ.");
            }
        }


    }
}
