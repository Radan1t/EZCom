using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Application.Common.DTO;
using Application.Interfaces.Services;
using EZCom.Forms;
using EZCom.Helper;
using Infrastructure.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace EZCom
{
    public partial class Login : Form
    {
        private readonly ILoginService _loginService;
        private readonly IRegistrationService _registrationService;
        private readonly ICodeSenderService _codeSenderService;
        public Login(ILoginService loginService, IRegistrationService registrationService, ICodeSenderService codeSenderService)
        {
            _registrationService = registrationService;
            _codeSenderService = codeSenderService;
            InitializeComponent();
            _loginService = loginService;
            DefaultUI.SetRoundedPictureBox(groupBox1, 15); // Викликаємо функцію заокруглення
            groupBox1.Paint += (sender, e) =>
            {
                e.Graphics.Clear(groupBox1.BackColor);
                TextRenderer.DrawText(e.Graphics, groupBox1.Text, groupBox1.Font, new Point(10, 1), groupBox1.ForeColor);
            };

            checkBox1.CheckedChanged += (sender, e) =>
            {
                if (checkBox1.Checked)
                {
                    textBox2.UseSystemPasswordChar = true; // Показати пароль
                }
                else
                {
                    textBox2.UseSystemPasswordChar = false; // Приховати пароль
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
                // Логіка успішного входу
                MessageBox.Show($"Welcome, {user.FirstName} {user.LastName}!");
            }
            else
            {
                // Повідомлення про невдалий вхід
                MessageBox.Show("Invalid login or password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pass the services to the Registration form
            Registration registrationForm = new Registration(_registrationService, _codeSenderService, this);
            registrationForm.Show();
            this.Hide();
        }
    }
}
