using System.Collections.Generic;

namespace angular.euromade.ru.Models.Import
{
    interface I1CImporter
    {
        IEnumerable<CatalogGroup> ParseGroups();
    }
}
