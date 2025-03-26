using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Engine.player.Move(e.KeyCode);
            Engine.Draw();
        }
    }
}
