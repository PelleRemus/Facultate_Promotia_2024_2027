namespace Fractali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmap;
        Graphics graphics;

        private void button1_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.Black);
            PointF topLeft = new PointF(200, 5);
            PointF topRight = new PointF(1000, 5);
            PointF bottomRight = new PointF(1000, 805);
            PointF bottomLeft = new PointF(200, 805);
            SierpinskiCarpet([topLeft, topRight, bottomRight, bottomLeft]);

            pictureBox1.Image = bitmap;
        }
        public void SierpinskiCarpet(PointF[] points)
        {
            float length = Math.Abs(points[0].X - points[1].X);
            if (length < 1)
            {
                return;
            }

            graphics.DrawPolygon(Pens.White, points);

            length = length / 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && j == 1)
                    {
                        continue;
                    }
                    PointF topLeft = new PointF(length * j + points[0].X, length * i + points[0].Y);
                    PointF topRight = new PointF(length * (j + 1) + points[0].X, length * i + points[0].Y);
                    PointF bottomRight = new PointF(length * (j + 1) + points[0].X, length * (i + 1) + points[0].Y);
                    PointF bottomLeft = new PointF(length * j + points[0].X, length * (i + 1) + points[0].Y);

                    SierpinskiCarpet([topLeft, topRight, bottomRight, bottomLeft]);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.Black);
            PointF bottomLeft = new PointF(200, 750);
            PointF bottomRight = new PointF(1000, 750);
            float height = (float)(400 * Math.Sqrt(3));
            PointF top = new PointF(600, 750 - height);
            SierpinskiTriangle([bottomLeft, bottomRight, top]);

            pictureBox1.Image = bitmap;
        }
        public void SierpinskiTriangle(PointF[] points)
        {
            float length = Distance(points[0], points[1]);
            if (length < 1)
            {
                return;
            }

            graphics.DrawPolygon(Pens.White, points);

            for (int i = 0; i < 3; i++)
            {
                int prevIndex = i - 1;
                if (prevIndex < 0)
                    prevIndex = 2;
                int nextIndex = (i + 1) % 3;

                PointF prev = new PointF((points[i].X + points[prevIndex].X) / 2, (points[i].Y + points[prevIndex].Y) / 2);
                PointF next = new PointF((points[i].X + points[nextIndex].X) / 2, (points[i].Y + points[nextIndex].Y) / 2);
                SierpinskiTriangle([prev, points[i], next]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.Black);
            float length = 200;
            float angle = (float)(3 * Math.PI / 2);
            PointF start = new PointF(600, 800);
            FractalTree(length, angle, start);

            pictureBox1.Image = bitmap;
        }
        public void FractalTree(float length, float angle, PointF start)
        {
            if (length < 5)
            {
                return;
            }

            float x = start.X + (float)Math.Cos(angle) * length;
            float y = start.Y + (float)Math.Sin(angle) * length;
            PointF end = new PointF(x, y);

            graphics.DrawLine(Pens.White, start, end);

            FractalTree(3 * length / 4, angle - (float)(Math.PI / 6), end);
            FractalTree(3 * length / 4, angle + (float)(Math.PI / 6), end);
        }

        public float Distance(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
}
