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
            LineDrow();
        }

        List<Line> LineList = new List<Line>();

        private void BTN_Check1_Click(object sender, RoutedEventArgs e)
        {
            BTN_Check1.Visibility = Visibility.Hidden;
            //LineDrow();

            for (int i = 0; i < 2; i++)
            {
                LineList[i].Visibility = Visibility.Visible;
            }
        }

        //void GetLines(Grid GridName)
        //{
            
        //}

        void LineDrow()
        {
            //int n = 0;
            //<Line Grid.Column="1" X1="50" X2="90" Y1="35" Y2="75" Stroke="#FF1ECE27" StrokeThickness="5" Margin="39.8,0,-39.6,92.6" Grid.RowSpan="2"></Line>
            //<Line Grid.Column="1" X1="88" X2="130" Y1="74" Y2="10" Stroke="#FF1ECE27" StrokeThickness="5" Margin="39.8,0,-39.6,92.6" Grid.RowSpan="2"></Line>
            double x = 35;

            for (int i = 0; i < 4; i++)
            {
                Line NL = new Line() { Stroke = Brushes.Green } ;
                
                
                //Thickness Margin = new Thickness(39.8, 0, -39.6, 92.6);
                //NL.Margin = Margin;
                NL.Stroke = Brushes.Green;
                
                NL.StrokeThickness = 5;
                NL.X1 = 50 +x;
                NL.X2 = 90 +x;
                NL.Y1 = 35;
                NL.Y2 = 75;

                NL.Visibility = Visibility.Hidden;

                Grid_Main1.Children.Add(NL);
                Grid.SetRow(NL, i);
                Grid.SetColumn(NL, 1);

                LineList.Add(NL);

                Line NL2 = new Line() { Stroke = Brushes.Green };
                NL2.X1 = 88+x;
                NL2.X2 = 130+x;
                NL2.Y1 = 74;
                NL2.Y2 = 10;
                NL2.StrokeThickness = 5;
                //Thickness Margin2 = new Thickness(39.8, 0, -39.6, 92.6);

               // NL2.Margin = Margin2;
                Grid_Main1.Children.Add(NL2);
                Grid.SetRow(NL2, i);
                Grid.SetColumn(NL2, 1);
                NL2.Visibility = Visibility.Hidden;
                LineList.Add(NL2);
            }
        }

        private void BTN_Check2_Click(object sender, RoutedEventArgs e)
        {
            BTN_Check2.Visibility = Visibility.Hidden;
            //LineDrow();

            for (int i = 2; i < 4; i++)
            {
                LineList[i].Visibility = Visibility.Visible;
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
