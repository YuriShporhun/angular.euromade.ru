using System.Collections.Generic;

namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    /// Описывает товар 1С
    /// </summary>
    /// <remarks>
    /// Формат CommerceML содержит товары в секции КоммерческаяИнформация -> Каталог -> Товары
    /// </remarks>
    public class CatalogProduct
    {
        /// <summary>
        /// Идентификатор товара в 1С, представляет собой GUID
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Артикул товара
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Описание товара
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Группы к которым принадлежит товар
        /// </summary>
        IEnumerable<string> GroupsIds => new List<string>();
    }
}
