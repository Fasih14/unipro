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
namespace PROJECTPRACTICE
{
    public partial class blendImages : Form
    {
        Image<Bgr, byte> [] Images;
       string [] ImagesString;
        public blendImages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.jpg, *.jpng)|*.jpg,*.png";
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ImagesString = ofd.FileNames;
                if(ImagesString.Length < 2)
                {
                    MessageBox.Show("Select more than One images");
                    return;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartUp obj1= new StartUp();
            this.Hide();
            obj1.Show();
        }
    }
}
