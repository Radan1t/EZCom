using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZCom.Helper
{
    public class DefaultUI
    {
        public static void SetRoundedPictureBox(GroupBox pb, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, d, d), 180, 90); // Верхній лівий кут
            path.AddArc(new Rectangle(pb.Width - d, 0, d, d), 270, 90); // Верхній правий кут
            path.AddArc(new Rectangle(pb.Width - d, pb.Height - d, d, d), 0, 90); // Нижній правий кут
            path.AddArc(new Rectangle(0, pb.Height - d, d, d), 90, 90); // Нижній лівий кут
            path.CloseFigure();
            pb.Region = new Region(path);
        }
        public static void SetRoundedButton(Button pb, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, d, d), 180, 90); // Верхній лівий кут
            path.AddArc(new Rectangle(pb.Width - d, 0, d, d), 270, 90); // Верхній правий кут
            path.AddArc(new Rectangle(pb.Width - d, pb.Height - d, d, d), 0, 90); // Нижній правий кут
            path.AddArc(new Rectangle(0, pb.Height - d, d, d), 90, 90); // Нижній лівий кут
            path.CloseFigure();
            pb.Region = new Region(path);
        }

        public static void GroupBoxFix(GroupBox groupBox)
        {
            groupBox.Paint += (sender, e) =>
            {
                e.Graphics.Clear(groupBox.BackColor);
                // Малюємо лише текст без малювання заголовка
                TextRenderer.DrawText(e.Graphics, groupBox.Text, groupBox.Font, new Point(10, 1), groupBox.ForeColor);
            };
        }

    }
}
