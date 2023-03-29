using System;

namespace Vocabulary
{
    public abstract class LinkBuilder
    {
        public abstract string GenerateLink(ExcelRow er);
    }

    public class GoogleLinkBuilder : LinkBuilder
    {
        public override string GenerateLink(ExcelRow er)
        {
            string word = er.word.Replace(" ", "%20");
            return $"https://translate.google.com/?sl=en&tl=ru&text={word}&op=translate";
        }
    }

    public class YandexLinkBuilder : LinkBuilder
    {
        public override string GenerateLink(ExcelRow er)
        {
            string word = er.word.Replace(" ", "%20");
            return $"https://translate.yandex.com/?lang=en-ru&text={word}";
        }
    }

    public class LengusaLinkBuilder : LinkBuilder
    {
        public override string GenerateLink(ExcelRow er)
        {
            string word = er.word.Replace(" ", "%20");
            return $"https://lengusa.com/sentence-examples/{word}";
        }
    }

    public class ReversoLinkBuilder : LinkBuilder
    {
        public override string GenerateLink(ExcelRow er)
        {
            string word = er.word.Replace(" ", "+");
            return $"https://context.reverso.net/translation/english-russian/{word}";
        }
    }

    public class DefinitionLinkBuilder : LinkBuilder
    {
        public override string GenerateLink(ExcelRow er)
        {
            string word = er.word.Replace(" ", "+");
            return $"https://www.google.com/search?q={word}+meaning&";
        }
    }

    public class SentenceStackLinkBuilder : LinkBuilder
    {
        public override string GenerateLink(ExcelRow er)
        {
            string word = er.word.Replace(" ", "_");
            return $"https://sentencestack.com/q/{word}";
        }
    }
}