using Tokonyadia.Model;

namespace rdbms_net.Service;

public interface ICustomerService
{   Customer? CreateNewCustomer(Customer customer);
    Customer? GetById(int id);
    List<Customer> FindAll();
    void Update(Customer customer);
    void Delete(int id);
}