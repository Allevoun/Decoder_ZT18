using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Decoder_ZT18
{
    public class Settings
    {

        public static DateTime Deadline { get; set; }

        public static Brushes LightPink { get; set; }

        public Settings()
        {
            Deadline = new DateTime(2018, 01, 15, 13, 15, 0, DateTimeKind.Local);
            
        }
    }
}
