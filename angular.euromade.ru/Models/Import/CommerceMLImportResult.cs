using System.Collections.Generic;

namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    /// Результат парсинга файла в формате CommerceML
    /// </summary>
    public class CommerceMLImportResult
    {
        /// <summary>
        /// Импортированные групы каталога
        /// </summary>
        IEnumerable<ClassifierGroup> Groups { get; }

        /// <summary>
        /// Импортированные товары
        /// </summary>
        IEnumerable<CatalogProduct> Products { get; }

        /// <summary>
        /// Импортированные свойства
        /// </summary>
        IEnumerable<ClassifierProperty> Properties { get; }

        /// <summary>
        /// Создает объект результата парсинга файла в формате CommerceML
        /// </summary>
        /// <param name="Groups">Импортированные групы каталога</param>
        /// <param name="Products">Импортированные товары</param>
        /// <param name="Properties">Импортированные свойства</param>
        public CommerceMLImportResult(
            IEnumerable<ClassifierGroup> Groups, 
            IEnumerable<CatalogProduct> Products, 
            IEnumerable<ClassifierProperty> Properties)
        {
            this.Groups = Groups;
            this.Products = Products;
            this.Properties = Properties;
        }
    }
}
