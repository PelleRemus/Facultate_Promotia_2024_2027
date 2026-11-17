namespace Polinoame
{
    public partial class Form1 : Form
    {
        public Graphics graphica;
        public Bitmap imagine;
        public Pen gri = new Pen(Color.Gray, 3);
        public PointF O;
        public decimal x0, y0, xn, yn;
        public float latime, inaltime;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = Width - 410;
            pictureBox1.Height = Height - 110;
            latime = pictureBox1.Width - 64;
            inaltime = pictureBox1.Height - 32;
            O = new PointF(64, inaltime);
            DeseneazaSchita();
        }

        public void DeseneazaSchita()
        {
            if (polinom != null)
            {
                decimal[] valori = polinom.F.SelectMany(v => v).ToArray();
                x0 = polinom.u.First();
                xn = polinom.u.Last();
                y0 = valori.Min();
                yn = valori.Max();
                scalareX = xn - x0;
                scalareY = yn - y0;
            }
            imagine = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphica = Graphics.FromImage(imagine);

            graphica.DrawLine(gri, 0, O.Y, pictureBox1.Width, O.Y);
            graphica.DrawLine(gri, O.X, 0, O.X, pictureBox1.Height);
            Font font = new Font("Arial", 12, FontStyle.Bold);
            SolidBrush pensula = new SolidBrush(Color.Black);

            graphica.DrawString(y0.ToString("0.00"), font, pensula, 0, inaltime - 32);
            graphica.DrawString(yn.ToString("0.00"), font, pensula, 0, 0);
            graphica.DrawString(x0.ToString("0.00"), font, pensula, O.X, O.Y);
            graphica.DrawString(xn.ToString("0.00"), font, pensula, latime, O.Y);
            pictureBox1.Image = imagine;
        }

        public Polinom polinom;
        public decimal scalareX, scalareY;
        public void DeseneazaGrafic(Pen creion, decimal[] x, decimal[] y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                PointF punct = TransformaInPunct(x[i], y[i]);
                float w = creion.Width;
                graphica.DrawEllipse(creion, punct.X - w / 2, punct.Y - w / 2, w, w);
            }
            pictureBox1.Image = imagine;
        }
        public PointF TransformaInPunct(decimal x, decimal y)
        {
            float X = O.X + (float)((x - x0) * (decimal)latime / scalareX);
            float Y = O.Y - (float)((y - y0) * (decimal)inaltime / scalareY);
            return new PointF(X, Y);
        }

        //
        // Taylor
        //
        private void TaylorSinus_Click(object sender, EventArgs e)
        {
            polinom = new PolinomulLuiTaylor(7, [0M, (decimal)Math.PI], [0M, 1, 0, -1, 0, 1, 0, -1]);
            polinom.CalcularePuncte();

            DeseneazaSchita();
            DeseneazaGrafic(new Pen(Color.Green, 3), polinom.u, polinom.F[1]);
            DeseneazaGrafic(new Pen(Color.Red, 3), polinom.u, polinom.F[3]);
            DeseneazaGrafic(new Pen(Color.Blue, 3), polinom.u, polinom.F[5]);
            DeseneazaGrafic(new Pen(Color.Black, 3), polinom.u, polinom.F[7]);
        }
        private void TaylorCosinus_Click(object sender, EventArgs e) { }
        private void TaylorELaX_Click(object sender, EventArgs e) { }

        //
        // Newton
        //
        private void NewtonRadical3_Click(object sender, EventArgs e) { }
        private void NewtonAleatoriu_Click(object sender, EventArgs e) { }

        //
        // Hermite
        //
        private void HermiteSinus_Click(object sender, EventArgs e) { }
        private void HermiteRadical_Click(object sender, EventArgs e) { }

        //
        // Bernstein
        //
        private void BernsteinELaX_Click(object sender, EventArgs e) { }
        private void BernsteinRadical_Click(object sender, EventArgs e) { }

        //
        // Regresie
        //
        private void RegresieDreapta_Click(object sender, EventArgs e) { }
        private void RegresieParabola_Click(object sender, EventArgs e) { }

        //
        // Spline
        //
        private void SplinePoligonal_Click(object sender, EventArgs e) { }
        private void SplinePatratic_Click(object sender, EventArgs e) { }
        private void SplineCubic_Click(object sender, EventArgs e) { }
        private void SplineAkima_Click(object sender, EventArgs e) { }
        private void SplinePatraticCubic_Click(object sender, EventArgs e) { }
        private void SplineCubicAkima_Click(object sender, EventArgs e) { }
        private void SplineToate_Click(object sender, EventArgs e) { }
    }
}
