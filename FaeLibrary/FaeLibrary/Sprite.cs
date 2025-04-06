using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace FaeLibrary
{
    public class Sprite
    {
        private string SpritePath;
        private PictureBox pictureBox;

        private Bitmap bitmap;

        public Sprite(string sprPth) { 
            SpritePath = sprPth;
            bitmap = new Bitmap(sprPth);
            pictureBox.Image = (Image) bitmap;
        }
    }
}
