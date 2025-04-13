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
        public ChatFormPrivate(UserDTO userDTO, int chatid)
        {
            this._userDTO = userDTO;
            _chatid= chatid;
            _chatService = Program.ServiceProvider.GetRequiredService<IChatService>();
            InitializeComponent();
            GetUsers();
            
        }
        public async void GetUsers()
        {
            var companion = await _chatService.GetCompanionInPrivateChatAsync(_chatid, _userDTO.Id);

            if (companion != null)
            {
                label1.Text = $"{companion.First_name} {companion.Last_name}";
            }
            else
            {
                label1.Text = "Співрозмовника не знайдено.";
            }
        }




    }
}
