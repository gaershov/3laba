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

namespace CompGraph.View
{
    public partial class LabThirdForm : Form
    {

        int[,] kv = new int[5, 3]; // матрица тела
        int[,] osi = new int[4, 3]; // матрица координат осей
        int[,] matr_sdv = new int[3, 3]; //матрица преобразования
        Bitmap Bitmap { get; set; }
        int PBWidth, PBHeight;
        int k, l; // элементы матрицы сдвига
        int kosi, losi; 
        int kdelta = 0;
        int ldelta = 0;

        bool f = true;
        public LabThirdForm()
        {
            InitializeComponent();
        }

        //инициализация матрицы тела
        private void Init_kvadrat()
        {
            kv[0, 0] = 40; kv[0, 1] = -30; kv[0, 2] = 1;
            kv[1, 0] = 0; kv[1, 1] = 0; kv[1, 2] = 1;
            kv[2, 0] = 40; kv[2, 1] = 30; kv[2, 2] = 1;
            kv[3, 0] = -50; kv[3, 1] = 120; kv[3, 2] = 1; 
            kv[4, 0] = -50; kv[4, 1] = -100; kv[4, 2] = 1;
        }

        //инициализация матрицы сдвига
        private void Init_matr_preob(int k1, int l1)
        {
            matr_sdv[0, 0] = 1; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = 1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        //инициализация матрицы осей
        private void Init_osi()
        {
            osi[0, 0] = -200; osi[0, 1] = 0; osi[0, 2] = 1;
            osi[1, 0] = 200; osi[1, 1] = 0; osi[1, 2] = 1;
            osi[2, 0] = 0; osi[2, 1] = 200; osi[2, 2] = 1;
            osi[3, 0] = 0; osi[3, 1] = -200; osi[3, 2] = 1;

        }

        //умножение матриц
        private int[,] Multiply_matr(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int[,] r = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += a[i, ii] * b[ii, j];
                    }
                }
            }
            return r;
        }

        //вывод квадратика в центре pictureBox
        private void button2_Click(object sender, EventArgs e)
        {
            //середина pictureBox
            kosi = pictureBox1.Width / 2;
            losi = pictureBox1.Height / 2;

            //вывод квадратика в середине
            Draw_Kv();
        }


        //вывод квадрата на экран
        private void Draw_Kv()
        {

            Init_kvadrat(); //инициализация матрицы тела
            Init_matr_preob(k, l); //инициализация матрицы преобразования

            int[,] kv1 = Multiply_matr(kv, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromImage(Bitmap);

            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[4, 0], kv1[4, 1]);
            g.DrawLine(myPen, kv1[4, 0], kv1[4, 1], kv1[0, 0], kv1[0, 1]);

            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            pictureBox1.Image = Bitmap;

        }

        //вывод осей в центре pictureBox
        private void button1_Click(object sender, EventArgs e)
        {
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
            Draw_osi();
        }

        //сдвиг вправо
        private void button4_Click(object sender, EventArgs e)
        {
            k += 5; //изменение соответствующего элемента матрицы сдвига
            ClearPictureBox();
            Draw_Kv();
            Draw_osi();
        }

        //непрерывное перемещение
        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            button8.Text = "Стоп";
            if (f == true)
                timer1.Start();
            else
            {
                timer1.Stop();
                button8.Text = "Старт";
            }
            f = !f;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            k += kdelta;
            l += ldelta;
            ClearPictureBox();
            Draw_osi() ;
            Draw_Kv () ;

            Thread.Sleep(100);
        }

        private void ClearPictureBox()
        {
            Bitmap.Dispose ();
            Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Bitmap;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ClearPictureBox() ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            k -= 5; //изменение соответствующего элемента матрицы сдвига
            ClearPictureBox ();
            Draw_Kv();
            Draw_osi();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            l += 5;
            ClearPictureBox();
            Draw_Kv();
            Draw_osi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l -= 5;
            ClearPictureBox();
            Draw_Kv();
            Draw_osi();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            kdelta += 1;
            timer1.Start();
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            kdelta -= 1;
            timer1.Stop();
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            kdelta -= 1;
            timer1.Start();
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            kdelta += 1;
            timer1.Stop();
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            ldelta += 1;
            timer1.Start();
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            ldelta -= 1;
            timer1.Start();
        }

        private void LabThirdForm_Load(object sender, EventArgs e)
        {
            Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            ldelta -= 1;
            timer1.Start();
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            ldelta += 1;
            timer1.Stop();
        }

        //вывод осей на экран
        private void Draw_osi()
        {
            Init_osi();
            Init_matr_preob(kosi, losi);

            int[,] osi1 = Multiply_matr(osi, matr_sdv);
            Pen myPen = new Pen(Color.Red, 1);// цвет линии и ширина
            Graphics g = Graphics.FromImage(Bitmap);

            // рисуем ось ОХ
            g.DrawLine(myPen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1, 1]);

            // рисуем ось ОУ
            g.DrawLine(myPen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3, 1]);

            g.Dispose();
            myPen.Dispose();
            pictureBox1.Image = Bitmap;
        }
    }
}
