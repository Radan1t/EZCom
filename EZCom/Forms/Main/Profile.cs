using Application.Common.DTO;
using Application.Interfaces.Services;
using EZCom.UI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace EZCom.Forms.Main
{
    public partial class Profile : Form
    {
        private UserDTO _originalUserDto;
        private readonly IRegistrationService _registrationService;

        public Profile(UserDTO userDto)
        {
            InitializeComponent();
            _registrationService = Program.ServiceProvider.GetRequiredService<IRegistrationService>();
            _originalUserDto = CloneUserDto(userDto);

            FillFields(_originalUserDto);
            SetEditingEnabled(false);
            btnSave.Visible = false;
        }

        private void FillFields(UserDTO user)
        {
            txtFirstName.Text = user.First_name;
            txtLastName.Text = user.Last_name;
            txtEmail.Text = user.E_mail;
            txtPhone.Text = user.Phone_number;
            dtpBirthDate.Value = user.Date_of_birthday;
        }

        private void SetEditingEnabled(bool isEnabled)
        {
            txtFirstName.Enabled = isEnabled;
            txtLastName.Enabled = isEnabled;
            txtPhone.Enabled = isEnabled;
            dtpBirthDate.Enabled = isEnabled;
        }

        private UserDTO CloneUserDto(UserDTO dto)
        {
            return new UserDTO
            {
                Id = dto.Id,
                First_name = dto.First_name,
                Last_name = dto.Last_name,
                E_mail = dto.E_mail,
                Phone_number = dto.Phone_number,
                Date_of_birthday = dto.Date_of_birthday,
                Credential = dto.Credential,
                CompanyID = dto.CompanyID
            };
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditingEnabled(true);
            btnSave.Visible = true;
        }

        private bool HasChanges()
        {
            return _originalUserDto.First_name != txtFirstName.Text ||
                   _originalUserDto.Last_name != txtLastName.Text ||
                   _originalUserDto.Phone_number != txtPhone.Text ||
                   _originalUserDto.Date_of_birthday.Date != dtpBirthDate.Value.Date;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Ім'я не може бути порожнім.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Прізвище не може бути порожнім.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Номер телефону не може бути порожнім.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, @"^\+?\d{9,15}$"))
            {
                MessageBox.Show("Некоректний формат номера телефону.");
                return false;
            }

            return true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!HasChanges())
            {
                MessageBox.Show("Немає змін для збереження.");
                return;
            }

            if (!ValidateFields())
            {
                return;
            }

            var updatedUser = CloneUserDto(_originalUserDto);
            updatedUser.First_name = txtFirstName.Text;
            updatedUser.Last_name = txtLastName.Text;
            updatedUser.Phone_number = txtPhone.Text;
            updatedUser.Date_of_birthday = dtpBirthDate.Value;

            try
            {
                var success = await _registrationService.UpdateUserAsync(updatedUser);

                if (success)
                {
                    MessageBox.Show("Профіль успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _originalUserDto = CloneUserDto(updatedUser);
                    SetEditingEnabled(false);
                    btnSave.Visible = false;
                }
                else
                {
                    MessageBox.Show("Не вдалося оновити профіль. Спробуйте пізніше.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
