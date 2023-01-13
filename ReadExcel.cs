using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronXL;

namespace Vocabulary
{
    public class ReadExcel
    {
        WorkBook workBook;
        WorkSheet workSheet;
        public List<ExcelRow> words;
        public ReadExcel()
        {
            workBook = WorkBook.Load(@"C:\Users\Maxim\Desktop\Projects\C#\Vocabulary\Vocabulary\Saved translations.xlsx");
            workSheet = workBook.GetWorkSheet("Saved translations");
            words = new List<ExcelRow>();
        }

        public void readWholeFile()
        {
            int index = 1;
            do
            {
                string fLColumn = workSheet[$"A{index}"].ToString();
                string sLColumn = workSheet[$"B{index}"].ToString();
                string wColumn = workSheet[$"C{index}"].ToString();
                string tColumn = workSheet[$"D{index}"].ToString();

                ExcelRow row = new ExcelRow(fLColumn, sLColumn, wColumn, tColumn);
                words.Add(row);

                index++;

            } while (workSheet[$"A{index}"].ToString() != "");
        }
    }

    public class ExcelRow
    {
        public string firstLanguage;
        public string secondLanguage;
        public string word;
        public string translation;

        public ExcelRow(string fL, string sL, string w, string t)
        {
            firstLanguage = fL;
            secondLanguage = sL;
            word = w;
            translation = t;
        }
    }
}
