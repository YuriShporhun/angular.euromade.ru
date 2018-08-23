using System;
using System.IO;

namespace angular.euromade.ru.Models.Import.CommerceMLSource
{
    /// <summary>
    /// Загружает файл в формате CommerceML из 1С
    /// </summary>
    /// <remarks>
    /// Пустой так как у меня отсутствует удаленное подключение к 1С.
    /// Создан с целью продемонстрировать зачем был создан ICommerceMLSource
    /// (помимо этого ICommerceMLSource будет использоваться в mock unit тестах.
    /// </remarks>
    public class CommerceML1CSource : ICommerceMLSource
    {
        public MemoryStream GetSource()
        {
            throw new NotImplementedException();
        }
    }
}
