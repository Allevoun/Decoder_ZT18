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
    /// Логика взаимодействия для Quest_one_page.xaml
    /// </summary>
    public partial class Quest_one_page : Page
    {
        public Quest_one_page()
        {
            InitializeComponent();
        }

        private void BTN_decode_Click(object sender, RoutedEventArgs e)
        {
            TB_Code.Text = "LOCKED";
        }

        private void Decode(string CODE)
        {
        }
    }
}
