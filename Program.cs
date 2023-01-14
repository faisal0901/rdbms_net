// See https://aka.ms/new-console-template for more information


using Microsoft.EntityFrameworkCore;
using rdbms_net.dtos;
using rdbms_net.repositories;
using rdbms_net.Service;
using Tokonyadia.Model;
using Tokonyadia.Repositories;
using ProductRequest = rdbms_net.dtos.ProductRequest;

namespace rdbms_net;
public class Program
{
    public static void Main(string[] args)
    {
        var context = new TokonyadiaContext();
        ICustomerRepositories customerRepositories = new CustomerRepositories(context);
        IPersisttence persisttence = new DbPersisttence(context);

        var products = context.Product.Include(p=>p.ProductPrices).ToList();
        // foreach (var item in products)
        // {
        //     foreach (var itemPrice in item.ProductPrices)
        //     {
        //         
        //     }
        // }
    }

    
    
    
    
    
    
    
    
    public static void CreateNewProduct(TokonyadiaContext context)
    {
        // string inputProductName = Console.ReadLine();
        // int inputProductPrice = int.Parse(Console.ReadLine());
        // string inputProductDescription = Console.ReadLine();
        // int inputProductStock=int.Parse( Console.ReadLine());
        // int inputStoreId = int.Parse(Console.ReadLine());
        // var products = new Product
        // {
        //     ProductName = inputProductName,
        //     ProductDescription = inputProductDescription,
        //     ProductPrice = new List<ProductPrice>
        //     {
        //         new()
        //         {
        //             Price = inputProductPrice,
        //             StoreId = inputStoreId,
        //             Stock = inputProductStock
        //         }
        //     }
        // };
        // context.Product.Add(products);
        // context.SaveChanges();
    }
}