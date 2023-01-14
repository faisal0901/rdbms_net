using Tokonyadia.Model;
using Tokonyadia.Repositories;

namespace rdbms_net.Service;

public class StoreSevice :IStoreService
{
    private readonly IStoreRepositories _storeRepositories;
    private readonly IPersisttence _persisttence;

    public StoreSevice(IStoreRepositories storeRepositories, IPersisttence persisttence)
    {
        _storeRepositories = storeRepositories;
        _persisttence=persisttence;
    }
    public Store? CreateNewStore(Store customer)
    {
        try
        {
            var savedCustomer = _storeRepositories.Save(customer);
            _persisttence.SaveChanges();
            return savedCustomer;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Store? GetById(int id)
    {
        try
        {
            var store = _storeRepositories.FindById(id);
            if (store is null) throw new Exception("store not found");
            return store;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Store> FindAll()
    {
        return _storeRepositories.FindAll();
    }

    public void Update(Store store)
    {
        var currentStore = GetById(store.store_id);
        currentStore.store_name = store.store_name is not null or""?store.store_name:currentStore.store_name;
        currentStore.phone_number = store.phone_number is not null or""?store.phone_number:currentStore.phone_number;
        currentStore.address = store.address is not null or""?store.address:currentStore.address;
        currentStore.siup_number = store.siup_number is not null or""?store.siup_number:currentStore.siup_number;
        _storeRepositories.Update(currentStore);
        _persisttence.SaveChanges();
    }

    public void Delete(int id)
    {
        var store = GetById(id);
        _storeRepositories.Delete(store);
        _persisttence.SaveChanges();
    }
}