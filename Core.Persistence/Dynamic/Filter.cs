namespace Core.Persistence.Dynamic;

/// <summary>
///     Bir nesneyi filtrelerken kullanacağımız sınıf.
///     Örneğin select * from cars where color = red and brand = bmw
///     Buradaki color -> Filter.Field,
///     = operatörü -> Filter.Operator,
///     and operatörü -> Filter.Logic,
///     red değeri -> Filter.Value
/// </summary>
public class Filter
{
    public Filter()
    {
        Field = string.Empty;
        Operator = string.Empty;
    }

    /// <summary>
    ///     başına @işareti koyarak c#'da bulunan operatör ile karıştırılmaması için kullanırız.
    /// </summary>
    /// <param name="field"></param>
    /// <param name="operator"></param>
    public Filter(string field, string @operator)
    {
        Field = field;
        Operator = @operator;
    }

    /// <summary>
    ///     Filtre nesnenin hangi property'si üzerinde çalışacak. Örneğin Car sınıfının Color property'si
    /// </summary>
    public string Field { get; set; }


    /// <summary>
    ///     Seçilen property'ye filtre değeri olarak hangi değer verilecek. Örneğin Car nesnesinin
    ///     color property'sinin value değeri : Red
    /// </summary>
    public string? Value { get; set; }


    /// <summary>
    ///     Car nesnesinin color property'si üzerinde color = red dediğimiz kısımda = dediğimiz operatörü temsil eder.
    /// </summary>
    public string Operator { get; set; }


    /// <summary>
    ///     Şu şartı sağlayan ve şunu sağlamayan , and or logic değerini tutar.
    /// </summary>
    public string? Logic { get; set; }

    public IEnumerable<Filter> Filters { get; set; }
}