using Application.Common.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZCom.Forms.Admin
{
    public partial class Adminform : Form
    {
        UserDTO _userDTO;
        public Adminform(UserDTO userDTO)
        {
            this._userDTO = userDTO;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(_userDTO);
            addUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeUserAccess changeUserAccess = new ChangeUserAccess(_userDTO);
            changeUserAccess.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDepartament addDepartament = new AddDepartament(_userDTO);
            addDepartament.Show();
        }
    }
}
