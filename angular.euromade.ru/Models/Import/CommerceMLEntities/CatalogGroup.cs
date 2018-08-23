using System.Collections.Generic;

namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    /// Представляет собой группу каталога товаров 1С.
    /// </summary>
    /// <remarks>
    /// {Constant object}
    /// Информация по группам в CommerceML находится в КоммерческаяИнформация->Классификатор->Группы
    /// </remarks>
    public class CatalogGroup
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
        IEnumerable<CatalogGroup> InnerGroups { get; } = new List<CatalogGroup>();

        /// <summary>
        /// Список фильтров
        /// </summary>
        /// <remarks>
        /// Может быть пустой так как фильтры существуют только для самых вложенных подгрупп
        /// </remarks>
        IEnumerable<string> Filters { get; } = new List<string>();

        /// <summary>
        /// Создает объект группы каталога
        /// </summary>
        /// <param name="Id">Идентификатор группы 1C представляет собой GUID</param>
        /// <param name="Name">Наименование группы</param>
        /// <param name="InnerGroups">Список вложенных групп</param>
        /// <param name="Filters">Список фильтров</param>
        public CatalogGroup(string Id, string Name, IEnumerable<CatalogGroup> InnerGroups, IEnumerable<string> Filters)
        {
            this.Id = Id;
            this.Name = Name;
            this.InnerGroups = InnerGroups;
            this.Filters = Filters;
        }
    }
}
