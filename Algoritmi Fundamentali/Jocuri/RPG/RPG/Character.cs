using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        public Stack<Ingredient> Burger { get; set; }

        public Character(PointF location, int size, string pathToImage, int speed)
        {
            Location = location;
            Size = size;
            Image = Image.FromFile(pathToImage);
            Speed = speed;
            Burger = new Stack<Ingredient>();
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
            if ((keyPressed == Keys.Space || keyPressed == Keys.Enter) && !value)
            {
                if (Burger.Any())
                {
                    Burger.Pop();
                    Engine.ServeBurger();
                    DrawBurger();
                }
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
            CheckCollisions();
        }

        public void CheckCollisions()
        {
            foreach (var ingredient in new List<Ingredient>(Engine.ingredients))
            {
                if (new RectangleF(Location, new SizeF(Size, Size)).IntersectsWith(
                        new RectangleF(ingredient.Location, new Size(ingredient.Width, ingredient.Height))
                    ))
                {
                    Burger.Push(ingredient);
                    Engine.ingredients.Remove(ingredient);
                    Engine.ServeBurger();
                    DrawBurger();
                }
            }
        }

        public void DrawBurger()
        {
            var bitmap = new Bitmap(Form1.Instance.pictureBox2.Width, Form1.Instance.pictureBox2.Height);
            var graphics = Graphics.FromImage(bitmap);

            var burger = Burger.Reverse().ToArray();
            for (int i = 0; i < burger.Length; i++)
            {
                graphics.DrawImage(burger[i].Image, 0, (10 - i - 1) * 50, 200, 50);
            }

            Form1.Instance.pictureBox2.Image = bitmap;
        }
    }
}
