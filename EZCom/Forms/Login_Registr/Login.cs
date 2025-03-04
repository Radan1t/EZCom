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

namespace EZCom
{
    public partial class Login : Form
    {
        private readonly ILoginService _loginService;
        private readonly IRegistrationService _registrationService;
        private readonly ICodeSenderService _codeSenderService;
        private static string[] Scopes = { "email", "profile" };
        private static string ApplicationName = "AuthTSPP";
        private readonly ApplicationDbContextFactory _dbContextFactory;

        public Login(ILoginService loginService, IRegistrationService registrationService, ICodeSenderService codeSenderService)
        {
            _registrationService = registrationService;
            _codeSenderService = codeSenderService;
            _dbContextFactory = new ApplicationDbContextFactory();
            InitializeComponent();
            _loginService = loginService;
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
            this.FormClosed += Login_FormClosed;
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
                MessageBox.Show($"Welcome, {user.FirstName} {user.LastName}!");
                Main mainForm = new Main();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login or password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idToken = null;
            Registration registrationForm = new Registration(_registrationService, _codeSenderService, this, idToken);
            registrationForm.Show();
            this.Hide();
        }

        private async void btnGoogleLogin_Click(object sender, EventArgs e)
        {
            UserCredential credential = await _dbContextFactory.GetGoogleUserCredentialAsync();
            string idToken = await _dbContextFactory.GetNewIdTokenAsync(credential);

            UserDTO user = await _loginService.CheckUserExistsAsync(idToken);

            if (user != null)
            {
                Main mainForm = new Main();
                mainForm.Show();
            }
            else
            {
                Registration registrationForm = new Registration(_registrationService, _codeSenderService,this, idToken);
                registrationForm.Show();
            }

            this.Hide();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dbContextFactory.DeleteToken(); // Викликає метод видалення токену
        }


    }
}
