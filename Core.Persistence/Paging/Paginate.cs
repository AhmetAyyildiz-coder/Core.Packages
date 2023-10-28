namespace Core.Persistence.Paging;

public class Paginate<T>
{
    public Paginate()
    {
        Items = Array.Empty<T>();
    }

    /// <summary>
    ///     Sayfada kaç adet data olacak ?
    /// </summary>
    public int Size { get; set; }


    /// <summary>
    ///     Hangi sayfadayız
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    ///     Toplam kayıt sayısı kaç ?
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    ///     Toplam kaç sayfa var
    /// </summary>
    public int PageCount { get; set; }

    public IList<T> Items { get; set; }

    public bool HasPrevious => Index > 0;
    public bool HasNext => Index + 1 < PageCount;
}