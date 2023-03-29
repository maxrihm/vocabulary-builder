namespace Vocabulary.Model
{
    public class ExcelRow
    {
        private readonly string _firstLanguage;
        private readonly string _secondLanguage;
        private readonly string _word;
        private readonly string _translation;

        public string FirstLanguage => _firstLanguage;
        public string SecondLanguage => _secondLanguage;
        public string Word => _word;
        public string Translation => _translation;

        public ExcelRow(string firstLanguage, string secondLanguage, string word, string translation)
        {
            _firstLanguage = firstLanguage;
            _secondLanguage = secondLanguage;
            _word = word;
            _translation = translation;
        }
    }
}