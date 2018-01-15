using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Decoder_ZT18
{
    /// <summary>
    /// Логика взаимодействия для Loader_win.xaml
    /// </summary>
    public partial class Loader_win : Window
    {
        public Loader_win()
        {
            InitializeComponent();

            //DateTime DeadLine = new DateTime();
            //DeadLine = DateTime.Now;
            //DeadLine.AddMinutes(2);

            Settings.Deadline = DateTime.Now;
            Settings.Deadline = Settings.Deadline.AddMinutes(2);


            timer.Interval = TimeSpan.FromMilliseconds(speed);
            timer.Tick += Timer_Tick;
            timer.Start();
            timer1.Interval = TimeSpan.FromMinutes(0.2);
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            //Line_1.X1 = this.Height / 3;
            //Line_1.Y1 = this.Width / 3;
            //Line_2.X1 = this.Height / 3;
            //Line_2.Y1 = this.Width * 2 / 3;

            A = new double[] { Line_1.X1, Line_1.Y1 };
            A2 = A;
            B = new double[] { Line_1.X2, Line_1.Y2 };
            B2 = B;
            C = new double[] { Line_2.X1, Line_2.Y1 };
            C2 = C;
            D = new double[] { Line_2.X2, Line_2.Y2 };
            D2 = D;

        }

        int Etap = 0;
        double speed = 1;
        bool Flag = false;
        // Settigs ???
        double[] A;
        double[] B;
        double[] C;
        double[] D;

        double[] A2;
        double[] B2;
        double[] C2;
        double[] D2;

        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer1 = new DispatcherTimer();

        void Timer_Tick(object sender, EventArgs e)
        {

            OldLinesMove();
            NewLinesMove();

            A2 = new double[] { Line_1.X1, Line_1.Y1 };
            B2 = new double[] { Line_1.X2, Line_1.Y2 };
            C2 = new double[] { Line_2.X1, Line_2.Y1 };
            D2 = new double[] { Line_2.X2, Line_2.Y2 };


            if (A2[0] == D[0] && A2[1] == D[1])
                Etap = 3;
            if (A2[0] == B[0] && A2[1] == B[1])
                Etap = 2;
            if (A2[0] == C[0] && A2[1] == C[1])
                Etap = 1;
            if (A2[0] == A[0] && A2[1] == A[1])
            {
                Flag = !Flag; // гениально чёрт подери
                //регулирует движение и видимость линий 
                NewLineCreate(C2, D2, A2, B2);
                Etap = 0;
            }
        }
        void Timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer1.Stop();
            this.Close();
        }

        void NewLineCreate(double[] L3A, double[] L3B, double[] L4A, double[] L4B)
        {
            if (Flag == true)
            {
                Line_3.Visibility = Visibility.Visible;
                Line_4.Visibility = Visibility.Visible;
            }
            else
            {
                Line_3.Visibility = Visibility.Hidden;
                Line_4.Visibility = Visibility.Hidden;
            }

            Line_3.X1 = L3A[0];
            Line_3.Y1 = L3A[1];
            Line_3.X2 = L3B[0];
            Line_3.Y2 = L3B[1];
            Line_4.X1 = L4A[0];
            Line_4.Y1 = L4A[1];
            Line_4.X2 = L4B[0];
            Line_4.Y2 = L4B[1];

            Line_3.Stroke = Brushes.Pink;
            Line_4.Stroke = Brushes.LightBlue;
        }

        void SpeedChange()
        {

        }

        // оптимизированный метод для поворота
        void LinesMove(Line myLine1, Line myLine2, int etap, int Moving, double Speed) // moving - +1 or -1 (против и по соответсвенно)
        {
            if (etap < 2)
            {
                myLine1.X1 = myLine1.X1 + Speed * (etap % 2); //changed
                myLine1.X2 = myLine1.X2 - Speed * (etap % 2);
                myLine1.Y1 = myLine1.Y1 + Moving * Speed * ((etap + 1) % 2); //need
                myLine1.Y2 = myLine1.Y2 - Moving * Speed * ((etap + 1) % 2);

                if (etap == 0)
                {
                    myLine2.X1 = myLine2.X1 + Speed * ((etap + 1) % 2); //changed
                    myLine2.X2 = myLine2.X2 - Speed * ((etap + 1) % 2);
                    myLine2.Y1 = myLine2.Y1 + Moving * Speed * (etap % 2);
                    myLine2.Y2 = myLine2.Y2 - Moving * Speed * (etap % 2);
                }
                else
                {
                    myLine2.X1 = myLine2.X1 - Moving * Speed * ((etap + 1) % 2);
                    myLine2.X2 = myLine2.X2 + Moving * Speed * ((etap + 1) % 2);
                    myLine2.Y1 = myLine2.Y1 - Moving * Speed * (etap % 2); //changed (mooving here is need)
                    myLine2.Y2 = myLine2.Y2 + Moving * Speed * (etap % 2);
                }
            }
            else
            {
                myLine1.X1 = myLine1.X1 - Speed * (etap % 2); //chenged
                myLine1.X2 = myLine1.X2 + Speed * (etap % 2);
                myLine1.Y1 = myLine1.Y1 - Moving * Speed * ((etap + 1) % 2); //nedd
                myLine1.Y2 = myLine1.Y2 + Moving * Speed * ((etap + 1) % 2);

                if (etap == 3)
                {
                    myLine2.X1 = myLine2.X1 + Moving * Speed * ((etap + 1) % 2);
                    myLine2.X2 = myLine2.X2 - Moving * Speed * ((etap + 1) % 2);
                    myLine2.Y1 = myLine2.Y1 + Moving * Speed * (etap % 2); //changed (mooving here is need)
                    myLine2.Y2 = myLine2.Y2 - Moving * Speed * (etap % 2);
                }
                else
                {
                    myLine2.X1 = myLine2.X1 - Speed * ((etap + 1) % 2); //changed
                    myLine2.X2 = myLine2.X2 + Speed * ((etap + 1) % 2);
                    myLine2.Y1 = myLine2.Y1 - Moving * Speed * (etap % 2);
                    myLine2.Y2 = myLine2.Y2 + Moving * Speed * (etap % 2);
                }
            }

        }

        void OldLinesMove()
        {

            LinesMove(Line_1, Line_2, Etap, 1, 4);

            switch (Etap)
            {
                case 0:
                    BlurEffect(Line1_Blur, Line2_Blur, 0.05, -1);
                    break;
                case 1:
                    BlurEffect(Line1_Blur, Line2_Blur, 0.05, -1);
                    break;
                case 2:
                    BlurEffect(Line1_Blur, Line2_Blur, 0.05, 1);
                    break;
                case 3:
                    BlurEffect(Line1_Blur, Line2_Blur, 0.05, 1);
                    break;
            }
        }


        void NewLinesMove()
        {
            if (Flag == true)
            {
                LinesMove(Line_3, Line_4, Etap, -1, 3); // по часовой стрелке, т.к. (-1)

                if (Etap < 2)
                    BlurEffect(Line3_Blur, Line4_Blur, 0.05, -1);
                else
                    BlurEffect(Line3_Blur, Line4_Blur, 0.05, 1);
            }
        }

        void BlurEffect(BlurEffect BELine1, BlurEffect BELine2, double n, int x)
        {
            if (x == 1)
            {
                BELine1.Radius = BELine1.Radius + n;
                BELine2.Radius = BELine2.Radius + n;
            }
            else if (x == -1)
            {
                BELine1.Radius = BELine1.Radius - n;
                BELine2.Radius = BELine2.Radius - n;
            }
        }

    }
}

