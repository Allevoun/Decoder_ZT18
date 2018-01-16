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
    /// Логика взаимодействия для Loader_win_X2.xaml
    /// </summary>
    public partial class Loader_win_X2 : Window
    {
        public Loader_win_X2()
        {
            InitializeComponent();
            CreateRectangle(Grid_2, 15);

            timer.Interval = TimeSpan.FromSeconds(1.5);
            timer.Tick += Timer_Tick;
            timer.Start();

            TimerOfClose(0.1);
        }

        int N = 4;

        List<string> GridRNames = new List<string>();
        List<string> GridCNames = new List<string>();
        List<Rectangle> RectanglesList = new List<Rectangle>();

        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer1 = new DispatcherTimer();

        void TimerOfClose(double time)
        {
            timer1.Interval = TimeSpan.FromMinutes(0.5);
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            ElementsColorChange(Grid_2);
        }


        void CreateRectangle(Grid GridName, double Margin)
        {

            for (int i = 0; i < GridName.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < GridName.ColumnDefinitions.Count; j++)
                {

                    if (i == j)
                    {
                        Rectangle RG = new Rectangle { Fill = Brushes.LightPink };

                        GridName.Children.Add(RG);
                        Grid.SetColumn(RG, j);
                        Grid.SetRow(RG, i);

                        Thickness myThickness = new Thickness();
                        myThickness.Left = Margin;
                        myThickness.Right = Margin;
                        myThickness.Top = Margin;
                        myThickness.Bottom = Margin;

                        RG.Margin = myThickness;

                        RectanglesList.Add(RG);
                    }
                    else
                    {
                        Rectangle RG = new Rectangle { Fill = Brushes.Gray }; // РЕАЛИЗОВАТЬ ЧЕРЕЗ SETTINGS

                        GridName.Children.Add(RG);
                        Grid.SetColumn(RG, j);
                        Grid.SetRow(RG, i);

                        Thickness myThickness = new Thickness();
                        myThickness.Left = Margin;
                        myThickness.Right = Margin;
                        myThickness.Top = Margin;
                        myThickness.Bottom = Margin;
                        RG.Margin = myThickness;

                        RectanglesList.Add(RG);

                    }
                }
            }
        }
        int i = 0;
        void ElementsColorChange(Grid GridName)
        {
            if (i != GridName.RowDefinitions.Count * GridName.ColumnDefinitions.Count)
            {
                // СДЕЛАТЬ НОРМАЛЬНЫЙ ВЫБОР ЧЕРЕЗ FOR С УСЛОВИЕМ РАВЕНСТВА НУЖНОЙ НАМ ЯЧЕЙКИ 
                RectanglesList[i].Fill = Brushes.LightPink;
            }
            i++;
        }

        void GetGridInfo(Grid GridName)
        {
            for (int i = 0; i < (GridName.RowDefinitions.Count); i++)
            {
                GridRNames.Add(GridName.RowDefinitions[i].Name);
            }
            for (int i = 0; i < (GridName.ColumnDefinitions.Count); i++)
            {
                GridCNames.Add(GridName.ColumnDefinitions[i].Name);
            }
        }
    }
}
