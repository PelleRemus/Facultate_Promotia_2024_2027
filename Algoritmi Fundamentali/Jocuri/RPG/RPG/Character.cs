using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPG
{
    public class Character
    {
        public PointF Location { get; set; }
        public int Size { get; set; }
        public Image Image { get; set; }
        public float Speed { get; set; }

        public bool MovesLeft { get; set; }
        public bool MovesRight { get; set; }
        public bool MovesUp { get; set; }
        public bool MovesDown { get; set; }

        public Character(PointF location, int size, string pathToImage, int speed)
        {
            Location = location;
            Size = size;
            Image = Image.FromFile(pathToImage);
            Speed = speed;
        }

        public void ChangeMovement(Keys keyPressed, bool value)
        {
            if (keyPressed == Keys.A || keyPressed == Keys.Left)
            {
                MovesLeft = value;
            }
            if (keyPressed == Keys.D || keyPressed == Keys.Right)
            {
                MovesRight = value;
            }
            if (keyPressed == Keys.W || keyPressed == Keys.Up)
            {
                MovesUp = value;
            }
            if (keyPressed == Keys.S || keyPressed == Keys.Down)
            {
                MovesDown = value;
            }
        }

        public void Move()
        {
            float speedX = 0, speedY = 0;

            if (MovesLeft)
                speedX -= Speed;
            if (MovesRight)
                speedX += Speed;
            if (MovesUp)
            {
                if (speedX != 0)
                {
                    speedX = speedX / (float)Math.Sqrt(2);
                    speedY -= Speed / (float)Math.Sqrt(2);
                }
                else
                    speedY -= Speed;
            }
            if (MovesDown)
            {
                if (speedX != 0)
                {
                    speedX = speedX / (float)Math.Sqrt(2);
                    speedY += Speed / (float)Math.Sqrt(2);
                }
                else
                    speedY += Speed;
            }

            float x = Location.X + speedX, y = Location.Y + speedY;

            if (x < 0)
                x = 0;
            if (x > Form1.Instance.pictureBox1.Width - Size)
                x = Form1.Instance.pictureBox1.Width - Size;
            if (y < 0)
                y = 0;
            if (y > Form1.Instance.pictureBox1.Height - Size)
                y = Form1.Instance.pictureBox1.Height - Size;

            Location = new PointF(x, y);
        }
    }
}
