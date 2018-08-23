using System.IO;

namespace angular.euromade.ru.Models.Import
{
    public interface ICommerceMLSource
    {
        MemoryStream GetSource();
    }
}
