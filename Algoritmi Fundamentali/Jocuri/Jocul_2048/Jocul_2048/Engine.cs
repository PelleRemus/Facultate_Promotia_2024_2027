using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Jocul_2048
{
    public static class Engine
    {
        public static int n = 4;

        public static Graphics graphics;
        public static Bitmap bitmap;
        public static Random random = new Random();
        public static Tile[][] display;

        public static void Initialise()
        {
            Tile.Size = Form1.Instance.panel1.Width / n - Tile.Offset;
            display = new Tile[n][];

            for (int i = 0; i < n; i++)
            {
                display[i] = new Tile[n];
                for (int j = 0; j < n; j++)
                {
                    display[i][j] = new Tile(0, i, j);
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

                    switch (display[i][j].Value)
                    {
                        case 0: graphics.Clear(Color.FromArgb(195, 188, 176)); break;
                        case 2: graphics.Clear(Color.FromArgb(237, 228, 219)); break;  // Culoarea lui 2
                        case 4: graphics.Clear(Color.FromArgb(237, 224, 201)); break;  // Culoarea lui 4
                        case 8: graphics.Clear(Color.FromArgb(244, 177, 122)); break;
                        case 16: graphics.Clear(Color.FromArgb(247, 150, 99)); break;
                        case 32: graphics.Clear(Color.FromArgb(246, 125, 98)); break;
                        case 64: graphics.Clear(Color.FromArgb(246, 94, 57)); break;
                        case 128: graphics.Clear(Color.FromArgb(237, 206, 115)); break;
                        case 256: graphics.Clear(Color.FromArgb(237, 202, 100)); break;
                        case 512: graphics.Clear(Color.FromArgb(237, 198, 81)); break;
                        case 1024: graphics.Clear(Color.FromArgb(238, 199, 68)); break;
                        case 2048: graphics.Clear(Color.FromArgb(236, 194, 48)); break;   // Culoarea lui 2048
                        default: graphics.Clear(Color.FromArgb(255, 32, 33)); break;    // Culoarea valorilor peste 2048
                    }
                    if (display[i][j].Value != 0)
                    {
                        int fontsize = Tile.Size / (display[i][j].Value.ToString().Length + 1);
                        StringFormat format = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };
                        graphics.DrawString(display[i][j].Value.ToString(),
                            new Font("Consolas", fontsize), new SolidBrush(Color.FromArgb(120, 110, 100)),
                            new Rectangle(0, 0, Tile.Size, Tile.Size), format);
                    }
                    display[i][j].Picturebox.Image = bitmap;
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
            } while (display[i][j].Value != 0);

            double chance = random.NextDouble();
            if (chance < 0.25)
                display[i][j].Value = 4;
            else
                display[i][j].Value = 2;
        }

        public static void ResetValues()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    display[i][j].Value = 0;
                }
            }
        }

        public static bool CheckIfYouLose()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (display[i][j].Value == 0)
                    {
                        return false;
                    }
                    if (j < n - 1 && display[i][j].Value == display[i][j + 1].Value)
                    {
                        return false;
                    }
                    if (i < n - 1 && display[i][j].Value == display[i + 1][j].Value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void Move(Keys keyPressed)
        {
            bool hasChanged = false;

            switch (keyPressed)
            {
                case Keys.Left:
                case Keys.A:
                    for (int i = 0; i < n; i++)
                    {
                        hasChanged = MoveOneRow(display[i]) || hasChanged;
                    }
                    break;
                case Keys.Right:
                case Keys.D:
                    for (int i = 0; i < n; i++)
                    {
                        hasChanged = MoveOneRow(display[i].Reverse().ToArray()) || hasChanged;
                    }
                    break;
                case Keys.Up:
                case Keys.W:
                    for (int i = 0; i < n; i++)
                    {
                        Tile[] tiles = new Tile[n];
                        for (int j = 0; j < n; j++)
                            tiles[j] = display[j][i];
                        hasChanged = MoveOneRow(tiles) || hasChanged;
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                    for (int i = 0; i < n; i++)
                    {
                        Tile[] tiles = new Tile[n];
                        for (int j = 0; j < n; j++)
                            tiles[j] = display[n - j - 1][i];
                        hasChanged = MoveOneRow(tiles) || hasChanged;
                    }
                    break;
            }

            if (hasChanged)
            {
                GenerateNewTile();
                DisplayValues();
            }

            if (CheckIfYouLose())
            {
                var response = MessageBox.Show("You lost! Would you like to play again?",
                    "Game Over!", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    ResetValues();
                    GenerateNewTile();
                    GenerateNewTile();
                    DisplayValues();
                }
                else
                {
                    Form1.Instance.Close();
                }
            }
        }

        public static bool MoveOneRow(Tile[] tiles)
        {
            bool hasChanged = false;
            int[] values = Combine(tiles);
            for (int j = 0; j < n; j++)
            {
                if (tiles[j].Value != values[j])
                {
                    tiles[j].Value = values[j];
                    hasChanged = true;
                }
            }
            return hasChanged;
        }

        public static int[] Combine(Tile[] tiles)
        {
            List<int> withoutZeros = tiles
                .Where(tile => tile.Value != 0) // filtram afara tile-urile care sunt 0
                .Select(tile => tile.Value)     // convertire de la Tile la int
                .ToList();

            for (int i = 0; i < withoutZeros.Count - 1; i++)
            {
                if (withoutZeros[i] == withoutZeros[i + 1])
                {
                    withoutZeros[i] += withoutZeros[i + 1];
                    withoutZeros.RemoveAt(i + 1);
                }
            }

            for (int i = withoutZeros.Count(); i < n; i++)
            {
                withoutZeros.Add(0);
            }
            return withoutZeros.ToArray();
        }
    }
}
