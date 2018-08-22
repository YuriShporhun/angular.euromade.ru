namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    /// Представляет собой свойство каталога 1С
    /// </summary>
    public class CatalogProperty
    {
        /// <summary>
        /// Идектификатор свойства 1С представляет собой GUID
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Наименование свойства
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Тип свойства
        /// </summary>
        string Type { get; }
    }
}
