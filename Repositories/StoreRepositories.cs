using rdbms_net.repositories;
using Tokonyadia.Model;

namespace Tokonyadia.Repositories;

public class StoreRepositories:IStoreRepositories
{
    private readonly TokonyadiaContext _tokonyadiaContext;

    public StoreRepositories(TokonyadiaContext tokonyadiaContext)
    {
        _tokonyadiaContext = tokonyadiaContext;
    }
    public Store Save(Store store)
    {
        var entry = _tokonyadiaContext.Store.Add(store);
        return entry.Entity;
    }

    public Store? FindById(int id)
    {
        return _tokonyadiaContext.Store.Find(id);
    }

    public List<Store> FindAll()
    {
        return _tokonyadiaContext.Store.ToList();
    }

    public void Update(Store store)
    {
        _tokonyadiaContext.Store.Update(store);
        
    }

    public void Delete(Store store)
    {
        _tokonyadiaContext.Store.Remove(store);
     
    }
}