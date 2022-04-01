using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;


namespace PROJECTPRACTICE
{
    public partial class Form1 : Form
    {
        public string imgname = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void image_load_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog emf = new OpenFileDialog();
            try
            {
                if (emf.ShowDialog() == DialogResult.OK)
                {
                    imgname = emf.FileName;
                    Image<Bgr, byte> img = new Image<Bgr, byte>(emf.FileName);
                    pictureBox1.Image = img.Bitmap;
                    textimage.Visible = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textimage_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();
            textapply.Visible = true;
        }

        private void textapply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Image<Bgr, byte> image = new Image<Bgr, byte>(imgname);
                CvInvoke.PutText(image, textBox1.Text, new System.Drawing.Point(50, 170), FontFace.HersheySimplex, 7.0, new MCvScalar(0, 0, 255), 8);
                pictureBox2.Image = image.Bitmap;
                CvInvoke.WaitKey();
                image.Dispose();
            }
            else
            {
                MessageBox.Show("Please fill the text box");
                textBox1.Focus();
            }
        }
    }
}
