using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jocul_2048
{
    public static class Engine
    {
        public static int n = 4;

        public static Graphics graphics;
        public static Bitmap bitmap;
        public static Random random = new Random();
        public static Tile[,] display;

        public static void Initialise()
        {
            Tile.Size = Form1.Instance.panel1.Width / n - Tile.Offset;
            display = new Tile[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    display[i, j] = new Tile(0, i, j);
                }
            }
        }

        public static void DisplayValues()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bitmap = new Bitmap(Tile.Size, Tile.Size);
                    graphics = Graphics.FromImage(bitmap);

                    switch (display[i, j].Value)
                    {
                        case 0:
                            graphics.Clear(Color.Brown);
                            break;
                        case 2:
                            graphics.Clear(Color.White);
                            break;
                        case 4:
                            graphics.Clear(Color.LightYellow);
                            break;
                        default:
                            graphics.Clear(Color.LightBlue);
                            break;
                    }
                    if (display[i, j].Value != 0)
                    {
                        int fontsize = Tile.Size / (display[i, j].Value.ToString().Length + 1);
                        StringFormat format = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        graphics.DrawString(display[i, j].Value.ToString(),
                            new Font("Consolas", fontsize), new SolidBrush(Color.Brown),
                            new Rectangle(0, 0, Tile.Size, Tile.Size), format);
                    }
                    display[i, j].Picturebox.Image = bitmap;
                }
            }
        }

        public static void GenerateNewTile()
        {
            int i, j;
            do
            {
                i = random.Next(n);
                j = random.Next(n);
            } while (display[i, j].Value != 0);

            double chance = random.NextDouble();
            if (chance < 0.25)
                display[i, j].Value = 4;
            else
                display[i, j].Value = 2;
        }

        public static void ResetValues()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    display[i, j].Value = 0;
                }
            }
        }
    }
}
