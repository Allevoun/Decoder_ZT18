using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder_ZT18
{
    public class Answers
    {
        
        public static string Ans1 { get; set; }
        public static string Ans2 { get; set; }
        public static string Ans3 { get; set; }
        public static string Ans4 { get; set; }

        public static int DoneCheck { get; set; }

        public static string[] AnsS = new string[] { Ans1, Ans2, Ans3, Ans4 };

        List<string[]> MSV =new List<string[]>();

        public Answers()
        {
            Ans1 = "равенство";
            Ans2 = "команда";
            Ans3 = "опыт";
            Ans4 = "воспоминания";

            DoneCheck = 0;
        }
        

        

    }
}
