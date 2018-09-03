using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    /// Реализация шаблона CommerceMLParserTemplate с помошью LINQ to XML
    /// </summary>
    public class CommerceML_LINQ_XMLParser : CommerceMLParserTemplate
    {
        /// <exception cref="System.ArgumentNullException">Если commerceMLSource = null</exception>
        /// <param name="commerceMLSource">Источник данных формата CommerceML</param>
        public CommerceML_LINQ_XMLParser(ICommerceMLSource commerceMLSource): base(commerceMLSource)
        {
            if(commerceMLSource == null) throw new ArgumentNullException(nameof(commerceMLSource));
        }

        private IEnumerable<CatalogGroup> ParseGroups(IEnumerable<XElement> elements)
        {
            foreach (XElement xgroup in elements)
            {
                string id = xgroup.Element("ИД").Value;
                string name = xgroup.Element("price").Value;
                IEnumerable<XElement> nestedGroups = xgroup.Elements("Группы");
                IEnumerable<CatalogGroup> childs = null;
                if(nestedGroups != null)
                {
                    childs = ParseGroups(nestedGroups);
                }

                yield return new CatalogGroup(id, name, childs, null);
            }
        }

        protected override IEnumerable<CatalogGroup> ExtractGroups()
        {
            XDocument xdoc = XDocument.Load(commerceMLStream);
            IEnumerable<XElement> xGroups = xdoc.Element("КоммерческаяИнформация").Elements("Классификатор").Elements("Группы");
            return ParseGroups(xGroups);
        }

        protected override IEnumerable<CatalogProduct> ExtractProducts()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<CatalogProperty> ExtractProperties()
        {
            throw new NotImplementedException();
        }
    }
}
