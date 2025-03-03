using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EZCom.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace EZCom
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DefaultUI.SetRoundedPictureBox(groupBox1, 15); // Викликаємо функцію заокруглення
            groupBox1.Paint += (sender, e) => {
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
    }
}
