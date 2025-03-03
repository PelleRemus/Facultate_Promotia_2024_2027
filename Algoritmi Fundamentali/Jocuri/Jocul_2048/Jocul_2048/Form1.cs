using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocul_2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 4, offset = 10;
        int size;
        Random random = new Random();
        PictureBox[,] display;
        int[,] values;

        private void Form1_Load(object sender, EventArgs e)
        {
            size = panel1.Width / n - offset;
            display = new PictureBox[n, n];
            values = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    PictureBox current = new PictureBox();
                    current.Parent = panel1;
                    current.Size = new Size(size, size);
                    current.BackColor = Color.Brown;
                    int x = offset / 2 + (size + offset) * j;
                    int y = offset / 2 + (size + offset) * i;
                    current.Location = new Point(x, y);

                    display[i, j] = current;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetValues();
            GenerateNewTile();
            GenerateNewTile();
            DisplayValues();
        }

        void DisplayValues()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    switch (values[i, j])
                    {
                        case 0:
                            display[i, j].BackColor = Color.Brown;
                            break;
                        case 2:
                            display[i, j].BackColor = Color.White;
                            break;
                        case 4:
                            display[i, j].BackColor = Color.LightYellow;
                            break;
                    }
                }
            }
        }

        void GenerateNewTile()
        {
            int i = 0, j = 0;
            do
            {
                i = random.Next(n);
                j = random.Next(n);
            } while (values[i, j] != 0);

            double chance = random.NextDouble();
            if (chance < 0.25)
                values[i, j] = 4;
            else
                values[i, j] = 2;
        }

        void ResetValues()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    values[i, j] = 0;
                }
            }
        }
    }
}
