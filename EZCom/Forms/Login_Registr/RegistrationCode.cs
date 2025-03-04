using Application.Common.DTO;
using Application.Interfaces.Services;
using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using EZCom.Helper;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZCom.Forms
{
    public partial class RegistrationCode : Form
    {
        private readonly UserDTO _userData;
        private  string _verificationCode;
        private readonly Registration _registrationForm;
        private readonly ICodeSenderService _codeSenderService;
        private DateTime _lastCodeSentTime;
        private readonly Login _loginForm;
        private readonly IRegistrationService _registrationService;
        public RegistrationCode(UserDTO userData, string verificationCode, Registration registrationForm,
                        ICodeSenderService codeSenderService, IRegistrationService registrationService, Login login)
        {

            _userData = userData;
            _verificationCode = verificationCode;
            _registrationForm = registrationForm;
            _registrationService = registrationService;
            _codeSenderService = codeSenderService;
            _loginForm=login;
            InitializeComponent();
            DefaultUI.GroupBoxFix(groupBox1);
            DefaultUI.GroupBoxFix(groupBox2);
            DefaultUI.SetRoundedPictureBox(groupBox2, 15);
            label3.Text = $"Email: {_userData.Email}";
            _lastCodeSentTime = DateTime.MinValue; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _registrationForm.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == _verificationCode)
            {
                try
                {
                    var success = await _registrationService.RegisterUserAsync(_userData);

                    if (success)
                    {
                        MessageBox.Show("Registration Successful! User has been saved in the database.",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        _registrationForm.Close();
                        _loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid code. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void button3_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи пройшло 60 секунд з моменту останньої відправки
            if ((DateTime.Now - _lastCodeSentTime).TotalSeconds < 60)
            {
                MessageBox.Show("Please wait before requesting a new code.", "Too Many Requests", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            button3.Enabled = false; // Вимикаємо кнопку, щоб уникнути повторного натискання

            // Викликаємо SendCodeAsync і отримуємо результат у змінну
            var result = await _codeSenderService.SendCodeAsync(_userData.Email);

            // Тепер звертаємося до елементів кортежу через result
            if (result.success)
            {
                _verificationCode = result.code; // Оновлюємо код
                _lastCodeSentTime = DateTime.Now; // Оновлюємо час останньої відправки
                MessageBox.Show("A new verification code has been sent to your email.", "Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Failed to send verification code: {result.message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Запускаємо таймер на 60 секунд перед повторним увімкненням кнопки
            await Task.Delay(60000);
            button3.Enabled = true;
        }

    }
}
