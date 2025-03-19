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

namespace EZCom.Forms.Main
{
    public partial class MainNoComp : Form
    {
        int UserID;
        private readonly Login _loginForm;
        private readonly ILoginService _loginService;
        public MainNoComp( int userID, Login loginForm)
        {
            InitializeComponent();
            UserID = userID;
            _loginForm = loginForm;
            _loginService = Program.ServiceProvider.GetRequiredService<ILoginService>();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            _loginService.DeleteToken();
            _loginForm.Show();
            this.Close();
        }

        private void buttonCreateCompany_Click(object sender, EventArgs e)
        {
            Form CompanyName = new CreateCompany(UserID,this,_loginForm);
            CompanyName.Show();
            this.Hide();


        }
    }
}
