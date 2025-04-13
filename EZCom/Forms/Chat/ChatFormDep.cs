using Application.Common.DTO;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZCom.Forms.Chat
{
    public partial class ChatFormDep : Form
    {
        UserDTO _userDTO;
        int _chatid;
        public ChatFormDep(UserDTO userDTO, int chatid)
        {
            this._userDTO = userDTO;
            _chatid = chatid;
            InitializeComponent();
        }
    }
}
