using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public class Character
    {
        public Point Location { get; set; }
        public int Size { get; set; }
        public Image Image { get; set; }
        public int Speed { get; set; }

        public Character(Point location, int size, string pathToImage, int speed)
        {
            Location = location;
            Size = size;
            Image = Image.FromFile(pathToImage);
            Speed = speed;
        }

        public void Move(Keys keyPressed)
        {
            if (keyPressed == Keys.A || keyPressed == Keys.Left)
            {
                if (Location.X < Speed)
                    Location = new Point(0, Location.Y);
                else
                    Location = new Point(Location.X - Speed, Location.Y);
            }
            if (keyPressed == Keys.D || keyPressed == Keys.Right)
            {
                if (Location.X > Form1.Instance.pictureBox1.Width - Size - Speed)
                    Location = new Point(Form1.Instance.pictureBox1.Width - Size, Location.Y);
                else
                    Location = new Point(Location.X + Speed, Location.Y);
            }
            if (keyPressed == Keys.W || keyPressed == Keys.Up)
            {
                if (Location.Y < Speed)
                    Location = new Point(Location.X, 0);
                else
                    Location = new Point(Location.X, Location.Y - Speed);
            }
            if (keyPressed == Keys.S || keyPressed == Keys.Down)
            {
                if (Location.Y > Form1.Instance.pictureBox1.Height - Size - Speed)
                    Location = new Point(Location.X, Form1.Instance.pictureBox1.Height - Size);
                else
                    Location = new Point(Location.X, Location.Y + Speed);
            }
        }
    }
}
