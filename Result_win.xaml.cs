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

namespace Decoder_ZT18
{
    /// <summary>
    /// Логика взаимодействия для Result_win.xaml
    /// </summary>
    public partial class Result_win : Window
    {
        public Result_win()
        {
            
            InitializeComponent();
            
            TB_Predistoriya.Text = Docket.StartWords;
        }

        Docket DK = new Docket();

        int i = 0;
        int j = 0;

        private void BT_next_Click(object sender, RoutedEventArgs e)
        {
            if (i< Docket.SubHeads.Length)
            {
                TB_Predistoriya.Text = Docket.SubHeads[i];
                i++;
            }

            if (j<Docket.Heads.Length)
            {
                TB_Head.Text = Docket.Heads[j];
                j++;
            }

            if (i == Docket.SubHeads.Length)
            {
                BT_next.Content = "copy";
                Clipboard.SetText(TB_Predistoriya.Text);
            }
        }
    }
}
