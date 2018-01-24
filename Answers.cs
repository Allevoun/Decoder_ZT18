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

        string[] AnsS = new string[] { Ans1, Ans2, Ans3, Ans4 };

        List<string[]> MSV =new List<string[]>();

        public Answers()
        {
            Ans1 = "слово1";
            Ans2 = "слово2";
            Ans3 = "слово3";
            Ans4 = "опыт";
        }
        

        

    }
}
