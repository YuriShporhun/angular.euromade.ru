using System.Collections.Generic;

namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    /// Описывает общий алгоритм парсинга файла в формате CommerceML
    /// </summary>
    /// <remarks>
    /// {Template method}
    /// </remarks>
    public abstract class CommerceMLParserTemplate
    {
        ICommerceMLSource commerceMLSource;

        public CommerceMLParserTemplate(ICommerceMLSource commerceMLSource)
        {
            this.commerceMLSource = commerceMLSource;
        }

        /// <summary>
        /// Описывает общий алгоритм извлечения данных из файла CommerceML
        /// </summary>
        /// <returns>Результат разбота CommerceML файла</returns>
        public CommerceMLImportResult Extract()
        {
            IEnumerable<CatalogGroup> groups = ExtractGroups(commerceMLSource);
            IEnumerable<CatalogProduct> products = ExtractProducts(commerceMLSource);
            IEnumerable<CatalogProperty> properties = ExtractProperties(commerceMLSource);

            CommerceMLImportResult result = new CommerceMLImportResult(groups, products, properties);
            return result;
        }

        protected abstract IEnumerable<CatalogGroup> ExtractGroups(ICommerceMLSource commerceMLSource);
        protected abstract IEnumerable<CatalogProduct> ExtractProducts(ICommerceMLSource commerceMLSource);
        protected abstract IEnumerable<CatalogProperty> ExtractProperties(ICommerceMLSource commerceMLSource); 
    }
}
