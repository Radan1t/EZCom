using Application.Interfaces.Services;
using EZCom.UI;
using Infrastructure.Persistence.Data;
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
using Application.Common.DTO;

namespace EZCom.Forms.Main
{
    public partial class MainNoComp : Form
    {
        UserDTO User;
        private readonly Login _loginForm;
        private readonly ILoginService _loginService;
        private readonly IGoogleAuthService _googleAuth;
        public MainNoComp( UserDTO user, Login loginForm)
        {
            InitializeComponent();
            User = user;
            _loginForm = loginForm;
            _loginService = Program.ServiceProvider.GetRequiredService<ILoginService>();
            _googleAuth = Program.ServiceProvider.GetRequiredService<IGoogleAuthService>();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            _googleAuth.DeleteToken();
            _loginForm.Show();
            this.Close();
        }

        private void buttonCreateCompany_Click(object sender, EventArgs e)
        {
            Form CompanyName = new CreateCompany(User,this,_loginForm);
            CompanyName.Show();
            this.Hide();


        }
    }
}
