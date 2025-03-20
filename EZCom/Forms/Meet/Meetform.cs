using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.Common.DTO;

namespace EZCom.Forms.Meet
{

    public partial class Meetform : Form
    {
        UserDTO userDTO;
        public Meetform(UserDTO user)
        {
            InitializeComponent();
            userDTO = user;
        }

        private void btnCreateEvent_Click_1(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            DateTime startDate = dateTimePicker.Value;
            DateTime endDate = startDate.AddHours(1); // За замовчуванням тривалість 1 година
            string emails = txtEmails.Text.Replace(" ", ""); // Прибираємо пробіли
            string email1 = userDTO.E_mail.ToString();

            // Форматуємо дату у формат YYYYMMDDTHHMMSSZ
            string startFormatted = startDate.ToUniversalTime().ToString("yyyyMMddTHHmmssZ");
            string endFormatted = endDate.ToUniversalTime().ToString("yyyyMMddTHHmmssZ");

            // Формуємо URL для Google Calendar
            string url = $"https://calendar.google.com/calendar/render?action=TEMPLATE" +
                         $"&text={Uri.EscapeDataString(eventName)}" +
                         $"&dates={startFormatted}/{endFormatted}" +
                         $"&add={Uri.EscapeDataString(emails)}";

            // Відкриваємо посилання у браузері
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
