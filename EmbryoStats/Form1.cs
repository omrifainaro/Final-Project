using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoStats
{
    public partial class Form1 : Form
    {

        ArrayList images;
        ProgressBar pb;

        public Form1()
        {
            InitializeComponent();
            images = new ArrayList();
        }

        private void openImageDialogBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                String[] names = openFileDialog1.FileNames;
                foreach (String name in names)
                {
                    addPicturebox(name);
                }
            }
            processBtn.Enabled = true;
        }

        private void addPicturebox(string path)
        {
            PictureBox pb = new PictureBox();
            Image img = Image.FromFile(path);
            images.Add(img);
            pb.Size = new Size(200, 200);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = img;
            pb.Visible = true;
            imagesView.Controls.Add(pb);
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            new Thread(startThread).Start();
        }

        public void startThread()
        {
            Algorithim algo = new Algorithim(images, progressBarProg, resultCallback);
            initProgressBar(algo.getSize());
            algo.start();
        }

        public void initProgressBar(long size) {
            Form2 form = new Form2();
            pb = form.getProgressBar();
            pb.Maximum = (int)size;
            pb.Value = 0;
            form.Show();
        }

        public void progressBarProg(int progress)
        {
            pb.Value = progress;
        }

        public void resultCallback(int res) {
            MessageBox.Show("Done! result: " + res);
        }
    }
}
