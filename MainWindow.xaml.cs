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
            
        }

        private void BTN_q1_Click(object sender, RoutedEventArgs e)
        {
            //Quest_one_page QOP = new Quest_one_page();
            //Frame_QuestOnePage.Content = QOP;
            Loader_win LW = new Loader_win();
            LW.ShowDialog();
        }

        private void BTN_q2_Click(object sender, RoutedEventArgs e)
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
        }

        private void BTN_q3_Click(object sender, RoutedEventArgs e)
        {
            Loader_win_X3 LWx3 = new Loader_win_X3();
            LWx3.Show();
        }
    }
}
