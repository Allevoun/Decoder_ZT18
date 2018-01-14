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

            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
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


        void Timer_Tick(object sender, EventArgs e)
        {
            OldLinesMove();

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
                NewLineCreate(A2, B2, C2, D2);
                Etap = 0;
            }

        }

        void NewLineCreate(double[]L3A, double[]L3B, double[] L4A, double[] L4B)
        {
            Line Line_3 = new Line();
            Line Line_4 = new Line();

            Grid_Loader.Children.Add(Line_3);
            Grid_Loader.Children.Add(Line_4);

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

        void OldLinesMove()
        {
            switch (Etap)
            {

                case 0:
                    Line_1.Y1 = Line_1.Y1 + 1;
                    Line_1.Y2 = Line_1.Y2 - 1;

                    Line_2.X1 = Line_2.X1 + 1;
                    Line_2.X2 = Line_2.X2 - 1;

                    BlurEffect(0.05, "minus");
                    break;
                case 1:
                    Line_1.X1 = Line_1.X1 + 1;
                    Line_1.X2 = Line_1.X2 - 1;

                    Line_2.Y1 = Line_2.Y1 - 1;
                    Line_2.Y2 = Line_2.Y2 + 1;
                    BlurEffect(0.05, "minus");
                    break;
                case 2:
                    Line_1.Y1 = Line_1.Y1 - 1;
                    Line_1.Y2 = Line_1.Y2 + 1;

                    Line_2.X1 = Line_2.X1 - 1;
                    Line_2.X2 = Line_2.X2 + 1;

                    BlurEffect(0.05, "plus");
                    break;
                case 3:
                    Line_1.X1 = Line_1.X1 - 1;
                    Line_1.X2 = Line_1.X2 + 1;

                    Line_2.Y1 = Line_2.Y1 + 1;
                    Line_2.Y2 = Line_2.Y2 - 1;

                    BlurEffect(0.05, "plus");
                    break;
            }


        }

        void NewLinesMove()
        {

        }

        void BlurEffect(double n, string x)
        {
            if (x == "plus")
            {
                RLine_Blur.Radius = RLine_Blur.Radius + n;
                BLine_Blur.Radius = BLine_Blur.Radius + n;
            }
            else if (x == "minus")
            {
                RLine_Blur.Radius = RLine_Blur.Radius - n;
                BLine_Blur.Radius = BLine_Blur.Radius - n;
            }
        }

    }
}

