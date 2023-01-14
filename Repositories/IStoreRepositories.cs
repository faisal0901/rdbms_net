using Tokonyadia.Model;

namespace Tokonyadia.Repositories;

public interface IStoreRepositories
{
    Store Save(Store store);
    Store? FindById(int id);
    List<Store> FindAll();
    void Update(Store store);
    void Delete(Store store);
}