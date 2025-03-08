using Application.Interfaces.Services;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редагування профілю");
        }

        private void buttonCreateCompany_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Створення компанії");
            
           
        }
    }
}
