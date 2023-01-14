using rdbms_net.repositories;
using Tokonyadia.Model;

namespace Tokonyadia.Repositories;

public class CustomerRepositories:ICustomerRepositories
{
    private readonly TokonyadiaContext _tokonyadiaContext;

    public CustomerRepositories(TokonyadiaContext tokonyadiaContext)
    {
        _tokonyadiaContext = tokonyadiaContext;
    }
    public Customer Save(Customer customer)
    {
        var entry = _tokonyadiaContext.Add(customer);
        return entry.Entity;
        

    }

    public Customer? FindById(int id)
    {
        return _tokonyadiaContext.Customer.Find(id);
    }

    public List<Customer> FindAll()
    {
        return _tokonyadiaContext.Customer.ToList();
    }

    public void Update(Customer customer)
    {
        _tokonyadiaContext.Customer.Update(customer);
    
    }

    public void Delete(Customer customer)
    {
        _tokonyadiaContext.Customer.Remove(customer);
        
    }
}