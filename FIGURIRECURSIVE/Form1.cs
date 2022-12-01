using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace FIGURIRECURSIVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        public Rectangle patrat(float x, float y, float l)
        {
            float l2;
            l2 = l / 2;
            Rectangle a = new Rectangle((Int16)(x - l2), (Int16)(y - l2), (Int16)(x + l2), (Int16)(y + l2));


            return a;

        }

        public void drawDiamant(float x, float y , float l)
        {
            float c = 2.3f;
            float l2, l3;

            if (l > 0)
            {
                Rectangle a = patrat(x, y, l);
                userControl11.g.DrawRectangle(userControl11.pen0, a);
                l2 = l / 2;
                l3 = (Int16) Math.Round(l / c);
                drawDiamant(x - l2, y - l2, l3 );
                drawDiamant(x - l2, y + l2, l3 );
                drawDiamant(x + l2, y - l2, l3 );
                drawDiamant(x + l2, y + l2, l3 );
                //Thread.Sleep(1);
                //Refresh();
            }
        }


        public void drawGrila()
        {
            for (int i = 0; i < 400; i += 40)
            {
                for (int j = 0; j < 400; j += 40)
                {
                    userControl11.g.DrawRectangle(userControl11.pen0, i, j, 40, 40);
                    userControl11.g.DrawString((i / 40).ToString() + ":" + (j / 40).ToString(), userControl11.font0, userControl11.brush0, i + 7, j + 7);
                    //Thread.Sleep(1);
                }
            }
        }

        public void thedrawings()
        {
            // drawGrila();
            for (float i = 400; i > 10; i -= i / 2)
            {
                for (float j = 400; j > 10; j -= j / 2)
                {

                    drawDiamant(i / 2, j / 2, j / 3);

                    // Thread.Sleep(1);
                }
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            thedrawings();
        }
    }
}
