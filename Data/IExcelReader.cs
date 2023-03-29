using System.Collections.Generic;
using System.Threading.Tasks;
using Vocabulary.Model;

namespace Vocabulary.FileReader
{
    public interface IExcelReader
    {
        Task<List<ExcelRow>> ReadWholeFileAsync();
    }
}