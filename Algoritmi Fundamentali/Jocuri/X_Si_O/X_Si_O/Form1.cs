using System;
using System.Drawing;
using System.Windows.Forms;

namespace X_Si_O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isPlayerO = false;
        int n = 3, size;
        Button[,] buttons;

        private void Form1_Load(object sender, EventArgs e)
        {
            size = panel1.Width / n;
            buttons = new Button[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Button button = new Button();
                    button.Parent = panel1;
                    button.Size = new Size(size, size);
                    button.BackColor = Color.ForestGreen;
                    button.Location = new Point(size * j, size * i);
                    button.Font = new Font("Arial", size / 2);
                    button.Click += Button_Click;

                    buttons[i, j] = button;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (isPlayerO)
            {
                button.Text = "O";
            }
            else
            {
                button.Text = "X";
            }
            // button.Text = isPlayerO ? "O" : "X";

            button.Enabled = false;

            if (CheckIfPlayerWon())
            {
                string player = isPlayerO ? "O" : "X";
                MessageBox.Show($"Player {player} has won", "Game Over", MessageBoxButtons.OK);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        buttons[i, j].Enabled = false;
                    }
                }
            }

            isPlayerO = !isPlayerO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isPlayerO = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    buttons[i, j].Enabled = true;
                    buttons[i, j].Text = "";
                }
            }
        }

        bool CheckIfPlayerWon()
        {
            int sumLine, sumColumn, sumDiagonal = 0, sumDiagonal2 = 0;
            for (int i = 0; i < n; i++)
            {
                sumLine = 0;
                sumColumn = 0;
                sumDiagonal += GetButtonValue(buttons[i, i]);
                sumDiagonal2 += GetButtonValue(buttons[i, n - i - 1]);

                for (int j = 0; j < n; j++)
                {
                    sumLine += GetButtonValue(buttons[i, j]);
                    sumColumn += GetButtonValue(buttons[j, i]);
                }

                if (sumLine % 10 == 3 || sumLine / 10 == 3 || sumColumn % 10 == 3 || sumColumn / 10 == 3)
                {
                    return true;
                }
            }

            if (sumDiagonal % 10 == 3 || sumDiagonal / 10 == 3 || sumDiagonal2 % 10 == 3 || sumDiagonal2 / 10 == 3)
            {
                return true;
            }
            return false;
        }

        int GetButtonValue(Button button)
        {
            string text = button.Text;
            if (text == "O")
                return 1;
            if (text == "X")
                return 10;
            return 0;
        }
    }
}
