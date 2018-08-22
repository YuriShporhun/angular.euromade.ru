using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        string Id { get; }
        string Code { get; }
        string Name { get; }
        string Description { get; }
        IEnumerable<string> GroupsIds => new List<string>();
    }
}
