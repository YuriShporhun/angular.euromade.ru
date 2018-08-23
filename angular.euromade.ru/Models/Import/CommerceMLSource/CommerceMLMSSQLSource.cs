using System.IO;

namespace angular.euromade.ru.Models.Import.CommerceMLSource
{
    /// <summary>
    /// Отвечает за загрузку файла CommerceML из базы данных
    /// </summary>
    /// <remarks>
    /// Пустой так как у меня отсутствует подключение к prod базе.
    /// Создан с целью продемонстрировать зачем был создан ICommerceMLSource
    /// (помимо этого ICommerceMLSource будет использоваться в mock unit тестах.
    /// </remarks>
    public class CommerceMLMSSQLSource : ICommerceMLSource
    {
        public MemoryStream GetSource()
        {
            throw new System.NotImplementedException();
        }
    }
}
