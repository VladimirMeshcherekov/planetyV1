using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphics bmp = pictureBox1.CreateGraphics();
            bmp.DrawLine(new Pen(Brushes.Black, 2), new Point(0, 200), new Point(900, 200));
            bmp.DrawLine(new Pen(Brushes.Black, 2), new Point(190, 0), new Point(190, 700));//отрисовка оси координат
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 0;
            Graphics bmp = pictureBox1.CreateGraphics();
            bmp.DrawLine(new Pen(Brushes.Black, 2), new Point(0, 300), new Point(900, 300));
            //Thread.Sleep(1000);
            bmp.DrawLine(new Pen(Brushes.Black, 2), new Point(450, 0), new Point(450, 700));//отрисовка оси координат
            Thread thread = new Thread(Raschet);
            thread.Start();
            button2.Text = "sdfsdf";
            while (0 == 0)
            {

                for (int i = 200; i > -200; i--)
                {

                    Rectangle rect1 = new Rectangle(Convert.ToInt32(450 - Math.Sqrt(100 * 100 - ((i/2) * (i/2)))), Convert.ToInt32(300 - (i/2)), 5, 5);
                    Pen blackPen1 = new Pen(Color.Black, 5);
                    bmp.DrawRectangle(blackPen1, rect1);

                    Rectangle rect2 = new Rectangle(Convert.ToInt32(450 - Math.Sqrt(200 * 200 - (i * i))), Convert.ToInt32(300 - i), 5, 5);
                    bmp.DrawRectangle(blackPen1, rect2);



                    Thread.Sleep(20);

                    Pen blackPen2 = new Pen(Color.White, 5);
                    bmp.DrawRectangle(blackPen2, rect1);
                    bmp.DrawRectangle(blackPen2, rect2);




                }
                for (int i = 200; i > -200; i--)
                {
                    Rectangle rect1 = new Rectangle(Convert.ToInt32(Math.Sqrt(100 * 100 - ((i / 2) * (i / 2)))+450), Convert.ToInt32((i / 2)+300), 5, 5);
                    Pen blackPen1 = new Pen(Color.Black, 5);
                    bmp.DrawRectangle(blackPen1, rect1);

                    Rectangle rect2 = new Rectangle(Convert.ToInt32(Math.Sqrt(200 * 200 - (i * i))+450), Convert.ToInt32(i+300), 5, 5);
                    bmp.DrawRectangle(blackPen1, rect2);



                    Thread.Sleep(20);

                    Pen blackPen2 = new Pen(Color.White, 5);
                    bmp.DrawRectangle(blackPen2, rect1);
                    bmp.DrawRectangle(blackPen2, rect2);


                }

            }



        }
        /*/*/

        void Raschet()
        {
            button2.Text = "sdfsdf"; // та самая строчка
            Graphics bmp = pictureBox1.CreateGraphics();
            Pen blackPen1 = new Pen(Color.Black, 5);
            Pen blackPen2 = new Pen(Color.White, 5);
            while (0 == 0) {

                for (int i = 300; i > -300; i--)
                {
                    Rectangle rect3 = new Rectangle(Convert.ToInt32(450 - Math.Sqrt(300 * 300 - (i * i))), Convert.ToInt32(300 - i), 5, 5);
                    bmp.DrawRectangle(blackPen1, rect3);
                    Thread.Sleep(20);
                    bmp.DrawRectangle(blackPen2, rect3);

                }

                for (int i = 300; i > -300; i--)
                {
                    Rectangle rect3 = new Rectangle(Convert.ToInt32( Math.Sqrt(300 * 300 - (i * i))+450), Convert.ToInt32(i+300), 5, 5);
                    bmp.DrawRectangle(blackPen1, rect3);
                    Thread.Sleep(20);
                    bmp.DrawRectangle(blackPen2, rect3);

                }



            }

        }



    }
}
