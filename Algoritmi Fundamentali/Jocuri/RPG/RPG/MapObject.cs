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

        public Point BlockLocation { get; set; }
        public int BlockWidth { get; set; }
        public int BlockHeight { get; set; }

        public MapObject(Point location, int width, int height, string pathToImage,
            string pathToTransparentImage, Point blockLocation, int blockWidth, int blockHeight)
        {
            Location = location;
            Width = width;
            Height = height;
            Image = Image.FromFile(pathToImage);
            TransparentImage = Image.FromFile(pathToTransparentImage);

            BlockLocation = blockLocation;
            BlockWidth = blockWidth;
            BlockHeight = blockHeight;
        }

        public void Draw(Graphics graphics)
        {
            if (Engine.HasCharacterBehind(this))
                graphics.DrawImage(TransparentImage, Location.X, Location.Y, Width, Height);
            else
                graphics.DrawImage(Image, Location.X, Location.Y, Width, Height);

            graphics.FillRectangle(new SolidBrush(Color.Red), BlockLocation.X,
                BlockLocation.Y, BlockWidth, BlockHeight);
        }
    }
}
