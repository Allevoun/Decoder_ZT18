using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder_ZT18
{
    public class Docket
    {
        public static string StartWords { get; set; }

        

        public static string Head1 { get; set; }
        public static string Head2 { get; set; }
        public static string Head3 { get; set; }
        public static string Head4 { get; set; }
        public static string Head5 { get; set; }

        public static string[] Heads { get; set; }

        public static string SubHead1 { get; set; }
        public static string SubHead2 { get; set; }
        public static string SubHead3 { get; set; }
        public static string SubHead4 { get; set; }
        public static string SubHead5 { get; set; }

        public static string[] SubHeads { get; set; }


        public static string ListOfAll { get; set; }

        public Docket()
        {
            StartWords = "Привет, первокурсники СтС! Этот док вам понадобится, чтобы позвать стсников на ЗТ. Сам процесс состоит из обзвона и добавления в группу.";

            Head1 = "Совет";
            SubHead1 = "Поделите список на несколько человек(для удобства можете отделять цветами).";

            Head2 = "Ваши действия";
            SubHead2 = "Звоните стснику в адекватное время и говорите написанный ЗАРАНЕЕ текст. А дальше импровизируйте, отвечайте на вопросы, задавайте их сами, не стесняйтесь. Когда все выяснено, попрощайтесь и скажите, что ждете на ЗТ. После того как позвонили, приглашайте в вашу группу вк.";
            
            Head3 = "Внимание";
            SubHead3 = "Если не дозвонились, перезвоните через какое-то время. Если не дозвонились 3 - 4 раза, пишите вк. Текст примерно такой же, как во время обзвона. После того как обговорили все, приглашайте в вашу группу вк.";

            Head4 = "Советы";
            SubHead4 = "Сразу отмечайте в доке до кого дозвонились и что вам ответили едет / не едет. Не делайте приглашения от группы, просто сделайте ее закрытой и кидайте ссылку стсникам. Они кинут заявку. В группу впускают ВСЕХ одновременно!";
            
            SubHead5 = "Не переживайте и не бойтесь звонить стсникам!Они будут рады, что вы их позвали:)";

            ListOfAll = "https://docs.google.com/spreadsheets/d/1uesYp6byN-BSIAAmG25mlLk-603Juwurx0GfuuP0iEw/edit#gid=0";

            Heads = new string[] { Head1, Head2, Head3, Head4, Head5 };
            SubHeads = new string[] { SubHead1, SubHead2, SubHead3, SubHead4, SubHead5, ListOfAll };

        }
    }
}
