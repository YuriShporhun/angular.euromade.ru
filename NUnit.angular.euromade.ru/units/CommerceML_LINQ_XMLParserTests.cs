using angular.euromade.ru.Models.Import;
using NUnit.angular.euromade.ru.mocks;
using NUnit.Framework;
using System;

namespace NUnit.angular.euromade.ru.units
{
    [TestFixture]
    public class CommerceML_LINQ_XMLParserTests
    {
        CommerceML_LINQ_XMLParser parser;
        CommerceMLMockSource source;

        [SetUp]
        public void Init()
        {
            source = new CommerceMLMockSource();
            parser = new CommerceML_LINQ_XMLParser(source);
        }

        [Test]
        public void IsCtorParameterValid_CommerceMLSourceIsNull_ExceptionThrown() => 
            Assert.That(() => { parser = new CommerceML_LINQ_XMLParser(null); },
                Throws.TypeOf<ArgumentNullException>());
    }
}
