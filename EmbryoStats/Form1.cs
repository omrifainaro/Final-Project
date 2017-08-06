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
        ProgressBar progbar;

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
            InitProgressBar(algo.getSize());
            algo.start();
        }

        public void InitProgressBar(long size)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<long>(InitProgressBar), new object[] { size });
                return;
            }
            progbar.Visible = true;
            progbar.Maximum = (int)size;
        }

        public void progressBarProg(int progress)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(progressBarProg), new object[] { progress });
                return;
            }
            progbar.Value = progress;
        }

        public void resultCallback(int res) {
            MessageBox.Show("Done! result: " + res);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progbar = progressBar2;
        }
    }
}
