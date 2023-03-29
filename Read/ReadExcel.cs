using IronXL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vocabulary.Model;

namespace Vocabulary.FileReader
{
    public class ReadExcel
    {
        private readonly WorkBook _workBook;
        private readonly WorkSheet _workSheet;
        private readonly List<ExcelRow> _words;

        public ReadExcel(WorkBook workBook, WorkSheet workSheet)
        {
            _workBook = workBook;
            _workSheet = workSheet;
            _words = new List<ExcelRow>();
        }

        public async Task<List<ExcelRow>> ReadWholeFileAsync()
        {
            try
            {
                int index = 1;

                while (_workSheet[$"A{index}"].ToString() != "")
                {
                    string firstLanguage = _workSheet[$"A{index}"].ToString();
                    string secondLanguage = _workSheet[$"B{index}"].ToString();
                    string word = _workSheet[$"C{index}"].ToString();
                    string translation = _workSheet[$"D{index}"].ToString();

                    ExcelRow row = new ExcelRow(firstLanguage, secondLanguage, word, translation);
                    _words.Add(row);

                    index++;
                }

                return _words;
            }
            catch (Exception ex)
            {
                // Handle exceptions here, for example log the error
                Console.WriteLine($"An error occurred while reading the excel file: {ex.Message}");
                return null;
            }
            finally
            {
                _workBook?.Dispose();
            }
        }
    }
}