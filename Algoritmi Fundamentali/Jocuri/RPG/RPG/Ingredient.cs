using System.Drawing;
using System.Reflection;

namespace RPG
{
    public class Ingredient
    {
        public Point Location { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }

        public Ingredient(Point location, int width, int height, string name)
        {
            Location = location;
            Width = width;
            Height = height;
            Name = name;
            Image = Image.FromFile($"../../Images/{name}.png");
        }
    }
}
