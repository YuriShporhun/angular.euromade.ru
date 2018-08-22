namespace angular.euromade.ru.Models.Import
{
    /// <summary>
    /// Описывает свойство товара 1C
    /// </summary>
    /// <example>
    /// Пример свойства товара:
    /// <![CDATA[ 
    ///     <ЗначенияСвойства>
	///         <Ид>20d509bb-a58d-11e4-8277-94de8067e7c4</Ид>
	///         <Значение>V55188</Значение>
	///     </ЗначенияСвойства>
    /// ]]>
    /// </example>
    /// <remarks>
    /// Идентификатор Ид свойства товара ссылается на Id объекта свойства каталога (CatalogProperty)
    /// </remarks>
    public class ProductProperty
    {
        /// <summary>
        /// Идентификатор свойства товара
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Значение свойства товара
        /// </summary>
        string Value { get; }
    }
}
