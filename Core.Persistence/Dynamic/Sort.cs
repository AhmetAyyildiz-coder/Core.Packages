namespace Core.Persistence.Dynamic;

/// <summary>
///     Sort işlemi uygulayabilmek için gerekli nesnedir.
///     Field -> hangi sütuna sıralama uygulayacağız.
///     Dir -> asc mi desc mi nasıl bir sıralama
/// </summary>
public class Sort
{
    public Sort()
    {
        Field = string.Empty;
        Dir = string.Empty;
    }

    public Sort(string field, string dir)
    {
        Field = field;
        Dir = dir;
    }

    public string Field { get; set; }
    public string Dir { get; set; }
}