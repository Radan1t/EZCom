﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.DTO;
using Application.Common.Validators;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using Application.Interfaces.Services;
using Infrastructure.Services;
using EZCom.Helper;
using Google.Apis.Auth;
using EZCom.UI;

namespace EZCom.Forms
{
    public partial class Registration : Form
    {
        private readonly IRegistrationService _registrationService;
        private readonly ICodeSenderService _codeSenderService;
        private readonly string _idToken;
        private readonly Login _loginForm;

        public Registration(Login login, string idToken)
        {
            _registrationService = Program.ServiceProvider.GetRequiredService<IRegistrationService>();
            _codeSenderService = Program.ServiceProvider.GetRequiredService<ICodeSenderService>();
            _idToken = idToken;
            _loginForm = login;
            InitializeComponent();
            DecodeTokenAsync(idToken);
            DefaultUI.GroupBoxFix(groupBox1);
            DefaultUI.GroupBoxFix(groupBox2);
            DefaultUI.GroupBoxFix(groupBox3);
            DefaultUI.GroupBoxFix(groupBox4);
            DefaultUI.GroupBoxFix(groupBox5);
            DefaultUI.GroupBoxFix(groupBox6);
            DefaultUI.GroupBoxFix(groupBox7);
            DefaultUI.GroupBoxFix(groupBox8);
            DefaultUI.SetRoundedPictureBox(groupBox2, 15);
            DefaultUI.SetRoundedPictureBox(groupBox4, 15);
            DefaultUI.SetRoundedPictureBox(groupBox6, 15);
            DefaultUI.SetRoundedPictureBox(groupBox7, 10);
            DefaultUI.SetRoundedPictureBox(groupBox8, 10);
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
            }
            else
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
                    First_name = FirstName.Text,
                    Last_name = LastName.Text,
                    Login = Login.Text,
                    E_mail = Email.Text,
                    Phone_number = Phone.Text,
                    Password = Password.Text,
                    Date_of_birthday = DateOfBirth.Value
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
                    var (success, message, verificationCode) = await _codeSenderService.SendCodeAsync(user.E_mail);

                    if (success)
                    {
                        var registrationCodeForm = new RegistrationCode(user, verificationCode, this,_loginForm);
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
        public async Task DecodeTokenAsync(string idToken)
        {
            try
            {
                var payload = await GoogleJsonWebSignature.ValidateAsync(idToken);

                Email.Text = payload.Email;
                Email.Enabled = false;
                FirstName.Text = payload.GivenName;
                LastName.Text = payload.FamilyName;
                FirstName.Enabled = false;
                LastName.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Token validation failed: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Close();
        }
    }
}
