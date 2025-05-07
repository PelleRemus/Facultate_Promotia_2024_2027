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
            player = new Character(new PointF(200, 200), 80, "../../Images/spongebob.png", 8);
            pineapple = new MapObject(new Point(100, 400), 200, 400, "../../Images/pineapple.png",
                "../../Images/pineapple_transparent.png", new Point(100, 700), 200, 100);
        }

        public static void Draw()
        {
            bitmap = new Bitmap(Form1.Instance.pictureBox1.Width, Form1.Instance.pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.Clear(backgroundColor);
            graphics.DrawImage(player.Image, player.Location.X, player.Location.Y,
                player.Size, player.Size);

            pineapple.Draw(graphics);

            Form1.Instance.pictureBox1.Image = bitmap;
        }

        public static bool HasCharacterBehind(MapObject mapObject)
        {
            if (new Rectangle(mapObject.Location, new Size(mapObject.Width, mapObject.Height))
                .IntersectsWith(new Rectangle(
                    new Point((int)player.Location.X, (int)player.Location.Y),
                    new Size(player.Size, player.Size))
                ))
                return true;
            return false;
        }
    }
}
