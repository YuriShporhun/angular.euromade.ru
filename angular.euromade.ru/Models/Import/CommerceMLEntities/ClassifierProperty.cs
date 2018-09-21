namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    /// Представляет собой свойство классификатора CommerceML
    /// </summary>
    public class ClassifierProperty
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
