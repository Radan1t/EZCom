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
using Newtonsoft.Json;

namespace EZCom
{
    public partial class Login : Form
    {
        private readonly ILoginService _loginService;
        private readonly IGoogleAuthService _googleAuthService;

        private static string[] Scopes = { "openid", "email", "profile" };
        private static string ApplicationName = "EZCom";

        public Login()
        {
            InitializeComponent();

            _loginService = Program.ServiceProvider.GetRequiredService<ILoginService>();
            _googleAuthService = Program.ServiceProvider.GetRequiredService<IGoogleAuthService>();

            DefaultUI.SetRoundedPictureBox(groupBox1, 15);

            groupBox1.Paint += (sender, e) =>
            {
                e.Graphics.Clear(groupBox1.BackColor);
                TextRenderer.DrawText(e.Graphics, groupBox1.Text, groupBox1.Font, new Point(10, 1), groupBox1.ForeColor);
            };

            checkBox1.CheckedChanged += (sender, e) =>
            {
                textBox2.UseSystemPasswordChar = checkBox1.Checked;
            };
        }

        private void EZCom_Click(object sender, EventArgs e)
        {
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            try
            {
                string login = textBox1.Text;
                string password = textBox2.Text;

                UserDTO user = await _loginService.LoginAsync(login, password);

                if (user != null)
                {
                    MessageBox.Show($"Welcome, {user.First_name} {user.Last_name}!");

                    Form mainForm = user.CompanyID == 0
                        ? new MainNoComp(user, this)
                        : new MainForm(user, this);

                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                await Task.Delay(10000); // Затримка 10 секунд
                button1.Enabled = true;
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string idToken = null;
            Registration registrationForm = new Registration(this, idToken);
            registrationForm.Show();
            this.Hide();
        }

        private async void btnGoogleLogin_Click(object sender, EventArgs e)
        {
            btnGoogleLogin.Enabled = false;

            try
            {
                UserCredential credential = await _googleAuthService.GetGoogleUserCredentialAsync();
                string idToken = await _googleAuthService.GetNewIdTokenAsync(credential);

                if (string.IsNullOrEmpty(idToken))
                {
                    MessageBox.Show("Не вдалося авторизуватися через Google. ID токен не отримано.");
                    return;
                }

                UserDTO user = await _loginService.CheckUserExistsAsync(idToken);

                if (user != null)
                {
                    user.Credential = JsonConvert.SerializeObject(credential.Token);

                    Form mainForm = user.CompanyID == null
                        ? new MainNoComp(user, this)
                        : new MainForm(user, this);

                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    Registration registrationForm = new Registration(this, idToken);
                    registrationForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Google Login Error: " + ex.Message);
            }
            finally
            {
                await Task.Delay(10000); // Затримка 10 секунд
                btnGoogleLogin.Enabled = true;
            }
        }
    }
}
