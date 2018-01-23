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
    /// Логика взаимодействия для Loader_win_X3.xaml
    /// </summary>
    public partial class Loader_win_X3 : Window
    {
        public Loader_win_X3()
        {
            InitializeComponent();

            GetEllipseInfo();
            SetRenderTransformation(1, 1, 15, 15);

            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        DispatcherTimer timer = new DispatcherTimer();
        List<UIElement> EllipseList = new List<UIElement>();

        bool Flag = false;

        void Timer_Tick(object sender, EventArgs e)
        {

            if (Flag)
            {
                SetRenderTransformation(1, 1, 15, 15);
            }
            else
            {
                SetRenderTransformation(0.7, 0.7, 15, 15);
            }

            Flag = !Flag;
        }



        void GetEllipseInfo()
        {
            for (int i = 0; i < Grid_1.ColumnDefinitions.Count; i++)
            {
                EllipseList.Add(Grid_1.Children[i]);

                //Grid.GetRow()
            }
        }

        void SetRenderTransformation(double scaleX, double scaleY, double centerX, double centerY)
        {
            for (int i = 0; i < EllipseList.Count; i++)
            {   // ---------------------------------------------------------------------------------------------------------------------------
                // ---------------------------------------------------------------------------------------------------------------------------
                // ---------------------------------------------------------------------------------------------------------------------------
                // ---------------------------------------------------------------------------------------------------------------------------
                ScaleTransform ST = new ScaleTransform(scaleX, scaleY, centerX, centerY);    // ВАЖНО !!!!!!
                // ---------------------------------------------------------------------------------------------------------------------------
                EllipseList[i].RenderTransform = ST;
            }


        }
    }
}
