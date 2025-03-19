namespace FiltreImagini
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGrayScale = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.buttonComplementary = new System.Windows.Forms.Button();
            this.buttonBlur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGrayScale
            // 
            this.buttonGrayScale.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonGrayScale.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrayScale.ForeColor = System.Drawing.Color.White;
            this.buttonGrayScale.Location = new System.Drawing.Point(1298, 12);
            this.buttonGrayScale.Name = "buttonGrayScale";
            this.buttonGrayScale.Size = new System.Drawing.Size(287, 42);
            this.buttonGrayScale.TabIndex = 1;
            this.buttonGrayScale.Text = "Gray Scale";
            this.buttonGrayScale.UseVisualStyleBackColor = false;
            this.buttonGrayScale.Click += new System.EventHandler(this.buttonGrayScale_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Crimson;
            this.buttonReset.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(1298, 690);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(287, 42);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonContrast
            // 
            this.buttonContrast.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonContrast.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContrast.ForeColor = System.Drawing.Color.White;
            this.buttonContrast.Location = new System.Drawing.Point(1298, 60);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(287, 42);
            this.buttonContrast.TabIndex = 3;
            this.buttonContrast.Text = "Contrast";
            this.buttonContrast.UseVisualStyleBackColor = false;
            this.buttonContrast.Click += new System.EventHandler(this.buttonContrast_Click);
            // 
            // buttonComplementary
            // 
            this.buttonComplementary.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonComplementary.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComplementary.ForeColor = System.Drawing.Color.White;
            this.buttonComplementary.Location = new System.Drawing.Point(1298, 108);
            this.buttonComplementary.Name = "buttonComplementary";
            this.buttonComplementary.Size = new System.Drawing.Size(287, 42);
            this.buttonComplementary.TabIndex = 4;
            this.buttonComplementary.Text = "Complementary";
            this.buttonComplementary.UseVisualStyleBackColor = false;
            this.buttonComplementary.Click += new System.EventHandler(this.buttonComplementary_Click);
            // 
            // buttonBlur
            // 
            this.buttonBlur.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBlur.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlur.ForeColor = System.Drawing.Color.White;
            this.buttonBlur.Location = new System.Drawing.Point(1298, 156);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(287, 42);
            this.buttonBlur.TabIndex = 5;
            this.buttonBlur.Text = "Blur";
            this.buttonBlur.UseVisualStyleBackColor = false;
            this.buttonBlur.Click += new System.EventHandler(this.buttonBlur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 746);
            this.Controls.Add(this.buttonBlur);
            this.Controls.Add(this.buttonComplementary);
            this.Controls.Add(this.buttonContrast);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonGrayScale);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGrayScale;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.Button buttonComplementary;
        private System.Windows.Forms.Button buttonBlur;
    }
}

