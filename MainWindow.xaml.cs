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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Decoder_ZT18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {           
            InitializeComponent();

            Loader_win_X2 LW2 = new Loader_win_X2();
            LW2.ShowDialog();
            RightLineDrow();
            WrongLineDrow();
        }

        List<Line> RightLineList = new List<Line>();
        List<Line> WrongLineList = new List<Line>();
        Answers AN = new Answers();

        private void BTN_Check1_Click(object sender, RoutedEventArgs e)
        {
            BTN_Check1.Visibility = Visibility.Hidden;

            if (TB_1.Text.ToUpper() == Answers.Ans1.ToUpper())
            {
                for (int i = 0; i < 2; i++)
                {
                    RightLineList[i].Visibility = Visibility.Visible;
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    WrongLineList[i].Visibility = Visibility.Visible;
                }
            }
        }
        
        void RightLineDrow()
        {
            //int n = 0;
            //<Line Grid.Column="1" X1="50" X2="90" Y1="35" Y2="75" Stroke="#FF1ECE27" StrokeThickness="5" Margin="39.8,0,-39.6,92.6" Grid.RowSpan="2"></Line>
            //<Line Grid.Column="1" X1="88" X2="130" Y1="74" Y2="10" Stroke="#FF1ECE27" StrokeThickness="5" Margin="39.8,0,-39.6,92.6" Grid.RowSpan="2"></Line>
            double x = 35;

            for (int i = 0; i < 4; i++)
            {
                Line NL = new Line() { Stroke = Brushes.Green } ;                 
                NL.StrokeThickness = 5;
                NL.X1 = 50 +x;
                NL.X2 = 90 +x;
                NL.Y1 = 35;
                NL.Y2 = 75;
                NL.Visibility = Visibility.Hidden;

                Grid_Main1.Children.Add(NL);
                Grid.SetRow(NL, i);
                Grid.SetColumn(NL, 1);

                RightLineList.Add(NL);

                Line NL2 = new Line() { Stroke = Brushes.Green };
                NL2.X1 = 88+x;
                NL2.X2 = 130+x;
                NL2.Y1 = 74;
                NL2.Y2 = 10;
                NL2.StrokeThickness = 5;
                                
                Grid_Main1.Children.Add(NL2);
                Grid.SetRow(NL2, i);
                Grid.SetColumn(NL2, 1);
                NL2.Visibility = Visibility.Hidden;

                RightLineList.Add(NL2);
            }
        }

        void WrongLineDrow()
        {
            //int n = 0;
            //<Line Grid.Column="1" X1="50" X2="90" Y1="35" Y2="75" Stroke="#FF1ECE27" StrokeThickness="5" Margin="39.8,0,-39.6,92.6" Grid.RowSpan="2"></Line>
            //<Line Grid.Column="1" X1="88" X2="130" Y1="74" Y2="10" Stroke="#FF1ECE27" StrokeThickness="5" Margin="39.8,0,-39.6,92.6" Grid.RowSpan="2"></Line>
            double x = 35;

            for (int i = 0; i < 4; i++)
            {
                Line NL = new Line() { Stroke = Brushes.Red };
                NL.StrokeThickness = 5;
                NL.X1 = 100 ;
                NL.X2 = 150 ;
                NL.Y1 = 20 ;
                NL.Y2 = 80 ;
                NL.Visibility = Visibility.Hidden;

                Grid_Main1.Children.Add(NL);
                Grid.SetRow(NL, i);
                Grid.SetColumn(NL, 1);

                WrongLineList.Add(NL);

                Line NL2 = new Line() { Stroke = Brushes.Red };
                NL2.X1 = 100;
                NL2.X2 = 150 ;
                NL2.Y1 = 80 ;
                NL2.Y2 = 20 ;
                NL2.StrokeThickness = 5;

                Grid_Main1.Children.Add(NL2);
                Grid.SetRow(NL2, i);
                Grid.SetColumn(NL2, 1);
                NL2.Visibility = Visibility.Hidden;

                WrongLineList.Add(NL2);
            }
        }

        private void BTN_Check2_Click(object sender, RoutedEventArgs e)
        {
            BTN_Check2.Visibility = Visibility.Hidden;

            if (TB_2.Text.ToUpper() == Answers.Ans2.ToUpper())
            {
                for (int i = 2; i < 4; i++)
                {
                    RightLineList[i].Visibility = Visibility.Visible;
                }
            }
            else
            {
                for (int i = 2; i < 4; i++)
                {
                    WrongLineList[i].Visibility = Visibility.Visible;
                }
            }
        }

        private void BTN_Check3_Click(object sender, RoutedEventArgs e)
        {
            BTN_Check3.Visibility = Visibility.Hidden;

            if (TB_3.Text.ToUpper() == Answers.Ans3.ToUpper())
            {
                for (int i = 4; i < 6; i++)
                {
                    RightLineList[i].Visibility = Visibility.Visible;
                }
            }
            else
            {
                for (int i = 4; i < 6; i++)
                {
                    WrongLineList[i].Visibility = Visibility.Visible;
                }
            }
        }

        private void BTN_Check4_Click(object sender, RoutedEventArgs e)
        {
            BTN_Check4.Visibility = Visibility.Hidden;

            if (TB_4.Text.ToUpper() == Answers.Ans4.ToUpper())
            {
                for (int i = 6; i < 8; i++)
                {
                    RightLineList[i].Visibility = Visibility.Visible;
                }
            }
            else
            {
                for (int i = 6; i < 8; i++)
                {
                    WrongLineList[i].Visibility = Visibility.Visible;
                }
            }

        }



        /*private void BTN_q1_Click(object sender, RoutedEventArgs e)
        {
            //Quest_one_page QOP = new Quest_one_page();
            //Frame_QuestOnePage.Content = QOP;
            Loader_win LW = new Loader_win();
            LW.ShowDialog();
        }*/

        /*private void BTN_q2_Click(object sender, RoutedEventArgs e)
        {
            // - - - - -- -  - - -- -  ВАЖНАЯ ВЕЩЬ 
            //if (DateTime.Now >= Settings.Deadline)
            //{
            //    MessageBox.Show("Respect");
            //}
            //else
            //    MessageBox.Show("Not now");
            Loader_win_X2 LWx2 = new Loader_win_X2();
            LWx2.Show();
        }*/

        /*private void BTN_q3_Click(object sender, RoutedEventArgs e)
        {
            Loader_win_X3 LWx3 = new Loader_win_X3();
            LWx3.Show();
        }*/


    }
}
