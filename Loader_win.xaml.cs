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
            switch (Etap)
            {

                case 0:
                    Line_1.Y1 = Line_1.Y1 + 1;
                    Line_1.Y2 = Line_1.Y2 - 1;

                    Line_2.X1 = Line_2.X1 + 1;
                    Line_2.X2 = Line_2.X2 - 1;

                    RLine_Blur.Radius = RLine_Blur.Radius - 0.05;
                    BLine_Blur.Radius = BLine_Blur.Radius - 0.05;
                    break;
                case 1:
                    Line_1.X1 = Line_1.X1 + 1;
                    Line_1.X2 = Line_1.X2 - 1;

                    Line_2.Y1 = Line_2.Y1 - 1;
                    Line_2.Y2 = Line_2.Y2 + 1;
                    RLine_Blur.Radius = RLine_Blur.Radius - 0.05;
                    BLine_Blur.Radius = BLine_Blur.Radius - 0.05;
                    break;
                case 2:
                    Line_1.Y1 = Line_1.Y1 - 1;
                    Line_1.Y2 = Line_1.Y2 + 1;

                    Line_2.X1 = Line_2.X1 - 1;
                    Line_2.X2 = Line_2.X2 + 1;
                    RLine_Blur.Radius = RLine_Blur.Radius + 0.05;
                    BLine_Blur.Radius = BLine_Blur.Radius + 0.05;
                    break;
                case 3:
                    Line_1.X1 = Line_1.X1 - 1;
                    Line_1.X2 = Line_1.X2 + 1;

                    Line_2.Y1 = Line_2.Y1 + 1;
                    Line_2.Y2 = Line_2.Y2 - 1;
                    RLine_Blur.Radius = RLine_Blur.Radius + 0.05;
                    BLine_Blur.Radius = BLine_Blur.Radius + 0.05;
                    break;
            }

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
                Etap = 0;

        }

        void NewLineCreate()
        {
            Line Line_3 = new Line();
            Line Line_4 = new Line();

            Line_3.X1=
        
        }
        
    }
}

