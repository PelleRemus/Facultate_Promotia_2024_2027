using System;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;

        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.Initialize();
            Engine.Draw();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Engine.player.ChangeMovement(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Engine.player.ChangeMovement(e.KeyCode, false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Engine.player.Move();
            Engine.Draw();
        }
    }
}
