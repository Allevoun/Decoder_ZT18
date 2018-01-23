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
            Ans1 = "67.421699, 63.904548";
            Ans2 = "29.654711, -5.579498";
            Ans3 = "67.312690, 14.919529";
            Ans4 = "19.020165, 79.257945";
        }
        
        //int y, x;
        //void Check5Place()
        //{
        //    for (int i = 0; i < 4; i++)
        //    {
        //        MSV.Add(AnsS[i].Split(new char[] { ',' }));
        //    }

        //    (y-double.Parse(MSV[0][0])) / (double.Parse(MSV[1][0]) - double.Parse(MSV[0][0])) 

        

    }
}
