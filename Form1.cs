using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Fractal_Project
{
    public partial class FractalForm : Form
    {
        private const int NO_COLOURING = 0, ITERATIONS = 1, MODULUS = 2, TRIG = 3, BINARY_DECOMPOSITION = 4;

        private static int coloringMethod = NO_COLOURING;

        private static double maxModulus = 2;
        private Bitmap fractalBitmap = new Bitmap(704, 557);

        public FractalForm()
        {
            InitializeComponent();
        }

        private void mandelbrotPictureBox_Click(object sender, EventArgs e)
        {
            switch (colouringMethodsComboBox.SelectedItem)
            {
                case "MODULUS":
                    coloringMethod = MODULUS;
                    break;
                case "ITERATIONS":
                    coloringMethod = ITERATIONS;
                    break;
                case "TRIG":
                    coloringMethod = TRIG;
                    break;
                case "BINARY DECOMPOSITION":
                    coloringMethod = BINARY_DECOMPOSITION;
                    break;
            }

            var mouseEventArgs = e as MouseEventArgs;
            Complex c = new Complex(4.0d / mandelbrotPictureBox.Width * mouseEventArgs.X - 2.5d,
                -3.0d / mandelbrotPictureBox.Height * mouseEventArgs.Y + 1.5d);
            DrawFractal(c, coloringMethod);
        }

        private void drawFractalButton_Click(object sender, EventArgs e)
        {
            switch (colouringMethodsComboBox.SelectedItem)
            {
                case "MODULUS":
                    coloringMethod = MODULUS;
                    break;
                case "ITERATIONS":
                    coloringMethod = ITERATIONS;
                    break;
                case "TRIG":
                    coloringMethod = TRIG;
                    break;
                case "BINARY DECOMPOSITION":
                    coloringMethod = BINARY_DECOMPOSITION;
                    break;
            }
            Complex c = new Complex(double.Parse(aTextBox.Text), double.Parse(bTextBox.Text));
            DrawFractal(c, coloringMethod);
        }

        private void mandelbrotPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            complexCoordinatesLabel.Text = "( " + String.Format("{0:0.000}", 4.0d / mandelbrotPictureBox.Width * e.X - 2.5d) + 
                " , " + String.Format("{0:0.000}", -3.0d / mandelbrotPictureBox.Height * e.Y + 1.5d).ToString() + " )";
        }

        private void fractalPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(fractalBitmap, 0, 0);
        }
        private void DrawFractal(Complex c, int colourMethod)
        {
            Graphics fractalSetImage = Graphics.FromImage(fractalBitmap);
            Complex z;

            int width = fractalBitmap.Width;
            int height = fractalBitmap.Height;

            fractalSetImage.Clear(Color.White);
            fractalPictureBox.Refresh();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    z = new Complex((4.0 / width) * x - 2, (-3.0 / height) * y + 1.5);
                    int iterations = 0;
                    while (Complex.Abs(z) < 2 && iterations <= 100)
                    {
                        z = Complex.Add(Complex.Pow(z, 2), c);
                        iterations++;
                    }
                    fractalBitmap.SetPixel(x, y, pixelColour(colourMethod, iterations, z));
                }
            }
            fractalPictureBox.Refresh();
        }
        private static Color pixelColour(int colourMethod, int repetitions, Complex c)
        {
            double modulus = Complex.Abs(c);

            if (colourMethod == ITERATIONS)
            {
                if (modulus >= 2.0d)
                {
                    int red = (int)(2.55f * repetitions);
                    int green = red;
                    int blue = (int)(255 - 2.55f * repetitions);
                    return Color.FromArgb(red, green, blue);
                }
                else
                    return Color.Black;
            }
            else if (colourMethod == MODULUS)
            {
                if (modulus >= 2.0d)
                {
                    int red = (int)Math.Round(-23.3d * modulus + 277.0d);
                    int green = (int)Math.Round(10.0d * Math.Pow(modulus, 2) - 136.0d * modulus + 465.0d);
                    int blue = (int)Math.Round(25.3d * modulus - 50.0d);
                    return Color.FromArgb(red, green, blue);
                }
                else
                    return Color.Black;

            }
            else if (colourMethod == TRIG)
            {
                int red = 255 - (int)(255 * Math.Abs(Math.Sin(c.Real)));
                int blue = 255 - (int)(255 * Math.Abs(Math.Cos(c.Imaginary)));
                int green = (red < blue) ? red : blue; //Set green to smaller of red and blue
                return Color.FromArgb(red, green, blue);
            }
            else if (colourMethod == BINARY_DECOMPOSITION)
            {
                if (repetitions == 2000)
                {
                    return Color.Black;
                }
                else
                {
                    if (c.Imaginary > 0)
                        return Color.Black;
                    else
                        return Color.White;
                }
            }
            else if (modulus < 2.0d) //
                return Color.Black;
            else
                return Color.White;
        }

        private static Color mapCountToColor(int count)
        {
            int r = 1200 / 255 * count;
            int g = 1200 / 255 * count;
            int b = 255;
            if (r > 255)
                r = 255;
            if (g > 255)
                g = 255;
            return Color.FromArgb(r, g, b);
        }
    }

}


