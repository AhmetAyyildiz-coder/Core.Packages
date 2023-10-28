using Core.Persistence.Paging;

namespace Core.Application.Responses;

/// <summary>
/// Bütün CQRS listeleme işlemlerinde kullanacağımız ortak sınıf
/// </summary>
public class GetListResponse<T> : BasePageableModel 
{
    private IList<T> _items;

    public IList<T> Items
    {
        get => _items ?? new List<T>();
        set => _items = value;
    }
}