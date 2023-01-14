using Tokonyadia.Model;

namespace Tokonyadia.Repositories;

public interface ICustomerRepositories
{
    Customer Save(Customer customer);
    Customer? FindById(int id);
    List<Customer> FindAll();
    void Update(Customer customer);
    void Delete(Customer customer);
}