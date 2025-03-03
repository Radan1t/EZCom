using Application.Common.DTO;
using Application.Common.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Application.Interfaces.Services;
using Infrastructure.Services;
using EZCom.Helper;

namespace EZCom.Forms
{
    public partial class Registration : Form
    {
        private readonly IRegistrationService _registrationService;
        private readonly ICodeSenderService _codeSenderService;
        public Registration(IRegistrationService registrationService, ICodeSenderService codeSenderService)
        {
            _registrationService = registrationService;
            _codeSenderService = codeSenderService;
            InitializeComponent();
            DefaultUI.GroupBoxFix(groupBox1);
            DefaultUI.GroupBoxFix(groupBox2);
            DefaultUI.GroupBoxFix(groupBox3);
            DefaultUI.GroupBoxFix(groupBox4);
            DefaultUI.GroupBoxFix(groupBox5);
            DefaultUI.GroupBoxFix(groupBox6);
            DefaultUI.GroupBoxFix(groupBox7);
            DefaultUI.SetRoundedPictureBox(groupBox2, 15);
            DefaultUI.SetRoundedPictureBox(groupBox4, 15);
            DefaultUI.SetRoundedPictureBox(groupBox6, 15);
            DefaultUI.SetRoundedPictureBox(groupBox7, 10);
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password.PasswordChar = '\0';
                Password2.PasswordChar = '\0';
            } else 
            { 
                Password.PasswordChar = '*';
                Password2.PasswordChar = '*';
            }


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Password.Text == Password2.Text)
            {
                var user = new UserDTO
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Login = Login.Text,
                    Email = Email.Text,
                    PhoneNumber = Phone.Text,
                    Password = Password.Text,
                    DateOfBirth = DateOfBirth.Value
                };

                var validator = new RegistrationValidator(_registrationService);
                var result = await validator.ValidateAsync(user);

                if (!result.IsValid)
                {
                    string errors = string.Join("\n", result.Errors.Select(err => $"{err.PropertyName}: {err.ErrorMessage}"));
                    MessageBox.Show(errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    var (success, message, verificationCode) = await _codeSenderService.SendCodeAsync(user.Email);

                    if (success)
                    {
                        var registrationCodeForm = new RegistrationCode(user, verificationCode, this, _codeSenderService, _registrationService);
                        registrationCodeForm.Show();
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show(message, "Email Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
