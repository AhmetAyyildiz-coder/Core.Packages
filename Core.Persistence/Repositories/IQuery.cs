namespace Core.Persistence.Repositories;

/// <summary>
///     Bazı raporlar için sql sorgusu ile veri çekebilmemiz amacıyla kullanılır.
/// </summary>
public interface IQuery<T>
{
    IQueryable<T> Query();
}