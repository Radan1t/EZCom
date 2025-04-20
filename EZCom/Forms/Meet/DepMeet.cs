using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Application.Common.DTO;
using Application.Interfaces.Services;
using EZCom.Application.Interfaces;
using EZCom.UI;
using Microsoft.Extensions.DependencyInjection;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using System.Threading.Tasks;

namespace EZCom.Forms.Meet
{
    public partial class DepMeet : Form
    {
        private UserDTO _userDTO;
        private IMeetService _meetService;
        private string _generatedMeetLink;
        private Dictionary<string, List<string>> _departmentData;
        public DepMeet(UserDTO user)
        {
            _userDTO = user;
            InitializeComponent();
            _meetService = Program.ServiceProvider.GetRequiredService<IMeetService>();
            Email_Load();
        }

        public async void Email_Load()
        {
            _departmentData = await _meetService.GetCompanyDepartmentsWithEmailsAsync(_userDTO.CompanyID ?? 0);

            comboBoxDepartments.DataSource = _departmentData.Keys.ToList();
            comboBoxDepartments.SelectedIndex = -1;
            textBoxEmails.Clear();
        }

        private void comboBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartments.SelectedIndex >= 0)
            {
                string selectedDepartment = comboBoxDepartments.SelectedItem.ToString();
                var emails = _departmentData[selectedDepartment]; // Отримуємо email користувачів вибраного підрозділу

                textBoxEmails.Clear();
                textBoxEmails.Text = string.Join(Environment.NewLine, emails);
            }
        }


        private async void btnCreateEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            DateTime eventDate = dateTimePicker.Value;
            var emails = textBoxEmails.Lines.Where(line => !string.IsNullOrEmpty(line)).ToList();
            emails.Add(_userDTO.E_mail);

            _generatedMeetLink = await _meetService.CreateGoogleCalendarEvent(eventName, eventDate, emails, _userDTO.CompanyID ?? 0);

            if (!string.IsNullOrEmpty(_generatedMeetLink))
            {
                MessageBox.Show("Google Meet Link: " + _generatedMeetLink, "Generated Link");
            }
            else
            {
                MessageBox.Show("Не вдалося створити зустріч.", "Помилка");
            }
        }

        private void btnCopyLink_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_generatedMeetLink))
            {
                Clipboard.SetText(_generatedMeetLink);
                MessageBox.Show("Посилання скопійовано в буфер обміну!", "Успіх");
            }
            else
            {
                MessageBox.Show("Будь ласка, спочатку створіть зустріч.", "Помилка");
            }
        }
    }
}