using System.Collections.Generic;

namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    ///  Представляет собой группу каталога товаров 1С
    /// </summary>
    class CatalogGroup
    {
        /// <summary>
        /// Идентификатор группы 1C представляет собой GUID
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Наименование группы
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Список вложенных групп
        /// </summary>
        IEnumerable<CatalogGroup> InnerGroups => new List<CatalogGroup>();

        /// <summary>
        /// Список фильтров
        /// </summary>
        /// <remarks>
        /// Может быть пустой так как фильтры существуют только для самых вложенных подгрупп
        /// </remarks>
        IEnumerable<string> Filters => new List<string>();
    }
}
