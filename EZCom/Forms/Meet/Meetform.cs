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
    public partial class Meetform : Form
    {
        private UserDTO _userDTO;
        private IMeetService _meetService;
        private string _generatedMeetLink;

        public Meetform(UserDTO user)
        {
            _userDTO = user;
            InitializeComponent();
            _meetService = Program.ServiceProvider.GetRequiredService<IMeetService>();
            Email_Load();
        }

        public async void Email_Load()
        {
            var emails = await _meetService.GetEmployeeEmailsAsync(_userDTO);

            var filteredEmails = emails.Where(email => email != _userDTO.E_mail).ToList();

            comboBoxEmails.DataSource = filteredEmails;
            comboBoxEmails.SelectedIndex = -1;
            textBoxEmails.Clear();
        }


        private void comboBoxEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmails.SelectedIndex >= 0)
            {
                string selectedEmail = comboBoxEmails.SelectedItem.ToString();
                textBoxEmails.AppendText(selectedEmail + Environment.NewLine);
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