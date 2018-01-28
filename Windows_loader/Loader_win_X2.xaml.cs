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
            CreateRectangle(Grid_2, 5);

            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += Timer_Tick;
            timer.Start();

            TimerOfClose(0.15); // идеально
        }

        List<string> GridRNames = new List<string>();
        List<string> GridCNames = new List<string>();

        List<Rectangle> RectanglesList = new List<Rectangle>();
        List<Rectangle> GridList = new List<Rectangle>();

        DispatcherTimer timer = new DispatcherTimer(); // за изменение цвета 
        DispatcherTimer timer1 = new DispatcherTimer(); // за остановление проекта

        void TimerOfClose(double time)
        {
            timer1.Interval = TimeSpan.FromMinutes(time);
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            ElementsColorChange_X2(Grid_2, 5);
        }

        void CreateRectangle(Grid GridName, double Margin)
        {

            for (int i = 0; i < GridName.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < GridName.ColumnDefinitions.Count; j++)
                {

                    //if (i == j)
                    //{
                    //    Rectangle RG = new Rectangle { Fill = Brushes.Gray };

                    //    GridName.Children.Add(RG);
                    //    Grid.SetColumn(RG, j);
                    //    Grid.SetRow(RG, i);

                    //    Thickness myThickness = new Thickness();
                    //    myThickness.Left = Margin;
                    //    myThickness.Right = Margin;
                    //    myThickness.Top = Margin;
                    //    myThickness.Bottom = Margin;

                    //    RG.Margin = myThickness;

                    //    RectanglesList.Add(RG);
                    //}
                    //else
                    //{

                    Rectangle RG = new Rectangle { Fill = Brushes.LightSlateGray }; // РЕАЛИЗОВАТЬ ЧЕРЕЗ SETTINGS

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

                    //}
                }
            }
        }

        void GridListChange(Grid GridName)
        {
        }

        int deffR = 0;
        int deffC = 0;

        int A = 1;

        int[] MSV1 = new int[] { 0, 1, 2, 3 };
        int[] MSV2 = new int[] { 0, 1, 2, 3 };

        // СДЕЛАТЬ НОРМАЛЬНЫЙ ВЫБОР ЧЕРЕЗ FOR С УСЛОВИЕМ РАВЕНСТВА НУЖНОЙ НАМ ЯЧЕЙКИ (найти функция для возврата номера колумна и роу)

        //void ElementsColorChange(Grid GridName)
        //{
        //    

        //    if ((i - 1) != GridName.RowDefinitions.Count * GridName.ColumnDefinitions.Count)
        //    {
        //        //if (i > 0)
        //        //    RectanglesList[i - 1].Fill = Brushes.Gray;

        //        if (i == GridName.ColumnDefinitions.Count - 1) // i == 3 - он становится три 
        //        {
        //            i = GridName.ColumnDefinitions.Count + 3; // ----> i = 7 
        //            A = -1;
        //        }
        //        if (i == GridName.ColumnDefinitions.Count)
        //        {
        //            i = GridName.ColumnDefinitions.Count + 4;
        //            A = 1;
        //        }
        //        if (i == GridName.ColumnDefinitions.Count + 7)
        //        {
        //            i = GridName.ColumnDefinitions.Count + 11;
        //            A = -1;
        //        }
        //        if (i != GridName.ColumnDefinitions.Count + 3 - 1 && i != GridName.ColumnDefinitions.Count + 4+1 && i != GridName.ColumnDefinitions.Count + 7)
        //            i = i + A;
        //        //if (i == GridName.ColumnDefinitions.Count + 3 && i == GridName.ColumnDefinitions.Count + 4 && i == GridName.ColumnDefinitions.Count + 7)
        //        //    i = i + A;

        //        //if (i != GridName.ColumnDefinitions.Count + 3 && i != GridName.ColumnDefinitions.Count + 4 && i != GridName.ColumnDefinitions.Count + 7)

        //    }

        //    RectanglesList[i].Fill = Brushes.LightPink;
        //}

        Rectangle newRG;
        bool Flagishe = false;

        void ElementsColorChange(Grid GridName, double Margin)
        {
            if (!Flagishe)
            {
                newRG = new Rectangle { Fill = Brushes.LightPink }; // РЕАЛИЗОВАТЬ ЧЕРЕЗ SETTINGS

                GridName.Children.Add(newRG);

                Thickness myThickness = new Thickness();
                myThickness.Left = Margin;
                myThickness.Right = Margin;
                myThickness.Top = Margin;
                myThickness.Bottom = Margin;
                newRG.Margin = myThickness;

                Flagishe = true;
            }
            Grid.SetRow(newRG, deffR);
            Grid.SetColumn(newRG, deffC);

            if (deffC == 3)
            {
                deffR = deffR + A;
                deffC = 0;
            }

            else
                deffC = deffC + A;
        }

        void ElementsColorChange_X2(Grid GridName, double Margin)
        {
            if (!Flagishe)
            {
                newRG = new Rectangle { Fill = Brushes.LightSeaGreen }; // РЕАЛИЗОВАТЬ ЧЕРЕЗ SETTINGS

                GridName.Children.Add(newRG);

                Thickness myThickness = new Thickness();
                myThickness.Left = Margin;
                myThickness.Right = Margin;
                myThickness.Top = Margin;
                myThickness.Bottom = Margin;
                newRG.Margin = myThickness;

                Flagishe = true;
            }
            if (deffR < GridName.RowDefinitions.Count && deffC < GridName.RowDefinitions.Count && deffC >= 0 && deffR >= 0)
            {
                Grid.SetRow(newRG, deffR);
                Grid.SetColumn(newRG, deffC);
            }

            if (deffC == 3 && deffR == 0)
            {
                deffR = deffR + A;
                A = -1 * A;
            }

            else if (deffC == 0 && deffR == 1)
            {
                A = -1 * A;
                deffR = deffR + A;
            }

            else if (deffC == 3 && deffR == 2)
            {
                deffR = deffR + A;
                A = -1 * A;
            }

            else
                deffC = deffC + A;
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
