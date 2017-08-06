using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoStats
{
    class Algorithim
    {
        public delegate void ProgressCallbackDelegate(int progress);
        public delegate void ResultCallbackDelegate(int result);

        private ArrayList images;
        private ProgressCallbackDelegate progCallback;
        private ResultCallbackDelegate resCallback;
        private long size;

        public Algorithim(ArrayList images, ProgressCallbackDelegate progCallback, ResultCallbackDelegate resCallback) {
            this.images = images;
            this.progCallback = progCallback;
            this.resCallback = resCallback;
            size = 0;
            foreach (Image img in images)
            {
                size += (img.Size.Height*img.Size.Width);
            }
        }

        public long getSize() {
            return size;
        }

        public void start() {
            for (int i = 0; i < size; i++) {
                progCallback(i);
            }
            resCallback((int)size);
        }
    }
}
