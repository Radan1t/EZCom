using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Application.Common.DTO;
using Application.Interfaces.Services;
using EZCom.Forms;
using EZCom.Forms.Main;
using EZCom.Helper;
using Infrastructure.Services;
using Infrastructure.Persistence.Data;
using EZCom.UI;
using Microsoft.Extensions.DependencyInjection;

namespace EZCom
{
    public partial class Login : Form
    {
        private readonly ILoginService _loginService;

        private static string[] Scopes = { "email", "profile" };
        private static string ApplicationName = "AuthTSPP";

        public Login()
        {

            InitializeComponent();
            _loginService = Program.ServiceProvider.GetRequiredService<ILoginService>();
            DefaultUI.SetRoundedPictureBox(groupBox1, 15);
            groupBox1.Paint += (sender, e) =>
            {
                e.Graphics.Clear(groupBox1.BackColor);
                TextRenderer.DrawText(e.Graphics, groupBox1.Text, groupBox1.Font, new Point(10, 1), groupBox1.ForeColor);
            };

            checkBox1.CheckedChanged += (sender, e) =>
            {
                if (checkBox1.Checked)
                {
                    textBox2.UseSystemPasswordChar = true;
                }
                else
                {
                    textBox2.UseSystemPasswordChar = false;
                }
            };
        }

        private void EZCom_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            UserDTO user = await _loginService.LoginAsync(login, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.First_name} {user.Last_name}!");
                if (user.CompanyID == 0)
                {
                    MainNoComp mainForm = new MainNoComp(user.Id,this);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MainForm main= new MainForm(user.Id, this);
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid login or password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idToken = null;
            Registration registrationForm = new Registration(this, idToken);
            registrationForm.Show();
            this.Hide();
        }

        private async void btnGoogleLogin_Click(object sender, EventArgs e)
        {
            UserCredential credential = await _loginService.GetGoogleUserCredentialAsync();
            string idToken = await _loginService.GetNewIdTokenAsync(credential);

            UserDTO user = await _loginService.CheckUserExistsAsync(idToken);

            if (user != null)
            {
                if (user.CompanyID == null)
                {
                    MainNoComp mainForm = new MainNoComp(user.Id,this);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MainForm main = new MainForm(user.Id, this);
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                Registration registrationForm = new Registration(this, idToken);
                registrationForm.Show();
            }

            this.Hide();
        }



    }
}
