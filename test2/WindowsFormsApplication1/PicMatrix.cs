using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication1
{
    class PicMatrix
    {
        private  int height;
        private int width;
        Random r = new Random();
        PictureBox[,] picturearea = new PictureBox[4,4];
       
        public PicMatrix(int height,int width)
        {
            this.height = height;
            this.width = width;
        }
        public void picshow(Form form1)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                        picturearea[j,i]=new PictureBox();
                        picturearea[j, i].Image = new Bitmap(@"C:\Users\Public\Pictures\Sample Pictures\Chrysanthemum.jpg");
                        picturearea[j,i].Size=new Size(height,width);
                        picturearea[j, i].Location = new Point(200+height*j,200+width*i);
                        form1.Controls.Add(picturearea[j,i]);
                        picturearea[j, i].Visible = false;
                }
            }
        }
        public void RandomShow()
        {
            int rs;
            for (int i = 0; i < 4; i++)
            {
                rs=r.Next(0,4);
                for (int j = 0; j < 4; j++)
                {
                    if (j==rs)
                    {
                        picturearea[j, i].Visible = true;
                    }
                    else
                    {
                        picturearea[j, i].Visible = false;
                    }
                }
            }
        }
        public void PictureDown()
        {
 
        }
    }
}
