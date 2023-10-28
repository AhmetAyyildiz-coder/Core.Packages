namespace Core.Persistence.Dynamic;

/// <summary>
///     İçerisinde Sort'lar ve Direction yardımcı nesneleri içeren query sınıfımızdır.
///     Burada sorguyu Dynamic yapıya çevirmeyi hedefliyoruz.
/// </summary>
public class DynamicQuery
{
    public DynamicQuery()
    {
    }

    public DynamicQuery(IEnumerable<Sort> sorts, Filter? filter)
    {
        Sort = sorts;
        Filter = filter;
    }

    public IEnumerable<Sort> Sort { get; set; }
    public Filter? Filter { get; set; }
}

/*
 * Ado net tarafındaki sorgular
 select * from cars where brand = 'mercedes' and unit_price < 100


* EF core tarafındaki sorgular
* p=>p.unitPrice<100 && p.name ='mercedes'
 */