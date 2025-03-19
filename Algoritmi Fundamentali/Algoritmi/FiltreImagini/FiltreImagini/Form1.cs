using System;
using System.Drawing;
using System.Windows.Forms;

namespace FiltreImagini
{
    public partial class Form1 : Form
    {
        Bitmap image = (Bitmap)Image.FromFile("../../Imagini/Background.jpeg");
        Bitmap filteredImage;

        public Form1()
        {
            InitializeComponent();
            filteredImage = new Bitmap(image.Width, image.Height);
            pictureBox1.Image = image;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image;
        }

        private void buttonGrayScale_Click(object sender, EventArgs e)
        {

        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {

        }

        private void buttonComplementary_Click(object sender, EventArgs e)
        {

        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {

        }
    }
}
