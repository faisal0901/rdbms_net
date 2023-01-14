using Tokonyadia.Model;

namespace rdbms_net.Service;

public interface IStoreService
{
    Store? CreateNewStore(Store customer);
    Store? GetById(int id);
    List<Store> FindAll();
    void Update(Store customer);
    void Delete(int id);
}