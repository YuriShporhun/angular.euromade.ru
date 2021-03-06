﻿using System;
using System.Collections.Generic;
using System.IO;

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
        protected MemoryStream commerceMLStream;

        protected CommerceMLParserTemplate(ICommerceMLSource commerceMLSource)
        {
            commerceMLStream = commerceMLSource?.GetSource();
        }

        /// <summary>
        /// Описывает общий алгоритм извлечения данных из файла CommerceML
        /// </summary>
        /// <returns>Результат разбота CommerceML файла</returns>
        public CommerceMLImportResult Extract()
        {
            IEnumerable<ClassifierGroup> groups = ExtractGroups();
            IEnumerable<CatalogProduct> products = ExtractProducts();
            IEnumerable<ClassifierProperty> properties = ExtractProperties();

            CommerceMLImportResult result = new CommerceMLImportResult(groups, products, properties);
            return result;
        }

        protected abstract IEnumerable<ClassifierGroup> ExtractGroups();
        protected abstract IEnumerable<CatalogProduct> ExtractProducts();
        protected abstract IEnumerable<ClassifierProperty> ExtractProperties(); 
    }
}
