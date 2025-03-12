using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jocul_2048
{
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; set; }

        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.Initialise();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Engine.ResetValues();
            Engine.GenerateNewTile();
            Engine.GenerateNewTile();
            Engine.DisplayValues();
        }
    }
}
