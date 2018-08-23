using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    /// Реализация шаблона CommerceMLParserTemplate с помошью LINQ to XML
    /// </summary>
    public class CommerceML_LINQ_XMLParser : CommerceMLParserTemplate
    {
        public CommerceML_LINQ_XMLParser(ICommerceMLSource commerceMLSource): base(commerceMLSource) { }

        protected override IEnumerable<CatalogGroup> ExtractGroups()
        {
            XDocument xdoc = XDocument.Load(commerceMLStream);
            foreach (XElement phoneElement in xdoc.Element("phones").Elements("phone"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");

                if (nameAttribute != null && companyElement != null && priceElement != null)
                {
                    Console.WriteLine("Смартфон: {0}", nameAttribute.Value);
                    Console.WriteLine("Компания: {0}", companyElement.Value);
                    Console.WriteLine("Цена: {0}", priceElement.Value);
                }
                Console.WriteLine();
            }
            return null;
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
