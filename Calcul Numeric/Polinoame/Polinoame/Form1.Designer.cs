namespace Polinoame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TaylorSinus = new Button();
            TaylorCosinus = new Button();
            TaylorELaX = new Button();
            label2 = new Label();
            NewtonRadical3 = new Button();
            NewtonAleatoriu = new Button();
            label3 = new Label();
            HermiteSinus = new Button();
            HermiteRadical = new Button();
            label4 = new Label();
            BernsteinRadical = new Button();
            BernsteinELaX = new Button();
            label5 = new Label();
            RegresieDreapta = new Button();
            RegresieParabola = new Button();
            label6 = new Label();
            SplinePoligonal = new Button();
            SplinePatratic = new Button();
            SplineCubic = new Button();
            SplineAkima = new Button();
            SplinePatraticCubic = new Button();
            SplineCubicAkima = new Button();
            SplineToate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(8, 14);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1267, 761);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1282, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 2;
            label1.Text = "Polinomul lui Taylor:";
            // 
            // TaylorSinus
            // 
            TaylorSinus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TaylorSinus.BackColor = Color.RoyalBlue;
            TaylorSinus.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            TaylorSinus.ForeColor = Color.White;
            TaylorSinus.Location = new Point(1282, 37);
            TaylorSinus.Margin = new Padding(4);
            TaylorSinus.Name = "TaylorSinus";
            TaylorSinus.Size = new Size(99, 40);
            TaylorSinus.TabIndex = 1;
            TaylorSinus.Text = "Sinus";
            TaylorSinus.UseVisualStyleBackColor = false;
            TaylorSinus.Click += TaylorSinus_Click;
            // 
            // TaylorCosinus
            // 
            TaylorCosinus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TaylorCosinus.BackColor = Color.RoyalBlue;
            TaylorCosinus.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            TaylorCosinus.ForeColor = Color.White;
            TaylorCosinus.Location = new Point(1388, 37);
            TaylorCosinus.Margin = new Padding(4);
            TaylorCosinus.Name = "TaylorCosinus";
            TaylorCosinus.Size = new Size(99, 40);
            TaylorCosinus.TabIndex = 3;
            TaylorCosinus.Text = "Cosinus";
            TaylorCosinus.UseVisualStyleBackColor = false;
            TaylorCosinus.Click += TaylorCosinus_Click;
            // 
            // TaylorELaX
            // 
            TaylorELaX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TaylorELaX.BackColor = Color.RoyalBlue;
            TaylorELaX.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            TaylorELaX.ForeColor = Color.White;
            TaylorELaX.Location = new Point(1282, 84);
            TaylorELaX.Margin = new Padding(4);
            TaylorELaX.Name = "TaylorELaX";
            TaylorELaX.Size = new Size(205, 40);
            TaylorELaX.TabIndex = 4;
            TaylorELaX.Text = "e^x";
            TaylorELaX.UseVisualStyleBackColor = false;
            TaylorELaX.Click += TaylorELaX_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label2.Location = new Point(1282, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 23);
            label2.TabIndex = 5;
            label2.Text = "Polinomul lui Newton:";
            // 
            // NewtonRadical3
            // 
            NewtonRadical3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NewtonRadical3.BackColor = Color.DarkOrchid;
            NewtonRadical3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            NewtonRadical3.ForeColor = Color.White;
            NewtonRadical3.Location = new Point(1282, 158);
            NewtonRadical3.Margin = new Padding(4);
            NewtonRadical3.Name = "NewtonRadical3";
            NewtonRadical3.Size = new Size(205, 40);
            NewtonRadical3.TabIndex = 6;
            NewtonRadical3.Text = "Radical Ordinul 3";
            NewtonRadical3.UseVisualStyleBackColor = false;
            NewtonRadical3.Click += NewtonRadical3_Click;
            // 
            // NewtonAleatoriu
            // 
            this.NewtonAleatoriu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.NewtonAleatoriu.BackColor = Color.DarkOrchid;
            this.NewtonAleatoriu.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            this.NewtonAleatoriu.ForeColor = Color.White;
            this.NewtonAleatoriu.Location = new Point(1282, 205);
            this.NewtonAleatoriu.Margin = new Padding(4);
            this.NewtonAleatoriu.Name = "NewtonAleatoriu";
            this.NewtonAleatoriu.Size = new Size(205, 40);
            this.NewtonAleatoriu.TabIndex = 7;
            this.NewtonAleatoriu.Text = "Functie Aleatorie";
            this.NewtonAleatoriu.UseVisualStyleBackColor = false;
            this.NewtonAleatoriu.Click += NewtonAleatoriu_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label3.Location = new Point(1282, 254);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 23);
            label3.TabIndex = 8;
            label3.Text = "Polinomul Hermite:";
            // 
            // HermiteSinus
            // 
            HermiteSinus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HermiteSinus.BackColor = Color.Teal;
            HermiteSinus.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            HermiteSinus.ForeColor = Color.White;
            HermiteSinus.Location = new Point(1282, 278);
            HermiteSinus.Margin = new Padding(4);
            HermiteSinus.Name = "HermiteSinus";
            HermiteSinus.Size = new Size(99, 40);
            HermiteSinus.TabIndex = 9;
            HermiteSinus.Text = "Sinus";
            HermiteSinus.UseVisualStyleBackColor = false;
            HermiteSinus.Click += HermiteSinus_Click;
            // 
            // HermiteRadical
            // 
            HermiteRadical.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HermiteRadical.BackColor = Color.Teal;
            HermiteRadical.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            HermiteRadical.ForeColor = Color.White;
            HermiteRadical.Location = new Point(1388, 278);
            HermiteRadical.Margin = new Padding(4);
            HermiteRadical.Name = "HermiteRadical";
            HermiteRadical.Size = new Size(99, 40);
            HermiteRadical.TabIndex = 10;
            HermiteRadical.Text = "Radical";
            HermiteRadical.UseVisualStyleBackColor = false;
            HermiteRadical.Click += HermiteRadical_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label4.Location = new Point(1282, 328);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 23);
            label4.TabIndex = 11;
            label4.Text = "Polinomul Bernstein:";
            // 
            // BernsteinELaX
            // 
            BernsteinELaX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BernsteinELaX.BackColor = Color.ForestGreen;
            BernsteinELaX.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            BernsteinELaX.ForeColor = Color.White;
            BernsteinELaX.Location = new Point(1282, 352);
            BernsteinELaX.Margin = new Padding(4);
            BernsteinELaX.Name = "BernsteinELaX";
            BernsteinELaX.Size = new Size(205, 40);
            BernsteinELaX.TabIndex = 12;
            BernsteinELaX.Text = "e^x";
            BernsteinELaX.UseVisualStyleBackColor = false;
            BernsteinELaX.Click += BernsteinELaX_Click;
            // 
            // BernsteinRadical
            // 
            BernsteinRadical.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BernsteinRadical.BackColor = Color.ForestGreen;
            BernsteinRadical.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            BernsteinRadical.ForeColor = Color.White;
            BernsteinRadical.Location = new Point(1282, 398);
            BernsteinRadical.Margin = new Padding(4);
            BernsteinRadical.Name = "BernsteinRadical";
            BernsteinRadical.Size = new Size(205, 40);
            BernsteinRadical.TabIndex = 13;
            BernsteinRadical.Text = "1 + Radical";
            BernsteinRadical.UseVisualStyleBackColor = false;
            BernsteinRadical.Click += BernsteinRadical_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label5.Location = new Point(1282, 450);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 14;
            label5.Text = "Regresie:";
            // 
            // RegresieDreapta
            // 
            RegresieDreapta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RegresieDreapta.BackColor = Color.Orange;
            RegresieDreapta.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            RegresieDreapta.ForeColor = Color.White;
            RegresieDreapta.Location = new Point(1282, 472);
            RegresieDreapta.Margin = new Padding(4);
            RegresieDreapta.Name = "RegresieDreapta";
            RegresieDreapta.Size = new Size(99, 40);
            RegresieDreapta.TabIndex = 15;
            RegresieDreapta.Text = "Dreapta";
            RegresieDreapta.UseVisualStyleBackColor = false;
            RegresieDreapta.Click += RegresieDreapta_Click;
            // 
            // RegresieParabola
            // 
            RegresieParabola.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RegresieParabola.BackColor = Color.Orange;
            RegresieParabola.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            RegresieParabola.ForeColor = Color.White;
            RegresieParabola.Location = new Point(1388, 472);
            RegresieParabola.Margin = new Padding(4);
            RegresieParabola.Name = "RegresieParabola";
            RegresieParabola.Size = new Size(99, 40);
            RegresieParabola.TabIndex = 16;
            RegresieParabola.Text = "Parabola";
            RegresieParabola.UseVisualStyleBackColor = false;
            RegresieParabola.Click += RegresieParabola_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label6.Location = new Point(1282, 527);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 17;
            label6.Text = "Spline:";
            // 
            // SplinePoligonal
            // 
            SplinePoligonal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SplinePoligonal.BackColor = Color.Red;
            SplinePoligonal.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            SplinePoligonal.ForeColor = Color.White;
            SplinePoligonal.Location = new Point(1282, 548);
            SplinePoligonal.Margin = new Padding(4);
            SplinePoligonal.Name = "SplinePoligonal";
            SplinePoligonal.Size = new Size(99, 40);
            SplinePoligonal.TabIndex = 18;
            SplinePoligonal.Text = "Poligonal";
            SplinePoligonal.UseVisualStyleBackColor = false;
            SplinePoligonal.Click += SplinePoligonal_Click;
            // 
            // SplinePatratic
            // 
            SplinePatratic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SplinePatratic.BackColor = Color.Red;
            SplinePatratic.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            SplinePatratic.ForeColor = Color.White;
            SplinePatratic.Location = new Point(1388, 548);
            SplinePatratic.Margin = new Padding(4);
            SplinePatratic.Name = "SplinePatratic";
            SplinePatratic.Size = new Size(99, 40);
            SplinePatratic.TabIndex = 19;
            SplinePatratic.Text = "Patratic";
            SplinePatratic.UseVisualStyleBackColor = false;
            SplinePatratic.Click += SplinePatratic_Click;
            // 
            // SplineCubic
            // 
            SplineCubic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SplineCubic.BackColor = Color.Red;
            SplineCubic.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            SplineCubic.ForeColor = Color.White;
            SplineCubic.Location = new Point(1282, 595);
            SplineCubic.Margin = new Padding(4);
            SplineCubic.Name = "SplineCubic";
            SplineCubic.Size = new Size(99, 41);
            SplineCubic.TabIndex = 20;
            SplineCubic.Text = "Cubic";
            SplineCubic.UseVisualStyleBackColor = false;
            SplineCubic.Click += SplineCubic_Click;
            // 
            // SplineAkima
            // 
            SplineAkima.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SplineAkima.BackColor = Color.Red;
            SplineAkima.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            SplineAkima.ForeColor = Color.White;
            SplineAkima.Location = new Point(1388, 596);
            SplineAkima.Margin = new Padding(4);
            SplineAkima.Name = "SplineAkima";
            SplineAkima.Size = new Size(99, 40);
            SplineAkima.TabIndex = 21;
            SplineAkima.Text = "Akima";
            SplineAkima.UseVisualStyleBackColor = false;
            SplineAkima.Click += SplineAkima_Click;
            // 
            // SplinePatraticCubic
            // 
            SplinePatraticCubic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SplinePatraticCubic.BackColor = Color.Red;
            SplinePatraticCubic.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            SplinePatraticCubic.ForeColor = Color.White;
            SplinePatraticCubic.Location = new Point(1282, 733);
            SplinePatraticCubic.Margin = new Padding(4);
            SplinePatraticCubic.Name = "SplinePatraticCubic";
            SplinePatraticCubic.Size = new Size(205, 40);
            SplinePatraticCubic.TabIndex = 22;
            SplinePatraticCubic.Text = "Toate";
            SplinePatraticCubic.UseVisualStyleBackColor = false;
            SplinePatraticCubic.Click += SplinePatraticCubic_Click;
            // 
            // SplineCubicAkima
            // 
            SplineCubicAkima.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SplineCubicAkima.BackColor = Color.Red;
            SplineCubicAkima.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            SplineCubicAkima.ForeColor = Color.White;
            SplineCubicAkima.Location = new Point(1282, 643);
            SplineCubicAkima.Margin = new Padding(4);
            SplineCubicAkima.Name = "SplineCubicAkima";
            SplineCubicAkima.Size = new Size(205, 40);
            SplineCubicAkima.TabIndex = 23;
            SplineCubicAkima.Text = "Patratic si Cubic";
            SplineCubicAkima.UseVisualStyleBackColor = false;
            SplineCubicAkima.Click += SplineCubicAkima_Click;
            // 
            // SplineToate
            // 
            SplineToate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SplineToate.BackColor = Color.Red;
            SplineToate.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            SplineToate.ForeColor = Color.White;
            SplineToate.Location = new Point(1282, 686);
            SplineToate.Margin = new Padding(4);
            SplineToate.Name = "SplineToate";
            SplineToate.Size = new Size(205, 40);
            SplineToate.TabIndex = 24;
            SplineToate.Text = "Cubic si Akima";
            SplineToate.UseVisualStyleBackColor = false;
            SplineToate.Click += SplineToate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 780);
            Controls.Add(SplineToate);
            Controls.Add(SplineCubicAkima);
            Controls.Add(SplinePatraticCubic);
            Controls.Add(SplineAkima);
            Controls.Add(SplineCubic);
            Controls.Add(SplinePatratic);
            Controls.Add(SplinePoligonal);
            Controls.Add(label6);
            Controls.Add(RegresieParabola);
            Controls.Add(RegresieDreapta);
            Controls.Add(label5);
            Controls.Add(BernsteinRadical);
            Controls.Add(BernsteinELaX);
            Controls.Add(label4);
            Controls.Add(HermiteRadical);
            Controls.Add(HermiteSinus);
            Controls.Add(label3);
            Controls.Add(NewtonAleatoriu);
            Controls.Add(NewtonRadical3);
            Controls.Add(label2);
            Controls.Add(TaylorELaX);
            Controls.Add(TaylorCosinus);
            Controls.Add(label1);
            Controls.Add(TaylorSinus);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Polinoame de Interpolare";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public PictureBox pictureBox1;
        private Label label1;
        private Button TaylorSinus;
        private Button TaylorCosinus;
        private Button TaylorELaX;
        private Label label2;
        private Button NewtonRadical3;
        private Button NewtonAleatoriu;
        private Label label3;
        private Button HermiteSinus;
        private Button HermiteRadical;
        private Label label4;
        private Button BernsteinELaX;
        private Button BernsteinRadical;
        private Label label5;
        private Button RegresieDreapta;
        private Button RegresieParabola;
        private Label label6;
        private Button SplinePoligonal;
        private Button SplinePatratic;
        private Button SplineCubic;
        private Button SplineAkima;
        private Button SplinePatraticCubic;
        private Button SplineCubicAkima;
        private Button SplineToate;
    }
}
