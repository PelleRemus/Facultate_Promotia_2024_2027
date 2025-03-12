using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocul_2048
{
    public class Tile
    {
        // 
        //private PictureBox picturebox;

        //public PictureBox GetPictureBox()
        //{
        //    return picturebox;
        //}

        //public void SetPictureBox(PictureBox picturebox)
        //{
        //    this.picturebox = picturebox;
        //}

        // Echivalent:
        public PictureBox Picturebox { get; set; }
        public int Value { get; set; }

        public static int Size { get; set; }
        public static int Offset { get; set; } = 10;

        public Tile(int value, int i, int j)
        {
            Value = value;
            Picturebox = new PictureBox();
            Picturebox.Parent = Form1.Instance.panel1;
            Picturebox.Size = new Size(Size, Size);
            Picturebox.BackColor = Color.Brown;

            int x = Offset / 2 + (Size + Offset) * j;
            int y = Offset / 2 + (Size + Offset) * i;
            Picturebox.Location = new Point(x, y);
        }
    }
}
