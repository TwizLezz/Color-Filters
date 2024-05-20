using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap Input_Image;
        Bitmap Filted_Image;

        double[,] histogram = new double[4, 256];
        double[] mean = new double [4];
        double standardDeviation = 0;
        double obliquity = 0;

        int[,,] Input_Image_As_A_Table;
        int[,,] Filted_Image_As_A_Table;

        private void FindHistogram()
        {
            for (int i = 0; i < Input_Image.Width; i++)
            {
                for (int j = 0; j < Input_Image.Height; j++)
                {
                    histogram[0, (int)(Filted_Image.GetPixel(i, j).R * 0.299 + Filted_Image.GetPixel(i, j).G * 0.587 + Filted_Image.GetPixel(i, j).B * 0.114)]++;
                    histogram[1, Filted_Image.GetPixel(i, j).R]++;
                    histogram[2, Filted_Image.GetPixel(i, j).G]++;
                    histogram[3, Filted_Image.GetPixel(i, j).B]++;
                }
            }

            for (int i = 0; i < 256; i++)
            {
                histogram[0, i] /= (Filted_Image.Width * Filted_Image.Height);
                histogram[1, i] /= (Filted_Image.Width * Filted_Image.Height);
                histogram[2, i] /= (Filted_Image.Width * Filted_Image.Height);
                histogram[3, i] /= (Filted_Image.Width * Filted_Image.Height);
            }

        }

        private void FindMean()
        {
            for (int i = 0; i < 256; i++)
            {
                mean[0] += i * histogram[0, i];
                mean[1] += i * histogram[1, i];
                mean[2] += i * histogram[2, i];
                mean[3] += i * histogram[3, i];
            }

            meanL2.Text = mean[0].ToString();
            meanR2.Text = mean[1].ToString();
            meanG2.Text = mean[2].ToString();
            meanB2.Text = mean[3].ToString();
        }

        private void FindStandardDeviation()
        { 
            for (int i = 0; i < 256; i++)
            {
                standardDeviation += Math.Pow((i - mean[0]), 2) * histogram[0, i];
            }
            variability2.Text = standardDeviation.ToString();

            standardDeviation = Math.Sqrt(standardDeviation);
            standardDeviation2.Text = standardDeviation.ToString();
        }

        private void FindObliquity()
        {
            for (int i = 0; i < 256; i++)
            {
                obliquity += Math.Pow((i - mean[0]), 3) * histogram[0, i];
            }

            obliquity2.Text = obliquity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Input_Image = new Bitmap(openFileDialog1.FileName);
                Filted_Image = Input_Image;

                Input_Image_As_A_Table = new int[3, Input_Image.Width, Input_Image.Height];
                Filted_Image_As_A_Table = new int[3, Input_Image.Width, Input_Image.Height];

                ConvertImageToTable(Input_Image);

                pictureBox1.Image = Input_Image;
                pictureBox2.Image = Input_Image;
            }
        }

        private void ConvertImageToTable(Bitmap input_Image)
        {
            for (int i = 0; i < input_Image.Width; i++)
            {
                for (int j = 0; j < input_Image.Height; j++)
                {
                    Input_Image_As_A_Table[0, i, j] =(int) input_Image.GetPixel(i, j).R;
                    Input_Image_As_A_Table[1, i, j] = (int)input_Image.GetPixel(i, j).G;
                    Input_Image_As_A_Table[2, i, j] = (int)input_Image.GetPixel(i, j).B;
                }
            }

            FindHistogram();
            FindMean();
            FindStandardDeviation();
            FindObliquity();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filted_Image = Input_Image;
            pictureBox2.Image = Filted_Image;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Input_Image.Width; i++)
            {
                for (int j = 0; j < Input_Image.Height; j++)
                {
                      Filted_Image_As_A_Table[0, i, j] = (int)(255 / (1 + Math.Pow(Math.E, -0.08 * (Input_Image_As_A_Table[0, i, j] - 128))));
                     Filted_Image_As_A_Table[1, i, j] = (int)(255 / (1 + Math.Pow(Math.E, -0.08 * (Input_Image_As_A_Table[1, i, j] - 128))));
                      Filted_Image_As_A_Table[2, i, j] = (int)(255 / (1 + Math.Pow(Math.E, -0.08 * (Input_Image_As_A_Table[2, i, j] - 128))));

                   // Filted_Image_As_A_Table[0, i, j] = Input_Image_As_A_Table[0, i, j];
                   // Filted_Image_As_A_Table[1, i, j] = Input_Image_As_A_Table[0, i, j];
                   //Filted_Image_As_A_Table[2, i, j] = Input_Image_As_A_Table[0, i, j];
                }

            }

            ConvertTableToImage(Filted_Image_As_A_Table);
            pictureBox2.Image = Filted_Image;
        }

        private void ConvertTableToImage(int[,,] filted_Image_As_A_Table)
        {
            Color myRgbColor = new Color();
            Filted_Image = new Bitmap(Input_Image.Width, Input_Image.Height);

            for (int i = 0; i < Input_Image.Width; i++)
            {
                for (int j = 0; j < Input_Image.Height; j++)
                {
                    myRgbColor = Color.FromArgb(Filted_Image_As_A_Table[0, i, j], Filted_Image_As_A_Table[1, i, j], Filted_Image_As_A_Table[2, i, j]);
                    Filted_Image.SetPixel(i, j, myRgbColor);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Input_Image.Width; i++)
            {
                for (int j = 0; j < Input_Image.Height; j++)
                {
                    Filted_Image_As_A_Table[0, i, j] = Input_Image_As_A_Table[0, i, j];
                    Filted_Image_As_A_Table[1, i, j] = Input_Image_As_A_Table[0, i, j];
                    Filted_Image_As_A_Table[2, i, j] = Input_Image_As_A_Table[0, i, j];
                }

            }

            ConvertTableToImage(Filted_Image_As_A_Table);
            pictureBox2.Image = Filted_Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Input_Image.Width; i++)
            {
                for (int j = 0; j < Input_Image.Height; j++)
                {
                    Filted_Image_As_A_Table[0, i, j] = Input_Image_As_A_Table[0, i, j];
                    Filted_Image_As_A_Table[1, i, j] = 0;
                    Filted_Image_As_A_Table[2, i, j] = 0;
                }

            }

            ConvertTableToImage(Filted_Image_As_A_Table);
            pictureBox2.Image = Filted_Image;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Input_Image.Width; i++)
            {
                for (int j = 0; j < Input_Image.Height; j++)
                {
                    Filted_Image_As_A_Table[0, i, j] = Input_Image_As_A_Table[2, i, j];
                    Filted_Image_As_A_Table[1, i, j] = Input_Image_As_A_Table[0, i, j];
                    Filted_Image_As_A_Table[2, i, j] = Input_Image_As_A_Table[1, i, j];
                }

            }

            ConvertTableToImage(Filted_Image_As_A_Table);
            pictureBox2.Image = Filted_Image;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void meanL1_Click(object sender, EventArgs e)
        {

        }

        private void meanL2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


            for (int i = 1; i < Input_Image.Width - 1; i++)
            {
             
                for (int j = 1; j < Input_Image.Height - 1; j++)
                {
                    int value = Horizontal(i, j);
                    if (value > 255)
                        value = 255;
                    else if (value < 0)
                        value = 0;

                    Filted_Image_As_A_Table[0, i, j] = value;
                    Filted_Image_As_A_Table[1, i, j] = value;
                    Filted_Image_As_A_Table[2, i, j] = value;
                }
            }

            ConvertTableToImage(Filted_Image_As_A_Table);
            pictureBox2.Image = Filted_Image;

        }
        private int Horizontal(int x, int y)
        {
            int width = Input_Image.Width;
            int height = Input_Image.Height;
            int[,] kernel = new int[3, 3] { { 1, 2, 1 },
                                        { 0, 0, 0} ,
                                        {-1, -2, -1 } };
            int sum = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + width) % width;
                    var row = (y + j + height) % height;
                    var luminosity = (int)(Input_Image_As_A_Table[0, col, row] * 0.299 + Input_Image_As_A_Table[1, col, row] * 0.587
                                            + Input_Image_As_A_Table[2, col, row] * 0.114);

                    sum += kernel[i + 1, j + 1] * luminosity;
                }
            }

            return sum;
        }
        private int Vertical(int x, int y)
        {
            int width = Input_Image.Width;
            int height = Input_Image.Height;
            int[,] kernel = new int[3, 3] { { 1, 0, -1 },
                                            { 2, 0, -2} ,
                                            { 1, 0, -1 } };
            int sum = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + width) % width;
                    var row = (y + j + height) % height;

                    var luminosity = (int)(Input_Image_As_A_Table[0, col, row] * 0.299 + Input_Image_As_A_Table[1, col, row] * 0.587
                                            + Input_Image_As_A_Table[2, col, row] * 0.114);

                    sum += kernel[i + 1, j + 1] * luminosity;
                }
            }

            return sum;
        }

        private void variability1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < Input_Image.Width - 1; i++)
            {

                for (int j = 1; j < Input_Image.Height - 1; j++)
                {
                    int value = Vertical(i, j);
                    

                    if (value > 255)
                        value = 255;

                    else if (value < 0)
                        value = 0;

                    Filted_Image_As_A_Table[0, i, j] = value;
                    Filted_Image_As_A_Table[1, i, j] = value;
                    Filted_Image_As_A_Table[2, i, j] = value;
                }
            }

            ConvertTableToImage(Filted_Image_As_A_Table);
            pictureBox2.Image = Filted_Image;
        }
    }




}
