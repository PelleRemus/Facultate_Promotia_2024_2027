using System.Drawing;

namespace RPG
{
    public class Ingredient
    {
        public Point Location { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Image Image { get; set; }

        public Ingredient(Point location, int width, int height, string pathToImage)
        {
            Location = location;
            Width = width;
            Height = height;
            Image = Image.FromFile(pathToImage);
        }
    }
}
