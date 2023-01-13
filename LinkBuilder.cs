using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    abstract class LinkBuilder
    {
        public static string generateLinkGoogle(ExcelRow er)
        {
            string word = er.word;
            
            word = word.Replace(" ", "%20");
            string adress = $"https://translate.google.com/?sl=en&tl=ru&text={word}&op=translate";

            return adress;
        }

        public static string generateLinkYandex(ExcelRow er)
        {
            string word = er.word;

            word = word.Replace(" ", "%20");
            string adress = $"https://translate.yandex.com/?lang=en-ru&text={word}";

            return adress;
        }

        public static string generateLinkLengusa(ExcelRow er)
        {
            string word = er.word;

            word = word.Replace(" ", "%20");
            string adress = $"https://lengusa.com/sentence-examples/{word}";

            return adress;
        }

        public static string generateLinkReverso(ExcelRow er)
        {
            string word = er.word;

            word = word.Replace(" ", "+");
            string adress = $"https://context.reverso.net/translation/english-russian/{word}";

            return adress;
        }

        public static string generateLinkDefenition(ExcelRow er)
        {
            string word = er.word;

            word = word.Replace(" ", "+");
            string adress = $"https://www.google.com/search?q={word}+meaning&";

            return adress;
        }

        public static string generateLinkSentenceStack(ExcelRow er)
        {
            string word = er.word;

            word = word.Replace(" ", "_");
            string adress = $"https://sentencestack.com/q/{word}";

            return adress;
        }
    }
}
