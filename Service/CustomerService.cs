using Tokonyadia.Model;
using Tokonyadia.Repositories;

namespace rdbms_net.Service;

internal class CustomerService:ICustomerService
{
    private static ICustomerRepositories _customerRepositories;
    private readonly IPersisttence _persisttence;
    public CustomerService(ICustomerRepositories customerRepositories,IPersisttence ipersistence)
    {
        _customerRepositories = customerRepositories;
        _persisttence = ipersistence;
    }
    public Customer CreateNewCustomer(Customer customer)
    {
        try
        {
            var savedCustomer = _customerRepositories.Save(customer);
            _persisttence.SaveChanges();
            return savedCustomer;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Customer? GetById(int id)
    {
        try
        {
            var customer = _customerRepositories.FindById(id);
            if (customer is null) throw new Exception("customer not found");
            return customer;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Customer> FindAll()
    {
        return _customerRepositories.FindAll();
    }

    public void Update(Customer customer)
    {
        var currentcustomer = GetById(customer.customer_id);
        currentcustomer.customer_name = customer.customer_name is not null or""?customer.customer_name:currentcustomer.customer_name;
        currentcustomer.phone_number = customer.phone_number is not null or""?customer.phone_number:currentcustomer.phone_number;
        currentcustomer.address = customer.address is not null or""?customer.address:currentcustomer.address;
        currentcustomer.email = customer.email is not null or""?customer.email:currentcustomer.email;
        _customerRepositories.Update(currentcustomer);
        _persisttence.SaveChanges();
     
    }

    public void Delete(int id)
    {
        var customer = GetById(id);
        _customerRepositories.Delete(customer);
        _persisttence.SaveChanges();
    }
}