using Application.Common.DTO;
using Application.Interfaces.Services;
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
    public partial class ChatFormPrivate : Form
    {
        UserDTO _userDTO;
        int _chatid;
        IChatService _chatService;
        UserDTO _companionName;
        string sendersName;
        private System.Windows.Forms.Timer _refreshTimer;

        public ChatFormPrivate(UserDTO userDTO, int chatid)
        {
            _userDTO = userDTO;
            _chatid = chatid;
            _chatService = Program.ServiceProvider.GetRequiredService<IChatService>();
            InitializeComponent();
            this.Load += ChatFormPrivate_Load;
        }

        private async void ChatFormPrivate_Load(object sender, EventArgs e)
        {
            await GetUsers();
            await LoadMessagesAsync(_chatid, _userDTO.Id);

            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 10000; // кожні 10 секунд
            _refreshTimer.Tick += async (s, args) =>
            {
                await LoadMessagesAsync(_chatid, _userDTO.Id);
            };
            _refreshTimer.Start();
        }


        public async Task GetUsers()
        {
            var companion = await _chatService.GetCompanionInPrivateChatAsync(_chatid, _userDTO.Id);

            if (companion != null)
            {
                label1.Text = $"{companion.First_name} {companion.Last_name}";
                _companionName = companion;
            }
            else
            {
                label1.Text = "Співрозмовника не знайдено.";
            }
        }

        private async Task LoadMessagesAsync(int chatId, int currentUserId)
        {
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            var messages = (await _chatService.GetMessagesByChatIdAsync(chatId))
                            .OrderBy(m => m.DateTime)
                            .ToList();

            foreach (var message in messages)
            {
                // Основна панель повідомлення
                Panel messagePanel = new Panel
                {
                    AutoSize = true,
                    BackColor = message.UserID == currentUserId ? Color.LightGray : Color.White,
                    Padding = new Padding(10),
                    Margin = new Padding(5),
                    MaximumSize = new Size(flowLayoutPanel1.Width - 120, 0)
                };

                // Текст повідомлення
                Label contentLabel = new Label
                {
                    AutoSize = true,
                    Text = message.Content,
                    Font = new Font("Segoe UI", 10),
                    MaximumSize = new Size(flowLayoutPanel1.Width - 120, 0)
                };

                string sendersName = message.UserID == currentUserId
                    ? $"{_userDTO.First_name} {_userDTO.Last_name}"
                    : $"{_companionName.First_name} {_companionName.Last_name}";

                // Час повідомлення
                Label timeLabel = new Label
                {
                    AutoSize = true,
                    Text = sendersName + "\n " + message.DateTime.ToString("HH:mm  M.MM.yyyy"),
                    Font = new Font("Segoe UI", 7, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Bottom,
                    Padding = new Padding(0, 17, 0, 0)
                };

                messagePanel.Controls.Add(contentLabel);
                messagePanel.Controls.Add(timeLabel);

                // Обгортка вирівнювання (все зліва)
                Panel alignPanel = new Panel
                {
                    Width = flowLayoutPanel1.Width - 25,
                    AutoSize = true
                };

                messagePanel.Location = new Point(10, 0); // Всі зліва

                alignPanel.Controls.Add(messagePanel);
                flowLayoutPanel1.Controls.Add(alignPanel);
            }

            flowLayoutPanel1.ResumeLayout();
        }





        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                var message = new MessageDTO
                {
                    ChatID = _chatid,
                    UserID = _userDTO.Id,
                    Content = textBox1.Text,
                };

                await _chatService.SendMessageAsync(message);
                textBox1.Clear();
                await LoadMessagesAsync(_chatid, _userDTO.Id);
            }
        }

    }
}
