namespace Fractal_Project
{
    partial class FractalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FractalForm));
            this.fractalPictureBox = new System.Windows.Forms.PictureBox();
            this.drawFractalButton = new System.Windows.Forms.Button();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mandel = new System.Windows.Forms.Label();
            this.mandelbrotPictureBox = new System.Windows.Forms.PictureBox();
            this.colouringMethodsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.complexCoordinatesLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalPictureBox
            // 
            this.fractalPictureBox.Location = new System.Drawing.Point(18, 66);
            this.fractalPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fractalPictureBox.Name = "fractalPictureBox";
            this.fractalPictureBox.Size = new System.Drawing.Size(1056, 857);
            this.fractalPictureBox.TabIndex = 0;
            this.fractalPictureBox.TabStop = false;
            this.fractalPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.fractalPictureBox_Paint);
            // 
            // drawFractalButton
            // 
            this.drawFractalButton.Location = new System.Drawing.Point(18, 937);
            this.drawFractalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawFractalButton.Name = "drawFractalButton";
            this.drawFractalButton.Size = new System.Drawing.Size(219, 48);
            this.drawFractalButton.TabIndex = 1;
            this.drawFractalButton.Text = "Draw Fractal";
            this.drawFractalButton.UseVisualStyleBackColor = true;
            this.drawFractalButton.Click += new System.EventHandler(this.drawFractalButton_Click);
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(309, 934);
            this.aTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(148, 26);
            this.aTextBox.TabIndex = 2;
            this.aTextBox.Text = "-1.037";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(531, 932);
            this.bTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(148, 26);
            this.bTextBox.TabIndex = 3;
            this.bTextBox.Text = "0.17";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 937);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Re(c):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 937);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Im(c):";
            // 
            // Mandel
            // 
            this.Mandel.AutoSize = true;
            this.Mandel.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mandel.Location = new System.Drawing.Point(1235, 0);
            this.Mandel.Name = "Mandel";
            this.Mandel.Size = new System.Drawing.Size(380, 61);
            this.Mandel.TabIndex = 6;
            this.Mandel.Text = "Mandelbrot Set";
            // 
            // mandelbrotPictureBox
            // 
            this.mandelbrotPictureBox.Image = global::Fractal_Project.Properties.Resources.mandelbrot;
            this.mandelbrotPictureBox.Location = new System.Drawing.Point(1177, 64);
            this.mandelbrotPictureBox.Name = "mandelbrotPictureBox";
            this.mandelbrotPictureBox.Size = new System.Drawing.Size(500, 400);
            this.mandelbrotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mandelbrotPictureBox.TabIndex = 7;
            this.mandelbrotPictureBox.TabStop = false;
            this.mandelbrotPictureBox.Click += new System.EventHandler(this.mandelbrotPictureBox_Click);
            this.mandelbrotPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mandelbrotPictureBox_MouseMove);
            // 
            // colouringMethodsComboBox
            // 
            this.colouringMethodsComboBox.FormattingEnabled = true;
            this.colouringMethodsComboBox.Items.AddRange(new object[] {
            "MODULUS",
            "ITERATIONS",
            "TRIG",
            "BINARY DECOMPOSITION"});
            this.colouringMethodsComboBox.Location = new System.Drawing.Point(800, 931);
            this.colouringMethodsComboBox.Name = "colouringMethodsComboBox";
            this.colouringMethodsComboBox.Size = new System.Drawing.Size(272, 28);
            this.colouringMethodsComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 61);
            this.label3.TabIndex = 10;
            this.label3.Text = "Julia Set";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 938);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Colouring:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1173, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Complex Plane Coordinates:";
            // 
            // complexCoordinatesLabel
            // 
            this.complexCoordinatesLabel.AutoSize = true;
            this.complexCoordinatesLabel.Location = new System.Drawing.Point(1387, 483);
            this.complexCoordinatesLabel.Name = "complexCoordinatesLabel";
            this.complexCoordinatesLabel.Size = new System.Drawing.Size(31, 20);
            this.complexCoordinatesLabel.TabIndex = 13;
            this.complexCoordinatesLabel.Text = "( , )";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Poor Richard", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1173, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(625, 123);
            this.label6.TabIndex = 14;
            this.label6.Text = "A Julia Set Fractal can be formed with every \'c\' value present within the Mandelb" +
    "rot Set. Click a point on the Mandelbrot Set above and see the corresponing Juli" +
    "a Set form on the left.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Poor Richard", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1173, 625);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(625, 123);
            this.label7.TabIndex = 15;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // FractalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1870, 989);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.complexCoordinatesLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colouringMethodsComboBox);
            this.Controls.Add(this.mandelbrotPictureBox);
            this.Controls.Add(this.Mandel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.drawFractalButton);
            this.Controls.Add(this.fractalPictureBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FractalForm";
            this.Text = "Fractal ";
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fractalPictureBox;
        private System.Windows.Forms.Button drawFractalButton;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mandel;
        private System.Windows.Forms.PictureBox mandelbrotPictureBox;
        private System.Windows.Forms.ComboBox colouringMethodsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label complexCoordinatesLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

