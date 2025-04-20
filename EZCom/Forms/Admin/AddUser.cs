using Application.Common.DTO;
using Application.Interfaces;
using Application.Interfaces.Services;
using EZCom.UI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EZCom.Forms.Admin
{
    public partial class AddUser : Form
    {
        UserDTO userDTO;
        IAdminService _adminService;
        public AddUser(UserDTO user)
        {
            this.userDTO = user;
            InitializeComponent();
            _adminService = Program.ServiceProvider.GetRequiredService<IAdminService>();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            int companyId = userDTO.CompanyID ?? 0;

            bool result = await _adminService.AddUserToCompanyAsync(email, companyId);

            if (result)
            {
                MessageBox.Show("Користувач успішно доданий до компанії!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не вдалося додати користувача. Переконайтесь, що він існує.Або ваша підписка не підтримує більше.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}