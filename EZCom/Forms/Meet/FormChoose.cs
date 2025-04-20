using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.Common.DTO;

namespace EZCom.Forms.Meet
{
    public partial class FormChoose : Form
    {
        private UserDTO _userDTO;
        public FormChoose(UserDTO userDTO)
        {
            _userDTO = userDTO;
            InitializeComponent();
        }

        private void unit_Click(object sender, EventArgs e)
        {
            DepMeet depMeet = new DepMeet(_userDTO);
            depMeet.Show();
        }

        private void custom_Click(object sender, EventArgs e)
        {
            Meetform custom = new Meetform(_userDTO);
            custom.Show();

        }
    }
}
