using System.Drawing;

namespace RPG
{
    public class MapObject
    {
        public Point Location { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Image Image { get; set; }
        public Image TransparentImage { get; set; }

        public MapObject(Point location, int width, int height, string pathToImage, string pathToTransparentImage)
        {
            Location = location;
            Width = width;
            Height = height;
            Image = Image.FromFile(pathToImage);
            TransparentImage = Image.FromFile(pathToTransparentImage);
        }

        public void Draw(Graphics graphics)
        {
            if (HasCharacterBehind())
                graphics.DrawImage(TransparentImage, Location.X, Location.Y, Width, Height);
            else
                graphics.DrawImage(Image, Location.X, Location.Y, Width, Height);
        }

        public bool HasCharacterBehind()
        {
            if (new RectangleF(Location, new Size(Width, Height)).IntersectsWith(
                    new RectangleF(Engine.player.Location, new SizeF(Engine.player.Size, Engine.player.Size))
                ))
                return true;
            return false;
        }
    }
}
