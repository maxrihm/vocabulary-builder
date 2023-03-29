using IronXL;
using System.Threading.Tasks;
using Vocabulary.Model;

namespace Vocabulary.FileReader
{
    public class IronXLReader : IExcelReader
    {
        private readonly string _filePath;
        public IronXLReader(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<List<ExcelRow>> ReadWholeFileAsync()
        {
            var workBook = WorkBook.Load(_filePath);
            var workSheet = workBook.GetWorkSheet("Saved translations");

            var reader = new ReadExcel(workBook, workSheet);
            return await Task.Run(() => reader.ReadWholeFileAsync());
        }
    }
}