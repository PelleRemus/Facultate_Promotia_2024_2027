using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public static class Engine
    {
        public static Bitmap bitmap;
        public static Graphics graphics;
        public static Character player;
        public static MapObject pineapple;

        public static Color backgroundColor = Color.CornflowerBlue;

        public static void Initialize()
        {
            player = new Character(new Point(200, 200), 80, "../../Images/spongebob.png", 15);
            pineapple = new MapObject(new Point(100, 400), 200, 400,
                "../../Images/pineapple.png", new Point(100, 700), 200, 100);
        }

        public static void Draw()
        {
            bitmap = new Bitmap(Form1.Instance.pictureBox1.Width, Form1.Instance.pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.Clear(backgroundColor);
            graphics.DrawImage(player.Image, player.Location.X, player.Location.Y,
                player.Size, player.Size);

            graphics.DrawImage(pineapple.Image, pineapple.Location.X, pineapple.Location.Y,
                pineapple.Width, pineapple.Height);
            graphics.FillRectangle(new SolidBrush(Color.Red), pineapple.BlockLocation.X,
                pineapple.BlockLocation.Y, pineapple.BlockWidth, pineapple.BlockHeight);

            Form1.Instance.pictureBox1.Image = bitmap;
        }
    }
}
