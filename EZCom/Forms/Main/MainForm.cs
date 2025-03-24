using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using EZCom.Helper;
using EZCom.Forms.Admin;
using EZCom.Forms.Meet;
using EZCom.Forms.Chat;
using System.Windows.Forms;
using Application.Interfaces.Services;
using EZCom.UI;
using Application.Interfaces;
using Application.Common.DTO;
using Core.Entities;
using Google;

namespace EZCom.Forms.Main
{
    public partial class MainForm : Form
    {
        Login _login;
        UserDTO userDTO;
        private readonly ILoginService _loginService;
        private readonly ICompanyService _companyService;
        private readonly IGoogleAuthService _googleAuthService;
        private readonly ICalendarService _calendarService;
        public MainForm(UserDTO user, Login login)
        {
            this.userDTO = user;
            this._login = login;

            InitializeComponent();
            DefaultUI.GroupBoxFix(groupBox1);
            DefaultUI.GroupBoxFix(groupBox2);
            DefaultUI.GroupBoxFix(groupBox3);
            DefaultUI.GroupBoxFix(groupBox4);
            DefaultUI.GroupBoxFix(groupBox5);
            DefaultUI.GroupBoxFix(groupBox6);
            DefaultUI.GroupBoxFix(groupBox7);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.WrapContents = false;
            flowLayoutPanel2.Dock = DockStyle.Fill;
            _loginService = Program.ServiceProvider.GetRequiredService<ILoginService>();
            _companyService = Program.ServiceProvider.GetRequiredService<ICompanyService>();
            _googleAuthService = Program.ServiceProvider.GetRequiredService<IGoogleAuthService>();
            _calendarService = Program.ServiceProvider.GetRequiredService<ICalendarService>();

        }
        private void AddChat(string chatName, FlowLayoutPanel panel)
        {
            int chatPanelWidth = Math.Min(flowLayoutPanel1.ClientSize.Width, flowLayoutPanel2.ClientSize.Width)
                                 - SystemInformation.VerticalScrollBarWidth;

            Panel chatPanel = new Panel();
            chatPanel.Width = chatPanelWidth;
            chatPanel.Height = 50;
            chatPanel.BackColor = Color.LightGray;
            chatPanel.BorderStyle = BorderStyle.FixedSingle;
            chatPanel.Cursor = Cursors.Hand;


            Label chatLabel = new Label();
            chatLabel.Text = chatName;
            chatLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            chatLabel.AutoSize = true;
            chatLabel.Location = new Point(10, 15);

            chatPanel.Controls.Add(chatLabel);
            panel.Controls.Add(chatPanel);
        }
        private void AddUrlBlock(string url, FlowLayoutPanel panel)
        {
            Panel blockPanel = new Panel
            {
                Width = panel.ClientSize.Width - SystemInformation.VerticalScrollBarWidth,
                Height = 50,
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                Padding = new Padding(5),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };

            TableLayoutPanel container = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 1
            };
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            LinkLabel linkLabel = new LinkLabel
            {
                Text = url,
                Font = new Font("Arial", 10, FontStyle.Underline),
                AutoSize = true,
                LinkColor = Color.Blue,
                VisitedLinkColor = Color.Purple,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.None
            };

            linkLabel.Click += (sender, e) =>
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = url, UseShellExecute = true });

            container.Controls.Add(linkLabel, 0, 0);
            blockPanel.Controls.Add(container);
            panel.Controls.Add(blockPanel);
        }


        private async void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                AddChat($"Чат {i}", flowLayoutPanel1);
                AddChat($"Чат {i}", flowLayoutPanel2);
            }

            AddUrlBlock("https://example.com/1", flowLayoutPanel3);
            AddUrlBlock("https://example.com/2", flowLayoutPanel3);
            AddUrlBlock("https://example.com/3", flowLayoutPanel3);
            AddUrlBlock("https://example.com/4", flowLayoutPanel3);

            if (!await _calendarService.HasCalendarAccessAsync())
            {
                MessageBox.Show("У вас немає доступу до календаря. Натисніть кнопку для надання дозволу.", "Доступ заблоковано", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Button requestAccessButton = new Button
                {
                    Text = "Надати доступ до календаря",
                    Width = 250,
                    Height = 40,
                    Location = new Point(10, 10)
                };
                requestAccessButton.Click += async (s, ev) => await RequestCalendarAccess();
                this.Controls.Add(requestAccessButton);
            }
            else
            {
                LoadCalendar();
            }
        }

        private void LoadCalendar()
        {
            string calendarUrl = $"https://calendar.google.com/calendar/embed?src={Uri.EscapeDataString(userDTO.E_mail)}&ctz=Europe/Kyiv&bgcolor=%23FFFFFF";
            webView21.Source = new Uri(calendarUrl);
        }
        private async Task RequestCalendarAccess()
        {
            try
            {
                bool success = await _calendarService.RequestCalendarPermissionAsync();
                if (success)
                {
                    MessageBox.Show("Доступ до календаря надано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCalendar();
                }
                else
                {
                    MessageBox.Show("Не вдалося отримати доступ до календаря.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (GoogleApiException ex)
            {
                // Це дозволяє отримати специфічні помилки від Google API
                MessageBox.Show($"Google API Error: {ex.Message}", "Помилка доступу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка доступу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void button5_Click(object sender, EventArgs e)
        {
            Meetform meet = new Meetform(userDTO);
            meet.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adminform admin = new Adminform();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewChat newChat = new NewChat();
            newChat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _googleAuthService.DeleteToken();
            _login.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
