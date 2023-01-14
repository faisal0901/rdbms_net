using rdbms_net.repositories;
using rdbms_net.Service;
using Tokonyadia.Model;
using Tokonyadia.Repositories;

namespace rdbms_net.dtos;

class ProductRequest
{
   
    public string ProductName { get; set; }
        public List<ProductPrice> ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductStock{ get; set; }
       public int storeId { get; set; }
}

