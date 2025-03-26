using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class MapObject
    {
        public Point Location { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Image Image { get; set; }

        public Point BlockLocation { get; set; }
        public int BlockWidth { get; set; }
        public int BlockHeight { get; set; }

        public MapObject(Point location, int width, int height, string pathToImage,
            Point blockLocation, int blockWidth, int blockHeight)
        {
            Location = location;
            Width = width;
            Height = height;
            Image = Image.FromFile(pathToImage);

            BlockLocation = blockLocation;
            BlockWidth = blockWidth;
            BlockHeight = blockHeight;
        }
    }
}
