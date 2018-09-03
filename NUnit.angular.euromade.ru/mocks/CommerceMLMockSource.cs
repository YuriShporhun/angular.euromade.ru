using angular.euromade.ru.Models.Import;
using System.IO;
using System.Text;

namespace NUnit.angular.euromade.ru.mocks
{
    internal class CommerceMLMockSource : ICommerceMLSource
    {
        public MemoryStream GetSource()
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(FakeCommerceML.CommerceML));
        }
    }
}
