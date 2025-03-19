using System;
using System.Drawing;
using System.Net.Configuration;
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
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    int media = (pixel.R + pixel.G + pixel.B) / 3;
                    filteredImage.SetPixel(i, j, Color.FromArgb(media, media, media));
                }
            }
            pictureBox1.Image = filteredImage;
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    int media = (pixel.R + pixel.G + pixel.B) / 3;
                    // valoarea maima a culorilor este 255, deci daca media culorii
                    // este mai mica decat 128, atunci culoarea este "inchisa"
                    if (media < 128)
                    {
                        // culorile nu pot avea valori negative (sau peste 255)
                        filteredImage.SetPixel(i, j, Color.FromArgb(
                            Math.Max(pixel.R - 40, 0),
                            Math.Max(pixel.G - 40, 0),
                            Math.Max(pixel.B - 40, 0)));
                    }
                    else
                    {
                        filteredImage.SetPixel(i, j, Color.FromArgb(
                            Math.Min(pixel.R + 40, 255),
                            Math.Min(pixel.G + 40, 255),
                            Math.Min(pixel.B + 40, 255)));
                    }
                }
            }
            pictureBox1.Image = filteredImage;
        }

        private void buttonComplementary_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    filteredImage.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }
            pictureBox1.Image = filteredImage;
        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                {
                    int red = 0, green = 0, blue = 0, count = 0;
                    for (int k = i - 2; k <= i + 2; k++)
                        for (int l = j - 2; l <= j + 2; l++)
                        {
                            if (k >= 0 && k < image.Width && l >= 0 && l < image.Height)
                            {
                                Color pixel = image.GetPixel(k, l);
                                count++;
                                red += pixel.R;
                                green += pixel.G;
                                blue += pixel.B;
                            }
                        }
                    filteredImage.SetPixel(i, j, Color.FromArgb(red / count, green / count, blue / count));
                }
            pictureBox1.Image = filteredImage;
        }
    }
}
