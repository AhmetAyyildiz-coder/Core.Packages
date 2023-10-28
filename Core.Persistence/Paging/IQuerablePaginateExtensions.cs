using Microsoft.EntityFrameworkCore;

namespace Core.Persistence.Paging;

/// <summary>
///     Gelen datayı sayfalı hale getirmek amacıyla yazılan bir extensions'dur.
/// </summary>
public static class IQuerablePaginateExtensions
{
    public static async Task<Paginate<T>> ToPaginateAsync<T>(
        this IQueryable<T> source,
        int index,
        int size,
        CancellationToken cancellationToken = default)
    {
        var count = await source.CountAsync(cancellationToken)
            .ConfigureAwait(false);

        var items = await source.Skip(index * size).Take(size).ToListAsync(cancellationToken).ConfigureAwait(false);

        var list = new Paginate<T>
        {
            Count = count,
            Index = index,
            Items = items,
            PageCount = (int)Math.Ceiling(count / (double)size),
            Size = size
        };

        return list;
    }


    public static Paginate<T> ToPaginate<T>(
        this IQueryable<T> source,
        int index,
        int size,
        CancellationToken cancellationToken = default)
    {
        var count = source.Count();
        var items = source.Skip(index * size).Take(size).ToList();

        var list = new Paginate<T>
        {
            Count = count,
            Index = index,
            Items = items,
            PageCount = (int)Math.Ceiling(count / (double)size),
            Size = size
        };

        return list;
    }
}